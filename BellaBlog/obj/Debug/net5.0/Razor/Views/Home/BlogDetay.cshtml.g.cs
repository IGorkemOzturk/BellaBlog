#pragma checksum "C:\Users\Gorke\source\repos\BellaBlog\BellaBlog\Views\Home\BlogDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e65323e48740901605d7f517d7b4e4004e3505b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BlogDetay), @"mvc.1.0.view", @"/Views/Home/BlogDetay.cshtml")]
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
#line 2 "C:\Users\Gorke\source\repos\BellaBlog\BellaBlog\Views\Home\BlogDetay.cshtml"
using BellaBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e65323e48740901605d7f517d7b4e4004e3505b", @"/Views/Home/BlogDetay.cshtml")]
    public class Views_Home_BlogDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Gorke\source\repos\BellaBlog\BellaBlog\Views\Home\BlogDetay.cshtml"
  
    ViewData["Title"] = "BlogDetay";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n\r\n\r\n\r\n<div class=\"w3-container w3-white w3-margin w3-padding-large\">\r\n    <div class=\"w3-center\">\r\n        <h3>Title</h3>\r\n        <h5> <span class=\"w3-opacity\">tarih</span></h5>\r\n    </div>\r\n\r\n    <div class=\"w3-justify\">\r\n");
#nullable restore
#line 22 "C:\Users\Gorke\source\repos\BellaBlog\BellaBlog\Views\Home\BlogDetay.cshtml"
         foreach (var x in Model)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n           ");
#nullable restore
#line 27 "C:\Users\Gorke\source\repos\BellaBlog\BellaBlog\Views\Home\BlogDetay.cshtml"
      Write(x.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
#nullable restore
#line 29 "C:\Users\Gorke\source\repos\BellaBlog\BellaBlog\Views\Home\BlogDetay.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"/Home/BlogDetay/BlogId\"><p class=\"w3-right\"><button class=\"w3-button w3-black\"><b>Daha fazla</b></button></p></a>\r\n        <p class=\"w3-clear\"></p>\r\n\r\n    </div>\r\n</div>\r\n<hr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591