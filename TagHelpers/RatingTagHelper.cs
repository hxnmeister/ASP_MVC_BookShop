using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ASP_MVC_BookShop.TagHelpers
{
    [HtmlTargetElement("rating", Attributes = "rate", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class RatingTagHelper : TagHelper
    {
        [HtmlAttributeName("rate")]
        public int Rate {  get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";

            switch (Rate)
            {
                case 1:
                    output.Attributes.Add("src", "/images/one-star.png");
                    break;
                case 2:
                    output.Attributes.Add("src", "/images/two-stars.png");
                    break;
                case 3:
                    output.Attributes.Add("src", "/images/three-stars.png");
                    break;
                case 4:
                    output.Attributes.Add("src", "/images/four-stars.png");
                    break;
                case 5:
                    output.Attributes.Add("src", "/images/five-stars.png");
                    break;
            }

            output.Attributes.Add("style", "width: 100px");
        }
    }
}
