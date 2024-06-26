﻿using Microsoft.AspNetCore.Razor.TagHelpers;
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
                string currentStyle = output.Attributes["style"]?.Value.ToString();
                string styleToAdd = "font-size: 0.8em;";

                output.Attributes.SetAttribute("style", (!string.IsNullOrEmpty(currentStyle) ? $"{currentStyle} {styleToAdd}" : styleToAdd));
            }
        }
    }
}
