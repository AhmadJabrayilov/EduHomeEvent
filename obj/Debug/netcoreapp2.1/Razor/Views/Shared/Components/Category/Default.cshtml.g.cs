#pragma checksum "C:\Users\User\Desktop\EduHome_Event-main\Views\Shared\Components\Category\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33013b8d5d4d22bba81698b7c688ec996f3f4bbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Category_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Category/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Category/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Category_Default))]
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
#line 1 "C:\Users\User\Desktop\EduHome_Event-main\Views\_ViewImports.cshtml"
using EducationBackendFinal.Models;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\EduHome_Event-main\Views\_ViewImports.cshtml"
using EducationBackendFinal.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33013b8d5d4d22bba81698b7c688ec996f3f4bbc", @"/Views/Shared/Components/Category/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5238128e7434fdaf904d8fd4d124de92181853c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Category_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable< Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\EduHome_Event-main\Views\Shared\Components\Category\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(54, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "C:\Users\User\Desktop\EduHome_Event-main\Views\Shared\Components\Category\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(86, 20, true);
            WriteLiteral("    <li><a href=\"#\">");
            EndContext();
            BeginContext(107, 9, false);
#line 8 "C:\Users\User\Desktop\EduHome_Event-main\Views\Shared\Components\Category\Default.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(116, 14, true);
            WriteLiteral(" </a>(3)</li>\n");
            EndContext();
#line 9 "C:\Users\User\Desktop\EduHome_Event-main\Views\Shared\Components\Category\Default.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable< Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
