using ASP_MVC_BookShop.Models;
using ASP_MVC_BookShop.Services.Implementations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public BookController(BookStorageService bookStorage)
        {
            _bookStorage = bookStorage;
        }


        // GET: BookController
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View(_bookStorage.GetAllBooks());
        }

        // GET: BookController/Details/5
        [HttpGet("books/{id}")]
        public ActionResult Details(int id)
        {
            ViewBag.Id = id;
            return View(_bookStorage.GetById(id));
        }

        // GET: BookController/Create
        [HttpGet("books/create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost("books/create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book model)
        {
            model.Id = (int)DateTime.UtcNow.Ticks;
            model.Author.Id = (int)DateTime.UtcNow.Ticks;

            _bookStorage.AddOne(model);
            return RedirectToAction("Index", "Book");
        }

        [HttpGet("books/download")]
        public ActionResult Download()
        {
            return View(_bookStorage.GetAllBooks());
        }

        [HttpPost("books/download")]
        public FileResult Download(IFormCollection formData)
        {
            int id = int.Parse(formData["BookId"]);
            string pathToTempFile = "tempBookData.json";
            List<Book> books = new List<Book>(_bookStorage.GetAllBooks());
            Book requiredBook = books.FirstOrDefault(item => item.Id == id);

            if (requiredBook != null)
            {
                var fileData = JsonConvert.SerializeObject(requiredBook);
                System.IO.File.WriteAllText(pathToTempFile, fileData);
            }

            string path = Path.Combine(Directory.GetCurrentDirectory(), pathToTempFile);
            string type = "application/json";

            return PhysicalFile(path, type, $"{requiredBook.Title}.json");
        }
    }
}
