#pragma checksum "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0052cd87a5311a6a93d919cfb8298d439a3abe53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Uom_Index), @"mvc.1.0.view", @"/Views/Uom/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0052cd87a5311a6a93d919cfb8298d439a3abe53", @"/Views/Uom/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b02511a79cf75c7dd0cdc87ae3c1f01d625ab51", @"/Views/_ViewImports.cshtml")]
    public class Views_Uom_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Uom>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "see", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"ms-panel\">\r\n    <div class=\"ms-panel-header\">\r\n        <h6>");
#nullable restore
#line 6 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
       Write(localizer.GetLocalizedHtmlString("List Of Unit Of Measures"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n    <div class=\"ms-panel-body\">\r\n        <div class=\"table-responsive\">\r\n            <table id=\"list-uoms\" class=\"table w-100 thead-primary\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>");
#nullable restore
#line 13 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
                       Write(localizer.GetLocalizedHtmlString("No"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 14 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
                       Write(localizer.GetLocalizedHtmlString("Uom Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 15 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
                       Write(localizer.GetLocalizedHtmlString("Create By"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 16 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
                       Write(localizer.GetLocalizedHtmlString("Create Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th class=\"text-center\">");
#nullable restore
#line 17 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
                                           Write(localizer.GetLocalizedHtmlString("Edit / Delete / See"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 21 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
                       var index = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 25 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
                           Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
                           Write(item.UomName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
                           Write(item.CreateBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
                           Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">\r\n                                <div class=\"action-modify\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0052cd87a5311a6a93d919cfb8298d439a3abe5310778", async() => {
                WriteLiteral("<i class=\"fas fa-pencil-alt text-secondary\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
AddHtmlAttributeValue("", 1390, localizer.GetLocalizedHtmlString("Edit"), 1390, 41, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-key", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
                                                                                                              WriteLiteral(item.Encryted);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["key"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-key", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["key"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"action-modify\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0052cd87a5311a6a93d919cfb8298d439a3abe5313728", async() => {
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 34 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
AddHtmlAttributeValue("", 1683, localizer.GetLocalizedHtmlString("Delete"), 1683, 43, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-key", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
                                                                                                                  WriteLiteral(item.Encryted);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["key"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-key", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["key"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"action-modify\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0052cd87a5311a6a93d919cfb8298d439a3abe5316663", async() => {
                WriteLiteral("<i class=\"fa fa-eye\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
AddHtmlAttributeValue("", 1959, localizer.GetLocalizedHtmlString("See"), 1959, 40, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-key", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
                                                                                                            WriteLiteral(item.Encryted);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["key"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-key", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["key"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 41 "D:\E-commerce\Develoment\e-commerce-backend\EcommerceBackEnd\EcommerceBackEnd\Views\Uom\Index.cshtml"
                        index++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'#list-uoms\').DataTable({\r\n            pageLength: 10\r\n        });\r\n    });\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Uom>> Html { get; private set; }
    }
}
#pragma warning restore 1591
