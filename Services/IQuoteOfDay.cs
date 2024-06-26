using System.Threading.Tasks;

namespace ASP_MVC_BookShop.Services
{
    public interface IQuoteOfDay
    {
        string GetNewQuoteOfDay();
        string GetCurrentQuoteOfDay();
    }
}
