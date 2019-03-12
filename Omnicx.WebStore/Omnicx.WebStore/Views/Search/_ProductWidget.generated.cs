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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Search/_ProductWidget.cshtml")]
    public partial class _Views_Search__ProductWidget_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Search__ProductWidget_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Search\_ProductWidget.cshtml"
  
/*
    Name: Product List View Widget For Grid and List
    Purpose: Show Product All detail in List view
    Structure: /Views/Search/_ProductWidget.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Search/_SearchResultCategory.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"product-container-panel\"");

WriteLiteral(" ng-init=\"product.bulkQty= 1\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" ng-if=\"pm.forDelete\"");

WriteAttribute("href", Tuple.Create(" href=\"", 491), Tuple.Create("\"", 543)
, Tuple.Create(Tuple.Create("", 498), Tuple.Create<System.Object, System.Int32>(Href("~/Account/RemoveWishList/{{product.recordId}}")
, 498), false)
);

WriteLiteral(" title=\"Remove\"");

WriteLiteral(" class=\"remove wishlist-remove\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-trash-o\"");

WriteLiteral("></i></a>\r\n    <div");

WriteLiteral(" class=\"imagePanel\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" ng-href=\"/{{product.slug}}\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"tooltiptext\"");

WriteLiteral(" ng-bind=\"product.title\"");

WriteLiteral("></span>\r\n            <img");

WriteLiteral(" ng-src=\"{{product.image==\'\'?DEFAULT_IMAGE_URL:product.images[0].url}}\"");

WriteLiteral(" alt=\"\"");

WriteLiteral("  class=\"image1 omni-img\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(" sizes=\"(min-width: 768px) 540px, 100vw\"");

WriteLiteral(">\r\n        </a>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"dataPanel\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ribbon-info\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" ng-href=\"/{{product.slug}}\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" ng-bind=\"product.name\"");

WriteLiteral("></span>\r\n            </a>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"name-info\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"prod-list-desc\"");

WriteLiteral("><strong>");

            
            #line 28 "..\..\Views\Search\_ProductWidget.cshtml"
                                            Write(LT("ProductDetail.Label.SKU", "SKU"));

            
            #line default
            #line hidden
WriteLiteral(": </strong><span");

WriteLiteral(" ng-bind=\"product.sku\"");

WriteLiteral("></span></span>            \r\n            <span");

WriteLiteral(" class=\"prod-list-desc\"");

WriteLiteral("><span");

WriteLiteral(" class=\"comment more\"");

WriteLiteral(" id=\"decriptionText\"");

WriteLiteral(" ng-bind=\"product.description\"");

WriteLiteral("></span></span>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"price-info\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-8 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                <h3>\r\n                    <span");

WriteLiteral(" ng-bind=\"(product.price.formatted.withTax)\"");

WriteLiteral("></span>\r\n                    <span");

WriteLiteral(" class=\"sml\"");

WriteLiteral(" ng-bind=\"(product.listPrice.formatted.withTax)\"");

WriteLiteral("></span>\r\n                </h3>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-sm-4 col-xs-4 no-padding quantity-info hidden-xs\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"number\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" ng-model=\"product.bulkQty\"");

WriteLiteral(" min=\"1\"");

WriteLiteral(" placeholder=\"Qty\"");

WriteLiteral(" ng-click=\"pm.onTextFocus($event)\"");

WriteLiteral(" numbers-Only />\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"button-info\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"icon-info\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"see-detail-icon\"");

WriteLiteral(" ng-click=\"pm.productDetail(product.recordId)\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" data-target=\"#product-quick-view-modal\"");

WriteLiteral(" ng-hide=\"pm.quickView\"");

WriteLiteral("></a>\r\n");

            
            #line 45 "..\..\Views\Search\_ProductWidget.cshtml"
                
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Search\_ProductWidget.cshtml"
                 if (SessionContext.CurrentUser != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteLiteral(" class=\"see-wishlist-icon\"");

WriteLiteral(" ng-if=\"product.inWishList==false\"");

WriteLiteral(" ng-click=\"pm.addToWishlist(product.recordId)\"");

WriteLiteral(" ng-hide=\"fromWishList\"");

WriteLiteral("></a>\r\n");

            
            #line 48 "..\..\Views\Search\_ProductWidget.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteLiteral(" class=\"see-wishlist-icon\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" data-target=\"#login-modal\"");

WriteLiteral("></a>\r\n");

            
            #line 52 "..\..\Views\Search\_ProductWidget.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <input");

WriteLiteral(" type=\"number\"");

WriteLiteral(" class=\"form-control hidden-xs\"");

WriteLiteral(" ng-model=\"product.bulkQty\"");

WriteLiteral(" min=\"1\"");

WriteLiteral(" placeholder=\"Qty\"");

WriteLiteral(" ng-click=\"pm.onTextFocus($event)\"");

WriteLiteral(" numbers-Only />\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"action-info hidden-xs\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"animate btn-success\"");

WriteLiteral(" ng-click=\"gm.addToBasket(product.recordId,product.bulkQty,0)\"");

WriteLiteral(" ng-if=\"!pm.isWhislist\"");

WriteLiteral("><span>");

            
            #line 56 "..\..\Views\Search\_ProductWidget.cshtml"
                                                                                                                                     Write(LT("ProductDetail.Label.AddToCart", "Add To Cart"));

            
            #line default
            #line hidden
WriteLiteral("</span></a>\r\n");

            
            #line 57 "..\..\Views\Search\_ProductWidget.cshtml"
                
            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\Search\_ProductWidget.cshtml"
                 if (SessionContext.CurrentUser != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteLiteral(" class=\"animate btn-success\"");

WriteLiteral(" ng-click=\"gm.addToBasket(product.recordId,product.bulkQty,0)\"");

WriteLiteral(" ng-if=\"pm.isWhislist\"");

WriteLiteral("><span>");

            
            #line 59 "..\..\Views\Search\_ProductWidget.cshtml"
                                                                                                                                        Write(LT("ProductDetail.Label.AddToCart", "Add To Cart"));

            
            #line default
            #line hidden
WriteLiteral("</span></a>\r\n");

            
            #line 60 "..\..\Views\Search\_ProductWidget.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n    </div>  \r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
