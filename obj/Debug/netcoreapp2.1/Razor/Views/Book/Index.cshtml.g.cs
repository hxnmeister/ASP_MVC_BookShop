#pragma checksum "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "eac1cc7fefdfae1cef55b82396ee2dd91cc41641df0a220fca10c949240e0b9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Index.cshtml", typeof(AspNetCore.Views_Book_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"eac1cc7fefdfae1cef55b82396ee2dd91cc41641df0a220fca10c949240e0b9b", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3e776884da7e66b68608511ba3c89c08df1095a536f913ccb8364193d50637f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link-body-emphasis link-underline link-underline-opacity-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col lh-1 book-card mx-3 p-3 border rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::ASP_MVC_BookShop.TagHelpers.AuctionGlowTagHelper __ASP_MVC_BookShop_TagHelpers_AuctionGlowTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::ASP_MVC_BookShop.TagHelpers.TextOverflowTagHelper __ASP_MVC_BookShop_TagHelpers_TextOverflowTagHelper;
        private global::ASP_MVC_BookShop.TagHelpers.RatingTagHelper __ASP_MVC_BookShop_TagHelpers_RatingTagHelper;
        private global::ASP_MVC_BookShop.TagHelpers.PriceTagHelper __ASP_MVC_BookShop_TagHelpers_PriceTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "Book Shop";

#line default
#line hidden
            BeginContext(66, 108, true);
            WriteLiteral("\r\n<div class=\"container text-center mt-5\">\r\n    <div class=\"row row-cols-4 gy-3 col-10 text-break m-auto\">\r\n");
            EndContext();
#line 9 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
         foreach (var book in Model)
        {

#line default
#line hidden
            BeginContext(223, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(235, 667, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("auction", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eac1cc7fefdfae1cef55b82396ee2dd91cc41641df0a220fca10c949240e0b9b5850", async() => {
                BeginContext(329, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(347, 531, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eac1cc7fefdfae1cef55b82396ee2dd91cc41641df0a220fca10c949240e0b9b6276", async() => {
                    BeginContext(484, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(506, 40, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eac1cc7fefdfae1cef55b82396ee2dd91cc41641df0a220fca10c949240e0b9b6719", async() => {
                        BeginContext(524, 7, true);
                        WriteLiteral("Title: ");
                        EndContext();
                        BeginContext(532, 10, false);
#line 13 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
                                        Write(book.Title);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __ASP_MVC_BookShop_TagHelpers_TextOverflowTagHelper = CreateTagHelper<global::ASP_MVC_BookShop.TagHelpers.TextOverflowTagHelper>();
                    __tagHelperExecutionContext.Add(__ASP_MVC_BookShop_TagHelpers_TextOverflowTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("check-overflow", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(546, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(568, 74, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eac1cc7fefdfae1cef55b82396ee2dd91cc41641df0a220fca10c949240e0b9b8699", async() => {
                        BeginContext(586, 8, true);
                        WriteLiteral("Author: ");
                        EndContext();
                        BeginContext(595, 21, false);
#line 14 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
                                         Write(book.Author.FirstName);

#line default
#line hidden
                        EndContext();
                        BeginContext(616, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(618, 20, false);
#line 14 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
                                                                Write(book.Author.LastName);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __ASP_MVC_BookShop_TagHelpers_TextOverflowTagHelper = CreateTagHelper<global::ASP_MVC_BookShop.TagHelpers.TextOverflowTagHelper>();
                    __tagHelperExecutionContext.Add(__ASP_MVC_BookShop_TagHelpers_TextOverflowTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("check-overflow", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(642, 33, true);
                    WriteLiteral("\r\n                    <p>Rating: ");
                    EndContext();
                    BeginContext(676, 11, false);
#line 15 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
                          Write(book.Rating);

#line default
#line hidden
                    EndContext();
                    BeginContext(687, 30, true);
                    WriteLiteral(" / 5</p>\r\n                    ");
                    EndContext();
                    BeginContext(717, 37, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("rating", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eac1cc7fefdfae1cef55b82396ee2dd91cc41641df0a220fca10c949240e0b9b11552", async() => {
                    }
                    );
                    __ASP_MVC_BookShop_TagHelpers_RatingTagHelper = CreateTagHelper<global::ASP_MVC_BookShop.TagHelpers.RatingTagHelper>();
                    __tagHelperExecutionContext.Add(__ASP_MVC_BookShop_TagHelpers_RatingTagHelper);
#line 16 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
__ASP_MVC_BookShop_TagHelpers_RatingTagHelper.Rate = book.Rating;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("rate", __ASP_MVC_BookShop_TagHelpers_RatingTagHelper.Rate, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(754, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(776, 80, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("price", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eac1cc7fefdfae1cef55b82396ee2dd91cc41641df0a220fca10c949240e0b9b13166", async() => {
                    }
                    );
                    __ASP_MVC_BookShop_TagHelpers_PriceTagHelper = CreateTagHelper<global::ASP_MVC_BookShop.TagHelpers.PriceTagHelper>();
                    __tagHelperExecutionContext.Add(__ASP_MVC_BookShop_TagHelpers_PriceTagHelper);
#line 17 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
__ASP_MVC_BookShop_TagHelpers_PriceTagHelper.CurrentPrice = book.Price;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("current-price", __ASP_MVC_BookShop_TagHelpers_PriceTagHelper.CurrentPrice, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 17 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
__ASP_MVC_BookShop_TagHelpers_PriceTagHelper.PreviousPrice = book.PreviousPrice;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("previous-price", __ASP_MVC_BookShop_TagHelpers_PriceTagHelper.PreviousPrice, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(856, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 12 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
                                                                                                                                   WriteLiteral(book.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(878, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __ASP_MVC_BookShop_TagHelpers_AuctionGlowTagHelper = CreateTagHelper<global::ASP_MVC_BookShop.TagHelpers.AuctionGlowTagHelper>();
            __tagHelperExecutionContext.Add(__ASP_MVC_BookShop_TagHelpers_AuctionGlowTagHelper);
#line 11 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
__ASP_MVC_BookShop_TagHelpers_AuctionGlowTagHelper.IsOnAuction = book.IsOnAuction;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("is-on-auction", __ASP_MVC_BookShop_TagHelpers_AuctionGlowTagHelper.IsOnAuction, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(902, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(915, 87, true);
            WriteLiteral("    </div>\r\n\r\n    <div class=\"container\">\r\n        <p>Quote of a day: </p>\r\n        <p>");
            EndContext();
            BeginContext(1003, 18, false);
#line 25 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
      Write(ViewBag.QuoteOfDay);

#line default
#line hidden
            EndContext();
            BeginContext(1021, 78, true);
            WriteLiteral("</p>\r\n    </div>\r\n\r\n    <div class=\"container\">\r\n        <h2>Calendar values (");
            EndContext();
            BeginContext(1101, 83, false);
#line 29 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
                         Write(ViewBag.CalendarValuesType.Equals("MonthValuesService") ? "Months" : "Days of Week");

#line default
#line hidden
            EndContext();
            BeginContext(1185, 52, true);
            WriteLiteral("):</h2>\r\n        <div class=\"container text-left\">\r\n");
            EndContext();
#line 31 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
             foreach (var item in ViewBag.CalendarValues)
            {

#line default
#line hidden
            BeginContext(1311, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(1331, 4, false);
#line 33 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
              Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(1335, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 34 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1356, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
