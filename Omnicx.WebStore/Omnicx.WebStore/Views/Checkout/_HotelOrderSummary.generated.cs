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
    
    #line 12 "..\..\Views\Checkout\_HotelOrderSummary.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Checkout/_HotelOrderSummary.cshtml")]
    public partial class _Views_Checkout__HotelOrderSummary_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Checkout__HotelOrderSummary_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Checkout\_HotelOrderSummary.cshtml"
  
/*
    Name: Order Summery
    Purpose: Contains Order item Lines, Promotion panel and Order Amount Information
    Structure: /Views/Checkout/_OrderSummary.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Basket/OnePageCheckout.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"summery-box\"");

WriteLiteral(" id=\"order-summary\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 border-top\"");

WriteLiteral(">\r\n        <h4");

WriteLiteral(" class=\"wzc--h4\"");

WriteLiteral("> ");

            
            #line 16 "..\..\Views\Checkout\_HotelOrderSummary.cshtml"
                        Write(LT("Checkout.Label.OrderSummery", "Order Summery"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 19 "..\..\Views\Checkout\_HotelOrderSummary.cshtml"
   Write(Html.Partial("~/Views/Checkout/_WizardSubscriptionProductSummary.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 22 "..\..\Views\Checkout\_HotelOrderSummary.cshtml"
   Write(Html.Partial("~/Views/Checkout/_WizardProductSummary.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 border-top\"");

WriteLiteral(">\r\n        <h4");

WriteLiteral(" class=\"wzc--h4\"");

WriteLiteral("> ");

            
            #line 25 "..\..\Views\Checkout\_HotelOrderSummary.cshtml"
                        Write(LT("Checkout.Label.PaymentSummery", "Payment Summery"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n    </div>    \r\n    <p");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" class=\"text-muted padding-sm label-span-desc\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\Checkout\_HotelOrderSummary.cshtml"
                                                                   Write(LT("Checkout.Text.ShippingInfo", "Shipping and additional costs are calculated based on the values you have entered"));

            
            #line default
            #line hidden
WriteLiteral(".</p>\r\n    <div");

WriteLiteral(" class=\"table-responsive\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"table no-margin-top\"");

WriteLiteral(">\r\n            <tbody>\r\n                <tr>\r\n                    <td>");

            
            #line 32 "..\..\Views\Checkout\_HotelOrderSummary.cshtml"
                   Write(LT("Checkout.Label.Subtotal", "Subtotal"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <th");

WriteLiteral(" ng-bind=\"ck.basket.subTotal.formatted.withTax\"");

WriteLiteral(" class=\"text-right\"");

WriteLiteral("></th>\r\n                </tr>\r\n                <tr>\r\n                    <td>");

            
            #line 36 "..\..\Views\Checkout\_HotelOrderSummary.cshtml"
                   Write(LT("Checkout.Label.ShippingCharge", "Shipping and handling"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <th");

WriteLiteral(" ng-bind=\"ck.basket.shippingCharge.formatted.withTax\"");

WriteLiteral(" class=\"text-right\"");

WriteLiteral("></th>\r\n                </tr>\r\n                ");

WriteLiteral("\r\n                <tr>\r\n                    <td>");

            
            #line 44 "..\..\Views\Checkout\_HotelOrderSummary.cshtml"
                   Write(LT("Checkout.Label.Discount", "Discount"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <th");

WriteLiteral(" ng-bind=\"ck.basket.discount.formatted.withTax\"");

WriteLiteral(" class=\"text-right\"");

WriteLiteral("></th>\r\n                </tr>\r\n                <tr");

WriteLiteral(" ng-show=\"ck.basket.promotionsApplied.length>0\"");

WriteLiteral(" id=\"promoApplied4\"");

WriteLiteral(">\r\n                    <td>Promotions Applied:</td>\r\n                    <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">\r\n                        <ul");

WriteLiteral(" class=\"promo-ul\"");

WriteLiteral(">\r\n                            <li");

WriteLiteral(" class=\"no-padding\"");

WriteLiteral(" ng-repeat=\"promotion in ck.basket.promotionsApplied\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" class=\"\"");

WriteLiteral(" title=\"Remove\"");

WriteLiteral(" ng-click=\"ck.removePromoCode(ck.basket.id,promotion.promoCode)\"");

WriteLiteral("><span");

WriteLiteral(" ng-bind=\"promotion.name\"");

WriteLiteral("></span> <i");

WriteLiteral(" class=\"fa fa-remove\"");

WriteLiteral("></i></a>\r\n                            </li>\r\n                        </ul>\r\n    " +
"                </th>\r\n                </tr>\r\n                <tr");

WriteLiteral(" class=\"total\"");

WriteLiteral(">\r\n                    <td>");

            
            #line 58 "..\..\Views\Checkout\_HotelOrderSummary.cshtml"
                   Write(LT("Checkout.Label.OrderTotal", "Amount Payable"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <th");

WriteLiteral(" ng-bind=\"ck.basket.grandTotal.formatted.withTax\"");

WriteLiteral(" class=\"text-right\"");

WriteLiteral("></th>\r\n                </tr>\r\n                <tr>\r\n                    <td");

WriteLiteral(" colspan=\"2\"");

WriteLiteral(" class=\"sml-text\"");

WriteLiteral(" ng-cloak");

WriteAttribute("ng-bind", Tuple.Create(" ng-bind=\"", 3208), Tuple.Create("\"", 3309)
, Tuple.Create(Tuple.Create("", 3218), Tuple.Create("\'", 3218), true)
            
            #line 62 "..\..\Views\Checkout\_HotelOrderSummary.cshtml"
, Tuple.Create(Tuple.Create("", 3219), Tuple.Create<System.Object, System.Int32>(LT("YourBag.Text.IncludingVATof", "including VAT of")
            
            #line default
            #line hidden
, 3219), false)
, Tuple.Create(Tuple.Create("", 3273), Tuple.Create("\'+ck.basket.grandTotal.formatted.tax", 3273), true)
);

WriteLiteral("></td                    \r\n                </tr>\r\n                <tr");

WriteLiteral(" class=\"total\"");

WriteLiteral(" ng-show=\"ck.showRemainingAmount\"");

WriteLiteral(">\r\n                    <td>");

            
            #line 65 "..\..\Views\Checkout\_HotelOrderSummary.cshtml"
                   Write(LT("Checkout.Label.RemainingAmount", "Remaining Amount"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <th");

WriteLiteral(" ng-bind=\"ck.model.checkout.balanceAmount.formatted.withTax\"");

WriteLiteral(" class=\"text-right\"");

WriteLiteral("> </th>\r\n                    ");

WriteLiteral("\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</di" +
"v>");

        }
    }
}
#pragma warning restore 1591
