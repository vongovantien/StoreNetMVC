#pragma checksum "D:\dotNetProject\ShopApp\ShopApp\Views\Shared\Components\TopProducts\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "124dde3ebfe73fd203fd751545ca484f0d15991b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopProducts_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopProducts/Default.cshtml")]
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
#line 1 "D:\dotNetProject\ShopApp\ShopApp\Views\_ViewImports.cshtml"
using ShopApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotNetProject\ShopApp\ShopApp\Views\_ViewImports.cshtml"
using ShopApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124dde3ebfe73fd203fd751545ca484f0d15991b", @"/Views/Shared/Components/TopProducts/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dde55ab62193c467ed049d9f51201d435e41902a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopProducts_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 3 "D:\dotNetProject\ShopApp\ShopApp\Views\Shared\Components\TopProducts\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4\">\r\n            abc\r\n        </div>\r\n");
#nullable restore
#line 8 "D:\dotNetProject\ShopApp\ShopApp\Views\Shared\Components\TopProducts\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
