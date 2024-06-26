using ASP_MVC_BookShop.Models;
using System.Collections.Generic;

namespace ASP_MVC_BookShop.Services
{
    public interface IBookStorage
    {
        IEnumerable<Book> GetAllBooks();
        void AddMany(IEnumerable<Book> books);
        void AddOne(Book book);
        Book GetById(int id);
        string StorageToString();
        List<Book> SearchBook(string searchingParam, string criteria);
    }
}
