#pragma checksum "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceFrontEnd\Views\Account\Wishlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2846af705309dde9a421d6e3f00dc58070832189"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Wishlist), @"mvc.1.0.view", @"/Views/Account/Wishlist.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceFrontEnd\Views\_ViewImports.cshtml"
using EcommerceFrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceFrontEnd\Views\_ViewImports.cshtml"
using EcommerceFrontEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceFrontEnd\Views\_ViewImports.cshtml"
using EcommerceFrontEnd.Models.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceFrontEnd\Views\_ViewImports.cshtml"
using EcommerceFrontEnd.Models.OtherProductModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceFrontEnd\Views\_ViewImports.cshtml"
using EcommerceFrontEnd.Models.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceFrontEnd\Views\_ViewImports.cshtml"
using EcommerceFrontEnd.Models.Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceFrontEnd\Views\_ViewImports.cshtml"
using EcommerceFrontEnd.Extentions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2846af705309dde9a421d6e3f00dc58070832189", @"/Views/Account/Wishlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1878e5c3d8ef17b15a7bc777d413fcb64bcef86", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Wishlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Begin Li's Breadcrumb Area -->
<div class=""breadcrumb-area"">
    <div class=""container"">
        <div class=""breadcrumb-content"">
            <ul>
                <li><a href=""index.html"">Home</a></li>
                <li class=""active"">Wishlist</li>
            </ul>
        </div>
    </div>
</div>
<!-- Li's Breadcrumb Area End Here -->
<!--Wishlist Area Strat-->
<div class=""wishlist-area pt-60 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2846af705309dde9a421d6e3f00dc580708321895435", async() => {
                WriteLiteral(@"
                    <div class=""table-content table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th class=""li-product-remove"">remove</th>
                                    <th class=""li-product-thumbnail"">images</th>
                                    <th class=""cart-product-name"">Product</th>
                                    <th class=""li-product-price"">Unit Price</th>
                                    <th class=""li-product-stock-status"">Stock Status</th>
                                    <th class=""li-product-add-cart"">add to cart</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td class=""li-product-remove""><a href=""#""><i class=""fa fa-times""></i></a></td>
                                    <td class=""li-product-thumbnai");
                WriteLiteral("l\"><a href=\"#\"><img src=\"images/wishlist-thumb/1.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 1627, "\"", 1633, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a></td>
                                    <td class=""li-product-name""><a href=""#"">Giro Civilia</a></td>
                                    <td class=""li-product-price""><span class=""amount"">$23.39</span></td>
                                    <td class=""li-product-stock-status""><span class=""in-stock"">in stock</span></td>
                                    <td class=""li-product-add-cart""><a href=""#"">add to cart</a></td>
                                </tr>
                                <tr>
                                    <td class=""li-product-remove""><a href=""#""><i class=""fa fa-times""></i></a></td>
                                    <td class=""li-product-thumbnail""><a href=""#""><img src=""images/wishlist-thumb/2.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 2382, "\"", 2388, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a></td>
                                    <td class=""li-product-name""><a href=""#"">Pro Bike Shoes</a></td>
                                    <td class=""li-product-price""><span class=""amount"">$30.50</span></td>
                                    <td class=""li-product-stock-status""><span class=""in-stock"">in stock</span></td>
                                    <td class=""li-product-add-cart""><a href=""#"">add to cart</a></td>
                                </tr>
                                <tr>
                                    <td class=""li-product-remove""><a href=""#""><i class=""fa fa-times""></i></a></td>
                                    <td class=""li-product-thumbnail""><a href=""#""><img src=""images/wishlist-thumb/3.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 3139, "\"", 3145, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a></td>
                                    <td class=""li-product-name""><a href=""#"">Nero Urban Shoes</a></td>
                                    <td class=""li-product-price""><span class=""amount"">$40.19</span></td>
                                    <td class=""li-product-stock-status""><span class=""out-stock"">out stock</span></td>
                                    <td class=""li-product-add-cart""><a href=""#"">add to cart</a></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--Wishlist Area End-->");
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
