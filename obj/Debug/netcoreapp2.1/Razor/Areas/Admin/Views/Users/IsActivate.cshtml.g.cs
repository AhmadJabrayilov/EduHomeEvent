#pragma checksum "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Users\IsActivate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f83d8fe3a9a388e23cd4deaf9963fcd702e0fb2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_IsActivate), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/IsActivate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Users/IsActivate.cshtml", typeof(AspNetCore.Areas_Admin_Views_Users_IsActivate))]
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
#line 1 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\_ViewImports.cshtml"
using EducationBackendFinal.Models;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\_ViewImports.cshtml"
using EducationBackendFinal.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f83d8fe3a9a388e23cd4deaf9963fcd702e0fb2c", @"/Areas/Admin/Views/Users/IsActivate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5238128e7434fdaf904d8fd4d124de92181853c6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_IsActivate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Users\IsActivate.cshtml"
  
    ViewData["Title"] = "IsActivate";

#line default
#line hidden
            BeginContext(58, 287, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12 d-flex align-items-stretch"">
        <div class=""row"">
            <div class=""col-md-12 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">");
            EndContext();
            BeginContext(346, 14, false);
#line 12 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Users\IsActivate.cshtml"
                                          Write(Model.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(360, 62, true);
            WriteLiteral("</h4>\n                        <p>\n                            ");
            EndContext();
            BeginContext(423, 11, false);
#line 14 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Users\IsActivate.cshtml"
                       Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(434, 86, true);
            WriteLiteral("\n                        </p>\n                        <p>\n                            ");
            EndContext();
            BeginContext(521, 14, false);
#line 17 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Users\IsActivate.cshtml"
                       Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(535, 30, true);
            WriteLiteral("\n                        </p>\n");
            EndContext();
#line 19 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Users\IsActivate.cshtml"
                         if (Model.IsActivated)
                        {

#line default
#line hidden
            BeginContext(639, 84, true);
            WriteLiteral("                            <p class=\"text-danger\">Deactive etmek isteyirsiniz?</p>\n");
            EndContext();
#line 22 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Users\IsActivate.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(804, 83, true);
            WriteLiteral("                            <p class=\"text-success\">Active etmek isteyirsiniz?</p>\n");
            EndContext();
#line 26 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Users\IsActivate.cshtml"
                        }

#line default
#line hidden
            BeginContext(913, 130, true);
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n    <div class=\"row mt-3\">\n        ");
            EndContext();
            BeginContext(1043, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f83d8fe3a9a388e23cd4deaf9963fcd702e0fb2c7496", async() => {
                BeginContext(1086, 7, true);
                WriteLiteral("Go Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1097, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(1106, 525, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f83d8fe3a9a388e23cd4deaf9963fcd702e0fb2c8959", async() => {
                BeginContext(1126, 43, true);
                WriteLiteral("\n            <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1169, "\"", 1186, 1);
#line 35 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Users\IsActivate.cshtml"
WriteAttributeValue("", 1177, Model.Id, 1177, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1187, 4, true);
                WriteLiteral(" />\n");
                EndContext();
#line 36 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Users\IsActivate.cshtml"
             if (Model.IsActivated)
            {

#line default
#line hidden
                BeginContext(1241, 157, true);
                WriteLiteral("                <input type=\"hidden\" name=\"IsActivated\" value=\"false\" />\n                <button type=\"submit\" class=\"btn btn-danger ml-2\">Disabled</button>\n");
                EndContext();
#line 40 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Users\IsActivate.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(1443, 158, true);
                WriteLiteral("                <input type=\"hidden\" name=\"IsActivated\" value=\"true\" />\n                <button type=\"submit\" class=\"btn btn-success ml-2\">Activated</button>\n");
                EndContext();
#line 45 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Users\IsActivate.cshtml"
            }

#line default
#line hidden
                BeginContext(1615, 9, true);
                WriteLiteral("\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1631, 12, true);
            WriteLiteral("\n    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
