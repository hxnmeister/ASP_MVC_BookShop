using ASP_MVC_BookShop.Models;

namespace ASP_MVC_BookShop.Services
{
    public interface IFileActions
    {
        void AppendTxtData(string pathToFile, string fileData);
        void WriteJsonStatistic(string pathToFile, StatisticModel model);
    }
}
