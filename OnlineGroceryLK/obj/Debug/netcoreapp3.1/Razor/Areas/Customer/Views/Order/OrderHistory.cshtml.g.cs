#pragma checksum "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fedcfb206135f3396da6bd001ab728f1b58e2d09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Order_OrderHistory), @"mvc.1.0.view", @"/Areas/Customer/Views/Order/OrderHistory.cshtml")]
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
#line 1 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\_ViewImports.cshtml"
using OnlineGroceryLK;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\_ViewImports.cshtml"
using OnlineGroceryLK.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
using OnlineGroceryLK.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fedcfb206135f3396da6bd001ab728f1b58e2d09", @"/Areas/Customer/Views/Order/OrderHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75d3e92ae827fdadee43c76c0e72418ec9c61b0e", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Order_OrderHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineGroceryLK.Models.ViewModels.OrderListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
  
    ViewData["Title"] = "OrderHistory";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""htc__product__details pt--50 pb--100 bg__white"">
    <div class=""container""

<div class=""border backgroundWhite"">
    <div class=""row"">
        <div class=""col-6"">
            <h2 class=""text-info""> Past Order List</h2>
        </div>
       
    </div>
    <br />
    <div>
");
#nullable restore
#line 21 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
         if (Model.Orders.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-striped border"">
                <tr class=""table-secondary"">
                    <th>
                        Order ID
                    </th>
                    <th>
                       Name
                    </th>
                    <th>
                        ");
#nullable restore
#line 32 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                       Address\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 38 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Total Items\r\n                    </th>\r\n                    <th></th>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
                 foreach (var item in Model.Orders)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 50 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 53 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 56 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 59 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                           ");
#nullable restore
#line 62 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
                      Write(item.OrderHeader.OrderTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 65 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderDetails.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <button type=\"submit\" class=\"btn btn-success anchorDetail\" data-id=\"");
#nullable restore
#line 68 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
                                                                                           Write(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\">\r\n                                <i class=\"far fa-list-alt\"></i> Details\r\n                            </button>\r\n                           \r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 74 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n            <div");
            BeginWriteAttribute("page-model", " page-model=\"", 2683, "\"", 2713, 1);
#nullable restore
#line 76 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
WriteAttributeValue("", 2696, Model.PagingInfo, 2696, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" page-classes-enabled=\"true\" page-class=\"btn border\"\r\n                 page-class-normal=\"btn btn-light\" page-class-selected=\"btn btn-info active\"\r\n                 class=\"btn-group float-right\">\r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 81 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No category exists...</p>\r\n");
#nullable restore
#line 85 "C:\Users\dkottawagamage\Documents\OnlineGrocery\OnlineGroceryLK\OnlineGroceryLK\Areas\Customer\Views\Order\OrderHistory.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog-centered modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-success text-light justify-content-center"">
                <h5 class=""modal-title"">Order Details</h5>
            </div>
            <div class=""modal-body justify-content-center"" id=""myModalContent"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" style=""width:20%"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""myOrderStatus"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-info text-light justify-content-center"">
                <h5 class=""modal-title"">Order");
            WriteLiteral(@" Status </h5>
            </div>
            <div class=""modal-body justify-content-center"" id='myOrderStatusContent'>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" style=""width:20%"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

    </div>
</section>





");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        var PostBackURL = '/Customer/Order/GetOrderDetails';
        var OrderStatusURL = '/Customer/Order/GetOrderStatus';

        $(function () {
            $("".anchorDetail"").click(function () {

                var $buttonClicked = $(this);
                var id = $buttonClicked.attr('data-id');

                $.ajax({
                    type: ""GET"",
                    url: PostBackURL,
                    contentType: ""application/json; charset=utf-8"",
                    data: { ""Id"": id },
                    cache: false,
                    dataType: ""html"",
                    success: function (data) {
                        $('#myModalContent').html(data);
                        $('#myModal').modal('show');
                    },
                    error: function () {
                        alert(""Dynamic content load failed"");
                    }
                });

            });

            $("".btnOrderStatus"").click(function () {
   ");
                WriteLiteral(@"             var $buttonClicked = $(this);
                var id = $buttonClicked.attr('data-id');
                $.ajax({
                    type: ""GET"",
                    url: OrderStatusURL,
                    contentType: ""text/html; charset=utf-8"",
                    data: { ""Id"": id },
                    cache: false,
                    dataType: ""html"",
                    success: function (data) {
                        $('#myOrderStatusContent').html(data);
                        $('#myOrderStatus').modal('show');

                    },
                    error: function () {
                        alert(""Dynamic content load failed."");
                    }
                });
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineGroceryLK.Models.ViewModels.OrderListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
