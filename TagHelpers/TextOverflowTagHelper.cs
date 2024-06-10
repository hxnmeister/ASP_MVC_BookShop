using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace ASP_MVC_BookShop.TagHelpers
{
    [HtmlTargetElement("p", Attributes = "check-overflow")]
    public class TextOverflowTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            string tagContent = (await output.GetChildContentAsync()).GetContent();

            if(tagContent.Length > 25) 
            {
                output.Attributes.Add("style", "font-size: 0.8em");
            }
        }
    }
}
