#pragma checksum "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01dce092813a2442972dd693d8f5e3aaffd8df0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_ListGroup), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/ListGroup.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
using Smartstore.Web.Rendering.Menus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
using Smartstore.Core.Content.Menus;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01dce092813a2442972dd693d8f5e3aaffd8df0d", @"/Views/Shared/Components/Menu/ListGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad33dec0fd4788294056b15f90fedae59b16276", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_ListGroup : Smartstore.Web.Razor.SmartRazorPage<MenuModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-header"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-bottom: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Smartstore.Web.TagHelpers.Shared.LanguageTagHelper __Smartstore_Web_TagHelpers_Shared_LanguageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
  
    var root = Model.Root;
    if (root == null)
    {
        return;
    }

    var hasIcons = root.Children.Any(x => x.Value.Icon.HasValue());
    var hasImages = root.Children.Any(x => x.Value.ImageUrl.HasValue());
    var headerText = root.GetItemText(T);
    var rtl = WorkContext.WorkingLanguage.Rtl;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"cms-menu cms-menu-listgroup\" data-menu-name=\"");
#nullable restore
#line 19 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
                                                     Write(Model.Name?.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n    <div class=\"card\">\r\n        \r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("h5", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01dce092813a2442972dd693d8f5e3aaffd8df0d7980", async() => {
                WriteLiteral("\r\n            ");
#nullable restore
#line 23 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
       Write(headerText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
            }
            );
            __Smartstore_Web_TagHelpers_Shared_IfTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.IfTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_IfTagHelper);
#nullable restore
#line 22 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
__Smartstore_Web_TagHelpers_Shared_IfTagHelper.Condition = headerText.HasValue();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("sm-if", __Smartstore_Web_TagHelpers_Shared_IfTagHelper.Condition, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        \r\n        <div class=\"list-group list-group-flush has-icons\">\r\n");
#nullable restore
#line 27 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
             foreach (var node in Model.Root.Children.Where(x => x.Value.Visible))
            {
                var item = node.Value;
                var itemState = node.GetNodePathState(Model.Path);
                var itemText = node.GetItemText(T);
                var itemUrl = item.GenerateUrl(this.ViewContext);

                var attrs = item.GetCombinedAttributes();
                attrs.PrependCssClass("list-group-item list-group-item-action menu-link" + ((itemState & NodePathState.Selected) == NodePathState.Selected ? " active" : ""));


#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01dce092813a2442972dd693d8f5e3aaffd8df0d10688", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
                     if (hasIcons)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <i");
                BeginWriteAttribute("class", " class=\"", 1451, "\"", 1555, 4);
                WriteAttributeValue("", 1459, "fal", 1459, 3, true);
                WriteAttributeValue(" ", 1462, "fa-fw", 1463, 6, true);
#nullable restore
#line 40 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
WriteAttributeValue("", 1468, item.Icon.HasValue() ? item.Icon.EnsureStartsWith(" ") : " fas", 1468, 66, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1534, "list-group-item-icon", 1535, 21, true);
                EndWriteAttribute();
                WriteLiteral("></i>\r\n");
#nullable restore
#line 41 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
                    }
                    else if (hasImages && item.ImageUrl.HasValue())
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <img class=\"sm-icon\"");
                BeginWriteAttribute("src", " src=\"", 1722, "\"", 1755, 1);
#nullable restore
#line 44 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
WriteAttributeValue("", 1728, Url.Content(item.ImageUrl), 1728, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1756, "\"", 1762, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 45 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
                    }
                    else if (hasImages)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <i class=\"fa-fw fas\"></i>\r\n");
#nullable restore
#line 49 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01dce092813a2442972dd693d8f5e3aaffd8df0d13451", async() => {
#nullable restore
#line 51 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
                                                       Write(itemText);

#line default
#line hidden
#nullable disable
                }
                );
                __Smartstore_Web_TagHelpers_Shared_LanguageTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.LanguageTagHelper>();
                __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_LanguageTagHelper);
#nullable restore
#line 51 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
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
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 53 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
                     if (item.BadgeText.HasValue())
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01dce092813a2442972dd693d8f5e3aaffd8df0d15507", async() => {
                    WriteLiteral("\r\n                            ");
#nullable restore
#line 56 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
                       Write(Html.Raw(item.BadgeText));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        ");
                }
                );
                __Smartstore_Web_TagHelpers_Shared_AttributesTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.AttributesTagHelper>();
                __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_AttributesTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2124, "badge", 2124, 5, true);
                AddHtmlAttributeValue(" ", 2129, "badge-pill", 2130, 11, true);
                AddHtmlAttributeValue(" ", 2140, "badge-", 2141, 7, true);
#nullable restore
#line 55 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
AddHtmlAttributeValue("", 2147, item.BadgeStyle.ToString().ToLower(), 2147, 37, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue(" ", 2184, "ml-auto", 2185, 8, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#nullable restore
#line 55 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
__Smartstore_Web_TagHelpers_Shared_AttributesTagHelper.Attributes = item.BadgeHtmlAttributes;

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
#line 58 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Smartstore_Web_TagHelpers_Shared_AttributesTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.AttributesTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_AttributesTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
AddHtmlAttributeValue("", 1340, itemUrl, 1340, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#nullable restore
#line 37 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
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
#line 60 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Components\Menu\ListGroup.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
