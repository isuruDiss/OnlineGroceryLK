#pragma checksum "E:\Personal\SLIIT\MSc IT\SEP\Project\OnlineGrocerylk\OnlineGroceryLK\Areas\Customer\Views\Home\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23e98eb56654aa57819bfde69b90fae8d11eed78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Products), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Products.cshtml")]
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
#line 1 "E:\Personal\SLIIT\MSc IT\SEP\Project\OnlineGrocerylk\OnlineGroceryLK\Areas\Customer\Views\_ViewImports.cshtml"
using OnlineGroceryLK;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Personal\SLIIT\MSc IT\SEP\Project\OnlineGrocerylk\OnlineGroceryLK\Areas\Customer\Views\_ViewImports.cshtml"
using OnlineGroceryLK.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23e98eb56654aa57819bfde69b90fae8d11eed78", @"/Areas/Customer/Views/Home/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75d3e92ae827fdadee43c76c0e72418ec9c61b0e", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("review-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "E:\Personal\SLIIT\MSc IT\SEP\Project\OnlineGrocerylk\OnlineGroceryLK\Areas\Customer\Views\Home\Products.cshtml"
  
    ViewData["Title"] = "Product";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""ht__bradcaump__wrap"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""bradcaump__inner text-center"">
                    <h2 class=""bradcaump-title"">Product Details</h2>
                    <nav class=""bradcaump-inner"">
                        <a class=""breadcrumb-item"" href=""index.html"">Home</a>
                        <span class=""brd-separetor"">/</span>
                        <span class=""breadcrumb-item active"">Product Details</span>
                    </nav>
                </div>
            </div>
        </div>
    </div>
</div>

