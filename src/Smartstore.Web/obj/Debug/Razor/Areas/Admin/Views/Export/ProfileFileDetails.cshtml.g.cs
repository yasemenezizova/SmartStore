#pragma checksum "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6258c59d2f79fb9b078fd2eac94676404ea94173"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Export_ProfileFileDetails), @"mvc.1.0.view", @"/Areas/Admin/Views/Export/ProfileFileDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6258c59d2f79fb9b078fd2eac94676404ea94173", @"/Areas/Admin/Views/Export/ProfileFileDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f966b0121d5b04d3349ea0c67b3def4c0c9c03", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9afb34f38267edf0db49142707e9d69ac2f0fcf6", @"/Areas/Admin/Views/Export/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Export_ProfileFileDetails : Smartstore.Web.Razor.SmartRazorPage<ExportFileDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadExportFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("sm-target-zone", "scripts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-origin", new global::Microsoft.AspNetCore.Html.HtmlString("ProfileFileDetails"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Smartstore.Web.TagHelpers.Shared.IfTagHelper __Smartstore_Web_TagHelpers_Shared_IfTagHelper;
        private global::Smartstore.Web.TagHelpers.Shared.AttributesTagHelper __Smartstore_Web_TagHelpers_Shared_AttributesTagHelper;
        private global::Smartstore.Web.TagHelpers.Shared.FileIconTagHelper __Smartstore_Web_TagHelpers_Shared_FileIconTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Smartstore.Web.TagHelpers.Shared.HtmlWidgetTagHelper __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
  
	var downloadString = T("Common.Download").Value;
	var allStoresString = T("Admin.Common.StoresAll").Value;
	var hasExportFiles = Model.ExportFiles.Any();
	var hasPublicFiles = Model.PublicFiles.Any();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6258c59d2f79fb9b078fd2eac94676404ea941739356", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
