#pragma checksum "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Event\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db2ac9adb17021869a6d98f5f03909780df0443e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Event_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Event/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Event/Detail.cshtml", typeof(AspNetCore.Areas_Admin_Views_Event_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db2ac9adb17021869a6d98f5f03909780df0443e", @"/Areas/Admin/Views/Event/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5238128e7434fdaf904d8fd4d124de92181853c6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Event_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UpComingEvent>
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
#line 2 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Event\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(60, 23, true);
            WriteLiteral("\n<div class=\"row\">\n    ");
            EndContext();
            BeginContext(83, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "db2ac9adb17021869a6d98f5f03909780df0443e5055", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 93, "~/img/event/", 93, 12, true);
#line 7 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 105, Model.Image, 105, 12, false);

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
            BeginContext(146, 126, true);
            WriteLiteral("\n\n</div>\n<div class=\"row mt-5\">\n    <div class=\"col-2\">\n        <h6>Title</h6>\n    </div>\n    <div class=\"col-4\">\n        <p> ");
            EndContext();
            BeginContext(273, 11, false);
#line 15 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Event\Detail.cshtml"
       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(284, 146, true);
            WriteLiteral("</p>\n    </div>\n    \n\n</div>\n<div class=\"row mt-2\">\n    <div class=\"col-2\">\n        <h6>Month</h6>\n    </div>\n    <div class=\"col-4\">\n        <p> ");
            EndContext();
            BeginContext(431, 28, false);
#line 25 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Event\Detail.cshtml"
       Write(Model.Month.ToString("MMMM"));

#line default
#line hidden
            EndContext();
            BeginContext(459, 138, true);
            WriteLiteral("</p>\n    </div>\n</div>\n<div class=\"row mt-2\">\n    <div class=\"col-2\">\n        <h6>Day</h6>\n    </div>\n    <div class=\"col-4\">\n        <p> ");
            EndContext();
            BeginContext(598, 24, false);
#line 33 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Event\Detail.cshtml"
       Write(Model.Day.ToString("dd"));

#line default
#line hidden
            EndContext();
            BeginContext(622, 144, true);
            WriteLiteral("</p>\n    </div>\n</div>\n<div class=\"row mt-2\">\n    <div class=\"col-2\">\n        <h6>StartTime</h6>\n    </div>\n    <div class=\"col-4\">\n        <p> ");
            EndContext();
            BeginContext(767, 36, false);
#line 41 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Event\Detail.cshtml"
       Write(Model.StartTime.ToString("hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(803, 137, true);
            WriteLiteral("</p>\n    </div>\n</div>\n<div class=\"row\">\n    <div class=\"col-2\">\n        <h6>EndTime</h6>\n    </div>\n    <div class=\"col-4\">\n        <p> ");
            EndContext();
            BeginContext(941, 34, false);
#line 49 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Event\Detail.cshtml"
       Write(Model.EndTime.ToString("hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(975, 146, true);
            WriteLiteral("</p>\n    </div>\n</div>\n<div class=\"row mt-2\">\n    <div class=\"col-2\">\n        <h6>Description</h6>\n    </div>\n    <div class=\"col-4\">\n        <p> ");
            EndContext();
            BeginContext(1122, 17, false);
#line 57 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Event\Detail.cshtml"
       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1139, 143, true);
            WriteLiteral("</p>\n    </div>\n</div>\n<div class=\"row mt-2\">\n    <div class=\"col-2\">\n        <h6>Speaker</h6>\n    </div>\n    <div class=\"col-4\">\n        <ul>\n");
            EndContext();
#line 66 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Event\Detail.cshtml"
             foreach (var item in Model.SpeakerEvents)
            {


#line default
#line hidden
            BeginContext(1352, 44, true);
            WriteLiteral("                <li style=\"list-style:none\">");
            EndContext();
            BeginContext(1397, 17, false);
#line 69 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Event\Detail.cshtml"
                                       Write(item.Speaker.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1414, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 70 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Event\Detail.cshtml"

            }

#line default
#line hidden
            BeginContext(1435, 155, true);
            WriteLiteral("        </ul>\n    </div>\n  \n</div>\n<div class=\"row mt-2\">\n    <div class=\"col-2\">\n        <h6>Category</h6>\n    </div>\n    <div class=\"col-4\">\n        <p> ");
            EndContext();
            BeginContext(1591, 19, false);
#line 81 "C:\Users\User\Desktop\EduHome_Event-main\Areas\Admin\Views\Event\Detail.cshtml"
       Write(Model.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1610, 51, true);
            WriteLiteral("</p>\n    </div>\n</div>\n\n<div class=\"row mt-3\">\n    ");
            EndContext();
            BeginContext(1661, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db2ac9adb17021869a6d98f5f03909780df0443e11391", async() => {
                BeginContext(1704, 7, true);
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
            BeginContext(1715, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UpComingEvent> Html { get; private set; }
    }
}
#pragma warning restore 1591
