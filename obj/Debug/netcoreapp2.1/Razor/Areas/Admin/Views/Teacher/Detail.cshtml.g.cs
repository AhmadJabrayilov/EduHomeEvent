#pragma checksum "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66caa7f50ca78c5c13925456129804e2c9d78c18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Teacher_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Teacher/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Teacher/Detail.cshtml", typeof(AspNetCore.Areas_Admin_Views_Teacher_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66caa7f50ca78c5c13925456129804e2c9d78c18", @"/Areas/Admin/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5238128e7434fdaf904d8fd4d124de92181853c6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Teacher\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(54, 23, true);
            WriteLiteral("\n<div class=\"row\">\n    ");
            EndContext();
            BeginContext(77, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66caa7f50ca78c5c13925456129804e2c9d78c185065", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 87, "~/img/teacher/", 87, 14, true);
#line 7 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 101, Model.Image, 101, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(142, 129, true);
            WriteLiteral("\n\n</div>\n<div class=\"row mt-5\">\n    <div class=\"col-2\">\n        <h6>FullName</h6>\n    </div>\n    <div class=\"col-4\">\n        <p> ");
            EndContext();
            BeginContext(272, 14, false);
#line 15 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Teacher\Detail.cshtml"
       Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(286, 145, true);
            WriteLiteral("</p>\n    </div>\n\n\n</div>\n<div class=\"row mt-2\">\n    <div class=\"col-2\">\n        <h6>Position</h6>\n    </div>\n    <div class=\"col-4\">\n        <p> ");
            EndContext();
            BeginContext(432, 14, false);
#line 25 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Teacher\Detail.cshtml"
       Write(Model.Position);

#line default
#line hidden
            EndContext();
            BeginContext(446, 143, true);
            WriteLiteral("</p>\n    </div>\n</div>\n<div class=\"row mt-2\">\n    <div class=\"col-2\">\n        <h6>Facebook</h6>\n    </div>\n    <div class=\"col-4\">\n        <p> ");
            EndContext();
            BeginContext(590, 14, false);
#line 33 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Teacher\Detail.cshtml"
       Write(Model.Facebook);

#line default
#line hidden
            EndContext();
            BeginContext(604, 142, true);
            WriteLiteral("</p>\n    </div>\n</div>\n<div class=\"row mt-2\">\n    <div class=\"col-2\">\n        <h6>Twitter</h6>\n    </div>\n    <div class=\"col-4\">\n        <p> ");
            EndContext();
            BeginContext(747, 13, false);
#line 41 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Teacher\Detail.cshtml"
       Write(Model.Twitter);

#line default
#line hidden
            EndContext();
            BeginContext(760, 139, true);
            WriteLiteral("</p>\n    </div>\n</div>\n<div class=\"row\">\n    <div class=\"col-2\">\n        <h6>Pinterest</h6>\n    </div>\n    <div class=\"col-4\">\n        <p> ");
            EndContext();
            BeginContext(900, 15, false);
#line 49 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Teacher\Detail.cshtml"
       Write(Model.Pinterest);

#line default
#line hidden
            EndContext();
            BeginContext(915, 143, true);
            WriteLiteral("</p>\n    </div>\n</div>\n<div class=\"row mt-2\">\n    <div class=\"col-2\">\n        <h6>VContact</h6>\n    </div>\n    <div class=\"col-4\">\n        <p> ");
            EndContext();
            BeginContext(1059, 14, false);
#line 57 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Teacher\Detail.cshtml"
       Write(Model.VContact);

#line default
#line hidden
            EndContext();
            BeginContext(1073, 151, true);
            WriteLiteral("</p>\n    </div>\n</div>\n<div class=\"row mt-2\">\n    <div class=\"col-2\">\n        <h6>Category</h6>\n    </div>\n        <div class=\"col-4\">\n            <p> ");
            EndContext();
            BeginContext(1225, 19, false);
#line 65 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Teacher\Detail.cshtml"
           Write(Model.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1244, 55, true);
            WriteLiteral("</p>\n        </div>\n</div>\n\n<div class=\"row mt-3\">\n    ");
            EndContext();
            BeginContext(1299, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66caa7f50ca78c5c13925456129804e2c9d78c1810258", async() => {
                BeginContext(1342, 7, true);
                WriteLiteral("Go Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1353, 9, true);
            WriteLiteral("\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
