#pragma checksum "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\QueuedEmail\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a3b83443db42ff0c830936752edebf710886378"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_QueuedEmail_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/QueuedEmail/Edit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Smartstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Smartstore.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Smartstore.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Smartstore.Imaging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Smartstore.Core.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Smartstore.Core.Widgets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Smartstore.Core.Content.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Smartstore.Core.Content.Menus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Smartstore.Web.Models.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Smartstore.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Smartstore.Web.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Smartstore.Web.Rendering.Choices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Smartstore.Web.TagHelpers.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Smartstore.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Humanizer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\QueuedEmail\Edit.cshtml"
using Smartstore.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a3b83443db42ff0c830936752edebf710886378", @"/Areas/Admin/Views/QueuedEmail/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f966b0121d5b04d3349ea0c67b3def4c0c9c03", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_QueuedEmail_Edit : Smartstore.Web.Razor.SmartRazorPage<QueuedEmailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("button-id", "queuedEmail-delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateOrUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Smartstore.Web.TagHelpers.Shared.ConfirmTagHelper __Smartstore_Web_TagHelpers_Shared_ConfirmTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\QueuedEmail\Edit.cshtml"
  
    ViewBag.Title = T("Admin.System.QueuedEmails.EditQueuedEmailDetails").Value;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a3b83443db42ff0c830936752edebf7108863789007", async() => {
                WriteLiteral("\r\n    <div class=\"section-header\">\r\n        <div class=\"title\">\r\n            ");
#nullable restore
#line 12 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\QueuedEmail\Edit.cshtml"
       Write(T("Admin.System.QueuedEmails.EditQueuedEmailDetails"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a3b83443db42ff0c830936752edebf7108863789629", async() => {
                    WriteLiteral("(");
#nullable restore
#line 12 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\QueuedEmail\Edit.cshtml"
                                                                                    Write(T("Admin.System.QueuedEmails.BackToList"));

#line default
#line hidden
#nullable disable
                    WriteLiteral(")");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n        <div class=\"options\">\r\n            <button type=\"submit\" name=\"save\" value=\"save\" class=\"btn btn-warning\">\r\n                <i class=\"fa fa-check\"></i>\r\n                <span>");
#nullable restore
#line 17 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\QueuedEmail\Edit.cshtml"
                 Write(T("Admin.Common.Save"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </button>\r\n            <button type=\"submit\" name=\"save\" value=\"save-continue\" class=\"btn btn-secondary\">\r\n                <span>");
#nullable restore
#line 20 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\QueuedEmail\Edit.cshtml"
                 Write(T("Admin.Common.SaveContinue"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </button>\r\n            <button type=\"submit\" name=\"requeue\" value=\"requeue\" class=\"btn btn-secondary\">\r\n                <i class=\"fa fa-redo\"></i>\r\n                <span>");
#nullable restore
#line 24 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\QueuedEmail\Edit.cshtml"
                 Write(T("Admin.System.QueuedEmails.Requeue"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </button>\r\n");
#nullable restore
#line 26 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\QueuedEmail\Edit.cshtml"
             if (Model.SendManually)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button type=\"submit\" name=\"sendnow\" value=\"sendnow\" class=\"btn btn-primary\"");
                BeginWriteAttribute("onclick", " onclick=\'", 1212, "\'", 1278, 4);
                WriteAttributeValue("", 1222, "return", 1222, 6, true);
                WriteAttributeValue(" ", 1228, "confirm(", 1229, 9, true);
#nullable restore
#line 28 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\QueuedEmail\Edit.cshtml"
WriteAttributeValue("", 1237, T("Admin.Common.AskToProceed").JsValue, 1237, 39, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1276, ");", 1276, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <i class=\"fa fa-envelope\"></i>\r\n                    <span>");
#nullable restore
#line 30 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\QueuedEmail\Edit.cshtml"
                     Write(T("Admin.Common.SendNow"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                </button>\r\n");
#nullable restore
#line 32 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\QueuedEmail\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <button id=\"queuedEmail-delete\" class=\"btn btn-danger\">\r\n                <i class=\"far fa-trash-alt\"></i>\r\n                <span>");
#nullable restore
#line 35 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\QueuedEmail\Edit.cshtml"
                 Write(T("Admin.Common.Delete"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </button>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("confirm", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a3b83443db42ff0c830936752edebf71088637814703", async() => {
                }
                );
                __Smartstore_Web_TagHelpers_Shared_ConfirmTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.ConfirmTagHelper>();
                __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_ConfirmTagHelper);
                __Smartstore_Web_TagHelpers_Shared_ConfirmTagHelper.ButtonId = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a3b83443db42ff0c830936752edebf71088637815910", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 41 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\QueuedEmail\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QueuedEmailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
