#pragma checksum "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f1f43706f9bdd6cbb4278849a06a48d542992591838d215c3e8955a9bd1ffb2d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f1f43706f9bdd6cbb4278849a06a48d542992591838d215c3e8955a9bd1ffb2d", @"/Views/Book/SearchResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3e776884da7e66b68608511ba3c89c08df1095a536f913ccb8364193d50637f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_SearchResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BookModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
  
    ViewData["Title"] = "Searching Results";

#line default
#line hidden
            BeginContext(79, 27, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n");
            EndContext();
#line 8 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
     if(Model.Count > 0)
    {

#line default
#line hidden
            BeginContext(139, 45, true);
            WriteLiteral("        <h1 class=\"text-center\">Results for \"");
            EndContext();
            BeginContext(185, 22, false);
#line 10 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                                        Write(ViewBag.SearchingParam);

#line default
#line hidden
            EndContext();
            BeginContext(207, 5, true);
            WriteLiteral("\" by ");
            EndContext();
            BeginContext(213, 16, false);
#line 10 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                                                                    Write(ViewBag.Criteria);

#line default
#line hidden
            EndContext();
            BeginContext(229, 544, true);
            WriteLiteral(@"</h1>
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
            BeginContext(837, 66, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(904, 7, false);
#line 28 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                                   Write(book.Id);

#line default
#line hidden
            EndContext();
            BeginContext(911, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(947, 10, false);
#line 29 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                       Write(book.Title);

#line default
#line hidden
            EndContext();
            BeginContext(957, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(993, 18, false);
#line 30 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                       Write(book.PublisherName);

#line default
#line hidden
            EndContext();
            BeginContext(1011, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1047, 19, false);
#line 31 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                       Write(book.PublishingYear);

#line default
#line hidden
            EndContext();
            BeginContext(1066, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1102, 16, false);
#line 32 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                       Write(book.PagesAmount);

#line default
#line hidden
            EndContext();
            BeginContext(1118, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1154, 11, false);
#line 33 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                       Write(book.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(1165, 39, true);
            WriteLiteral(" / 5</td>\r\n                        <td>");
            EndContext();
            BeginContext(1205, 21, false);
#line 34 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                       Write(book.Author.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1226, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1228, 20, false);
#line 34 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                                              Write(book.Author.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1248, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1284, 10, false);
#line 35 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                       Write(book.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1294, 35, true);
            WriteLiteral("$</td>\r\n                    </tr>\r\n");
            EndContext();
#line 37 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                }

#line default
#line hidden
            BeginContext(1348, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 40 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
    }
    else 
    {

#line default
#line hidden
            BeginContext(1413, 59, true);
            WriteLiteral("        <h1 class=\"text-danger text-center\">No results by \"");
            EndContext();
            BeginContext(1473, 22, false);
#line 43 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
                                                      Write(ViewBag.SearchingParam);

#line default
#line hidden
            EndContext();
            BeginContext(1495, 9, true);
            WriteLiteral("\"!</h1>\r\n");
            EndContext();
#line 44 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\SearchResult.cshtml"
    }

#line default
#line hidden
            BeginContext(1511, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BookModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
