#pragma checksum "C:\Users\AgnieszkaGielata\Desktop\repos\W5\W5\Views\Home\Layout1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74c338c0462576f005194750ef89fc0792863820"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Layout1), @"mvc.1.0.view", @"/Views/Home/Layout1.cshtml")]
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
#nullable restore
#line 1 "C:\Users\AgnieszkaGielata\Desktop\repos\W5\W5\Views\_ViewImports.cshtml"
using W5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AgnieszkaGielata\Desktop\repos\W5\W5\Views\_ViewImports.cshtml"
using W5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74c338c0462576f005194750ef89fc0792863820", @"/Views/Home/Layout1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78e0f324cb314e66f9a4edf9844f319b42a5d825", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Layout1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\AgnieszkaGielata\Desktop\repos\W5\W5\Views\Home\Layout1.cshtml"
  
    ViewData["Title"] = "Layout1";
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Left", async() => {
                WriteLiteral(@"
    <h2> Left Column </h2>
    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras at ipsum commodo tellus tristique laoreet. Proin erat orci, congue in sem at, rutrum interdum nunc. Ut non ornare arcu. Duis volutpat malesuada arcu, a dictum est aliquet a. Suspendisse fringilla pulvinar massa at rutrum. Nunc luctus convallis aliquam. Proin eget mauris posuere, porta turpis efficitur, consequat ex. </p>
");
            }
            );
            DefineSection("Right", async() => {
                WriteLiteral("\r\n    <h2> Right Column </h2>\r\n    <img src=\"https://picsum.photos/200/300\" alt=\"lorem picsum\" />\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
