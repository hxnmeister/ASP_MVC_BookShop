#pragma checksum "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4a6c95d715f731b23e93e25e05f659b131ca65dbccf9b357341b5822cb93e428"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Details), @"mvc.1.0.view", @"/Views/Book/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Details.cshtml", typeof(AspNetCore.Views_Book_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4a6c95d715f731b23e93e25e05f659b131ca65dbccf9b357341b5822cb93e428", @"/Views/Book/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3e776884da7e66b68608511ba3c89c08df1095a536f913ccb8364193d50637f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
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
        private global::ASP_MVC_BookShop.TagHelpers.TextLenghtFormatterTagHelper __ASP_MVC_BookShop_TagHelpers_TextLenghtFormatterTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Details.cshtml"
  
    ViewData["Title"] = Model?.Title ?? "Book not found!";

#line default
#line hidden
            BeginContext(82, 39, true);
            WriteLiteral("\r\n<div class=\"container text-center\">\r\n");
            EndContext();
#line 8 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Details.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(153, 12, true);
            WriteLiteral("        <h1>");
            EndContext();
            BeginContext(166, 11, false);
#line 10 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Details.cshtml"
       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(177, 15, true);
            WriteLiteral("</h1>\r\n        ");
            EndContext();
            BeginContext(192, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("t", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a6c95d715f731b23e93e25e05f659b131ca65dbccf9b357341b5822cb93e4284268", async() => {
                BeginContext(195, 8, true);
                WriteLiteral("Author: ");
                EndContext();
                BeginContext(204, 22, false);
#line 11 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Details.cshtml"
              Write(Model.Author.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(226, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(228, 21, false);
#line 11 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Details.cshtml"
                                      Write(Model.Author.LastName);

#line default
#line hidden
                EndContext();
            }
            );
            __ASP_MVC_BookShop_TagHelpers_TextLenghtFormatterTagHelper = CreateTagHelper<global::ASP_MVC_BookShop.TagHelpers.TextLenghtFormatterTagHelper>();
            __tagHelperExecutionContext.Add(__ASP_MVC_BookShop_TagHelpers_TextLenghtFormatterTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(253, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(263, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("t", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a6c95d715f731b23e93e25e05f659b131ca65dbccf9b357341b5822cb93e4286108", async() => {
                BeginContext(266, 11, true);
                WriteLiteral("Publisher: ");
                EndContext();
                BeginContext(278, 19, false);
#line 12 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Details.cshtml"
                 Write(Model.PublisherName);

#line default
#line hidden
                EndContext();
            }
            );
            __ASP_MVC_BookShop_TagHelpers_TextLenghtFormatterTagHelper = CreateTagHelper<global::ASP_MVC_BookShop.TagHelpers.TextLenghtFormatterTagHelper>();
            __tagHelperExecutionContext.Add(__ASP_MVC_BookShop_TagHelpers_TextLenghtFormatterTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(301, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(311, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("t", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a6c95d715f731b23e93e25e05f659b131ca65dbccf9b357341b5822cb93e4287573", async() => {
                BeginContext(314, 8, true);
                WriteLiteral("Rating: ");
                EndContext();
                BeginContext(323, 12, false);
#line 13 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Details.cshtml"
              Write(Model.Rating);

#line default
#line hidden
                EndContext();
                BeginContext(335, 4, true);
                WriteLiteral(" / 5");
                EndContext();
            }
            );
            __ASP_MVC_BookShop_TagHelpers_TextLenghtFormatterTagHelper = CreateTagHelper<global::ASP_MVC_BookShop.TagHelpers.TextLenghtFormatterTagHelper>();
            __tagHelperExecutionContext.Add(__ASP_MVC_BookShop_TagHelpers_TextLenghtFormatterTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(343, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(353, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("t", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a6c95d715f731b23e93e25e05f659b131ca65dbccf9b357341b5822cb93e4289139", async() => {
                BeginContext(356, 7, true);
                WriteLiteral("Pages: ");
                EndContext();
                BeginContext(364, 17, false);
#line 14 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Details.cshtml"
             Write(Model.PagesAmount);

#line default
#line hidden
                EndContext();
            }
            );
            __ASP_MVC_BookShop_TagHelpers_TextLenghtFormatterTagHelper = CreateTagHelper<global::ASP_MVC_BookShop.TagHelpers.TextLenghtFormatterTagHelper>();
            __tagHelperExecutionContext.Add(__ASP_MVC_BookShop_TagHelpers_TextLenghtFormatterTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(385, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(395, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("t", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a6c95d715f731b23e93e25e05f659b131ca65dbccf9b357341b5822cb93e42810593", async() => {
                BeginContext(398, 17, true);
                WriteLiteral("Publishing Year: ");
                EndContext();
                BeginContext(416, 20, false);
#line 15 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Details.cshtml"
                       Write(Model.PublishingYear);

#line default
#line hidden
                EndContext();
            }
            );
            __ASP_MVC_BookShop_TagHelpers_TextLenghtFormatterTagHelper = CreateTagHelper<global::ASP_MVC_BookShop.TagHelpers.TextLenghtFormatterTagHelper>();
            __tagHelperExecutionContext.Add(__ASP_MVC_BookShop_TagHelpers_TextLenghtFormatterTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(440, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Details.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(466, 54, true);
            WriteLiteral("        <h1 class=\"text-danger\">No such book with ID: ");
            EndContext();
            BeginContext(521, 10, false);
#line 19 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Details.cshtml"
                                                 Write(ViewBag.Id);

#line default
#line hidden
            EndContext();
            BeginContext(531, 8, true);
            WriteLiteral("!</h1>\r\n");
            EndContext();
#line 20 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_BookShop\Views\Book\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(546, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
