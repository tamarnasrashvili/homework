using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSUViewEngine.Helper
{
    [HtmlTargetElement("button",Attributes = "bs-button-style")]
    public class ButtonTagHelper : TagHelper
    {
        public string BsButtonStyle { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"btn btn-{BsButtonStyle}");
        }

    }
}
