#pragma checksum "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08887de13d59ca71a7ad5ae8337d37ca0d2979d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Supplier_Views_StockMaster_Index), @"mvc.1.0.view", @"/Areas/Supplier/Views/StockMaster/Index.cshtml")]
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
#line 1 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\_ViewImports.cshtml"
using OnlineGroceryLK;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\_ViewImports.cshtml"
using OnlineGroceryLK.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08887de13d59ca71a7ad5ae8337d37ca0d2979d0", @"/Areas/Supplier/Views/StockMaster/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75d3e92ae827fdadee43c76c0e72418ec9c61b0e", @"/Areas/Supplier/Views/_ViewImports.cshtml")]
    public class Areas_Supplier_Views_StockMaster_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StockMaster>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"categories-slider-area bg__white\">\r\n\r\n    <div class=\"container\" style=\"padding-top:20px\">\r\n        <h2 class=\"text-info\"> Stock List</h2>\r\n\r\n        <div class=\"row\">\r\n\r\n            <div class=\"col-9 text-right\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "08887de13d59ca71a7ad5ae8337d37ca0d2979d04541", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <br />\r\n        <div>\r\n");
#nullable restore
#line 21 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
             if (Model.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <table class=\"table table-striped border\">\r\n                    <tr class=\"table-secondary\">\r\n                        <th>\r\n                            ");
#nullable restore
#line 26 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 29 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 32 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 35 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 38 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Qty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 41 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            Decription\r\n                        </th>\r\n                        <th></th>\r\n                        <th></th>\r\n                    </tr>\r\n");
#nullable restore
#line 49 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 53 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
                           Write(Html.DisplayFor(m => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 57 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
                           Write(Html.DisplayFor(m => item.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 60 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
                           Write(Html.DisplayFor(m => item.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 63 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
                           Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 66 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
                           Write(Html.DisplayFor(m => item.Qty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 69 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
                           Write(Html.DisplayFor(m => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "08887de13d59ca71a7ad5ae8337d37ca0d2979d011689", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 72 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

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
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 75 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n");
#nullable restore
#line 77 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>No Stocks Under Logged Supplier exists...</p>\r\n");
#nullable restore
#line 81 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Supplier\Views\StockMaster\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StockMaster>> Html { get; private set; }
    }
}
#pragma warning restore 1591
