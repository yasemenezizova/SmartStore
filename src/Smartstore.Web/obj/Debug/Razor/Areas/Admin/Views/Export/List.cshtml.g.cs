#pragma checksum "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65e66f71aad175859bbc8058d3d488a9f1c841fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Export_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Export/List.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\_ViewImports.cshtml"
using Smartstore.Core.DataExchange;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\_ViewImports.cshtml"
using Smartstore.Admin.Models.Export;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65e66f71aad175859bbc8058d3d488a9f1c841fe", @"/Areas/Admin/Views/Export/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f966b0121d5b04d3349ea0c67b3def4c0c9c03", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9afb34f38267edf0db49142707e9d69ac2f0fcf6", @"/Areas/Admin/Views/Export/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Export_List : Smartstore.Web.Razor.SmartRazorPage<List<ExportProfileModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ProfileList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "export-profile-dialog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "export-profile-file-dialog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("sm-target-zone", "scripts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-origin", new global::Microsoft.AspNetCore.Html.HtmlString("ExportList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Smartstore.Web.TagHelpers.Shared.ModalTagHelper __Smartstore_Web_TagHelpers_Shared_ModalTagHelper;
        private global::Smartstore.Web.TagHelpers.Shared.ModalHeaderTagHelper __Smartstore_Web_TagHelpers_Shared_ModalHeaderTagHelper;
        private global::Smartstore.Web.TagHelpers.Shared.ModalBodyTagHelper __Smartstore_Web_TagHelpers_Shared_ModalBodyTagHelper;
        private global::Smartstore.Web.TagHelpers.Shared.ModalFooterTagHelper __Smartstore_Web_TagHelpers_Shared_ModalFooterTagHelper;
        private global::Smartstore.Web.TagHelpers.Shared.HtmlWidgetTagHelper __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
  
    ViewBag.Title = T("Common.Export").Value;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"section-header\">\r\n    <div class=\"title\">\r\n        <i class=\"fa fa-upload\"></i>\r\n        <span>");
