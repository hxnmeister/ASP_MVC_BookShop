using ASP_MVC_BookShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace ASP_MVC_BookShop.Services.Implementations
{
    public class RecommendationService : IRecommendation
    {
        private readonly IBookStorage _bookStorage;

        public RecommendationService(IBookStorage bookStorage)
        {
            _bookStorage = bookStorage;
        }

        public List<BookModel> GetRecommendedBooksByPublisher(string publisher)
        {
            return _bookStorage.GetAllBooks().Where(item => item.PublisherName.Equals(publisher, System.StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}
