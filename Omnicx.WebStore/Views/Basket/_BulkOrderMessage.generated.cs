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
    
    #line 11 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Basket/_BulkOrderMessage.cshtml")]
    public partial class _Views_Basket__BulkOrderMessage_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Basket__BulkOrderMessage_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
  
/*
    Name: Bulk Order Listing
    Purpose: Show Item lines of added items using Quick order pad
    Structure: /Views/Basket/_BulkOrderMessage.cshtml
    Contains (Partial Views Used):
    Contained In (Where we Use this View):
        a-/Views/Shared/_HeaderBasketView.cshtml 
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 12 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
  
    ViewBag.Title = "Bulk Order Message";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"modal fade\"");

WriteLiteral(" id=\"bulkOrderMessage\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-labelledby=\"myModalLabel\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"modal-dialog modal-lg\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(">");

            
            #line 21 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
                                    Write(LT("Header.Text.UserBasket", "Quick Order Basket"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</button>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(" ng-init=\"gm.format2=false\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                        <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger text-left\"");

WriteLiteral(" ng-show=\"gm.errorMessage\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i><span");

WriteLiteral(" ng-bind=\"gm.errorMessage\"");

WriteLiteral("></span>\r\n                        </div>\r\n                        <div");

WriteLiteral(" ng-show=\"gm.stockUnavailable\"");

WriteLiteral(">\r\n                            <h3>");

            
            #line 31 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
                           Write(LT("YourBag.Message.stockUnavailable", "0 Product(s) Added to Cart"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                        </div>\r\n                        <div");

WriteLiteral(" ng-show=\"!gm.stockUnavailable && !gm.basketMessage\"");

WriteLiteral(">\r\n                            <h3>");

            
            #line 34 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
                           Write(LT("YourBag.Message.Success", "All Product(s) Added to Cart"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                        </div>\r\n                        <div");

WriteLiteral(" ng-show=\"gm.basketMessage && !gm.stockUnavailable\"");

WriteLiteral(">\r\n                            <h3>");

            
            #line 37 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
                           Write(LT("YourBag.Message.BasketMessage", "Some Items are added to cart"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                        </div>\r\n                    </div>\r\n              " +
"  </div>\r\n                <div");

WriteLiteral(" class=\"container-fluid max-350\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-xs-12\"");

WriteLiteral(" ng-show=\"gm.basketMessage\"");

WriteLiteral(">\r\n                            <h4");

WriteLiteral(" class=\"unavail-product\"");

WriteLiteral("><span");

WriteLiteral(" ng-bind=\"gm.notFoundLength\"");

WriteLiteral(" ng-if=\"gm.notFoundLength != 0\"");

WriteLiteral("></span>");

            
            #line 44 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
                                                                                                                           Write(LT("YourBag.Message.NotAddToCart", " Product(s) Below Not Added to Cart."));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                            <h5>");

            
            #line 45 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
                           Write(LT("YourBag.Message.NotValid", "The quantity or stockcode are not valid."));

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n                            <p");

WriteLiteral(" class=\"padding-left20\"");

WriteLiteral("><strong>Item # <span");

WriteLiteral(" ng-bind=\"gm.basketMessage\"");

WriteLiteral("></span></strong></p>\r\n                        </div>\r\n                    </div>" +
"\r\n                    ");

WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"col-md-12 clearfix\"");

WriteLiteral(" id=\"basket\"");

WriteLiteral(" ng-show=\"gm.basketResponse.lineItems.length>0 && !gm.stockUnavailable && !gm.bas" +
"ketMessage \"");

WriteLiteral(">\r\n                        <form");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12  no-padding itemBorder\"");

WriteLiteral(" ng-repeat=\"items in gm.basketResponse.lineItems\"");

WriteLiteral(" ng-if=\"items.parentProductId == gm.emptyGuid\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"no-border\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"col-xs-3 col-sm-1 no-padding-left\"");

WriteLiteral(">\r\n                                        <a");

WriteLiteral(" href=\"/{{items.slug}}\"");

WriteLiteral(">\r\n                                            <img");

WriteLiteral(" ng-src=\"{{items.image}}\"");

WriteLiteral(" class=\"img-responsive\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(">\r\n                                        </a>\r\n                                " +
"    </div>\r\n                                    <div");

WriteLiteral(" class=\"col-xs-9 col-sm-11 no-padding\"");

WriteLiteral(" ng-if=\"items.parentProductId == gm.emptyGuid\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"col-xs-11 col-sm-11 no-padding\"");

WriteLiteral(">\r\n                                            <a");

WriteLiteral(" class=\"basket-item\"");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(" ng-bind=\"items.name\"");

WriteLiteral("></a>\r\n                                            <span");

WriteLiteral(" class=\"basket-price-mob\"");

WriteLiteral(" ng-bind=\"items.price.formatted.withTax\"");

WriteLiteral("></span>\r\n                                        </div>\r\n                       " +
"                 <div");

WriteLiteral(" class=\"col-xs-1 col-sm-1 no-padding text-right\"");

WriteLiteral(">\r\n                                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" title=\"Remove\"");

WriteLiteral(" class=\"remove pull-right\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-trash-o\"");

WriteLiteral(" ng-click=\"gm.addToBasket( items.productId,0,items.displayOrder,gm.model)\"");

WriteLiteral("></i></a>\r\n                                        </div>\r\n                      " +
"                  <div");

WriteLiteral(" class=\"col-xs-12 col-sm-12 no-padding priceBorder\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"col-xs-6 col-sm-6 no-padding\"");

WriteLiteral(">\r\n                                                <div");

WriteLiteral(" class=\"qty qty-changer\"");

WriteLiteral(">\r\n                                                    <fieldset");

WriteLiteral(" class=\"qtychanger\"");

WriteLiteral(">\r\n                                                        <button");

WriteLiteral(" class=\"btn-qty\"");

WriteLiteral(" ng-init=\"oldQty=items.qty\"");

WriteLiteral(" ng-click=\"gm.addToBasket(items.productId,-1,items.displayOrder)\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-minus\"");

WriteLiteral(" title=\"Remove\"");

WriteLiteral("></i></button>\r\n                                                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" ng-mousedown=\"oldQty=items.qty\"");

WriteLiteral(" ng-click=\"gm.onTextFocus($event)\"");

WriteLiteral(" ng-model=\"items.qty\"");

WriteLiteral(" value=\"{{items.qty}}\"");

WriteLiteral(" class=\"cart-text form-control\"");

WriteLiteral(" ng-blur=\"gm.updateQtyAndAdd(items.productId,items.qty,oldQty,items.displayOrder)" +
"\"");

WriteLiteral(" numbers-Only");

WriteLiteral(" name=\"qty\"");

WriteLiteral(" ");

WriteLiteral(">\r\n                                                        <button");

WriteLiteral(" class=\"btn-qty\"");

WriteLiteral(" ng-click=\"gm.addToBasket(items.productId,1,items.displayOrder)\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-plus\"");

WriteLiteral(" title=\"Add\"");

WriteLiteral("></i></button>\r\n                                                    </fieldset>\r\n" +
"                                                </div>\r\n                        " +
"                    </div>\r\n                                            <div");

WriteLiteral(" class=\"col-xs-6 col-sm-6 no-padding text-right\"");

WriteLiteral(">\r\n                                                <span");

WriteLiteral(" class=\"basket-price-mob-strong\"");

WriteLiteral(" ng-bind=\"items.totalPrice.formatted.withTax\"");

WriteLiteral("></span>\r\n                                            </div>\r\n                   " +
"                     </div>\r\n                                        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 padding-sm\"");

WriteLiteral(">\r\n                                                <strong");

WriteLiteral(" class=\"text-orange\"");

WriteAttribute("ng-show", Tuple.Create(" ng-show=\"", 6289), Tuple.Create("\"", 6372)
, Tuple.Create(Tuple.Create("", 6299), Tuple.Create("items.displayInBasket", 6299), true)
, Tuple.Create(Tuple.Create(" ", 6320), Tuple.Create("&&", 6321), true)
, Tuple.Create(Tuple.Create(" ", 6323), Tuple.Create("items.itemType", 6324), true)
, Tuple.Create(Tuple.Create(" ", 6338), Tuple.Create("==", 6339), true)
            
            #line 83 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
                                               , Tuple.Create(Tuple.Create("", 6341), Tuple.Create<System.Object, System.Int32>(ItemTypes.Bundle.GetHashCode()
            
            #line default
            #line hidden
, 6341), false)
);

WriteLiteral(">");

            
            #line 83 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
                                                                                                                                                           Write(LT("YourBag.Text.IncludeComponents", "Included Components:"));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n                                                <div");

WriteLiteral(" class=\"row component-row\"");

WriteLiteral(" ng-repeat=\"bundle in gm.basketResponse.lineItems\"");

WriteLiteral(" ng-if=\"bundle.parentProductId == items.productId\"");

WriteLiteral(" ng-show=\"items.displayInBasket\"");

WriteLiteral(">\r\n                                                    <div");

WriteLiteral(" class=\"col-sm-9 col-xs-9 no-padding\"");

WriteLiteral(">\r\n                                                        <a");

WriteLiteral(" class=\"small-cart-name\"");

WriteLiteral(" ng-href=\"/{{bundle.slug}}\"");

WriteLiteral(" ng-bind=\"bundle.name\"");

WriteLiteral("></a>\r\n                                                    </div>\r\n              " +
"                                      <div");

WriteLiteral(" class=\"col-sm-3 col-xs-3 no-padding text-right\"");

WriteLiteral(">\r\n                                                        <strong>");

            
            #line 89 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
                                                           Write(LT("YourBag.Text.Qty", "Qty:"));

            
            #line default
            #line hidden
WriteLiteral(" </strong><span");

WriteLiteral(" ng-bind=\"bundle.qty\"");

WriteLiteral(@"></span>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    ");

WriteLiteral("\r\n                                    ");

WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n   " +
"                     </form>\r\n                    </div>\r\n                </div>" +
"\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-6 margin-top-md\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral("><strong>");

            
            #line 128 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
                                            Write(LT("YourBag.Text.YourHave", "You currently have "));

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" ng-bind=\"gm.basketResponse.lineItems.length\"");

WriteLiteral("></span>");

            
            #line 128 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
                                                                                                                                                         Write(LT("YourBag.Text.YourBag", " Items in Your Bag"));

            
            #line default
            #line hidden
WriteLiteral("</strong></p>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-6 no-padding\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" class=\"animate btn-bordered\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(">");

            
            #line 131 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
                                                                            Write(LT("Header.Link.Shopping", "Continue Shopping"));

            
            #line default
            #line hidden
WriteLiteral(" <i");

WriteLiteral(" class=\"fa fa-caret-right\"");

WriteLiteral("></i></a>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 10380), Tuple.Create("\"", 10417)
            
            #line 132 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
, Tuple.Create(Tuple.Create("", 10387), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "Basket")
            
            #line default
            #line hidden
, 10387), false)
);

WriteLiteral(" class=\"animate btn-primary\"");

WriteLiteral(">");

            
            #line 132 "..\..\Views\Basket\_BulkOrderMessage.cshtml"
                                                                                    Write(LT("Header.Link.ViewCart", "View Cart"));

            
            #line default
            #line hidden
WriteLiteral(" <i");

WriteLiteral(" class=\"fa fa-caret-right\"");

WriteLiteral("></i></a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>" +
"\r\n</div>");

        }
    }
}
#pragma warning restore 1591
