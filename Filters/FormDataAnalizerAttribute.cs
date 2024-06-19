using ASP_MVC_BookShop.Models;
using ASP_MVC_BookShop.Services;
using ASP_MVC_BookShop.Services.Implementations;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;

namespace ASP_MVC_BookShop.Filters
{
    public class FormDataAnalizerAttribute : ActionFilterAttribute
    {
        private readonly IFileActions _fileActions;
        private readonly string criteriaName;
        private readonly string valueName;
        private readonly int startingCount;

        public FormDataAnalizerAttribute(string criteriaName = "Criteria", string valueName = "SearchingParam", int startingCount = 1)
        {
            this.criteriaName = criteriaName;
            this.valueName = valueName;
            this.startingCount = startingCount;
            _fileActions = new FileActionsService();
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            StatisticModel statisticModel = new StatisticModel();

            if(context.HttpContext.Request.Method == "POST" && context.HttpContext.Request.Form.Count > 0)
            {
                string path = Path.Combine("wwwroot", "Files", "statistics.json");

                statisticModel.CriteriaName = context.HttpContext.Request.Form[criteriaName];
                statisticModel.Value = context.HttpContext.Request.Form[valueName];
                statisticModel.Count = startingCount;

                _fileActions.WriteJsonStatistic(path ,statisticModel);
            }
        }
    }
}
