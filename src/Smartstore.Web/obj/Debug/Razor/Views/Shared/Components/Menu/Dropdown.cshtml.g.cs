#pragma checksum "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2b4d50c915a3d3fd7e7f6f0ec76cfbcb9304b35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Dropdown), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Dropdown.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
using Smartstore.Web.Rendering.Menus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
using Smartstore.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
using Smartstore.Core.Content.Menus;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2b4d50c915a3d3fd7e7f6f0ec76cfbcb9304b35", @"/Views/Shared/Components/Menu/Dropdown.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad33dec0fd4788294056b15f90fedae59b16276", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Dropdown : Smartstore.Web.Razor.SmartRazorPage<MenuModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-haspopup", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-expanded", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("nofollow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Smartstore.Web.TagHelpers.Shared.AttributesTagHelper __Smartstore_Web_TagHelpers_Shared_AttributesTagHelper;
        private global::Smartstore.Web.TagHelpers.Shared.LanguageTagHelper __Smartstore_Web_TagHelpers_Shared_LanguageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
  
    var root = Model.Root;
    if (root == null)
    {
        return;
    }

    // Support both cases: the dropdown-link is Model.Root or the first item if it has children.
    if (root.HasChildren && root.Children.Count == 1 && root.FirstChild.HasChildren)
    {
        root = root.FirstChild;
    }

    var item = root.Value;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"cms-menu cms-menu-dropdown\" data-menu-name=\"");
#nullable restore
#line 23 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
                                                    Write(Model.Name?.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n    <div class=\"dropdown\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2b4d50c915a3d3fd7e7f6f0ec76cfbcb9304b359112", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2b4d50c915a3d3fd7e7f6f0ec76cfbcb9304b359379", async() => {
#nullable restore
#line 26 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
                                               Write(root.GetItemText(T));

#line default
#line hidden
#nullable disable
                }
                );
                __Smartstore_Web_TagHelpers_Shared_LanguageTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.LanguageTagHelper>();
                __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_LanguageTagHelper);
#nullable restore
#line 26 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
__Smartstore_Web_TagHelpers_Shared_LanguageTagHelper.LanguageAttributesFor = item;

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
                WriteLiteral("\r\n            <i class=\"fal fa-angle-down menubar-caret\"></i>\r\n        ");
            }
            );
            __Smartstore_Web_TagHelpers_Shared_AttributesTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.AttributesTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_AttributesTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 25 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
__Smartstore_Web_TagHelpers_Shared_AttributesTagHelper.Attributes = item.GetCombinedAttributes().PrependCssClass("menubar-link");

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("attrs", __Smartstore_Web_TagHelpers_Shared_AttributesTagHelper.Attributes, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
           await CreateDropdown(root.Children); 

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 33 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
  
    async Task CreateDropdown(IEnumerable<TreeNode<MenuItem>> nodes)
    {
        if (!nodes.Any())
        {
            return;
        }

        var isFirst = true;
        var rtl = WorkContext.WorkingLanguage.Rtl;
        var hasIcons = nodes.Any(x => x.Value.Icon.HasValue());
        var hasImages = nodes.Any(x => x.Value.ImageUrl.HasValue());


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 1381, "\"", 1456, 2);
            WriteAttributeValue("", 1389, "dropdown-menu", 1389, 13, true);
#nullable restore
#line 46 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
WriteAttributeValue(" ", 1402, rtl ? "dropdown-menu-right" : "dropdown-menu-left", 1403, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 47 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
             foreach (var node in nodes)
            {
                var item = node.Value;
                if (!item.Visible)
                {
                    continue;
                }

                var itemText = node.GetItemText(T);
                var itemUrl = item.GenerateUrl(this.ViewContext);

                if (item.IsGroupHeader)
                {
                    if (!isFirst)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"dropdown-divider\"></div>\r\n");
#nullable restore
#line 63 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
                    }
                    if (itemText.HasValue() && item.Text != "[SKIP]")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"dropdown-header menu-header h6\">");
#nullable restore
#line 66 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
                                                               Write(itemText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 67 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
                    }
                    isFirst = false;
                    continue;
                }

                var attrs = item.GetCombinedAttributes().PrependCssClass("dropdown-item menu-link");


#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2b4d50c915a3d3fd7e7f6f0ec76cfbcb9304b3516077", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 75 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
                     if (hasIcons)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <i");
                BeginWriteAttribute("class", " class=\"", 2521, "\"", 2600, 2);
                WriteAttributeValue("", 2529, "fa-fw", 2529, 5, true);
#nullable restore
#line 77 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
WriteAttributeValue("", 2534, item.Icon.HasValue() ? item.Icon.EnsureStartsWith(" ") : " fas", 2534, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>\r\n");
#nullable restore
#line 78 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
                    }
                    else if (hasImages && item.ImageUrl.HasValue())
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <img class=\"sm-icon\"");
                BeginWriteAttribute("src", " src=\"", 2767, "\"", 2800, 1);
#nullable restore
#line 81 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
WriteAttributeValue("", 2773, Url.Content(item.ImageUrl), 2773, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2801, "\"", 2807, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 82 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
                    }
                    else if (hasImages)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <i class=\"fa-fw fas\"></i>\r\n");
#nullable restore
#line 86 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2b4d50c915a3d3fd7e7f6f0ec76cfbcb9304b3518670", async() => {
#nullable restore
#line 87 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
                                                       Write(itemText);

#line default
#line hidden
#nullable disable
                }
                );
                __Smartstore_Web_TagHelpers_Shared_LanguageTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.LanguageTagHelper>();
                __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_LanguageTagHelper);
#nullable restore
#line 87 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
__Smartstore_Web_TagHelpers_Shared_LanguageTagHelper.LanguageAttributesFor = item;

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
                WriteLiteral("\r\n                ");
            }
            );
            __Smartstore_Web_TagHelpers_Shared_AttributesTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.AttributesTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_AttributesTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 74 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
AddHtmlAttributeValue("", 2410, itemUrl, 2410, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#nullable restore
#line 74 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
__Smartstore_Web_TagHelpers_Shared_AttributesTagHelper.Attributes = attrs;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("attrs", __Smartstore_Web_TagHelpers_Shared_AttributesTagHelper.Attributes, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 89 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"

                isFirst = false;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 93 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\Dropdown.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
