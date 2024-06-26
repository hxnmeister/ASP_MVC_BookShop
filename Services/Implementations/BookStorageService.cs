﻿using ASP_MVC_BookShop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ASP_MVC_BookShop.Services.Implementations
{
    public class BookStorageService : IBookStorage
    {
        private readonly string _filePath;
        private List<Book> _books;

        private List<Book> LoadBooks()
        {
            return File.Exists(_filePath) ? JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(_filePath)) : new List<Book>();
        }

        private void SaveBooks()
        {
            var fileData = JsonConvert.SerializeObject(_books);
            File.WriteAllText(_filePath, fileData);
        }

        public BookStorageService(string filePath)
        {
            _filePath = filePath;
            _books = LoadBooks() ?? new List<Book>();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }

        public void AddOne(Book book)
        {
            _books.Add(book);
            SaveBooks();
        }

        public void AddMany(IEnumerable<Book> books)
        {
           _books.AddRange(books);
            SaveBooks();
        }

        public Book GetById(int id)
        {
            return _books.Count != 0 && id > 0 ? _books.FirstOrDefault(item => item.Id == id) : null;
        }

        public string StorageToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var item in _books)
            {
                builder.Append(item).Append("\n");
            }

            return builder.ToString();
        }

        public List<Book> SearchBook(string searchingParam, string criteria)
        {
            List<Book> foundedBooks = new List<Book>();

            switch(criteria)
            {
                case "Title":
                    foundedBooks.AddRange(this._books.Where(book => book.Title == searchingParam));
                    break;
                case "Publisher":
                    foundedBooks.AddRange(this._books.Where(book => book.PublisherName == searchingParam));
                    break;
                case "PublishingYear":
                    foundedBooks.AddRange(this._books.Where(book => book.PublishingYear == int.Parse(searchingParam)));
                    break;
                case "Pages":
                    foundedBooks.AddRange(this._books.Where(book => book.PagesAmount == int.Parse(searchingParam)));
                    break;
                case "Rating":
                    foundedBooks.AddRange(this._books.Where(book => book.Rating == int.Parse(searchingParam)));
                    break;
                case "Author":
                    foundedBooks.AddRange(this._books.Where(book => $"{book.Author.FirstName} {book.Author.LastName}" == searchingParam));
                    break;
            }

            return foundedBooks;
        }
    }
}
