using ASP_MVC_BookShop.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ASP_MVC_BookShop.Services.Implementations
{
    public class FileActionsService : IFileActions
    {
        public void AppendTxtData(string pathToFile, string fileData)
        {
            using (StreamWriter sw = new StreamWriter(pathToFile, true))
            {
                sw.WriteLine(fileData);
            }
        }

        public void WriteJsonStatistic(string pathToFile, StatisticModel model)
        {
            List<StatisticModel> currentFileData = new List<StatisticModel>();

            if (File.Exists(pathToFile))
            {
                using (StreamReader sr = new StreamReader(pathToFile))
                {
                    currentFileData = JsonConvert.DeserializeObject<List<StatisticModel>>(sr.ReadToEnd());

                    StatisticModel foundedItem = currentFileData.FirstOrDefault(item => item.Value.Equals(model.Value, System.StringComparison.CurrentCultureIgnoreCase));
                    if (foundedItem != null)
                    {
                        ++foundedItem.Count;
                    }
                    else
                    {
                        currentFileData.Add(model);
                    }

                    currentFileData.Sort((x, y) => y.Count.CompareTo(x.Count));
                }
            }

            currentFileData.Add(model);

            using (StreamWriter sw = new StreamWriter(pathToFile, false))
            {
                sw.WriteLine(JsonConvert.SerializeObject(currentFileData));
            }
        }
    }
}
