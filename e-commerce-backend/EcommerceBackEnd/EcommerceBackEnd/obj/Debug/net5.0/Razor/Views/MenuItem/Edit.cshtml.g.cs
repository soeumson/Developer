#pragma checksum "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3773d020e6adfa254694a3bdc60cf4985b90422c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MenuItem_Edit), @"mvc.1.0.view", @"/Views/MenuItem/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3773d020e6adfa254694a3bdc60cf4985b90422c", @"/Views/MenuItem/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b02511a79cf75c7dd0cdc87ae3c1f01d625ab51", @"/Views/_ViewImports.cshtml")]
    public class Views_MenuItem_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuClass.MenuItem>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.Error))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        <strong>Oh worrying!</strong> ");
#nullable restore
#line 5 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
                                 Write(localizer.GetLocalizedHtmlString(ViewBag.Error));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 7 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"ms-panel\">\r\n    <div class=\"ms-panel-header\">\r\n        <h6>");
#nullable restore
#line 10 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
       Write(localizer.GetLocalizedHtmlString("Update Menu Item"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n    <div class=\"ms-panel-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3773d020e6adfa254694a3bdc60cf4985b90422c10078", async() => {
                WriteLiteral("\r\n            <div class=\"col-xl-12 col-md-12\">\r\n                <div class=\"form-row\">\r\n                    <div class=\"col-md-12\">\r\n                        <label>");
#nullable restore
#line 17 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
                          Write(localizer.GetLocalizedHtmlString("Menu Item ID"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <span class=\"required-star\">*</span>\r\n                        <div class=\"input-group\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3773d020e6adfa254694a3bdc60cf4985b90422c10961", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 19 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
AddHtmlAttributeValue("", 920, localizer.GetLocalizedHtmlString("ID"), 920, 39, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <div class=\"valid-feedback\">\r\n                                ");
#nullable restore
#line 21 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
                           Write(localizer.GetLocalizedHtmlString("Looks good!"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"invalid-feedback\">\r\n                                ");
#nullable restore
#line 24 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
                           Write(localizer.GetLocalizedHtmlString("Menu item id name is required."));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <label>");
#nullable restore
#line 27 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
                          Write(localizer.GetLocalizedHtmlString("Description"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <span class=\"required-star\">*</span>\r\n                        <div class=\"input-group\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3773d020e6adfa254694a3bdc60cf4985b90422c15486", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 29 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
AddHtmlAttributeValue("", 1676, localizer.GetLocalizedHtmlString("Description"), 1676, 48, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <div class=\"valid-feedback\">\r\n                                ");
#nullable restore
#line 31 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
                           Write(localizer.GetLocalizedHtmlString("Looks good!"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"invalid-feedback\">\r\n                                ");
#nullable restore
#line 34 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
                           Write(localizer.GetLocalizedHtmlString("Description is required."));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <label>");
#nullable restore
#line 37 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
                          Write(localizer.GetLocalizedHtmlString("khmer Description"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <span class=\"required-star\">*</span>\r\n                        <div class=\"input-group\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3773d020e6adfa254694a3bdc60cf4985b90422c19708", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 39 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.KhmerDescription);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 39 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
AddHtmlAttributeValue("", 2446, localizer.GetLocalizedHtmlString("Khmer Description"), 2446, 54, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <div class=\"valid-feedback\">\r\n                                ");
#nullable restore
#line 41 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
                           Write(localizer.GetLocalizedHtmlString("Looks good!"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"invalid-feedback\">\r\n                                ");
#nullable restore
#line 44 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
                           Write(localizer.GetLocalizedHtmlString("Khmer description is required."));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <label>");
#nullable restore
#line 47 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
                          Write(localizer.GetLocalizedHtmlString("Url"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <span class=\"required-star\">*</span>\r\n                        <div class=\"input-group\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3773d020e6adfa254694a3bdc60cf4985b90422c23933", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 49 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 49 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
AddHtmlAttributeValue("", 3201, localizer.GetLocalizedHtmlString("Url"), 3201, 40, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <div class=\"valid-feedback\">\r\n                                ");
#nullable restore
#line 51 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
                           Write(localizer.GetLocalizedHtmlString("Looks good!"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"invalid-feedback\">\r\n                                ");
#nullable restore
#line 54 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
                           Write(localizer.GetLocalizedHtmlString("Url is required."));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-12 text-right\">\r\n                        <button class=\"btn btn-primary\" type=\"submit\">");
#nullable restore
#line 59 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
                                                                 Write(localizer.GetLocalizedHtmlString("Update"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3773d020e6adfa254694a3bdc60cf4985b90422c28195", async() => {
#nullable restore
#line 60 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\MenuItem\Edit.cshtml"
                                                                 Write(localizer.GetLocalizedHtmlString("Back to List"));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            \r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuClass.MenuItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
