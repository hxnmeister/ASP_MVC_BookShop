using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_BookShop.TagHelpers
{
    [HtmlTargetElement("t" ,TagStructure = TagStructure.NormalOrSelfClosing)]
    public class TextLenghtFormatterTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "p";

            string tagContent = (await output.GetChildContentAsync()).GetContent().Trim();

            if(!string.IsNullOrEmpty(tagContent) && tagContent.Length > 100)
            {
                string currentStyle = output.Attributes["style"]?.Value.ToString();
                string styleToAdd = "letter-spacing: -0.05em;";

                output.Attributes.SetAttribute("style", (!string.IsNullOrEmpty(currentStyle) ? $"{currentStyle} {styleToAdd}" : styleToAdd));
            }
        }
    }
}
