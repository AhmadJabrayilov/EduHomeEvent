#pragma checksum "C:\Users\User\Desktop\EduHome_Event-main\Views\Shared\_partialSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bf88c09e38da6c5917ab711215313cb2073d788"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__partialSearch), @"mvc.1.0.view", @"/Views/Shared/_partialSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_partialSearch.cshtml", typeof(AspNetCore.Views_Shared__partialSearch))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf88c09e38da6c5917ab711215313cb2073d788", @"/Views/Shared/_partialSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5238128e7434fdaf904d8fd4d124de92181853c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__partialSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Teacher>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\EduHome_Event-main\Views\Shared\_partialSearch.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(52, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "C:\Users\User\Desktop\EduHome_Event-main\Views\Shared\_partialSearch.cshtml"
 foreach (Teacher item in Model)
{

#line default
#line hidden
            BeginContext(88, 19, true);
            WriteLiteral("    <li>\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 107, "\"", 114, 0);
            EndWriteAttribute();
            BeginContext(115, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(117, 13, false);
#line 9 "C:\Users\User\Desktop\EduHome_Event-main\Views\Shared\_partialSearch.cshtml"
              Write(item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(130, 15, true);
            WriteLiteral("</a>\n    </li>\n");
            EndContext();
#line 11 "C:\Users\User\Desktop\EduHome_Event-main\Views\Shared\_partialSearch.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Teacher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
