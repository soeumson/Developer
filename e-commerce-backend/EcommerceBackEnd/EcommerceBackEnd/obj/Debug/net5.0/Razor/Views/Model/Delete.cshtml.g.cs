#pragma checksum "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c8b0c3339facb0a8e4963bc5eda15f7e3e68ba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Model_Delete), @"mvc.1.0.view", @"/Views/Model/Delete.cshtml")]
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
#line 1 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using EcommerceBackEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using EcommerceBackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Ecommerce.Core.Model.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Ecommerce.Core.Model.Company;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Ecommerce.Core.Model.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using EcommerceBackEnd.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Ecommerce.Core.Model.RoleManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Ecommerce.Core.Model.Uom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Ecommerce.Core.Model.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Ecommerce.Core.Model.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Ecommerce.Core.Model.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\_ViewImports.cshtml"
using EcommerceBackEnd.Extension;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c8b0c3339facb0a8e4963bc5eda15f7e3e68ba7", @"/Views/Model/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b02511a79cf75c7dd0cdc87ae3c1f01d625ab51", @"/Views/_ViewImports.cshtml")]
    public class Views_Model_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModelProduct>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.Error))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        <strong>Oh worrying!</strong> ");
#nullable restore
#line 5 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                                 Write(localizer.GetLocalizedHtmlString(ViewBag.Error));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 7 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"ms-panel\">\r\n    <div class=\"ms-panel-header\">\r\n        <h6>");
#nullable restore
#line 10 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
       Write(localizer.GetLocalizedHtmlString("Are you sure you want to delete this ?"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n    <div class=\"ms-panel-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c8b0c3339facb0a8e4963bc5eda15f7e3e68ba79387", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5c8b0c3339facb0a8e4963bc5eda15f7e3e68ba79657", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 14 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ModelID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"col-xl-12 col-md-12\">\r\n                <div class=\"row col-modify\">\r\n                    <div class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 18 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                   Write(localizer.GetLocalizedHtmlString("Model ID"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 21 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.ModelID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 24 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                   Write(localizer.GetLocalizedHtmlString("Model Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 27 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.ModelName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 30 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                   Write(localizer.GetLocalizedHtmlString("Shop"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 33 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.CompanyID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 36 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                   Write(localizer.GetLocalizedHtmlString("Create By"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 39 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.CreateBy));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 42 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                   Write(localizer.GetLocalizedHtmlString("Create Date"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 45 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 48 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                   Write(localizer.GetLocalizedHtmlString("Update By"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 51 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.UpdateBy));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 54 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                   Write(localizer.GetLocalizedHtmlString("Update Date"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 57 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.UpdateDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12 text-right\">\r\n                    <button class=\"btn btn-primary\" type=\"submit\">");
#nullable restore
#line 63 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                                                             Write(localizer.GetLocalizedHtmlString("Delete"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c8b0c3339facb0a8e4963bc5eda15f7e3e68ba717788", async() => {
#nullable restore
#line 64 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Model\Delete.cshtml"
                                                             Write(localizer.GetLocalizedHtmlString("Back to List"));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModelProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591
