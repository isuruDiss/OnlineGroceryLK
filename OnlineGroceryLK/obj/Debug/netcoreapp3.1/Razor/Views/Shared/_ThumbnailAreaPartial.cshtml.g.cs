#pragma checksum "D:\MSC\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Views\Shared\_ThumbnailAreaPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7893dcb9297166ac35519aa3200a65476890f880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ThumbnailAreaPartial), @"mvc.1.0.view", @"/Views/Shared/_ThumbnailAreaPartial.cshtml")]
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
#line 1 "D:\MSC\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Views\_ViewImports.cshtml"
using OnlineGroceryLK;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MSC\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Views\_ViewImports.cshtml"
using OnlineGroceryLK.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7893dcb9297166ac35519aa3200a65476890f880", @"/Views/Shared/_ThumbnailAreaPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75d3e92ae827fdadee43c76c0e72418ec9c61b0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ThumbnailAreaPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StockMaster>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 6 "D:\MSC\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Views\Shared\_ThumbnailAreaPartial.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 193, "\"", 292, 4);
            WriteAttributeValue("", 201, "col-12", 201, 6, true);
            WriteAttributeValue(" ", 207, "post", 208, 5, true);
#nullable restore
#line 8 "D:\MSC\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Views\Shared\_ThumbnailAreaPartial.cshtml"
WriteAttributeValue(" ", 212, Model.FirstOrDefault().Category.Name.Replace(" ",string.Empty), 213, 63, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 276, "menu-restaurant", 277, 16, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"row\">\r\n            <h3 class=\"text-success\"> ");
#nullable restore
#line 10 "D:\MSC\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Views\Shared\_ThumbnailAreaPartial.cshtml"
                                 Write(Model.FirstOrDefault().Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n        </div>\r\n\r\n");
#nullable restore
#line 13 "D:\MSC\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Views\Shared\_ThumbnailAreaPartial.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"border border-info rounded col-12\" style=\"margin-bottom:10px; margin-top:10px; padding:10px\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-3 col-sm-12\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 709, "\"", 726, 1);
#nullable restore
#line 18 "D:\MSC\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Views\Shared\_ThumbnailAreaPartial.cshtml"
WriteAttributeValue("", 715, item.Image, 715, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""99%"" style=""border-radius:5px;border:1px solid #716666"" />
                    </div>
                    <div class=""col-md-9 col-sm-12"">
                        <div class=""row pr-3"">
                            <div class=""col-8"">
                                <label class=""text-primary"" style=""font-size:21px;color:maroon"">");
#nullable restore
#line 23 "D:\MSC\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Views\Shared\_ThumbnailAreaPartial.cshtml"
                                                                                           Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                <label class=\"text-primary\" style=\"font-size:15px;color:dimgrey\">(");
#nullable restore
#line 24 "D:\MSC\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Views\Shared\_ThumbnailAreaPartial.cshtml"
                                                                                             Write(item.SupplierId);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</label>\r\n\r\n                            </div>\r\n                            <div class=\"col-4 text-right\" style=\"color:maroon\">\r\n                                <h4>Rs.");
#nullable restore
#line 28 "D:\MSC\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Views\Shared\_ThumbnailAreaPartial.cshtml"
                                  Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n                        <div class=\"row col-12 text-justify d-none d-md-block\">\r\n                            <p>");
#nullable restore
#line 34 "D:\MSC\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Views\Shared\_ThumbnailAreaPartial.cshtml"
                          Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"col-md-3 col-sm-12 offset-md-9 text-center\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7893dcb9297166ac35519aa3200a65476890f8808190", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "D:\MSC\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Views\Shared\_ThumbnailAreaPartial.cshtml"
                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 43 "D:\MSC\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Views\Shared\_ThumbnailAreaPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"p-4\"></div>\r\n    </div>\r\n");
#nullable restore
#line 46 "D:\MSC\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Views\Shared\_ThumbnailAreaPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
