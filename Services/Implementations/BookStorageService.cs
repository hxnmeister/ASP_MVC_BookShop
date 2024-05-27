using ASP_MVC_BookShop.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ASP_MVC_BookShop.Services.Implementations
{
    public class BookStorageService : IBookStorage
    {
        private readonly string _filePath;
        private List<Book> _books;

        public BookStorageService(string filePath)
        {
            _filePath = filePath;
            LoadBooks();
        }

        private void LoadBooks()
        {
            _books = File.Exists(_filePath) ? JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(_filePath)) : new List<Book>();
        }

        private void SaveBooks()
        {
            var fileData = JsonConvert.SerializeObject(_books);
            File.WriteAllText(_filePath, fileData);
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
    }
}
