using ASP_MVC_BookShop.Filters;
using ASP_MVC_BookShop.Models;
using ASP_MVC_BookShop.Services;
using ASP_MVC_BookShop.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_BookShop.Controllers
{
    [TypeFilter(typeof(ExceptionCatcherAttribute))]
    public class BookController : Controller
    {
        private readonly List<SelectListItem> SearchingOptions = new List<SelectListItem>
        {
            new SelectListItem { Value = "", Text = "Select Criteria", Disabled = true, Selected = true },
            new SelectListItem { Value = "Title", Text = "Title" },
            new SelectListItem { Value = "Publisher", Text = "Publisher" },
            new SelectListItem { Value = "Publishing Year", Text = "Publishing Year" },
            new SelectListItem { Value = "Pages", Text = "Pages" },
            new SelectListItem { Value = "Rating", Text = "Rating" },
            new SelectListItem { Value = "Price", Text = "Price" },
            new SelectListItem { Value = "Author", Text = "Author" }
        };
        private readonly IBookStorage _bookStorage;
        private readonly IQuoteOfDay _quoteOfDay;
        private readonly IRandomQuote _randomQuote;
        private readonly ICalendarValues _calendarsValues;
        private readonly IRecommendation _recommendation;
        private readonly IHostingEnvironment _env;
        private readonly IMemoryCache _cache;
        private readonly ILogger<BookController> _logger;
        private readonly BookShopDBContext _dbContext;

        public BookController(IBookStorage bookStorage, IQuoteOfDay quoteOfDay, IRandomQuote randomQuote,  
            IHostingEnvironment env, ICalendarValues calendarsValues, 
            IRecommendation recommendation, IMemoryCache cache, ILogger<BookController> logger, BookShopDBContext dBContext)
        {
            _randomQuote = randomQuote;
            _quoteOfDay = quoteOfDay;
            _bookStorage = bookStorage;
            _env = env;
            _calendarsValues = calendarsValues;
            _recommendation = recommendation;
            _cache = cache;
            _logger = logger;
            _dbContext = dBContext;
        }


        [HttpGet("/")]
        public IActionResult Index()
        {
            ViewBag.QuoteOfDay = _quoteOfDay.GetCurrentQuoteOfDay();
            ViewBag.CalendarValues = _calendarsValues.GetValues();
            ViewBag.CalendarValuesType = _calendarsValues.GetType().Name;

            return View(_bookStorage.GetAllBooks());
        }

        [HttpGet("books/{id}")]
        public IActionResult Details(int id)
        {
            ViewBag.Id = id;
            BookModel requestedBook = _bookStorage.GetById(id);

            if(requestedBook == null)
            {
                _logger.LogInformation("Book not found!");
                return Redirect("https://www.duckduckgo.com");
            }

            return View(requestedBook);
        }

        [HttpGet("books/create")]
        public IActionResult Create()
        {
            ViewBag.RandomQuote = _randomQuote.GetCurrentRandomQuote();
            BookModel book = new BookModel()
            {
                Author = new AuthorModel()
            };

            return View(book);
        }

        [HttpPost("books/create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookModel model)
        {
            if(ModelState.IsValid)
            {
                model.Id = (int)DateTime.UtcNow.Ticks;
                model.Author.Id = (int)DateTime.UtcNow.Ticks;

                _bookStorage.AddOne(model);
                return RedirectToAction("Index", "Book");
            }
            
            return View(model);
        }

        [HttpGet("books/download")]
        public IActionResult Download()
        {
            List<BookModel> books = _bookStorage.GetAllBooks().ToList();
            List<SelectListItem> selectListItems = books.Select((book, index) => new SelectListItem()
            {
                Text = book.Title,
                Value = (index + 1).ToString()
            }).ToList();

            selectListItems.Insert(0, new SelectListItem() { Text = "Choose book to download!", Value = "" });
            ViewBag.DownloadOptions = new SelectList(selectListItems, "Value", "Text", selectListItems[0]);

            return View();
        }

        [HttpPost("books/download")]
        public IActionResult Download(IFormCollection formData)
        {
            try
            {
                int id = int.Parse(formData["BookId"]);
                string pathToTempFile = Path.Combine(_env.WebRootPath, "Files", "tempBookData.json");
                List<BookModel> books = new List<BookModel>(_bookStorage.GetAllBooks());
                BookModel requiredBook = books.FirstOrDefault(item => item.Id == id);

                if (requiredBook != null)
                {
                    var fileData = JsonConvert.SerializeObject(requiredBook);
                    string type = "application/json";

                    System.IO.File.WriteAllText(pathToTempFile, fileData);

                    _logger.LogInformation($"Book {requiredBook.Title} was downloaded!");

                    return PhysicalFile(pathToTempFile, type, $"{requiredBook.Title}.json");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"An excepttion occured during downloading book!\n{ex.Message}\n\n{ex.StackTrace}");
                return RedirectToAction("Index");
            }
        }

        [HttpGet("books/json")]
        public JsonResult GetJson()
        {
            return Json(_bookStorage.GetAllBooks());
        }

        [HttpGet("books/text")]
        public string GetTxt()
        {
            return _bookStorage.StorageToString();
        }

        [HttpGet("books/search")]
        public IActionResult Search()
        {
            ViewBag.SearchingOptions = SearchingOptions;
            BookSearchModel bookSearch = new BookSearchModel();

            return View(bookSearch);
        }

        [FormDataAnalizer]
        [HttpPost("books/search")]
        public IActionResult SearchResult(BookSearchModel model)
        {
            List<string> numberCriterias = new List<string> { "Rating", "Publishing Year", "Price", "Pages" };
            ViewBag.SearchingOptions = SearchingOptions;
            string criteria = model.Criteria;
            string searchingParam = model.SearchingParam;

            if (ModelState.IsValid)
            {
                if (numberCriterias.Contains(criteria) && !decimal.TryParse(searchingParam, out _))
                {
                    ModelState.AddModelError("SearchingParam", "If selected numbered criteria you cannot enter not number value!");
                    return View("Search", model);
                }

                List<BookModel> requiredBooks = _bookStorage.SearchBook(searchingParam, criteria);

                ViewBag.SearchingParam = searchingParam;
                ViewBag.Criteria = criteria;

                Response.Cookies.Append("lastSearchingRequest", searchingParam);
                Response.Cookies.Append("favouritePublisher", requiredBooks[0].PublisherName);

                _cache.Set("bookRecommendations", _recommendation.GetRecommendedBooksByPublisher(requiredBooks[0].PublisherName));

                return View(requiredBooks);
            }

            return View("Search", model);
        }
    }
}
