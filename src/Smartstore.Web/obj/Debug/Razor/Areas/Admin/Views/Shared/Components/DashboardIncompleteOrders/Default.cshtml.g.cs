#pragma checksum "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e4fd481c5b3cfe4f7e26155c7a16ae1611ef06c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_DashboardIncompleteOrders_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/DashboardIncompleteOrders/Default.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
using Smartstore.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e4fd481c5b3cfe4f7e26155c7a16ae1611ef06c", @"/Areas/Admin/Views/Shared/Components/DashboardIncompleteOrders/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f966b0121d5b04d3349ea0c67b3def4c0c9c03", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_DashboardIncompleteOrders_Default : Smartstore.Web.Razor.SmartRazorPage<List<DashboardIncompleteOrdersModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bundle/js/chart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("sm-target-zone", "scripts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("sm-key", "charting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/admin.dashboard.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("sm-key", "dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-origin", new global::Microsoft.AspNetCore.Html.HtmlString("DashboardIncompleteOrders"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Smartstore.Web.TagHelpers.Shared.ScriptAssetTagHelper __Smartstore_Web_TagHelpers_Shared_ScriptAssetTagHelper;
        private global::Smartstore.Web.TagHelpers.Shared.HtmlWidgetTagHelper __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
  
    var jsonData = JsonConvert.SerializeObject(Model);
    var labels = new string[]
    {
        T("Admin.Report.Today"),
        T("Admin.Report.LastWeek"),
        T("Admin.Report.LastMonth"),
        T("Admin.Report.ThisYear")
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e4fd481c5b3cfe4f7e26155c7a16ae1611ef06c9912", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Smartstore_Web_TagHelpers_Shared_ScriptAssetTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.ScriptAssetTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_ScriptAssetTagHelper);
            __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.HtmlWidgetTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper.TargetZone = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper.Key = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e4fd481c5b3cfe4f7e26155c7a16ae1611ef06c11867", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Smartstore_Web_TagHelpers_Shared_ScriptAssetTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.ScriptAssetTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_ScriptAssetTagHelper);
            __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.HtmlWidgetTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper.TargetZone = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper.Key = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"report chart-colors\" id=\"incomplete-orders-report\">\r\n    <div class=\"report-title-row\">\r\n        <div class=\"report-title\">");
#nullable restore
#line 22 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
                             Write(T("Admin.SalesReport.Incomplete"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"d-flex justify-content-around px-4 pb-4 flex-wrap incomplete-orders-row\">\r\n");
#nullable restore
#line 25 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
         for (int i = 0; i < Model.Count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"incomplete-orders-container\">\r\n                <div class=\"incomplete-orders-title\">");
#nullable restore
#line 28 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
                                                Write(labels[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"incomplete-orders-chart-container\">\r\n                    <div class=\"incomplete-orders-chart-text\">\r\n                        <div class=\"incomplete-orders-quantity\">");
#nullable restore
#line 31 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
                                                           Write(Model[i].QuantityTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"incomplete-orders-amount\"");
            BeginWriteAttribute("title", " title=\"", 1308, "\"", 1404, 2);
#nullable restore
#line 32 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
WriteAttributeValue("", 1316, Model[i].AmountTotal, 1316, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
WriteAttributeValue(" ", 1337, T("Enums.SmartStore.Core.Domain.Tax.TaxDisplayType.IncludingTax"), 1338, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 33 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
                       Write(Model[i].AmountTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"canvas-container w-100 h-100\">\r\n                        <canvas");
            BeginWriteAttribute("id", " id=\"", 1614, "\"", 1645, 2);
            WriteAttributeValue("", 1619, "incomplete-orders-chart-", 1619, 24, true);
#nullable restore
#line 37 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
WriteAttributeValue("", 1643, i, 1643, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </canvas>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 42 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e4fd481c5b3cfe4f7e26155c7a16ae1611ef06c17875", async() => {
                WriteLiteral("\r\n    $(function () {\r\n        Smartstore.Admin.Charts.Create.IncompleteOrdersCharts(\r\n            ");
#nullable restore
#line 49 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
       Write(Html.Raw(jsonData));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n            \'");
#nullable restore
#line 50 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
        Write(T("Admin.SalesReport.NoIncompleteOrders"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n            \'");
#nullable restore
#line 51 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
        Write(T("Admin.SalesReport.Incomplete.TotalNotShippedOrders"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n            \'");
#nullable restore
#line 52 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
        Write(T("Admin.SalesReport.Incomplete.TotalUnpaidOrders"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n            \'");
#nullable restore
#line 53 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
        Write(T("Admin.SalesReport.NewOrders"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n            \'");
#nullable restore
#line 54 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
        Write(T("Admin.Orders"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n            \'");
#nullable restore
#line 55 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Areas\Admin\Views\Shared\Components\DashboardIncompleteOrders\Default.cshtml"
        Write(T("Admin.SalesReport.Sales"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n        );\r\n    });\r\n");
            }
            );
            __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.HtmlWidgetTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper);
            __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper.TargetZone = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DashboardIncompleteOrdersModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