<section class=""htc__product__details pt--120 pb--100 bg__white"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-lg-6 col-sm-12 col-xs-12"">
                <div class=""product__details__container"">
                    <!-- Start Small images -->
                    <!-- End Small images -->
                    <div class=""pr");
            WriteLiteral(@"oduct__big__images"">
                        <div class=""portfolio-full-image tab-content"">
                            <div role=""tabpanel"" class=""tab-pane fade in active product-video-position"" id=""img-tab-1"">
                                <img src=""images/product-details/big-img/10.jpg"" alt=""full-image"">
                                <div class=""product-video"">
                                    <a class=""video-popup"" href=""https://www.youtube.com/watch?v=cDDWvj_q-o8"">
                                        <i class=""zmdi zmdi-videocam""></i> View Video
                                    </a>
                                </div>
                            </div>
                            <div role=""tabpanel"" class=""tab-pane fade product-video-position"" id=""img-tab-2"">
                                <img src=""images/product-details/big-img/12.jpg"" alt=""full-image"">
                                <div class=""product-video"">
                                    <a class=""video-popup"" ");
            WriteLiteral(@"href=""https://www.youtube.com/watch?v=cDDWvj_q-o8"">
                                        <i class=""zmdi zmdi-videocam""></i> View Video
                                    </a>
                                </div>
                            </div>
                            <div role=""tabpanel"" class=""tab-pane fade product-video-position"" id=""img-tab-3"">
                                <img src=""images/product-details/big-img/11.jpg"" alt=""full-image"">
                                <div class=""product-video"">
                                    <a class=""video-popup"" href=""https://www.youtube.com/watch?v=cDDWvj_q-o8"">
                                        <i class=""zmdi zmdi-videocam""></i> View Video
                                    </a>
                                </div>
                            </div>
                            <div role=""tabpanel"" class=""tab-pane fade product-video-position"" id=""img-tab-4"">
                                <img src=""images/product-details/b");
            WriteLiteral(@"ig-img/12.jpg"" alt=""full-image"">
                                <div class=""product-video"">
                                    <a class=""video-popup"" href=""https://www.youtube.com/watch?v=cDDWvj_q-o8"">
                                        <i class=""zmdi zmdi-videocam""></i> View Video
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-6 col-sm-12 col-xs-12 smt-30 xmt-30"">
                <div class=""htc__product__details__inner"">
                    <div class=""pro__detl__title"">
                        <h2>Black Clock</h2>
                    </div>
                    <div class=""pro__dtl__rating"">
                        <ul class=""pro__rating"">
                            <li><span class=""ti-star""></span></li>
                            <li><span class=""ti-star""></span></li>
     ");
            WriteLiteral(@"                       <li><span class=""ti-star""></span></li>
                            <li><span class=""ti-star""></span></li>
                            <li><span class=""ti-star""></span></li>
                        </ul>
                        <span class=""rat__qun"">(Based on 0 Ratings)</span>
                    </div>
                    <div class=""pro__details"">
                        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit, sed do eiusmod temf incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, nostr exercitation ullamco laboris nisi ut aliquip ex ea. </p>
                    </div>
                    <ul class=""pro__dtl__prize"">
                        <li class=""old__prize"">$15.21</li>
                        <li>$10.00</li>
                    </ul>


                    <div class=""product-action-wrap"">
                        <div class=""prodict-statas""><span>Quantity :</span></div>
                        <div class=""product-quantity"">
");
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23e98eb56654aa57819bfde69b90fae8d11eed7810406", async() => {
                WriteLiteral(@"
                                <div class=""product-quantity"">
                                    <div class=""cart-plus-minus"">
                                        <input class=""cart-plus-minus-box"" type=""text"" name=""qtybutton"" value=""02"">
                                        <div class=""dec qtybutton"">-</div><div class=""inc qtybutton"">+</div>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                    <ul class=""pro__dtl__btn"">
                        <li class=""buy__now__btn""><a href=""#"">buy now</a></li>
                        <li><a href=""#""><span class=""ti-heart""></span></a></li>
                        <li><a href=""#""><span class=""ti-email""></span></a></li>
                    </ul>
                    <div class=""pro__social__share"">
                        <h2>Share :</h2>
                        <ul class=""pro__soaial__link"">
                            <li><a href=""#""><i class=""zmdi zmdi-twitter""></i></a></li>
                            <li><a href=""#""><i class=""zmdi zmdi-instagram""></i></a></li>
                            <li><a href=""#""><i class=""zmdi zmdi-facebook""></i></a></li>
                            <li><a href=""#""><i class=""zmdi zmdi-google-plus""></i></a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</s");
            WriteLiteral(@"ection>

<section class=""htc__product__details__tab bg__white pb--120"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 col-lg-12 col-sm-12 col-xs-12"">
                <ul class=""product__deatils__tab mb--60"" role=""tablist"">
                    <li role=""presentation"" class=""active"">
                        <a href=""#description"" role=""tab"" data-toggle=""tab"">Description</a>
                    </li>
                    <li role=""presentation"">
                        <a href=""#sheet"" role=""tab"" data-toggle=""tab"">Data sheet</a>
                    </li>
                    <li role=""presentation"">
                        <a href=""#reviews"" role=""tab"" data-toggle=""tab"">Reviews</a>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""product__details__tab__content"">
                    <!-- Start Single Content -->
                  ");
            WriteLiteral(@"  <div role=""tabpanel"" id=""description"" class=""product__tab__content fade in active"">
                        <div class=""product__description__wrap"">
                            <div class=""product__desc"">
                                <h2 class=""title__6"">Details</h2>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis noexercit ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id.</p>
                            </div>
                            <div class=""pro__feature"">
                                <h2 class=""title__6"">Features</h2>
                                <ul class=""feature__list"">
                                    <li><a href=""#""><i class=""z");
            WriteLiteral(@"mdi zmdi-play-circle""></i>Duis aute irure dolor in reprehenderit in voluptate velit esse</a></li>
                                    <li><a href=""#""><i class=""zmdi zmdi-play-circle""></i>Irure dolor in reprehenderit in voluptate velit esse</a></li>
                                    <li><a href=""#""><i class=""zmdi zmdi-play-circle""></i>Sed do eiusmod tempor incididunt ut labore et </a></li>
                                    <li><a href=""#""><i class=""zmdi zmdi-play-circle""></i>Nisi ut aliquip ex ea commodo consequat.</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <!-- End Single Content -->
                    <!-- Start Single Content -->
                    <div role=""tabpanel"" id=""sheet"" class=""product__tab__content fade"">
                        <div class=""pro__feature"">
                            <h2 class=""title__6"">Data sheet</h2>
                            <ul class=""featur");
            WriteLiteral(@"e__list"">
                                <li><a href=""#""><i class=""zmdi zmdi-play-circle""></i>Duis aute irure dolor in reprehenderit in voluptate velit esse</a></li>
                                <li><a href=""#""><i class=""zmdi zmdi-play-circle""></i>Irure dolor in reprehenderit in voluptate velit esse</a></li>
                                <li><a href=""#""><i class=""zmdi zmdi-play-circle""></i>Irure dolor in reprehenderit in voluptate velit esse</a></li>
                                <li><a href=""#""><i class=""zmdi zmdi-play-circle""></i>Sed do eiusmod tempor incididunt ut labore et </a></li>
                                <li><a href=""#""><i class=""zmdi zmdi-play-circle""></i>Sed do eiusmod tempor incididunt ut labore et </a></li>
                                <li><a href=""#""><i class=""zmdi zmdi-play-circle""></i>Nisi ut aliquip ex ea commodo consequat.</a></li>
                                <li><a href=""#""><i class=""zmdi zmdi-play-circle""></i>Nisi ut aliquip ex ea commodo consequat.</a></li>
   ");
            WriteLiteral(@"                         </ul>
                        </div>
                    </div>
                    <!-- End Single Content -->
                    <!-- Start Single Content -->
                    <div role=""tabpanel"" id=""reviews"" class=""product__tab__content fade"">
                        <div class=""review__address__inner"">
                            <!-- Start Single Review -->
                            <div class=""pro__review"">
                                <div class=""review__thumb"">
                                    <img src=""images/review/1.jpg"" alt=""review images"">
                                </div>
                                <div class=""review__details"">
                                    <div class=""review__info"">
                                        <h4><a href=""#"">Gerald Barnes</a></h4>
                                        <ul class=""rating"">
                                            <li><i class=""zmdi zmdi-star""></i></li>
                       ");
            WriteLiteral(@"                     <li><i class=""zmdi zmdi-star""></i></li>
                                            <li><i class=""zmdi zmdi-star""></i></li>
                                            <li><i class=""zmdi zmdi-star-half""></i></li>
                                            <li><i class=""zmdi zmdi-star-half""></i></li>
                                        </ul>
                                        <div class=""rating__send"">
                                            <a href=""#""><i class=""zmdi zmdi-mail-reply""></i></a>
                                            <a href=""#""><i class=""zmdi zmdi-close""></i></a>
                                        </div>
                                    </div>
                                    <div class=""review__date"">
                                        <span>27 Jun, 2016 at 2:30pm</span>
                                    </div>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer accumsan e");
            WriteLiteral(@"gestas elese ifend. Phasellus a felis at estei to bibendum feugiat ut eget eni Praesent et messages in con sectetur posuere dolor non.</p>
                                </div>
                            </div>
                            <!-- End Single Review -->
                            <!-- Start Single Review -->
                            <div class=""pro__review ans"">
                                <div class=""review__thumb"">
                                    <img src=""images/review/2.jpg"" alt=""review images"">
                                </div>
                                <div class=""review__details"">
                                    <div class=""review__info"">
                                        <h4><a href=""#"">Gerald Barnes</a></h4>
                                        <ul class=""rating"">
                                            <li><i class=""zmdi zmdi-star""></i></li>
                                            <li><i class=""zmdi zmdi-star""></i></li>
       ");
            WriteLiteral(@"                                     <li><i class=""zmdi zmdi-star""></i></li>
                                            <li><i class=""zmdi zmdi-star-half""></i></li>
                                            <li><i class=""zmdi zmdi-star-half""></i></li>
                                        </ul>
                                        <div class=""rating__send"">
                                            <a href=""#""><i class=""zmdi zmdi-mail-reply""></i></a>
                                            <a href=""#""><i class=""zmdi zmdi-close""></i></a>
                                        </div>
                                    </div>
                                    <div class=""review__date"">
                                        <span>27 Jun, 2016 at 2:30pm</span>
                                    </div>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer accumsan egestas elese ifend. Phasellus a felis at estei to bibendum feugiat ut");
            WriteLiteral(@" eget eni Praesent et messages in con sectetur posuere dolor non.</p>
                                </div>
                            </div>
                            <!-- End Single Review -->
                        </div>
                        <!-- Start RAting Area -->
                        <div class=""rating__wrap"">
                            <h2 class=""rating-title"">Write  A review</h2>
                            <h4 class=""rating-title-2"">Your Rating</h4>
                            <div class=""rating__list"">
                                <!-- Start Single List -->
                                <ul class=""rating"">
                                    <li><i class=""zmdi zmdi-star-half""></i></li>
                                </ul>
                                <!-- End Single List -->
                                <!-- Start Single List -->
                                <ul class=""rating"">
                                    <li><i class=""zmdi zmdi-star-half""></i><");
            WriteLiteral(@"/li>
                                    <li><i class=""zmdi zmdi-star-half""></i></li>
                                </ul>
                                <!-- End Single List -->
                                <!-- Start Single List -->
                                <ul class=""rating"">
                                    <li><i class=""zmdi zmdi-star-half""></i></li>
                                    <li><i class=""zmdi zmdi-star-half""></i></li>
                                    <li><i class=""zmdi zmdi-star-half""></i></li>
                                </ul>
                                <!-- End Single List -->
                                <!-- Start Single List -->
                                <ul class=""rating"">
                                    <li><i class=""zmdi zmdi-star-half""></i></li>
                                    <li><i class=""zmdi zmdi-star-half""></i></li>
                                    <li><i class=""zmdi zmdi-star-half""></i></li>
                        ");
            WriteLiteral(@"            <li><i class=""zmdi zmdi-star-half""></i></li>
                                </ul>
                                <!-- End Single List -->
                                <!-- Start Single List -->
                                <ul class=""rating"">
                                    <li><i class=""zmdi zmdi-star-half""></i></li>
                                    <li><i class=""zmdi zmdi-star-half""></i></li>
                                    <li><i class=""zmdi zmdi-star-half""></i></li>
                                    <li><i class=""zmdi zmdi-star-half""></i></li>
                                    <li><i class=""zmdi zmdi-star-half""></i></li>
                                </ul>
                                <!-- End Single List -->
                            </div>
                        </div>
                        <!-- End RAting Area -->
                        <div class=""review__box"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23e98eb56654aa57819bfde69b90fae8d11eed7825360", async() => {
                WriteLiteral(@"
                                <div class=""single-review-form"">
                                    <div class=""review-box name"">
                                        <input type=""text"" placeholder=""Type your name"">
                                        <input type=""email"" placeholder=""Type your email"">
                                    </div>
                                </div>
                                <div class=""single-review-form"">
                                    <div class=""review-box message"">
                                        <textarea placeholder=""Write your review""></textarea>
                                    </div>
                                </div>
                                <div class=""review-btn"">
                                    <a class=""fv-btn"" href=""#"">submit review</a>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <!-- End Single Content -->\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
