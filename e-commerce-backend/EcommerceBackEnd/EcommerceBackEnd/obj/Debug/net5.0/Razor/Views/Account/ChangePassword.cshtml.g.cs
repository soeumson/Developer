#pragma checksum "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e6420a2fcb485a4b4b008c4a50569d0b0fbe6d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ChangePassword), @"mvc.1.0.view", @"/Views/Account/ChangePassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e6420a2fcb485a4b4b008c4a50569d0b0fbe6d0", @"/Views/Account/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b02511a79cf75c7dd0cdc87ae3c1f01d625ab51", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChangePasswordViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "password", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "changepassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.Error))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        <strong>Oh worrying!</strong> ");
#nullable restore
#line 5 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
                                 Write(localizer.GetLocalizedHtmlString(ViewBag.Error));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 7 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.Success))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        <strong>Well done!</strong> ");
#nullable restore
#line 11 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
                               Write(localizer.GetLocalizedHtmlString("You successfully change password account."));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 13 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"ms-panel\">\r\n    <div class=\"ms-panel-header\">\r\n        <h6>");
#nullable restore
#line 16 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
       Write(localizer.GetLocalizedHtmlString("Change Password Form"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n    <div class=\"ms-panel-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e6420a2fcb485a4b4b008c4a50569d0b0fbe6d010353", async() => {
                WriteLiteral("\r\n            <div class=\"col-xl-12 col-md-12\">\r\n                <div class=\"form-row\">\r\n                    <div class=\"col-md-12\">\r\n                        <label>");
#nullable restore
#line 23 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
                          Write(localizer.GetLocalizedHtmlString("Old Password"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <span class=\"required-star\">*</span>\r\n                        <div class=\"input-group\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6e6420a2fcb485a4b4b008c4a50569d0b0fbe6d011245", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 25 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OldPassword);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
AddHtmlAttributeValue("", 1156, localizer.GetLocalizedHtmlString("Old Password"), 1156, 49, false);

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
#line 27 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
                           Write(localizer.GetLocalizedHtmlString("Looks good!"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"invalid-feedback\">\r\n                                ");
#nullable restore
#line 30 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
                           Write(localizer.GetLocalizedHtmlString("Old Password is required."));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-12\">\r\n                        <label>");
#nullable restore
#line 35 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
                          Write(localizer.GetLocalizedHtmlString("New Password"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <span class=\"required-star\">*</span>\r\n                        <div class=\"input-group\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6e6420a2fcb485a4b4b008c4a50569d0b0fbe6d015501", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 37 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NewPassword);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
AddHtmlAttributeValue("", 1976, localizer.GetLocalizedHtmlString("New password"), 1976, 49, false);

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
#line 39 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
                           Write(localizer.GetLocalizedHtmlString("Looks good!"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"invalid-feedback\">\r\n                                ");
#nullable restore
#line 42 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
                           Write(localizer.GetLocalizedHtmlString("New Password is required."));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-12\">\r\n                        <label>");
#nullable restore
#line 47 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
                          Write(localizer.GetLocalizedHtmlString("Confirm New password"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <span class=\"required-star\">*</span>\r\n                        <div class=\"input-group\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6e6420a2fcb485a4b4b008c4a50569d0b0fbe6d019765", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 49 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ConfirmPassword);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 49 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
AddHtmlAttributeValue("", 2808, localizer.GetLocalizedHtmlString("Confirm new password"), 2808, 57, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
#line 51 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
                           Write(localizer.GetLocalizedHtmlString("Looks good!"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"invalid-feedback\">\r\n                                ");
#nullable restore
#line 54 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
                           Write(localizer.GetLocalizedHtmlString("Confirm new password is required."));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-12"">
                        <div class=""text-right"">
                            <button class=""btn btn-primary"" type=""submit"">");
#nullable restore
#line 60 "D:\E-commerce\MY PROJECT\Developer\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Account\ChangePassword.cshtml"
                                                                     Write(localizer.GetLocalizedHtmlString("Save"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChangePasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
