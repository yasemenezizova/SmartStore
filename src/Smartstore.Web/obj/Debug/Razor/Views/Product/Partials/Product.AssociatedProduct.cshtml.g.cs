#pragma checksum "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Product\Partials\Product.AssociatedProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3de42c51978f8e1bb50fd87f62f14805e1b5f42e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Partials_Product_AssociatedProduct), @"mvc.1.0.view", @"/Views/Product/Partials/Product.AssociatedProduct.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Product\Partials\Product.AssociatedProduct.cshtml"
using Smartstore.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de42c51978f8e1bb50fd87f62f14805e1b5f42e", @"/Views/Product/Partials/Product.AssociatedProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad33dec0fd4788294056b15f90fedae59b16276", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Partials_Product_AssociatedProduct : Smartstore.Web.Razor.SmartRazorPage<ProductDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Product.Info", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Product.Attrs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Product.Offer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Product\Partials\Product.AssociatedProduct.cshtml"
  
    string updateUrl = Url.Action("UpdateProductDetails", "Product", new
    {
        productId = Model.Id,
        bundleItemId = Model.BundleItem.Id,
        itemType = "associateditem"
    });

    var gallery = Model.MediaGalleryModel;
    var img = gallery.Files?.FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n\r\n<article class=\"pd-variant row update-container\" data-url=\"");
#nullable restore
#line 19 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Product\Partials\Product.AssociatedProduct.cshtml"
                                                      Write(updateUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" itemscope itemtype=\"http://schema.org/Product\">\r\n    <div class=\"col-4 col-sm-6 col-lg-3\">\r\n        <div class=\"pd-variant-picture img-center-container\">\r\n");
#nullable restore
#line 22 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Product\Partials\Product.AssociatedProduct.cshtml"
             if (img != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img class=\"pd-dyn-thumb\"");
            BeginWriteAttribute("src", " src=\"", 699, "\"", 735, 1);
#nullable restore
#line 24 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Product\Partials\Product.AssociatedProduct.cshtml"
WriteAttributeValue("", 705, img.GetUrl(gallery.ImageSize), 705, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 736, "\"", 753, 1);
#nullable restore
#line 24 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Product\Partials\Product.AssociatedProduct.cshtml"
WriteAttributeValue("", 742, img?.Alt, 742, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 754, "\"", 784, 1);
#nullable restore
#line 24 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Product\Partials\Product.AssociatedProduct.cshtml"
WriteAttributeValue("", 762, img?.TitleAttribute, 762, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 25 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Product\Partials\Product.AssociatedProduct.cshtml"
            }
            else if (gallery.FallbackUrl.HasValue())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img class=\"pd-dyn-thumb\"");
            BeginWriteAttribute("src", " src=\"", 915, "\"", 941, 1);
#nullable restore
#line 28 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Product\Partials\Product.AssociatedProduct.cshtml"
WriteAttributeValue("", 921, gallery.FallbackUrl, 921, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 942, "\"", 967, 1);
#nullable restore
#line 28 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Product\Partials\Product.AssociatedProduct.cshtml"
WriteAttributeValue("", 948, gallery.DefaultAlt, 948, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 29 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Product\Partials\Product.AssociatedProduct.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-8 col-sm-6 col-lg-4\">\r\n        <!-- Title/Brand/ReviewSummary -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3de42c51978f8e1bb50fd87f62f14805e1b5f42e11007", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 34 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Product\Partials\Product.AssociatedProduct.cshtml"
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
            WriteLiteral("\r\n\r\n        <!-- Product attributes (SKU, EAN, Weight etc.) -->\r\n        <div class=\"pd-attrs-container\" data-partial=\"Attrs\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3de42c51978f8e1bb50fd87f62f14805e1b5f42e12751", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 38 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Product\Partials\Product.AssociatedProduct.cshtml"
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col col-lg-5 d-flex\">\r\n        <!-- Offer box -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3de42c51978f8e1bb50fd87f62f14805e1b5f42e14460", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 43 "C:\Users\Dell\Desktop\Smartstore\src\Smartstore.Web\Views\Product\Partials\Product.AssociatedProduct.cshtml"
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
            WriteLiteral("\r\n    </div>\r\n</article>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
