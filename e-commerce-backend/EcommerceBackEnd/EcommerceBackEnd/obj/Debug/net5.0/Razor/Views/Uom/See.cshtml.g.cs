#pragma checksum "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc43d235e9cbe148029070d94952a5e3283ee6e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Uom_See), @"mvc.1.0.view", @"/Views/Uom/See.cshtml")]
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
#line 1 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using EcommerceBackEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using EcommerceBackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Ecommerce.Core.Model.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Ecommerce.Core.Model.Company;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Ecommerce.Core.Model.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using EcommerceBackEnd.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Ecommerce.Core.Model.RoleManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Ecommerce.Core.Model.Uom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Ecommerce.Core.Model.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Ecommerce.Core.Model.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Ecommerce.Core.Model.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using EcommerceBackEnd.Extension;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc43d235e9cbe148029070d94952a5e3283ee6e1", @"/Views/Uom/See.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b02511a79cf75c7dd0cdc87ae3c1f01d625ab51", @"/Views/_ViewImports.cshtml")]
    public class Views_Uom_See : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Uom>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"ms-panel\">\r\n    <div class=\"ms-panel-header\">\r\n        <h6>");
#nullable restore
#line 4 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml"
       Write(localizer.GetLocalizedHtmlString("View Uom"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n    <div class=\"ms-panel-body\">\r\n        <div class=\"col-xl-12 col-md-12\">\r\n            <div class=\"row col-modify\">\r\n                <div class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 10 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml"
               Write(localizer.GetLocalizedHtmlString("Uom ID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 13 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml"
               Write(Html.DisplayFor(model => model.UomID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 16 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml"
               Write(localizer.GetLocalizedHtmlString("Uom Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 19 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml"
               Write(Html.DisplayFor(model => model.UomName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 22 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml"
               Write(localizer.GetLocalizedHtmlString("Shop"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 25 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml"
               Write(Html.DisplayFor(model => model.CompanyID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 28 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml"
               Write(localizer.GetLocalizedHtmlString("Create By"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 31 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml"
               Write(Html.DisplayFor(model => model.CreateBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 34 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml"
               Write(localizer.GetLocalizedHtmlString("Create Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 37 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml"
               Write(Html.DisplayFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 40 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml"
               Write(localizer.GetLocalizedHtmlString("Update By"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 43 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml"
               Write(Html.DisplayFor(model => model.UpdateBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 46 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml"
               Write(localizer.GetLocalizedHtmlString("Update Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 49 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml"
               Write(Html.DisplayFor(model => model.UpdateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12 text-right\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc43d235e9cbe148029070d94952a5e3283ee6e112046", async() => {
#nullable restore
#line 55 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\See.cshtml"
                                                         Write(localizer.GetLocalizedHtmlString("Back to List"));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public EcommerceBackEnd.Resources.LocalizationService localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Uom> Html { get; private set; }
    }
}
#pragma warning restore 1591
