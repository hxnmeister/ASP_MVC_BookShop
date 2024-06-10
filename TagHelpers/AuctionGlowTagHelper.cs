using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ASP_MVC_BookShop.TagHelpers
{
    [HtmlTargetElement("auction", Attributes = "is-on-auction")]
    public class AuctionGlowTagHelper : TagHelper
    {
        [HtmlAttributeName("is-on-auction")]
        public bool IsOnAuction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            if (IsOnAuction == true)
            {
                output.Attributes.Add("style", "box-shadow: 0 0 20px #0d6efd");
            }
        }
    }
}
