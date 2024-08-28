using ASP_MVC_BookShop.Models;
using System.Collections.Generic;

namespace ASP_MVC_BookShop.Services
{
    public interface IBookStorage
    {
        IEnumerable<BookModel> GetAllBooks();
        void AddMany(IEnumerable<BookModel> books);
        void AddOne(BookModel book);
        BookModel GetById(int id);
        string StorageToString();
        List<BookModel> SearchBook(string searchingParam, string criteria);
    }
}
