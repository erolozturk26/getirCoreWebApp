#pragma checksum "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\Musteriler\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "456771665bc20110f95c4f815250d0822a6f3080"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Musteriler_Index), @"mvc.1.0.view", @"/Views/Musteriler/Index.cshtml")]
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
#line 1 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\_ViewImports.cshtml"
using Getir_Core_WebApp_ORM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\_ViewImports.cshtml"
using Getir_Core_WebApp_ORM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"456771665bc20110f95c4f815250d0822a6f3080", @"/Views/Musteriler/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d68e014a9a15fb8c8c47df788dbd5364602a5d6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Musteriler_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppModel.Models.Musteriler>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\Musteriler\Index.cshtml"
  
    ViewData["Title"] = "Müşterileri Listele";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "456771665bc20110f95c4f815250d0822a6f30805130", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <h2 class=""page-header text-center"">Müşterileri Listele</h2>
        <hr />
        <div class=""row"">
            <div class=""col-sm-12 col-sm-offset-2"">
                <table class=""table table-bordered table-striped"" style=""margin-top:20px;"">
                    <thead align=""center"">
                    <th>");
#nullable restore
#line 17 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\Musteriler\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 18 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\Musteriler\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ADI));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 19 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\Musteriler\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.SOYADI));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 20 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\Musteriler\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TELEFON));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 21 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\Musteriler\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ADRES));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>İŞLEM</th>\r\n                    </thead>\r\n                    <tbody align=\"center\">\r\n");
#nullable restore
#line 25 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\Musteriler\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 29 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\Musteriler\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 32 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\Musteriler\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ADI));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 35 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\Musteriler\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.SOYADI));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 38 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\Musteriler\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TELEFON));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 41 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\Musteriler\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ADRES));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "456771665bc20110f95c4f815250d0822a6f308010282", async() => {
                    WriteLiteral("<i class=\"fa fa-pencil\"></i>Düzenle");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\Musteriler\Index.cshtml"
                                                           WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "456771665bc20110f95c4f815250d0822a6f308012753", async() => {
                    WriteLiteral("<i class=\"fa fa-pencil\"></i> Kaldır");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\Musteriler\Index.cshtml"
                                                             WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 48 "C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Getir_Core_WebApp_ORM\Getir_Core_WebApp_ORM\Views\Musteriler\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppModel.Models.Musteriler>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
