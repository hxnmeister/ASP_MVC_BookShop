using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_BookShop.Services
{
    public interface IQuote
    {
        string GetRandomQuote(int quoteNumber);
        int GetQuotesCount();
    }
}
