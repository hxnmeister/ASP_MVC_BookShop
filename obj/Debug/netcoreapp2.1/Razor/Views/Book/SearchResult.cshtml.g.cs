#pragma checksum "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b71063aa7a4e685073b52afd8d4fcb437077cd653c02bbef0d9714e97483a788"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_SearchResult), @"mvc.1.0.view", @"/Views/Book/SearchResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/SearchResult.cshtml", typeof(AspNetCore.Views_Book_SearchResult))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\_ViewImports.cshtml"
using ASP_MVC_BookShop;

#line default
#line hidden
#line 2 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\_ViewImports.cshtml"
using ASP_MVC_BookShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b71063aa7a4e685073b52afd8d4fcb437077cd653c02bbef0d9714e97483a788", @"/Views/Book/SearchResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3e776884da7e66b68608511ba3c89c08df1095a536f913ccb8364193d50637f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_SearchResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
  
    ViewData["Title"] = "Searching Results";

#line default
#line hidden
            BeginContext(74, 27, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n");
            EndContext();
#line 8 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
     if(Model.Count > 0)
    {

#line default
#line hidden
            BeginContext(134, 45, true);
            WriteLiteral("        <h1 class=\"text-center\">Results for \"");
            EndContext();
            BeginContext(180, 22, false);
#line 10 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                                        Write(ViewBag.SearchingParam);

#line default
#line hidden
            EndContext();
            BeginContext(202, 545, true);
            WriteLiteral(@"""</h1>
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">ID</th>
                    <th scope=""col"">Title</th>
                    <th scope=""col"">Publisher</th>
                    <th scope=""col"">Publishing Year</th>
                    <th scope=""col"">Pages</th>
                    <th scope=""col"">Rating</th>
                    <th scope=""col"">Auhtor</th>
                    <th scope=""col"">Price</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 25 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                 foreach(var book in Model)
                {

#line default
#line hidden
            BeginContext(811, 66, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(878, 7, false);
#line 28 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                                   Write(book.Id);

#line default
#line hidden
            EndContext();
            BeginContext(885, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(921, 10, false);
#line 29 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                       Write(book.Title);

#line default
#line hidden
            EndContext();
            BeginContext(931, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(967, 18, false);
#line 30 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                       Write(book.PublisherName);

#line default
#line hidden
            EndContext();
            BeginContext(985, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1021, 19, false);
#line 31 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                       Write(book.PublishingYear);

#line default
#line hidden
            EndContext();
            BeginContext(1040, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1076, 16, false);
#line 32 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                       Write(book.PagesAmount);

#line default
#line hidden
            EndContext();
            BeginContext(1092, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1128, 11, false);
#line 33 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                       Write(book.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(1139, 39, true);
            WriteLiteral(" / 5</td>\r\n                        <td>");
            EndContext();
            BeginContext(1179, 21, false);
#line 34 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                       Write(book.Author.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1200, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1202, 20, false);
#line 34 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                                              Write(book.Author.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1222, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1258, 10, false);
#line 35 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                       Write(book.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1268, 35, true);
            WriteLiteral("$</td>\r\n                    </tr>\r\n");
            EndContext();
#line 37 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                }

#line default
#line hidden
            BeginContext(1322, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 40 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
    }
    else 
    {

#line default
#line hidden
            BeginContext(1387, 59, true);
            WriteLiteral("        <h1 class=\"text-danger text-center\">No results by \"");
            EndContext();
            BeginContext(1447, 22, false);
#line 43 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                                                      Write(ViewBag.SearchingParam);

#line default
#line hidden
            EndContext();
            BeginContext(1469, 9, true);
            WriteLiteral("\"!</h1>\r\n");
            EndContext();
#line 44 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
    }

#line default
#line hidden
            BeginContext(1485, 6, true);
            WriteLiteral("</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
