#pragma checksum "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Layouts\_Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90ff8197f16be7060116fbba5286987596c962cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Layouts__Checkout), @"mvc.1.0.view", @"/Views/Shared/Layouts/_Checkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ff8197f16be7060116fbba5286987596c962cc", @"/Views/Shared/Layouts/_Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad33dec0fd4788294056b15f90fedae59b16276", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Layouts__Checkout : Smartstore.Web.Razor.SmartRazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "order_progress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target-zone", "teaser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Smartstore.Web.TagHelpers.Shared.WidgetTagHelper __Smartstore_Web_TagHelpers_Shared_WidgetTagHelper;
        private global::Smartstore.Web.TagHelpers.Shared.ZoneTagHelper __Smartstore_Web_TagHelpers_Shared_ZoneTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Layouts\_Checkout.cshtml"
  
    Layout = "_Layout";
    Assets.BodyAttributes.AppendCssClass("checkout-page");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("widget", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90ff8197f16be7060116fbba5286987596c962cc6742", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("zone", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90ff8197f16be7060116fbba5286987596c962cc7006", async() => {
                }
                );
                __Smartstore_Web_TagHelpers_Shared_ZoneTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.ZoneTagHelper>();
                __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_ZoneTagHelper);
                __Smartstore_Web_TagHelpers_Shared_ZoneTagHelper.ZoneName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            __Smartstore_Web_TagHelpers_Shared_WidgetTagHelper = CreateTagHelper<global::Smartstore.Web.TagHelpers.Shared.WidgetTagHelper>();
            __tagHelperExecutionContext.Add(__Smartstore_Web_TagHelpers_Shared_WidgetTagHelper);
            __Smartstore_Web_TagHelpers_Shared_WidgetTagHelper.TargetZone = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Shared\Layouts\_Checkout.cshtml"
Write(RenderBody());

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
