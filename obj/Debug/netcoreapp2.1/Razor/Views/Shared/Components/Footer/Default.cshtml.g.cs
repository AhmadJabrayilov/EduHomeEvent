#pragma checksum "C:\Users\User\Desktop\EduHome_Event-main\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c479e64f994a8b9f37cca510337127cf10f0cffe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Footer/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Footer_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c479e64f994a8b9f37cca510337127cf10f0cffe", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5238128e7434fdaf904d8fd4d124de92181853c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("eduhome"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(11, 371, true);
            WriteLiteral(@"
    <footer class=""footer-area"">
        <div class=""main-footer"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-4 col-sm-6 col-xs-12"">
                        <div class=""single-widget pr-60"">
                            <div class=""footer-logo pb-25"">
                                <a href=""index.html"">");
            EndContext();
            BeginContext(382, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c479e64f994a8b9f37cca510337127cf10f0cffe4144", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 392, "~/img/logo/", 392, 11, true);
#line 10 "C:\Users\User\Desktop\EduHome_Event-main\Views\Shared\Components\Footer\Default.cshtml"
AddHtmlAttributeValue("", 403, Model.Logo, 403, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(430, 349, true);
            WriteLiteral(@"</a>
                            </div>
                            <p>I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and give you a coete account of the system. </p>
                            <div class=""footer-social"">
                                <ul>
                                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 779, "\"", 801, 1);
#line 15 "C:\Users\User\Desktop\EduHome_Event-main\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 786, Model.Facebook, 786, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(802, 87, true);
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\n                                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 889, "\"", 911, 1);
#line 16 "C:\Users\User\Desktop\EduHome_Event-main\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 896, Model.Vcontact, 896, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(912, 88, true);
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\n                                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1000, "\"", 1023, 1);
#line 17 "C:\Users\User\Desktop\EduHome_Event-main\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 1007, Model.Pinterest, 1007, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1024, 84, true);
            WriteLiteral("><i class=\"zmdi zmdi-vimeo\"></i></a></li>\n                                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1108, "\"", 1129, 1);
#line 18 "C:\Users\User\Desktop\EduHome_Event-main\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 1115, Model.Twitter, 1115, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1130, 2429, true);
            WriteLiteral(@"><i class=""zmdi zmdi-twitter""></i></a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-6 col-xs-12"">
                        <div class=""single-widget"">
                            <h3>information</h3>
                            <ul>
                                <li><a href=""#"">addmission</a></li>
                                <li><a href=""#"">Academic Calender</a></li>
                                <li><a href=""event.html"">Event List</a></li>
                                <li><a href=""#"">Hostel &amp; Dinning</a></li>
                                <li><a href=""#"">TimeTable</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-md-2 col-sm-6 col-xs-12"">
                        <div class=""single-widget"">
                            <h3>useful links</h3>
                            <ul>");
            WriteLiteral(@"
                                <li><a href=""course.html"">our courses</a></li>
                                <li><a href=""about.html"">about us</a></li>
                                <li><a href=""teacher.html"">teachers &amp; faculty</a></li>
                                <li><a href=""#"">teams &amp; conditions</a></li>
                                <li><a href=""event.html"">our events</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-6 col-xs-12"">
                        <div class=""single-widget"">
                            <h3>get in touch</h3>
                            <p>Your address goes here, Street<br>City, Roadno 785 New York</p>
                            <p>+880  548  986  898  87<br>+880  659  785  658  98</p>
                            <p>info@eduhome.com<br>www.eduhome.com</p>
                        </div>
                    </div>
                </div>
            </div>
        </div");
            WriteLiteral(@">
        <div class=""footer-bottom text-center"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <p>Copyright ?? <a href=""#"" target=""_blank"">HasTech</a> 2017. All Right Reserved By Hastech.</p>
                    </div>
                </div>
            </div>
        </div>
    </footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; }
    }
}
#pragma warning restore 1591
