using ASP_MVC_BookShop.Services;
using ASP_MVC_BookShop.Services.Implementations;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace ASP_MVC_BookShop.Filters
{
    public class ActionLoadTimeFilter : ActionFilterAttribute
    {
        private Stopwatch _stopwatch;
        private readonly IFileActions _fileActions;

        public ActionLoadTimeFilter(IFileActions fileActions)
        {
            _fileActions = fileActions;
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            string path = Path.Combine("wwwroot", "Files", "timeElapsedForAction.txt");
            _stopwatch = Stopwatch.StartNew();

            await next();

            _stopwatch.Stop();
            _fileActions.AppendTxtData(path, $"> Action Execution Time for {context.ActionDescriptor.DisplayName}: {_stopwatch.Elapsed.TotalSeconds}s. [{DateTime.Now}]");
        }

        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            string path = Path.Combine("wwwroot", "Files", "timeElapsedForActionResult.txt");
            _stopwatch = Stopwatch.StartNew();

            await next();

            _stopwatch.Stop();
            _fileActions.AppendTxtData(path, $"> Action Result Execution Time for {context.ActionDescriptor.DisplayName}: {_stopwatch.Elapsed.TotalSeconds}s. [{DateTime.Now}]");
        }
    }
}
