#pragma checksum "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceFrontEnd\Views\Home\NotFoundPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0febfa8492fe0919c095c9d312e704d6f82a2cf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NotFoundPage), @"mvc.1.0.view", @"/Views/Home/NotFoundPage.cshtml")]
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
#line 1 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceFrontEnd\Views\_ViewImports.cshtml"
using EcommerceFrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceFrontEnd\Views\_ViewImports.cshtml"
using EcommerceFrontEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceFrontEnd\Views\_ViewImports.cshtml"
using EcommerceFrontEnd.Models.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceFrontEnd\Views\_ViewImports.cshtml"
using EcommerceFrontEnd.Models.OtherProductModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceFrontEnd\Views\_ViewImports.cshtml"
using EcommerceFrontEnd.Models.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceFrontEnd\Views\_ViewImports.cshtml"
using EcommerceFrontEnd.Models.Shop;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0febfa8492fe0919c095c9d312e704d6f82a2cf1", @"/Views/Home/NotFoundPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4feab4fe417eafeb7b7f3ff9041d2438ab60cca5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NotFoundPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                <li class=""active"">404 Error</li>
            </ul>
        </div>
    </div>
</div>
<!-- Li's Breadcrumb Area End Here -->
<!-- Error 404 Area Start -->
<div class=""error404-area pt-30 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""error-wrapper text-center ptb-50 pt-xs-20"">
                    <div class=""error-text"">
                        <h1>404</h1>
                        <h2>Opps! PAGE NOT BE FOUND</h2>
                        <p>Sorry but the page you are looking for does not exist, have been removed, <br> name changed or is temporarity unavailable.</p>
                    </div>
                    <div class=""search-error"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0febfa8492fe0919c095c9d312e704d6f82a2cf15953", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"Search\">\r\n                            <button><i class=\"zmdi zmdi-search\"></i></button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""error-button"">
                        <a href=""index.html"">Back to home page</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Error 404 Area End -->");
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