Write(T("Common.NoFilesAvailable"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Smartstore_Web_TagHelpers_Shared_IfTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.IfTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_IfTagHelper);
#nullable restore
#line 10 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
__Smartstore_Web_TagHelpers_Shared_IfTagHelper.Condition = !hasExportFiles && !hasPublicFiles;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("sm-if", __Smartstore_Web_TagHelpers_Shared_IfTagHelper.Condition, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6258c59d2f79fb9b078fd2eac94676404ea9417311131", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
     foreach (var grp in Model.ExportFiles.OrderBy(x => x.DisplayOrder).GroupBy(x => x.DisplayOrder))
	{
		foreach (var file in grp)
		{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<div class=\"py-1\">\r\n\t\t\t\t<span");
                BeginWriteAttribute("class", " class=\"", 599, "\"", 676, 2);
                WriteAttributeValue("", 607, "badge", 607, 5, true);
#nullable restore
#line 19 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
WriteAttributeValue(" ", 612, file.RelatedType.HasValue ? "badge-secondary" : "badge-info", 613, 63, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("file-icon", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6258c59d2f79fb9b078fd2eac94676404ea9417312323", async() => {
                }
                );
                __Smartstore_Web_TagHelpers_Shared_FileIconTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.FileIconTagHelper>();
                __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_FileIconTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
                                   WriteLiteral(file.File.Extension);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Smartstore_Web_TagHelpers_Shared_FileIconTagHelper.FileExtension = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("file-extension", __Smartstore_Web_TagHelpers_Shared_FileIconTagHelper.FileExtension, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 21 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
                Write(file.Label.HasValue() ? file.Label : file.File.Extension.EmptyNull().ToLower().TrimStart('.'));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</span>\r\n\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6258c59d2f79fb9b078fd2eac94676404ea9417314402", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 24 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
               Write(file.FileRootPath);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
                                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
                                                                                WriteLiteral(file.File.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
                                                                                                                         WriteLiteral(Model.IsForDeployment);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isDeployment"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-isDeployment", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isDeployment"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
AddHtmlAttributeValue("", 1006, downloadString, 1006, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("download", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t</div>\r\n");
#nullable restore
#line 27 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
		}
	}

#line default
#line hidden
#nullable disable
            }
            );
            __Smartstore_Web_TagHelpers_Shared_AttributesTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.AttributesTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_AttributesTagHelper);
            if (__Smartstore_Web_TagHelpers_Shared_AttributesTagHelper.ConditionalAttributes == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("attr-class", "Smartstore.Web.TagHelpers.Shared.AttributesTagHelper", "ConditionalAttributes"));
            }
#nullable restore
#line 13 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
__Smartstore_Web_TagHelpers_Shared_AttributesTagHelper.ConditionalAttributes["class"] = (hasExportFiles && hasPublicFiles, "mb-4");

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("attr-class", __Smartstore_Web_TagHelpers_Shared_AttributesTagHelper.ConditionalAttributes["class"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 31 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
     foreach (var grp in Model.PublicFiles.OrderBy(x => x.StoreId).GroupBy(x => x.StoreId))
	{
		var storeName = grp.First().StoreName;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div>\r\n\t\t\t<div>\r\n\t\t\t\t<span class=\"fs-h6\">");
#nullable restore
#line 36 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
                               Write(T("Admin.Common.PublicFiles"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t<span class=\"smaller\">(");
#nullable restore
#line 37 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
                                   Write(storeName.HasValue() ? storeName : allStoresString);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 39 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
             foreach (var file in grp)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"py-1 d-flex copy-to-clipboard\">\r\n\t\t\t\t\t<div>\r\n\t\t\t\t\t\t<span");
            BeginWriteAttribute("class", " class=\"", 1532, "\"", 1612, 2);
            WriteAttributeValue("", 1540, "badge", 1540, 5, true);
#nullable restore
#line 43 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
WriteAttributeValue(" ", 1545, file.RelatedType.HasValue ? "badge-secondary" : "badge-success", 1546, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("file-icon", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6258c59d2f79fb9b078fd2eac94676404ea9417323202", async() => {
            }
            );
            __Smartstore_Web_TagHelpers_Shared_FileIconTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.FileIconTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_FileIconTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
                                           WriteLiteral(file.File.Extension);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Smartstore_Web_TagHelpers_Shared_FileIconTagHelper.FileExtension = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("file-extension", __Smartstore_Web_TagHelpers_Shared_FileIconTagHelper.FileExtension, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 45 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
                        Write(file.Label.HasValue() ? file.Label : file.File.Extension.EmptyNull().ToLower().TrimStart('.'));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1804, "\"", 1824, 1);
#nullable restore
#line 47 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
WriteAttributeValue("", 1811, file.FileUrl, 1811, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1825, "\"", 1848, 1);
#nullable restore
#line 47 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
WriteAttributeValue("", 1833, downloadString, 1833, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" download>");
#nullable restore
#line 47 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
                                                                            Write(file.FileUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"ml-auto\">\r\n\t\t\t\t\t\t<button type=\"button\" class=\"btn btn-sm btn-secondary btn-copy-to-clipboard\">\r\n\t\t\t\t\t\t\t<i class=\"far fa-clipboard\"></i>\r\n\t\t\t\t\t\t</button>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 55 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n");
#nullable restore
#line 57 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6258c59d2f79fb9b078fd2eac94676404ea9417327054", async() => {
                WriteLiteral("\r\n    $(function() {\r\n\t\t// Button to copy URL to clipboard.\r\n\t\t$(\'.btn-copy-to-clipboard\').tooltip({\r\n\t\t\tplacement: \'bottom\',\r\n\t\t\ttrigger: \'hover\',\r\n\t\t\ttitle: ");
#nullable restore
#line 66 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
              Write(T("Common.CopyToClipboard").JsValue);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t}).click(function () {\r\n\t\t\tvar self = $(this);\r\n\t\t\tvar url = self.closest(\'.copy-to-clipboard\').find(\'a\').attr(\'href\');\r\n\r\n\t\t\tvar succeeded = window.copyTextToClipboard(url);\r\n\r\n\t\t\tself.attr(\'data-original-title\', succeeded ? ");
#nullable restore
#line 73 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
                                                    Write(T("Common.CopyToClipboard.Succeeded").JsValue);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : ");
#nullable restore
#line 73 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
                                                                                                     Write(T("Common.CopyToClipboard.Failed").JsValue);

#line default
#line hidden
#nullable disable
                WriteLiteral(")\r\n\t\t\t\t.tooltip(\'show\');\r\n\r\n\t\t\tsetTimeout(function () {\r\n\t\t\t\tself.attr(\'data-original-title\', ");
#nullable restore
#line 77 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Export\ProfileFileDetails.cshtml"
                                            Write(T("Common.CopyToClipboard").JsValue);

#line default
#line hidden
#nullable disable
                WriteLiteral(").tooltip(\'hide\');\r\n\t\t\t}, 2000);\r\n\t\t});\r\n\t});\r\n");
            }
            );
            __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.HtmlWidgetTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper);
            __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper.TargetZone = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExportFileDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
