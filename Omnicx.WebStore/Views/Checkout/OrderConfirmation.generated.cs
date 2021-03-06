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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Checkout/OrderConfirmation.cshtml")]
    public partial class _Views_Checkout_OrderConfirmation_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Commerce.OrderModel>
    {
        public _Views_Checkout_OrderConfirmation_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Checkout\OrderConfirmation.cshtml"
  
/*
    Name: Order Confirmation
    Purpose: Show Order Overview after complete the order
    Structure: /Views/Checkout/OrderConfirmation.cshtml
    Contains (Partial Views Used):
        a-/Views/Shared/_OpcLayout.cshtml                   (For Base Structure)

    Contained In (Where we Use this View):
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..\Views\Checkout\OrderConfirmation.cshtml"
  
    ViewBag.Title = "OrderConfirmation";
    Layout = "~/Views/Shared/_OpcLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"row whiteContainer\"");

WriteLiteral(">\r\n    <h1");

WriteLiteral(" class=\"basket-h1 margin-bottom-lg\"");

WriteLiteral(">");

            
            #line 18 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                      Write(LT("Static.Checkout.PageHeading.OrderConfirmation", "Order Confirmation"));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n    <p");

WriteLiteral(" class=\"bg-success col-lg-12 confirmation-msg margin-top-md\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                              Write(LT("OrderConfirmation.Label.Order", "Order"));

            
            #line default
            #line hidden
WriteLiteral(" <strong>");

            
            #line 19 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                                                                                    Write(Model.OrderNo);

            
            #line default
            #line hidden
WriteLiteral("</strong> ");

            
            #line 19 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                                                                                                            Write(LT("OrderConfirmation.Label.SuccessfullyPlaced", "has been successfully placed and will be with you shortly."));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n    <div");

WriteLiteral(" class=\"col-md-8 col-sm-12 col-xs-12 whiteContainer\"");

WriteLiteral(" id=\"customer-order\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"table-responsive\"");

WriteLiteral(">\r\n");

            
            #line 22 "..\..\Views\Checkout\OrderConfirmation.cshtml"
            
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Checkout\OrderConfirmation.cshtml"
             if (Model.Items.Any(x => !x.IsSubscription))
            {

            
            #line default
            #line hidden
WriteLiteral("                <table");

WriteLiteral(" class=\"table no-margin-bottom basket-table\"");

WriteLiteral(">\r\n                    <thead>\r\n                        <tr>\r\n                   " +
"         <th");

WriteLiteral(" colspan=\"2\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                       Write(LT("MyAccount.Text.Product", "Product"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 28 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                              Write(LT("MyAccount.Text.Qty", "Qty"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 29 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                              Write(LT("MyAccount.Text.Price", "Unit Price"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 30 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                              Write(LT("MyAccount.Text.Discount", "Discount"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 31 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                              Write(LT("MyAccount.Text.GrandTotal", "Grand Total"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n             " +
"       <tbody");

WriteLiteral(" id=\"cart\"");

WriteLiteral(">\r\n");

            
            #line 35 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                         foreach (var item in @Model.Items)
                        {
                            var FinalAmount = item.TotalPrice.Raw.WithTax - item.DiscountAmt.Raw.WithTax;
                            if (!item.IsSubscription)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <tr>\r\n                                    <td>\r\n " +
"                                       <a");

WriteAttribute("ng-href", Tuple.Create(" ng-href=\"", 2280), Tuple.Create("\"", 2301)
, Tuple.Create(Tuple.Create("", 2290), Tuple.Create("/", 2290), true)
            
            #line 42 "..\..\Views\Checkout\OrderConfirmation.cshtml"
, Tuple.Create(Tuple.Create("", 2291), Tuple.Create<System.Object, System.Int32>(item.Slug
            
            #line default
            #line hidden
, 2291), false)
);

WriteLiteral(">\r\n                                            <img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 2353), Tuple.Create("\"", 2373)
            
            #line 43 "..\..\Views\Checkout\OrderConfirmation.cshtml"
, Tuple.Create(Tuple.Create("", 2362), Tuple.Create<System.Object, System.Int32>(item.Image
            
            #line default
            #line hidden
, 2362), false)
);

WriteLiteral(" alt=\"OCX\"");

WriteLiteral(" class=\"omni-img\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(" sizes=\"(min-width: 768px) 540px, 100vw\"");

WriteLiteral(">\r\n                                        </a>\r\n                                " +
"    </td>\r\n                                    <td>\r\n                           " +
"             <a");

WriteLiteral(" class=\"basket-item\"");

WriteAttribute("ng-href", Tuple.Create(" ng-href=\"", 2676), Tuple.Create("\"", 2697)
, Tuple.Create(Tuple.Create("", 2686), Tuple.Create("/", 2686), true)
            
            #line 47 "..\..\Views\Checkout\OrderConfirmation.cshtml"
, Tuple.Create(Tuple.Create("", 2687), Tuple.Create<System.Object, System.Int32>(item.Slug
            
            #line default
            #line hidden
, 2687), false)
);

WriteLiteral(">");

            
            #line 47 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                                                Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                                    </td>\r\n                                " +
"    <td");

WriteLiteral(" align=\"right\"");

WriteLiteral(">");

            
            #line 49 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                 Write(item.Qty);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                    <td");

WriteLiteral(" align=\"right\"");

WriteLiteral(">");

            
            #line 50 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                 Write(item.Price.Formatted.WithTax);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                    <td");

WriteLiteral(" align=\"right\"");

WriteLiteral(">");

            
            #line 51 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                 Write(item.DiscountAmt.Formatted.WithTax);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                    <td");

WriteLiteral(" align=\"right\"");

WriteLiteral(">");

            
            #line 52 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                 Write(item.TotalPrice.Formatted.WithoutTax);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                </tr>\r\n");

            
            #line 54 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                            }
                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n");

            
            #line 59 "..\..\Views\Checkout\OrderConfirmation.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 60 "..\..\Views\Checkout\OrderConfirmation.cshtml"
             if (Model.HasSubscription)
            {

            
            #line default
            #line hidden
WriteLiteral("                <table");

WriteLiteral(" class=\"table no-margin-bottom basket-table\"");

WriteLiteral(">\r\n                    <thead>\r\n                        <tr>\r\n                   " +
"         <th");

WriteLiteral(" colspan=\"2\"");

WriteLiteral(">");

            
            #line 65 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                       Write(LT("MyAccount.Text.Product", "Subscription Products"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n             " +
"       <tbody");

WriteLiteral(" id=\"cart\"");

WriteLiteral(">\r\n");

            
            #line 69 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 69 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                         foreach (var item in @Model.Items)
                        {
                            var FinalAmount = item.TotalPrice.Raw.WithTax - item.DiscountAmt.Raw.WithTax;
                            if (item.IsSubscription)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <tr>\r\n                                    <td>\r\n " +
"                                       <a");

WriteAttribute("ng-href", Tuple.Create(" ng-href=\"", 4073), Tuple.Create("\"", 4094)
, Tuple.Create(Tuple.Create("", 4083), Tuple.Create("/", 4083), true)
            
            #line 76 "..\..\Views\Checkout\OrderConfirmation.cshtml"
, Tuple.Create(Tuple.Create("", 4084), Tuple.Create<System.Object, System.Int32>(item.Slug
            
            #line default
            #line hidden
, 4084), false)
);

WriteLiteral(">\r\n                                            <img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 4146), Tuple.Create("\"", 4166)
            
            #line 77 "..\..\Views\Checkout\OrderConfirmation.cshtml"
, Tuple.Create(Tuple.Create("", 4155), Tuple.Create<System.Object, System.Int32>(item.Image
            
            #line default
            #line hidden
, 4155), false)
);

WriteLiteral(" alt=\"OCX\"");

WriteLiteral(" class=\"omni-img\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(" sizes=\"(min-width: 768px) 540px, 100vw\"");

WriteLiteral(">\r\n                                        </a>\r\n                                " +
"        <span");

WriteLiteral(" class=\"label label-primary label-subscription\"");

WriteLiteral(">Subscription</span>\r\n                                    </td>\r\n                " +
"                    <td>\r\n                                        <a");

WriteLiteral(" class=\"basket-item\"");

WriteAttribute("ng-href", Tuple.Create(" ng-href=\"", 4583), Tuple.Create("\"", 4604)
, Tuple.Create(Tuple.Create("", 4593), Tuple.Create("/", 4593), true)
            
            #line 82 "..\..\Views\Checkout\OrderConfirmation.cshtml"
, Tuple.Create(Tuple.Create("", 4594), Tuple.Create<System.Object, System.Int32>(item.Slug
            
            #line default
            #line hidden
, 4594), false)
);

WriteLiteral(">");

            
            #line 82 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                                                Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                                    </td>\r\n\r\n\r\n                            " +
"    </tr>\r\n");

            
            #line 87 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                            }
                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n");

            
            #line 92 "..\..\Views\Checkout\OrderConfirmation.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-md-4 col-sm-12 col-xs-12 pull-left\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"whiteContainer no-padding\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"summery-box\"");

WriteLiteral(" id=\"order-summary\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"box-header\"");

WriteLiteral(">\r\n                    <h3><i");

WriteLiteral(" class=\"fa fa-shopping-basket\"");

WriteLiteral("></i> ");

            
            #line 99 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                         Write(LT("Checkout.Label.OrderSummary", "Order Summary"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"table-responsive\"");

WriteLiteral(">\r\n                    <table");

WriteLiteral(" class=\"table no-margin-top\"");

WriteLiteral(">\r\n                        <tbody>\r\n                            <tr>\r\n           " +
"                     <td>");

            
            #line 106 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                               Write(LT("MyAccount.Text.OrderSubtotal", "Order Subtotal"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 107 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                  Write(Model.SubTotal.Formatted.WithoutTax);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            </tr>\r\n");

            
            #line 109 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 109 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                             if (Model.HasSubscription && Model.SubscriptionTotal != null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <tr>\r\n                                    <td>");

            
            #line 112 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                   Write(LT("MyAccount.Text.SubscriptionTotal", "Subscription Total"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                    <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 113 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                      Write(Model.SubscriptionTotal.Formatted.WithoutTax);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                </tr>\r\n");

            
            #line 115 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            <tr>\r\n                                <td>");

            
            #line 117 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                               Write(LT("Myaccount.Text.ShippingCharge", "Shipping and handling"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 118 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                  Write(Model.ShippingCharge.Formatted.WithoutTax);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            </tr>\r\n                            <tr>\r\n     " +
"                           <td>");

            
            #line 121 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                               Write(LT("MyAccount.Text.Discount", "Discount"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral("> ");

            
            #line 122 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                   Write(Model.Discount.Formatted.WithTax);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            </tr>\r\n                            <tr>\r\n     " +
"                           <td>");

            
            #line 125 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                               Write(LT("MyAccount.Text.Tax", "Tax"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 126 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                  Write(Model.GrandTotal.Formatted.Tax);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            </tr>\r\n                            <tr");

WriteLiteral(" class=\"total\"");

WriteLiteral(">\r\n                                <td>");

            
            #line 129 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                               Write(LT("MyAccount.Text.Amount", "Total"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 130 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                  Write(Model.GrandTotal.Formatted.WithTax);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            </tr>\r\n                        </tbody>\r\n     " +
"               </table>\r\n                </div>\r\n            </div>\r\n        </d" +
"iv>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"row addresses whiteContainer\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-sm-6 billing-box\"");

WriteLiteral(">\r\n        <h2");

WriteLiteral(" class=\"billing-h2\"");

WriteLiteral(">");

            
            #line 142 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                          Write(LT("MyAccount.Text.BillingAdd", "Billing Address"));

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n        <p><strong>");

            
            #line 143 "..\..\Views\Checkout\OrderConfirmation.cshtml"
              Write(LT("MyAccount.Text.Product", "Name:"));

            
            #line default
            #line hidden
WriteLiteral(" </strong>");

            
            #line 143 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                              Write(Model.BillingAddress.FirstName);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 143 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                                                              Write(Model.BillingAddress.LastName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <p><strong>");

            
            #line 144 "..\..\Views\Checkout\OrderConfirmation.cshtml"
              Write(LT("MyAccount.Text.Product", "Address:"));

            
            #line default
            #line hidden
WriteLiteral(" </strong>");

            
            #line 144 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                                 Write(Model.BillingAddress.Address1);

            
            #line default
            #line hidden
WriteLiteral(" <br />");

            
            #line 144 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                                                                      Write(Model.BillingAddress.Address2);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <p><strong>");

            
            #line 145 "..\..\Views\Checkout\OrderConfirmation.cshtml"
              Write(LT("MyAccount.Text.Product", "City:"));

            
            #line default
            #line hidden
WriteLiteral(" </strong>");

            
            #line 145 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                              Write(Model.BillingAddress.City);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        ");

WriteLiteral("\r\n        <p><strong>");

            
            #line 147 "..\..\Views\Checkout\OrderConfirmation.cshtml"
              Write(LT("MyAccount.Text.Product", "Post Code:"));

            
            #line default
            #line hidden
WriteLiteral(" </strong>");

            
            #line 147 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                                   Write(Model.BillingAddress.PostCode);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <p><strong>");

            
            #line 148 "..\..\Views\Checkout\OrderConfirmation.cshtml"
              Write(LT("MyAccount.Text.Product", "Phone No:"));

            
            #line default
            #line hidden
WriteLiteral(" </strong>");

            
            #line 148 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                                  Write(Model.BillingAddress.PhoneNo);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-sm-6 shipping-box\"");

WriteLiteral(">\r\n        <h2");

WriteLiteral(" class=\"billing-h2\"");

WriteLiteral(">");

            
            #line 151 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                          Write(LT("MyAccount.Text.ShippingAddress", "Shipping Address"));

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n        <p><strong>");

            
            #line 152 "..\..\Views\Checkout\OrderConfirmation.cshtml"
              Write(LT("MyAccount.Text.Product", "Name:"));

            
            #line default
            #line hidden
WriteLiteral(" </strong>");

            
            #line 152 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                              Write(Model.ShippingAddress.FirstName);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 152 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                                                               Write(Model.ShippingAddress.LastName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <p><strong>");

            
            #line 153 "..\..\Views\Checkout\OrderConfirmation.cshtml"
              Write(LT("MyAccount.Text.Product", "Address:"));

            
            #line default
            #line hidden
WriteLiteral(" </strong>");

            
            #line 153 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                                 Write(Model.ShippingAddress.Address1);

            
            #line default
            #line hidden
WriteLiteral(" <br />");

            
            #line 153 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                                                                       Write(Model.ShippingAddress.Address2);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <p><strong>");

            
            #line 154 "..\..\Views\Checkout\OrderConfirmation.cshtml"
              Write(LT("MyAccount.Text.Product", "City:"));

            
            #line default
            #line hidden
WriteLiteral(" </strong>");

            
            #line 154 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                              Write(Model.ShippingAddress.City);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        ");

WriteLiteral("\r\n        <p><strong>");

            
            #line 156 "..\..\Views\Checkout\OrderConfirmation.cshtml"
              Write(LT("MyAccount.Text.Product", "Post Code:"));

            
            #line default
            #line hidden
WriteLiteral(" </strong>");

            
            #line 156 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                                   Write(Model.ShippingAddress.PostCode);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <p><strong>");

            
            #line 157 "..\..\Views\Checkout\OrderConfirmation.cshtml"
              Write(LT("MyAccount.Text.Product", "Phone No:"));

            
            #line default
            #line hidden
WriteLiteral(" </strong>");

            
            #line 157 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                                  Write(Model.ShippingAddress.PhoneNo);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"row margin-bottom-lg\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 text-center\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" href=\"/\"");

WriteLiteral(" class=\"animate btn-default\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-caret-left\"");

WriteLiteral("></i>");

            
            #line 162 "..\..\Views\Checkout\OrderConfirmation.cshtml"
                                                                           Write(LT("DiscoveryClub.Label.ContinueShopping", "Continue Shopping"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
