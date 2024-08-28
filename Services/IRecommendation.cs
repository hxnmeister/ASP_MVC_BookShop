using ASP_MVC_BookShop.Models;
using System.Collections.Generic;

namespace ASP_MVC_BookShop.Services
{
    public interface IRecommendation
    {
        List<BookModel> GetRecommendedBooksByPublisher(string publisher);
    }
}
