#pragma checksum "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08d4164a824891b729e10ea3ebd408e16c9ea057"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_StockSubscriptions), @"mvc.1.0.view", @"/Views/Customer/StockSubscriptions.cshtml")]
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
#line 3 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\_ViewImports.cshtml"
using Smartstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\_ViewImports.cshtml"
using Smartstore.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\_ViewImports.cshtml"
using Smartstore.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\_ViewImports.cshtml"
using Smartstore.Imaging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\_ViewImports.cshtml"
using Smartstore.Core.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\_ViewImports.cshtml"
using Smartstore.Core.Widgets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\_ViewImports.cshtml"
using Smartstore.Core.Content.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\_ViewImports.cshtml"
using Smartstore.Core.Content.Menus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\_ViewImports.cshtml"
using Smartstore.Web.Models.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\_ViewImports.cshtml"
using Smartstore.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\_ViewImports.cshtml"
using Smartstore.Web.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\_ViewImports.cshtml"
using Smartstore.Web.Rendering.Choices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\_ViewImports.cshtml"
using Humanizer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml"
using Smartstore.Web.Models.Customers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08d4164a824891b729e10ea3ebd408e16c9ea057", @"/Views/Customer/StockSubscriptions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad33dec0fd4788294056b15f90fedae59b16276", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_StockSubscriptions : Smartstore.Web.Razor.SmartRazorPage<CustomerStockSubscriptionsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("sm-query-param", "page", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "paginator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StockSubscriptions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("sm-target-zone", "scripts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-origin", new global::Microsoft.AspNetCore.Html.HtmlString("stock-subscriptions"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Smartstore.Web.TagHelpers.Shared.LanguageTagHelper __Smartstore_Web_TagHelpers_Shared_LanguageTagHelper;
        private global::Smartstore.Web.TagHelpers.Shared.PaginationTagHelper __Smartstore_Web_TagHelpers_Shared_PaginationTagHelper;
        private global::Smartstore.Web.TagHelpers.Shared.HtmlWidgetTagHelper __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml"
  
    Assets.AppendTitleParts(T("PageTitle.BackInStockSubscriptions"));

    Layout = "_MyAccount";
    ViewBag.PageClassToken = "backinstock";
    ViewBag.PageTitle = T("Account.BackInStockSubscriptions").Value;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml"
 if (Model.Subscriptions.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        ");
#nullable restore
#line 16 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml"
   Write(T("Account.BackInStockSubscriptions.NoSubscriptions"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml"
    return;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"alert alert-success mb-0\">\r\n    ");
#nullable restore
#line 22 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml"
Write(T("Account.BackInStockSubscriptions.Description"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08d4164a824891b729e10ea3ebd408e16c9ea0579749", async() => {
                WriteLiteral(@"
    <div class=""subscription-list table-responsive"">
        <table class=""table"">
            <thead>
                <tr>
                    <th style=""width: 30px"">
                        <input type=""checkbox"" id=""selectall"" />
                    </th>
                    <th>
                        ");
#nullable restore
#line 34 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml"
                   Write(T("Account.BackInStockSubscriptions.ProductColumn"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml"
                 foreach (var item in Model.Subscriptions)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td style=\"width: 30px\">\r\n                            <input type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 1299, "\"", 1320, 2);
                WriteAttributeValue("", 1306, "biss", 1306, 4, true);
#nullable restore
#line 43 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml"
WriteAttributeValue("", 1310, item.Id, 1310, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rowcheckbox\" />\r\n                        </td>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08d4164a824891b729e10ea3ebd408e16c9ea05711690", async() => {
                    WriteLiteral("\r\n                            ");
#nullable restore
#line 46 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml"
                       Write(Html.RouteLink(item.ProductName, "Product", new { SeName = item.SeName }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        ");
                }
                );
                __Smartstore_Web_TagHelpers_Shared_LanguageTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.LanguageTagHelper>();
                __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_LanguageTagHelper);
#nullable restore
#line 45 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml"
__Smartstore_Web_TagHelpers_Shared_LanguageTagHelper.LanguageAttributesFor = item.ProductName;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("sm-language-attributes-for", __Smartstore_Web_TagHelpers_Shared_LanguageTagHelper.LanguageAttributesFor, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n");
#nullable restore
#line 53 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml"
         if (Model.TotalPages > 1)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pagination", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "08d4164a824891b729e10ea3ebd408e16c9ea05714172", async() => {
                }
                );
                __Smartstore_Web_TagHelpers_Shared_PaginationTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.PaginationTagHelper>();
                __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_PaginationTagHelper);
#nullable restore
#line 55 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml"
__Smartstore_Web_TagHelpers_Shared_PaginationTagHelper.ListItems = Model;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("sm-list-items", __Smartstore_Web_TagHelpers_Shared_PaginationTagHelper.ListItems, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Smartstore_Web_TagHelpers_Shared_PaginationTagHelper.QueryParamName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Smartstore_Web_TagHelpers_Shared_PaginationTagHelper.Id = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"buttons\">\r\n            <button type=\"submit\" class=\"btn btn-danger btn-lg delete-selected-biss-button\">\r\n                <span>");
#nullable restore
#line 60 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Customer\StockSubscriptions.cshtml"
                 Write(T("Account.BackInStockSubscriptions.DeleteSelected"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </button>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08d4164a824891b729e10ea3ebd408e16c9ea05717967", async() => {
                WriteLiteral(@"
    $(function () {
        $('#selectall').on('click', function (e) {
            $('.subscription-list .rowcheckbox').attr('checked', $(this).is(':checked')).change();
        });

        $(document).on('change', '.subscription-list .rowcheckbox', function (e) {
            var numChkBoxes = $('.subscription-list .rowcheckbox').length;
            var numChkBoxesChecked = $('.subscription-list .rowcheckbox:checked').length;
            $('#selectall').attr('checked', numChkBoxes == numChkBoxesChecked && numChkBoxes > 0);
        });
    });
");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerStockSubscriptionsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591