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
    
    #line 18 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 21 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 20 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    #line 19 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
    using Omnicx.WebStore.Models.Common;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Checkout/WizardCheckoutBilling.cshtml")]
    public partial class _Views_Checkout_WizardCheckoutBilling_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<CheckoutViewModel>
    {
        public _Views_Checkout_WizardCheckoutBilling_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
  
/*
    Name: Standard Checkout (Steps)
    Purpose: Standard Checkout for steps to process
    Structure: /Views/Checkout/StandardCheckout.cshtml
    Contains (Partial Views Used):
        a-/Views/Shared/_OpcLayout.cshtml                   (For Base Structure)
        b-/Views/Checkout/_CheckoutDeliveryAddress.cshtml   (Select Delivery Address)
        c-/Views/Checkout/_CheckoutDeliveryMethod.cshtml    (Select Delivery Method)
        d-/Views/Checkout/_CheckoutPaymentMethod.cshtml     (Select Payment Method)
        e-/Views/Checkout/_CheckoutOrderReview.cshtml       (Complete Overview of order with all selected items)
        f-/Views/Checkout/_GuestRegistration.cshtml         (Guest Checkout or Registration)

    Contained In (Where we Use this View):
        a-/Views/Basket/Index.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 23 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
  
    ViewBag.Title = @LT("Checkout.Title.Checkout", "Checkout");
    var checkoutForm = Html.Angular().ModelFor("ck.model");
    Layout = "~/Views/Shared/_OpcLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("bodyClass", () => {

WriteLiteral("class=\"bg-white\"");

});

            
            #line 29 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
  

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"row m--gray--panel\"");

WriteLiteral(" ng-controller=\"checkoutCtrl as ck\"");

WriteLiteral(" ng-cloak>\r\n");

            
            #line 31 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
        
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
         if (Model.Checkout != null && Model.Checkout.Basket.GrandTotal.Raw.WithTax > 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 m--fixed--steps\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"container no-padding\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"m--step\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"number\"");

WriteLiteral(">");

            
            #line 37 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                                           Write(LT("MyAccount.Text.Number", "1"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                            <div");

WriteLiteral(" class=\"step--name\"");

WriteLiteral(">");

            
            #line 38 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                                               Write(LT("MyAccount.Text.Name", "Login"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"m--step\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"number\"");

WriteLiteral(">");

            
            #line 41 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                                           Write(LT("MyAccount.Text.Number", "2"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                            <div");

WriteLiteral(" class=\"step--name\"");

WriteLiteral(">");

            
            #line 42 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                                               Write(LT("MyAccount.Text.Name", "Delivery"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"m--step active\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"number\"");

WriteLiteral(">");

            
            #line 45 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                                           Write(LT("MyAccount.Text.Number", "3"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                            <div");

WriteLiteral(" class=\"step--name\"");

WriteLiteral(">");

            
            #line 46 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                                               Write(LT("MyAccount.Text.Name", "Billing"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n             " +
"   </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-8 col-xs-12 m--checkout-top\"");

WriteLiteral(" ng-init=\"ck.initMethod();ck.oldBasketPopup();\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                        <h4");

WriteLiteral(" class=\"wzc--h4\"");

WriteLiteral(">");

            
            #line 52 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                                       Write(LT("MyAccount.Text.Login", "Billing & Review"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n");

WriteLiteral("                       ");

            
            #line 55 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                  Write(Html.Partial("~/Views/Checkout/_WizardSummary.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 58 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                   Write(Html.Partial("~/Views/Checkout/_PaymentMethod.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-4 col-xs-12 hidden-xs\"");

WriteLiteral(" style=\"margin-top:56px;\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"whiteContainer summeryBorder no-padding\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 63 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                   Write(Html.Partial("~/Views/Checkout/_WizardOrderSummary.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");

            
            #line 67 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
            
            
            #line default
            #line hidden
            
            #line 67 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
       Write(Html.Partial("~/Views/Checkout/_AddressView.cshtml"));

            
            #line default
            #line hidden
            
            #line 67 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                                                                 
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");

            
            #line 70 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script>\r\n        var signIn = \'");

            
            #line 73 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                  Write(Html.BuildUrlFromExpression<AccountController>(c => c.SignIn(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var converToOrder = \'");

            
            #line 74 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                         Write(Html.BuildUrlFromExpression<CheckoutController>(c => c.ConvertToOrder(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var custGridUrl = \'");

            
            #line 75 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                       Write(Html.BuildUrlFromExpression<AccountController>(c => c.GetCustomerAddress()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var deleteAddressUrl = \'");

            
            #line 76 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                            Write(Html.BuildUrlFromExpression<AccountController>(c => c.DeleteAddress(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var register = \'");

            
            #line 77 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                    Write(Html.BuildUrlFromExpression<AccountController>(c => c.Registration(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var addToBasket = \'");

            
            #line 78 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                       Write(Html.BuildUrlFromExpression<BasketController>(c => c.AddtoBasket(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var removePromoCode = \'");

            
            #line 79 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                           Write(Html.BuildUrlFromExpression<BasketController>(c => c.RemovePromoCode("","")));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var searchPhysicalStore = \'");

            
            #line 80 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                               Write(Html.BuildUrlFromExpression<CheckoutController>(c => c.GetClickAndCollectOptions(null, null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var nominatedDelivery = \'");

            
            #line 81 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                             Write(Html.BuildUrlFromExpression<CheckoutController>(c => c.GetNominatedDelivery(null,null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var guestCheckout = \'");

            
            #line 82 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                         Write(Html.BuildUrlFromExpression<CheckoutController>(c => c.GuestCheckout(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var validateGuestPassword = \'");

            
            #line 83 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                                 Write(Html.BuildUrlFromExpression<CheckoutController>(c => c.ValidateGuestPassword(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var addProductToWishlist = \'");

            
            #line 84 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                                Write(Html.BuildUrlFromExpression<CheckoutController>(c => c.AddProductToWishlist("")));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var removeWishList = \'");

            
            #line 85 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                          Write(Html.BuildUrlFromExpression<CheckoutController>(c => c.RemoveWishList("",true)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var validateLoginPassword = \'");

            
            #line 86 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                                 Write(Html.BuildUrlFromExpression<AccountController>(c => c.SignIn(null)));

            
            #line default
            #line hidden
WriteLiteral(@"';
        window.app.constant('checkoutConfig',{
            signIn : signIn,
            converToOrder : converToOrder,
            custGridUrl: custGridUrl,
            deleteAddressUrl :deleteAddressUrl,
            register : register,
            addToBasket: addToBasket,
            removePromoCode : removePromoCode,
            searchPhysicalStore : searchPhysicalStore,
            nominatedDelivery : nominatedDelivery,
            guestCheckout : guestCheckout,
            validateGuestPassword : validateGuestPassword,
            addProductToWishlist : addProductToWishlist,
            removeWishList : removeWishList,
            validateLoginPassword : validateLoginPassword
        });
        window.app.constant('model', ");

            
            #line 103 "..\..\Views\Checkout\WizardCheckoutBilling.cshtml"
                                Write(Html.JsonFor(Model));

            
            #line default
            #line hidden
WriteLiteral(");\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
