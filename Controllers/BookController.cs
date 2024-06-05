using ASP_MVC_BookShop.Models;
using ASP_MVC_BookShop.Services.Implementations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ASP_MVC_BookShop.Controllers
{
    public class BookController : Controller
    {
        private readonly BookStorageService _bookStorage;
        private readonly IHostingEnvironment _env;

        public BookController(BookStorageService bookStorage, IHostingEnvironment env)
        {
            _bookStorage = bookStorage;
            _env = env;
        }


        // GET: BookController
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View(_bookStorage.GetAllBooks());
        }

        // GET: BookController/Details/5
        [HttpGet("books/{id}")]
        public IActionResult Details(int id)
        {
            ViewBag.Id = id;
            Book requestedBook = _bookStorage.GetById(id);

            if(requestedBook == null)
            {
                return Redirect("https://www.duckduckgo.com");
            }

            return View(requestedBook);
        }

        // GET: BookController/Create
        [HttpGet("books/create")]
        public IActionResult Create()
        {
            Book book = new Book()
            {
                Author = new Author()
            };

            return View(book);
        }

        // POST: BookController/Create
        [HttpPost("books/create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book model)
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
            List<Book> books = _bookStorage.GetAllBooks().ToList();
            List<SelectListItem> selectListItems = books.Select((book, index) => new SelectListItem()
            {
                Text = book.Title,
                Value = (index + 1).ToString()
            }).ToList();

            selectListItems.Insert(0, new SelectListItem() { Text = "Choose book to download!", Value = "" });
            ViewBag.Options = new SelectList(selectListItems, "Value", "Text", selectListItems[0]);

            return View();
        }

        [HttpPost("books/download")]
        public IActionResult Download(IFormCollection formData)
        {
            try
            {
                int id = int.Parse(formData["BookId"]);
                string pathToTempFile = Path.Combine(_env.WebRootPath, "Files", "tempBookData.json");
                List<Book> books = new List<Book>(_bookStorage.GetAllBooks());
                Book requiredBook = books.FirstOrDefault(item => item.Id == id);

                if (requiredBook != null)
                {
                    var fileData = JsonConvert.SerializeObject(requiredBook);
                    string type = "application/json";

                    System.IO.File.WriteAllText(pathToTempFile, fileData);

                    return PhysicalFile(pathToTempFile, type, $"{requiredBook.Title}.json");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
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
            BookSearch bookSearch = new BookSearch();

            return View(bookSearch);
        }

        [HttpPost("books/search")]
        public IActionResult SearchResult(BookSearch model)
        {
            if (ModelState.IsValid)
            {
                List<Book> requiredBooks = _bookStorage.SearchBook(model.SearchingParam);
                ViewBag.SearchingParam = model.SearchingParam;

                return View(requiredBooks);
            }

            return View("Search", model);
        }
    }
}
