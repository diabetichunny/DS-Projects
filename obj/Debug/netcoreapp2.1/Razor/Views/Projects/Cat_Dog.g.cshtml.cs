#pragma checksum "/home/diabetichunny/Desktop/Johann/Mega/Trying/MyProjects/Views/Projects/Cat_Dog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e92d9de7fed1a6675ff9a6271e1c98890672f098"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Cat_Dog), @"mvc.1.0.view", @"/Views/Projects/Cat_Dog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Cat_Dog.cshtml", typeof(AspNetCore.Views_Projects_Cat_Dog))]
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
#line 1 "/home/diabetichunny/Desktop/Johann/Mega/Trying/MyProjects/Views/_ViewImports.cshtml"
using MyProjects;

#line default
#line hidden
#line 2 "/home/diabetichunny/Desktop/Johann/Mega/Trying/MyProjects/Views/_ViewImports.cshtml"
using MyProjects.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e92d9de7fed1a6675ff9a6271e1c98890672f098", @"/Views/Projects/Cat_Dog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9098c4a86e23acb823df47cdfda1a0d0287d84ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Cat_Dog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/diabetichunny/Desktop/Johann/Mega/Trying/MyProjects/Views/Projects/Cat_Dog.cshtml"
  
    ViewData["Title"] = "Cat or Dog";

#line default
#line hidden
            BeginContext(43, 279, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12 col-sm-6"">
        <div class=""embed-responsive embed-responsive-16by9 z-depth-4"">
            <iframe class=""embed-responsive-item"" src=""https://dh-cat-dog.herokuapp.com/"" allowfullscreen></iframe>
        </div>
    </div>   
</div>");
            EndContext();
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