#nullable restore
#line 10 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
         Write(T("Common.Export"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    <div class=\"options\">\r\n\t\t<a href=\"#\" data-url=\"");
#nullable restore
#line 13 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
                         Write(Url.Action("Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-primary export-profile-button\">\r\n\t\t\t<i class=\"fa fa-plus\"></i>\r\n\t\t\t<span>");
#nullable restore
#line 15 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
             Write(T("Admin.DataExchange.AddNewProfile"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t</a>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"ExportProfileListContainer\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65e66f71aad175859bbc8058d3d488a9f1c841fe10670", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 21 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Where(x => !x.IsSystemProfile);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = new ViewDataDictionary(ViewData) { { "IsSystemProfile", false } };

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65e66f71aad175859bbc8058d3d488a9f1c841fe12812", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 22 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Where(x => x.IsSystemProfile);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 22 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = new ViewDataDictionary(ViewData) { { "IsSystemProfile", true } };

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("modal", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e66f71aad175859bbc8058d3d488a9f1c841fe14962", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("modal-header", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e66f71aad175859bbc8058d3d488a9f1c841fe15224", async() => {
                }
                );
                __Smartstore_Web_TagHelpers_Shared_ModalHeaderTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.ModalHeaderTagHelper>();
                __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_ModalHeaderTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
                WriteLiteral(T("Admin.DataExchange.AddNewProfile"));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Smartstore_Web_TagHelpers_Shared_ModalHeaderTagHelper.Title = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("sm-title", __Smartstore_Web_TagHelpers_Shared_ModalHeaderTagHelper.Title, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("modal-body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e66f71aad175859bbc8058d3d488a9f1c841fe16915", async() => {
                }
                );
                __Smartstore_Web_TagHelpers_Shared_ModalBodyTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.ModalBodyTagHelper>();
                __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_ModalBodyTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("modal-footer", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e66f71aad175859bbc8058d3d488a9f1c841fe17893", async() => {
                    WriteLiteral("\r\n\t\t<button class=\"btn btn-secondary btn-flat\" data-dismiss=\"modal\"><span>");
#nullable restore
#line 29 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
                                                                         Write(T("Common.Cancel"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</span></button>\r\n\t\t<button class=\"btn btn-primary\"><span>");
#nullable restore
#line 30 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
                                         Write(T("Common.OK"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</span></button>\r\n    ");
                }
                );
                __Smartstore_Web_TagHelpers_Shared_ModalFooterTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.ModalFooterTagHelper>();
                __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_ModalFooterTagHelper);
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
            __Smartstore_Web_TagHelpers_Shared_ModalTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.ModalTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_ModalTagHelper);
            __Smartstore_Web_TagHelpers_Shared_ModalTagHelper.Id = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 25 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
__Smartstore_Web_TagHelpers_Shared_ModalTagHelper.RenderAtPageEnd = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("sm-render-at-page-end", __Smartstore_Web_TagHelpers_Shared_ModalTagHelper.RenderAtPageEnd, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
__Smartstore_Web_TagHelpers_Shared_ModalTagHelper.Size = global::Smartstore.Web.TagHelpers.Shared.ModalSize.Large;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("sm-size", __Smartstore_Web_TagHelpers_Shared_ModalTagHelper.Size, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("modal", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e66f71aad175859bbc8058d3d488a9f1c841fe21536", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("modal-header", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e66f71aad175859bbc8058d3d488a9f1c841fe21800", async() => {
                }
                );
                __Smartstore_Web_TagHelpers_Shared_ModalHeaderTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.ModalHeaderTagHelper>();
                __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_ModalHeaderTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
                WriteLiteral(T("Admin.DataExchange.Export.ExportFiles"));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Smartstore_Web_TagHelpers_Shared_ModalHeaderTagHelper.Title = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("sm-title", __Smartstore_Web_TagHelpers_Shared_ModalHeaderTagHelper.Title, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("modal-body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e66f71aad175859bbc8058d3d488a9f1c841fe23496", async() => {
                }
                );
                __Smartstore_Web_TagHelpers_Shared_ModalBodyTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.ModalBodyTagHelper>();
                __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_ModalBodyTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("modal-footer", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e66f71aad175859bbc8058d3d488a9f1c841fe24474", async() => {
                    WriteLiteral("\r\n        <button class=\"btn btn-secondary btn-flat\" data-dismiss=\"modal\"><span>");
#nullable restore
#line 38 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
                                                                         Write(T("Common.Cancel"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</span></button>\r\n    ");
                }
                );
                __Smartstore_Web_TagHelpers_Shared_ModalFooterTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.ModalFooterTagHelper>();
                __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_ModalFooterTagHelper);
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
            __Smartstore_Web_TagHelpers_Shared_ModalTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.ModalTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_ModalTagHelper);
            __Smartstore_Web_TagHelpers_Shared_ModalTagHelper.Id = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 34 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
__Smartstore_Web_TagHelpers_Shared_ModalTagHelper.RenderAtPageEnd = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("sm-render-at-page-end", __Smartstore_Web_TagHelpers_Shared_ModalTagHelper.RenderAtPageEnd, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 34 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
__Smartstore_Web_TagHelpers_Shared_ModalTagHelper.Size = global::Smartstore.Web.TagHelpers.Shared.ModalSize.FlexSmall;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("sm-size", __Smartstore_Web_TagHelpers_Shared_ModalTagHelper.Size, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e66f71aad175859bbc8058d3d488a9f1c841fe27787", async() => {
                WriteLiteral(@"
    $(function() {
        var dialog = $('#export-profile-dialog');

        // Show profile dialog.
        $(document).on('click', '.export-profile-button', function (e) {
            e.preventDefault();

            dialog.find('.modal-body').empty();
            dialog.find('.btn-primary').toggle(false);

			$(this).doAjax({
				type: 'GET',
				smallIcon: dialog.find('.modal-body'),
				callbackSuccess: function (response) {
					dialog.find('.modal-body').html(response);

					$('select[name=""ProviderSystemName""]').selectWrapper({
						minimumResultsForSearch: 16,
						templateResult: providerSelectItemFormatting,
						templateSelection: providerSelectItemFormatting
					});

					toggleProviderDescription();

					$('select[name=""CloneProfileId""]').selectWrapper({
						allowClear: true,
						minimumResultsForSearch: 16,
						templateResult: profileSelectItemFormatting,
						templateSelection: profileSelectItemFormatting
					});
				},
				callbackComplete: func");
                WriteLiteral(@"tion () {
					dialog.find('.btn-primary').toggle(true);
				}
			});

            dialog.modal();
            return false;
        });

        // Show profile file dialog.
        $(document).on('click', '.export-file-count', function (e) {
            e.preventDefault();

            var fileDialog = $('#export-profile-file-dialog');
            var id = $(this).closest('.profile-row').attr('data-profile-id');

            fileDialog.find('.modal-body').empty();
			
			$({}).doAjax({
				type: 'GET',
				url: '");
#nullable restore
#line 94 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
                 Write(Url.Action("ProfileFileDetails"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?deploymentId=0&profileId=' + id,
				smallIcon: fileDialog.find('.modal-body'),
				callbackSuccess: function (response) {
					fileDialog.find('.modal-body').html(response);
				}
			});

            fileDialog.modal();
            return false;
        });

		// Add export profile.
		dialog.on('click', '.btn-primary', function () {
			var form = dialog.find('.export-profile-form');

			if (!form.length) {
				dialog.modal('hide');
			}
			else {
				form.submit();
			}
		});

		// Toggle provider description.
		$(document).on('change', 'select[name=""ProviderSystemName""]', toggleProviderDescription);

		function toggleProviderDescription() {
			dialog.find('.export-provider-description').hide();

			var option = dialog.find('select[name=""ProviderSystemName""]').find(':selected');
			$('#ExportProviderDescription' + option.attr('data-id')).fadeIn('fast');
		}

		function providerSelectItemFormatting(item) {
			try {
				var option = $(item.element);

				// item.element is");
                WriteLiteral(@" undefined for selection formatting.
				if (option.length === 0) {
					option = $('select[name=""ProviderSystemName""]').find('option[value=""' + item.id + '""]');
				}

				var html = '<div class=""form-row flex-nowrap align-items-center"">';
				var imageUrl = option.data('imageurl');

				if (imageUrl) {
					html += '<div class=""col"" style=""max-width:48px; width:48px""><div class=""img-center-container""><img class=""img-fluid"" src=""' + imageUrl + '"" /></div></div>';
				}

				html += '<div class=""col"">';
				html += '<div class=""fs-xs font-weight-medium"" style=""line-height:1.2"">' + item.text + '</div>';
				html += '<div class=""text-muted fs-xs"">' + option.attr('value') + '</div>';
				html += '</div>';
				html += '</div>';

				return $(html);
			}
			catch (e) { }

			return item.text;
		}

		function profileSelectItemFormatting(item) {
			try {
				var option = $(item.element);

				// item.element is undefined for selection formatting.
				if (option.length === 0) {
					opt");
                WriteLiteral(@"ion = $('select[name=""CloneProfileId""]').find('option[value=""' + item.id + '""]');
				}

				var html = '<div class=""form-row flex-nowrap align-items-center h-100"">';
				var imageUrl = option.data('imageurl');

				if (imageUrl) {
					html += '<div class=""col"" style=""max-width:48px; width:48px""><div class=""img-center-container""><img class=""img-fluid"" src=""' + imageUrl + '"" /></div></div>';
				}

				html += '<div class=""col"">';
				html += '<div class=""fs-xs font-weight-medium"" style=""line-height:1.2"">' + item.text + '</div>';
				if (option.attr('data-systemname')) {
					html += '<div class=""text-muted fs-xs"">' + option.attr('data-systemname') + '</div>';
				}
				
				html += '</div>';
				html += '</div>';

				return $(html);
			}
			catch (e) { }

			return item.text;
		}

		// Start export task.
		$(document).on('click', '.btn-run-task', function (e) {
			e.preventDefault();
            $(this).doPostData({
                ask: ");
#nullable restore
#line 192 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\List.cshtml"
                Write(T("Admin.Common.AskToProceed").JsValue);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n\t\t\t\tdata: { \"__RequestVerificationToken\": $(\'input[name=\"__RequestVerificationToken\"]\').val() }\r\n\t\t\t});\r\n\t\t\treturn false;\r\n\t\t});\r\n\r\n");
                WriteLiteral("    });\r\n");
            }
            );
            __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.HtmlWidgetTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper);
            __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper.TargetZone = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ExportProfileModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
