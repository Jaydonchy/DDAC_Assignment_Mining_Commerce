#pragma checksum "C:\Users\Jaydon\source\repos\DDAC_Assignment_Mining_Commerce\DDAC_Assignment_Mining_Commerce\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59c5f6ecede9cc7c3db52a9ec752ec9e83c1d1f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Jaydon\source\repos\DDAC_Assignment_Mining_Commerce\DDAC_Assignment_Mining_Commerce\Views\_ViewImports.cshtml"
using DDAC_Assignment_Mining_Commerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jaydon\source\repos\DDAC_Assignment_Mining_Commerce\DDAC_Assignment_Mining_Commerce\Views\_ViewImports.cshtml"
using DDAC_Assignment_Mining_Commerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59c5f6ecede9cc7c3db52a9ec752ec9e83c1d1f0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"460f61dc868e714ca88d8dd2d17b5e6208eb1b59", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DDAC_Assignment_Mining_Commerce.Models.ProductModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Jaydon\source\repos\DDAC_Assignment_Mining_Commerce\DDAC_Assignment_Mining_Commerce\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Display";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Home Page</h1>\r\nWelcome to Ore you ready\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public DDAC_Assignment_Mining_Commerce.Services.BlobService _blob { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DDAC_Assignment_Mining_Commerce.Models.ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
