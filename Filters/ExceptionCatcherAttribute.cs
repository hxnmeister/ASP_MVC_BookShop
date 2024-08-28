using ASP_MVC_BookShop.Services;
using ASP_MVC_BookShop.Services.Implementations;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace ASP_MVC_BookShop.Filters
{
    public class ExceptionCatcherAttribute : ExceptionFilterAttribute
    {
        private readonly IFileActions _fileActions;

        public ExceptionCatcherAttribute(IFileActions fileActions)
        {
            _fileActions = fileActions;
        }

        public override void OnException(ExceptionContext context)
        {
            string path = Path.Combine("wwwroot", "Files", "exceptions.txt");
            string fileData = $"Date: {DateTime.Now}\nSource: {context.Exception.Source}\nMessage: {context.Exception.Message}\nStack Trace: {context.Exception.StackTrace}\n";

            _fileActions.AppendTxtData(path, fileData);
        }
    }
}
