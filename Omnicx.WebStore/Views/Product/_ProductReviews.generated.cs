﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using DevTrends.MvcDonutCaching;
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Product/_ProductReviews.cshtml")]
    public partial class _Views_Product__ProductReviews_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Product__ProductReviews_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Product\_ProductReviews.cshtml"
  
/*
    Name: product review
    Purpose: Show All users review of selected product
    Structure: /Views/Product/_ProductReviews.cshtml
    Contains (Partial Views Used):
        a-/Views/Product/_WriteProductReview.cshtml

    Contained In (Where we Use this View):
        a-/Views/Product/ProductDetail.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel-group no-margin\"");

WriteLiteral(" id=\"productReviews\"");

WriteLiteral(" role=\"tablist\"");

WriteLiteral(" aria-multiselectable=\"true\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(" role=\"tab\"");

WriteLiteral(">\r\n                <h4");

WriteLiteral(" class=\"panel-title heading-h4\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" role=\"button\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-parent=\"#productReviews\"");

WriteLiteral(" href=\"#reviewData\"");

WriteLiteral(" aria-expanded=\"true\"");

WriteLiteral(" aria-controls=\"Data\"");

WriteLiteral(">");

            
            #line 20 "..\..\Views\Product\_ProductReviews.cshtml"
                                                                                                                                                  Write(LT("productDetail.label.ProductReviews", "Product Reviews"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </h4>\r\n            </div>\r\n            <div");

WriteLiteral(" id=\"reviewData\"");

WriteLiteral(" class=\"panel-collapse collapse in\"");

WriteLiteral(" role=\"tabpanel\"");

WriteLiteral(" aria-labelledby=\"productReviews\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"panel-body no-padding no-border\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                            <h3");

WriteLiteral(" class=\"category-headline\"");

WriteLiteral(" ng-bind=\"pm.model.subBrand\"");

WriteLiteral("></h3>\r\n                            <i");

WriteLiteral(" class=\"fa fa-star text-orange\"");

WriteLiteral(" ng-repeat=\"1 in pm.setRating(pm.model.rating,1)\"");

WriteLiteral("></i><i");

WriteLiteral(" class=\"fa fa-star-o\"");

WriteLiteral(" ng-repeat=\"1 in pm.setRating(pm.model.rating,0)\"");

WriteLiteral("></i><br />\r\n                            <span");

WriteLiteral(" ng-show=\"pm.model.reviews.length>0 && pm.model.reviews!=null\"");

WriteLiteral("> <span");

WriteLiteral(" ng-bind=\"pm.model.reviews.length\"");

WriteLiteral("></span> ");

            
            #line 29 "..\..\Views\Product\_ProductReviews.cshtml"
                                                                                                                                            Write(LT("ProductDetail.label.Reviews", "review(s)"));

            
            #line default
            #line hidden
WriteLiteral("<br /></span>\r\n                            <p");

WriteLiteral(" class=\"faq-ans no-padding\"");

WriteLiteral(" ng-show=\"pm.model.reviews.length>0 && pm.model.reviews!=null\"");

WriteLiteral("><span");

WriteLiteral(" ng-bind=\"pm.model.reviews.length\"");

WriteLiteral("></span> ");

            
            #line 30 "..\..\Views\Product\_ProductReviews.cshtml"
                                                                                                                                                                   Write(LT("ProductDetail.Label.OutOf", "out of"));

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" ng-bind=\"pm.model.reviews.length\"");

WriteLiteral("></span> ");

            
            #line 30 "..\..\Views\Product\_ProductReviews.cshtml"
                                                                                                                                                                                                                                                             Write(LT("ProductDetail.Label.Recommend", "people would recommend this product"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <p");

WriteLiteral(" class=\"faq-ans no-padding\"");

WriteLiteral(" ng-show=\"pm.model.reviews.length<=0\"");

WriteLiteral(">");

            
            #line 31 "..\..\Views\Product\_ProductReviews.cshtml"
                                                                                          Write(LT("ProductDetail.Label.BeFirstReview", "Be the first one to review this product"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <p");

WriteLiteral(" class=\"text-center col-xs-12 col-sm-12 text-center\"");

WriteLiteral(">\r\n");

            
            #line 33 "..\..\Views\Product\_ProductReviews.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Product\_ProductReviews.cshtml"
                                 if (SessionContext.CurrentUser == null)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <button");

WriteLiteral(" class=\"animate btn-default\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" data-target=\"#productReviewLogin\"");

WriteLiteral(" ng-click=\"pm.GetDynamicReviewConfig()\"");

WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 36 "..\..\Views\Product\_ProductReviews.cshtml"
                                   Write(LT("ProductReview.Button.WriteReview", " Write a Review"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </button>\r\n");

            
            #line 38 "..\..\Views\Product\_ProductReviews.cshtml"
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <button");

WriteLiteral(" class=\"animate btn-default\"");

WriteLiteral(" ng-click=\"pm.GetDynamicReviewConfig();pm.writeReview = true;pm.reviewAsGuest()\"");

WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 42 "..\..\Views\Product\_ProductReviews.cshtml"
                                   Write(LT("ProductReview.Button.WriteReview", " Write a Review"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </button>\r\n");

            
            #line 44 "..\..\Views\Product\_ProductReviews.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </p>\r\n                            <div");

WriteLiteral(" class=\"or-spacer\"");

WriteLiteral("><div");

WriteLiteral(" class=\"mask\"");

WriteLiteral("></div></div>\r\n                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 text-center \"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"img-full color-black\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" href=\"#collapse2\"");

WriteLiteral(" ng-show=\"pm.model.reviews!=null && pm.model.reviews.length>0 && !pm.reviews\"");

WriteLiteral(" ng-click=\"pm.reviews=!pm.reviews\"");

WriteLiteral(">");

            
            #line 48 "..\..\Views\Product\_ProductReviews.cshtml"
                                                                                                                                                                                                                   Write(LT("Product.Label.ReadAllReviews", "Read All Reviews"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                            </div>\r\n                        </div>\r\n       " +
"             </div>\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"panel-group\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" id=\"collapse1\"");

WriteLiteral(" class=\"panel-collapse collapse in\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"panel-group\"");

WriteLiteral(" ng-show=\"pm.model.reviews.length>0 && pm.model.reviews!=null\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n                                                <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n                                                    <hr />\r\n                  " +
"                                  <h3");

WriteLiteral(" class=\"panel-title text-center pull-left width-full\"");

WriteLiteral("></h3>\r\n                                                </div>\r\n                 " +
"                               <div");

WriteLiteral(" id=\"collapse2\"");

WriteLiteral(" class=\"panel-collapse collapse\"");

WriteLiteral(">\r\n                                                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" ng-repeat=\"review in pm.model.reviews\"");

WriteLiteral(">\r\n                                                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                                                            <h3");

WriteLiteral(" ng-bind=\"review.title\"");

WriteLiteral(" class=\"category-headline\"");

WriteLiteral("></h3>\r\n                                                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                                                                <ul");

WriteLiteral(" class=\"list-inline\"");

WriteLiteral(">\r\n                                                                    <li");

WriteLiteral(" class=\"no-padding\"");

WriteLiteral(">\r\n                                                                        <i");

WriteLiteral(" class=\"fa fa-star text-orange\"");

WriteLiteral(" ng-repeat=\"1 in pm.setRating(review.rating,1)\"");

WriteLiteral("></i>\r\n                                                                        <i" +
"");

WriteLiteral(" class=\"fa fa-star-o\"");

WriteLiteral(" ng-repeat=\"1 in pm.setRating(review.rating,0)\"");

WriteLiteral(@"></i>
                                                                    </li>
                                                                </ul>
                                                            </div>
                                                            <p");

WriteLiteral(" class=\"faq-ans no-padding\"");

WriteLiteral(" ng-bind=\"review.comment\"");

WriteLiteral("></p>\r\n                                                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding margin-bottom-xs\"");

WriteLiteral(" ng-repeat=\"section in review.sections\"");

WriteLiteral(">\r\n                                                                <strong><span");

WriteLiteral(" class=\"text-capitalize\"");

WriteLiteral(" ng-bind=\"section.sectionName\"");

WriteLiteral("></span>:</strong>\r\n                                                             " +
"   <span");

WriteLiteral(" ng-repeat=\"option in section.options\"");

WriteLiteral(" ng-if=\"option.isChecked\"");

WriteLiteral("><span");

WriteLiteral(" ng-bind=\"option.name\"");

WriteLiteral("></span></span>\r\n                                                            </di" +
"v>\r\n                                                            <p");

WriteLiteral(" class=\"faq-ans no-padding\"");

WriteLiteral(">");

            
            #line 80 "..\..\Views\Product\_ProductReviews.cshtml"
                                                                                     Write(LT("Product.detail.Label.WasHelpFul", "Was this review helpful?"));

            
            #line default
            #line hidden
WriteLiteral("<strong");

WriteLiteral(" class=\"text-black\"");

WriteLiteral(">Yes</strong></p>\r\n                                                            <p" +
"");

WriteLiteral(" class=\"faq-ans no-padding\"");

WriteLiteral("><strong");

WriteLiteral(" class=\"text-black\"");

WriteLiteral(">");

            
            #line 81 "..\..\Views\Product\_ProductReviews.cshtml"
                                                                                                                Write(LT("ProductDetail.Label.Recommend", "Yes, "));

            
            #line default
            #line hidden
WriteLiteral("</strong>");

            
            #line 81 "..\..\Views\Product\_ProductReviews.cshtml"
                                                                                                                                                                      Write(LT("ProductDetail.Label.Recommend", "I would recommend this product"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                                            <p");

WriteLiteral(" class=\"faq-ques\"");

WriteLiteral(" ng-bind=\"review.postedBy\"");

WriteLiteral("></p>\r\n                                                        </div>\r\n          " +
"                                              <div");

WriteLiteral(" class=\"or-spacer\"");

WriteLiteral("><div");

WriteLiteral(" class=\"mask\"");

WriteLiteral("></div></div>\r\n\r\n                                                    </div>\r\n    " +
"                                                <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n                                                        <hr />\r\n              " +
"                                          <h3");

WriteLiteral(" class=\"panel-title text-center pull-left width-full\"");

WriteLiteral(">\r\n                                                            <a");

WriteLiteral(" class=\"img-full\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" href=\"#collapse2\"");

WriteLiteral(" ng-show=\"pm.reviews\"");

WriteLiteral(" ng-click=\"pm.reviews=!pm.reviews\"");

WriteLiteral(">");

            
            #line 90 "..\..\Views\Product\_ProductReviews.cshtml"
                                                                                                                                                                           Write(LT("Product.Label.ReadLess", "Read Less"));

            
            #line default
            #line hidden
WriteLiteral(@"</a>
                                                        </h3>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div");

WriteLiteral(" id=\"collapse3\"");

WriteLiteral(" class=\"panel-collapse collapse\"");

WriteLiteral(">\r\n");

            
            #line 98 "..\..\Views\Product\_ProductReviews.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 98 "..\..\Views\Product\_ProductReviews.cshtml"
                                           /* Start product write review*/ 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                        ");

            
            #line 99 "..\..\Views\Product\_ProductReviews.cshtml"
                                   Write(Html.Partial("~/Views/Product/_WriteProductReview.cshtml", new Omnicx.WebStore.Models.Catalog.ProductReviewAddModel { }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 100 "..\..\Views\Product\_ProductReviews.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 100 "..\..\Views\Product\_ProductReviews.cshtml"
                                           /* End product write review */ 
            
            #line default
            #line hidden
WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");

        }
    }
}
#pragma warning restore 1591
