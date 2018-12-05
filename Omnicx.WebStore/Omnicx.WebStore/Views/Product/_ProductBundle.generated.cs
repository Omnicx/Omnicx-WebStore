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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Product/_ProductBundle.cshtml")]
    public partial class _Views_Product__ProductBundle_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Catalog.ProductDetailModel>
    {
        public _Views_Product__ProductBundle_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Product\_ProductBundle.cshtml"
  
/*
    Name: product Bundle View
    Purpose: Show Bundle product
    Structure: /Views/Product/_ProductBundle.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
     a-/Views/Product/ProductDetail.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"container-fluid no-padding bundle\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"product-headline\"");

WriteLiteral(" ng-bind=\"pm.model.name\"");

WriteLiteral("></h3>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"row margin-top-sm\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-4 col-xs-12\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row animated zoomIn\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 bundle-product-container\"");

WriteLiteral(">\r\n                    <img data-ng-magnify");

WriteLiteral(" image-src=\"{{pm.model.image}}\"");

WriteLiteral(" class=\"img-responsive\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-sm-8 col-xs-12\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row bundle-products\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-3 col-xs-4\"");

WriteLiteral(" ng-repeat=\"productBundle in pm.model.componentProducts\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bundle-image-container\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" ng-href=\"/{{productBundle.slug}}\"");

WriteLiteral(">\r\n                            <img");

WriteLiteral(" ng-src=\"{{productBundle.images[0].url}}\"");

WriteLiteral(" class=\"img-responsive\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(">\r\n                        </a>\r\n                    </div>\r\n                    " +
"<div>\r\n                        <a");

WriteLiteral(" class=\"text-black\"");

WriteLiteral(" ng-href=\"/{{productBundle.slug}}\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" ng-bind=\"productBundle.name\"");

WriteLiteral("></span>\r\n                        </a>\r\n                    </div>\r\n             " +
"       <div");

WriteLiteral(" class=\"bundle-qty\"");

WriteLiteral(">\r\n                        <strong>");

            
            #line 42 "..\..\Views\Product\_ProductBundle.cshtml"
                           Write(LT("ProductDetail.Label.Qty", "Qty"));

            
            #line default
            #line hidden
WriteLiteral(": </strong><span");

WriteLiteral(" ng-bind=\"productBundle.qty\"");

WriteLiteral("></span>\r\n                    </div>\r\n                </div>\r\n            </div>\r" +
"\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"row margin-top-lg\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-4 col-xs-12\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"prod-list-desc\"");

WriteLiteral("><strong>");

            
            #line 52 "..\..\Views\Product\_ProductBundle.cshtml"
                                                    Write(LT("ProductDetail.Label.SKU", "SKU"));

            
            #line default
            #line hidden
WriteLiteral(": </strong><span");

WriteLiteral(" ng-bind=\"pm.model.sku\"");

WriteLiteral("></span></span>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"prod-list-desc\"");

WriteLiteral(" ng-bind=\"pm.model.description\"");

WriteLiteral("></span>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding-right margin-top-md text-left\"");

WriteLiteral(">\r\n                    <h5");

WriteLiteral(" class=\"price-h5\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" ng-bind=\"(pm.model.price.formatted.withoutTax)\"");

WriteLiteral("></span>\r\n                    </h5>\r\n                </div>\r\n            </div>\r\n" +
"            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-3 col-xs-4 margin-top-sm\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"number\"");

WriteLiteral(" id=\"qtyBox\"");

WriteLiteral(" ng-click=\"pm.onTextFocus($event)\"");

WriteLiteral(" ng-model=\"pm.productCount\"");

WriteLiteral(" name=\"qty\"");

WriteLiteral(" autofocus");

WriteLiteral(" class=\"form-control qty-textbox\"");

WriteLiteral(" numbers-Only />\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-9 col-xs-8 text-left no-padding\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"animate btn-default\"");

WriteLiteral(" ng-click=\"gm.addToBasket(pm.model.recordId,pm.productCount,0)\"");

WriteLiteral("><span>");

            
            #line 72 "..\..\Views\Product\_ProductBundle.cshtml"
                                                                                                                   Write(LT("Checkout.Button.AddBundle", "Add Bundle"));

            
            #line default
            #line hidden
WriteLiteral("</span></a>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-4 col-xs-12 no-padding\"");

WriteLiteral(" ng-show=\"pm.model.flags.isFreeDelivery\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" ng-show=\"pm.model.flags.isFreeDelivery\"");

WriteLiteral(" class=\"free-label\"");

WriteLiteral(" ng-cloak>\r\n                        <span");

WriteLiteral(" class=\"free-icon\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-truck\"");

WriteLiteral("></i></span>\r\n                        <span");

WriteLiteral(" class=\"free-text\"");

WriteLiteral("><strong>");

            
            #line 79 "..\..\Views\Product\_ProductBundle.cshtml"
                                                   Write(LT("ProductDetail.Label.FreeDelivery", "Free Delivery"));

            
            #line default
            #line hidden
WriteLiteral("</strong><br /> ");

            
            #line 79 "..\..\Views\Product\_ProductBundle.cshtml"
                                                                                                                           Write(LT("ProductDetail.Label.onthisitem", "on this item"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </label>\r\n                </div>\r\n                <d" +
"iv");

WriteLiteral(" class=\"col-sm-4 col-xs-12 no-padding\"");

WriteLiteral(" ng-if=\"pm.model.freeProducts.length > 0\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" ng-if=\"pm.model.freeProducts.length > 0\"");

WriteLiteral(" class=\"free-label\"");

WriteLiteral(" ng-cloak>\r\n                        <span");

WriteLiteral(" class=\"free-icon\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-gift\"");

WriteLiteral("></i></span>\r\n                        <span");

WriteLiteral(" class=\"free-text\"");

WriteLiteral("><strong>");

            
            #line 85 "..\..\Views\Product\_ProductBundle.cshtml"
                                                   Write(LT("ProductDetail.Label.FreeGift", "Free Gift"));

            
            #line default
            #line hidden
WriteLiteral(" </strong><br /> ");

            
            #line 85 "..\..\Views\Product\_ProductBundle.cshtml"
                                                                                                                    Write(LT("ProductDetail.Label.withthisitem", "with this item"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </label>\r\n                </div>\r\n            </div>" +
"\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591