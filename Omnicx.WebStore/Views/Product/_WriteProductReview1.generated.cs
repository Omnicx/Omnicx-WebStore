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
    
    #line 13 "..\..\Views\Product\_WriteProductReview.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Product/_WriteProductReview.cshtml")]
    public partial class _Views_Product__WriteProductReview_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Catalog.ProductReviewAddModel>
    {
        public _Views_Product__WriteProductReview_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Product\_WriteProductReview.cshtml"
  
/*
    Name: Product Review Form
    Purpose: Review Form
    Structure: /Views/Product/_WriteProductReview.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Product/_ProductReviews.cshtml         (product Reviews)
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 14 "..\..\Views\Product\_WriteProductReview.cshtml"
  
    var addReview = Html.Angular().ModelFor("pm.model.review");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(" ng-show=\"pm.writeReview\"");

WriteLiteral(" ng-init=\"pm.configRating(0);\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" name=\"reviewForm\"");

WriteLiteral(" ng-submit=\"pm.model.review.rating=pm.trueRating.length;pm.addReview(pm.productId" +
",pm.model.review,reviewForm)\"");

WriteLiteral(" novalidate>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label>");

            
            #line 20 "..\..\Views\Product\_WriteProductReview.cshtml"
              Write(LT("ProductReview.Label.OverallRating" , "Overall rating"));

            
            #line default
            #line hidden
WriteLiteral("</label><br />\r\n            <i");

WriteLiteral(" class=\"fa fa-star fa-2x\"");

WriteLiteral(" ng-repeat=\"1 in pm.trueRating\"");

WriteLiteral(" ng-click=\"pm.configRating($index+1)\"");

WriteLiteral(">&nbsp;</i>\r\n            <i");

WriteLiteral(" class=\"fa fa-star-o  fa-2x\"");

WriteLiteral(" ng-repeat=\"1 in pm.falseRating\"");

WriteLiteral(" ng-click=\"pm.configRating(pm.trueRating.length+$index+1)\"");

WriteLiteral(">&nbsp;</i>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 25 "..\..\Views\Product\_WriteProductReview.cshtml"
       Write(addReview.FormGroupFor(x => x.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label>");

            
            #line 28 "..\..\Views\Product\_WriteProductReview.cshtml"
              Write(LT("ProductReview.Label.Comment" , "Comment"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n            <textarea");

WriteLiteral(" class=\"form-control ng-pristine ng-valid\"");

WriteLiteral(" cols=\"20\"");

WriteLiteral(" id=\"Comment\"");

WriteLiteral(" name=\"Comment\"");

WriteLiteral(" ng-model=\"pm.model.review.comment\"");

WriteLiteral(" placeholder=\"\"");

WriteLiteral(" rows=\"7\"");

WriteLiteral("></textarea>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"control control--checkbox ng-binding\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 33 "..\..\Views\Product\_WriteProductReview.cshtml"
           Write(LT("ProductReview.Label.Recommend" , "Would you recommend this product"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ng-model=\"pm.model.review.isRecommended\"");

WriteLiteral(" class=\"ng-pristine ng-valid\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"control__indicator\"");

WriteLiteral("></div>\r\n            </label>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" ng-repeat=\"section in pm.reviewSections track by $index\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" ng-bind=\"section.sectionName\"");

WriteLiteral("></label>\r\n            <label");

WriteLiteral(" class=\"control control--checkbox ng-binding\"");

WriteLiteral(" ng-repeat=\"option in section.options track by $index\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" ng-bind=\"option.name\"");

WriteLiteral("></span>\r\n                <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=\"ng-pristine ng-valid\"");

WriteLiteral(" ng-model=\"option.isChecked\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"control__indicator\"");

WriteLiteral("></div>\r\n            </label>\r\n        </div> \r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 47 "..\..\Views\Product\_WriteProductReview.cshtml"
       Write(addReview.FormGroupFor(x => x.Nickname));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 50 "..\..\Views\Product\_WriteProductReview.cshtml"
       Write(addReview.FormGroupFor(x => x.Location));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <select");

WriteLiteral(" name=\"gender\"");

WriteLiteral(" tabindex=\"1\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" data-label=\"Title\"");

WriteLiteral(" ng-model=\"pm.model.review.gender\"");

WriteLiteral(">\r\n                <option");

WriteLiteral(" ng-selected=\"pm.model.review.gender == null\"");

WriteLiteral(" value=\"Gender\"");

WriteLiteral(">");

            
            #line 54 "..\..\Views\Product\_WriteProductReview.cshtml"
                                                                               Write(LT("Review.Label.Gender" , "Gender"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                <option");

WriteLiteral(" value=\"Male\"");

WriteLiteral(">Male</option>\r\n                <option");

WriteLiteral(" value=\"Female\"");

WriteLiteral(">Female</option>\r\n                <option");

WriteLiteral(" value=\"Other\"");

WriteLiteral(">Other</option>\r\n            </select>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" class=\"animate btn-primary\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(">\r\n");

WriteLiteral("               ");

            
            #line 63 "..\..\Views\Product\_WriteProductReview.cshtml"
          Write(LT("ProductReview.Label.Submit" , " Submit your Review"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </button>\r\n            <button");

WriteLiteral(" class=\"animate btn-bordered\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" ng-click=\"pm.cancel()\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 66 "..\..\Views\Product\_WriteProductReview.cshtml"
           Write(LT("ProductReview.Label.Cancel" , "Cancel"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </button>\r\n        </div>\r\n    </form>\r\n\r\n</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591