#pragma checksum "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\LanguageSelector\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb3961cc85f56407ff51edba65ded6a2dc40ec19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LanguageSelector_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LanguageSelector/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb3961cc85f56407ff51edba65ded6a2dc40ec19", @"/Views/Shared/Components/LanguageSelector/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad33dec0fd4788294056b15f90fedae59b16276", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LanguageSelector_Default : Smartstore.Web.Razor.SmartRazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("sm-target-zone", "scripts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-origin", new global::Microsoft.AspNetCore.Html.HtmlString("language-selector"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Smartstore.Web.TagHelpers.Shared.HtmlWidgetTagHelper __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\LanguageSelector\Default.cshtml"
  
    var languages = ViewBag.AvailableLanguages as IList<LanguageModel>;
    
    if (languages.Count <= 1)
    {
        return;
    }

    var activeLang = languages.Where(x => x.Id == WorkContext.WorkingLanguage.Id).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"dropdown language-selector\">\r\n    <a class=\"menubar-link\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\" href=\"#\">\r\n        <span>");
#nullable restore
#line 14 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\LanguageSelector\Default.cshtml"
         Write(activeLang.CultureCode.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <i class=\"fa fa-angle-down\"></i>\r\n    </a>\r\n    <div class=\"dropdown-menu\" aria-labelledby=\"dLabel\">\r\n");
#nullable restore
#line 18 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\LanguageSelector\Default.cshtml"
         foreach (var lang in languages)
        {
            var returnUrl = ViewBag.ReturnUrls[lang.CultureCode] as string;
            var href = Display.ModifyQueryString(Url.RouteUrl("ChangeLanguage", new { langid = lang.Id }), "returnUrl=" + returnUrl.UrlEncode(), null);


#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 865, "\"", 877, 1);
#nullable restore
#line 23 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\LanguageSelector\Default.cshtml"
WriteAttributeValue("", 872, href, 872, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 878, "\"", 902, 1);
#nullable restore
#line 23 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\LanguageSelector\Default.cshtml"
WriteAttributeValue("", 886, lang.NativeName, 886, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" rel=\"nofollow\"");
            BeginWriteAttribute("class", " class=\"", 918, "\"", 985, 2);
            WriteAttributeValue("", 926, "dropdown-item", 926, 13, true);
#nullable restore
#line 23 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\LanguageSelector\Default.cshtml"
WriteAttributeValue("", 939, lang.Id == activeLang.Id ? " disabled" : "", 939, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n               data-selected=\"");
#nullable restore
#line 24 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\LanguageSelector\Default.cshtml"
                          Write(lang.Equals(activeLang) ? "true" : "false");

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-abbreviation=\"");
#nullable restore
#line 24 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\LanguageSelector\Default.cshtml"
                                                                                           Write(lang.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\r\n");
#nullable restore
#line 26 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\LanguageSelector\Default.cshtml"
                 if (ViewBag.UseImages)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"mr-1 align-text-bottom\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1247, "\"", 1309, 1);
#nullable restore
#line 29 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\LanguageSelector\Default.cshtml"
WriteAttributeValue("", 1253, Url.Content("~/images/flags/" + lang.FlagImageFileName), 1253, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </span>\r\n");
#nullable restore
#line 31 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\LanguageSelector\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span>");
#nullable restore
#line 33 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\LanguageSelector\Default.cshtml"
                 Write(lang.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                <span class=\"abbreviation lrm\">(");
#nullable restore
#line 35 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\LanguageSelector\Default.cshtml"
                                           Write(lang.CultureCode.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n            </a>\r\n");
#nullable restore
#line 37 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\LanguageSelector\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb3961cc85f56407ff51edba65ded6a2dc40ec1912028", async() => {
                WriteLiteral("\r\n    $(function () {\r\n        $(\".language-selector .dropdown-item.disabled\").on(\'click\', function (e) {\r\n            e.preventDefault();\r\n        });\r\n    });\r\n");
            }
            );
            __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.HtmlWidgetTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper);
            __Smartstore_Web_TagHelpers_Shared_HtmlWidgetTagHelper.TargetZone = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591