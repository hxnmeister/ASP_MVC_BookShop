using ASP_MVC_BookShop.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP_MVC_BookShop.TagHelpers
{
    [HtmlTargetElement("recommended-books")]
    public class RecommendedBooksTagHelper : TagHelper
    {
        private readonly IMemoryCache _cache;

        public RecommendedBooksTagHelper(IMemoryCache cache)
        {
            _cache = cache;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            List<BookModel> recommendedBooks = _cache.Get<List<BookModel>>("bookRecommendations");

            if(recommendedBooks != null && recommendedBooks.Count > 0)
            {
                string content = "<p>Recommended for you:</p>";
                content += "<div class='row row-cols-4 gy-3 col-10 text-break m-auto'>";
                if (recommendedBooks != null)
                {
                    foreach (var item in recommendedBooks)
                    {
                        content += $@"
                        <div class='col lh-1 book-card mx-3 p-3 border rounded'>
                            <a class='link-body-emphasis link-underline link-underline-opacity-0' asp-controller='Book' asp-action='Details' asp-route-id='{item.Id}'>
                                <p check-overflow>Title: {item.Title}</p>
                                <p check-overflow>Publisher: {item.PublisherName}</p>
                            </a>
                        </div>";
                    }
                }
                content += "</div>";
                output.TagName = "footer";

                output.Content.SetHtmlContent(content);
            }
        }
    }
}
