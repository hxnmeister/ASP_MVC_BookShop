using ASP_MVC_BookShop.Models;
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
        private List<BookModel> _books;

        private List<BookModel> LoadBooks()
        {
            return File.Exists(_filePath) ? JsonConvert.DeserializeObject<List<BookModel>>(File.ReadAllText(_filePath)) : new List<BookModel>();
        }

        private void SaveBooks()
        {
            var fileData = JsonConvert.SerializeObject(_books);
            File.WriteAllText(_filePath, fileData);
        }

        public BookStorageService(string filePath)
        {
            _filePath = filePath;
            _books = LoadBooks() ?? new List<BookModel>();
        }

        public IEnumerable<BookModel> GetAllBooks()
        {
            return _books;
        }

        public void AddOne(BookModel book)
        {
            _books.Add(book);
            SaveBooks();
        }

        public void AddMany(IEnumerable<BookModel> books)
        {
           _books.AddRange(books);
            SaveBooks();
        }

        public BookModel GetById(int id)
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

        public List<BookModel> SearchBook(string searchingParam, string criteria)
        {
            List<BookModel> foundedBooks = new List<BookModel>();

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
