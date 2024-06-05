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
        private List<Book> _books;

        private void LoadBooks()
        {
            _books = File.Exists(_filePath) ? JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(_filePath)) : new List<Book>();
        }

        private void SaveBooks()
        {
            var fileData = JsonConvert.SerializeObject(_books);
            File.WriteAllText(_filePath, fileData);
        }

        public BookStorageService(string filePath)
        {
            _filePath = filePath;
            LoadBooks();
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

        public List<Book> SearchBook(string searchingParam)
        {
            return _books.Where(book =>
            int.TryParse(searchingParam, out int number) &&
            (number == book.Id || number == book.Rating || number == book.PublishingYear || number == book.PagesAmount) ||
            searchingParam.Equals(book.Title, StringComparison.CurrentCultureIgnoreCase) ||
            searchingParam.Equals(book.PublisherName, StringComparison.CurrentCultureIgnoreCase) ||
            searchingParam.Equals(book.Author.FirstName, StringComparison.CurrentCultureIgnoreCase) ||
            searchingParam.Equals(book.Author.LastName, StringComparison.CurrentCultureIgnoreCase))
            .ToList();
        }
    }
}
