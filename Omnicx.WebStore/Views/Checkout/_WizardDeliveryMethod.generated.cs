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
    
    #line 12 "..\..\Views\Checkout\_WizardDeliveryMethod.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Checkout/_WizardDeliveryMethod.cshtml")]
    public partial class _Views_Checkout__WizardDeliveryMethod_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Checkout__WizardDeliveryMethod_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Checkout\_WizardDeliveryMethod.cshtml"
  
/*
    Name: Delivery Method
    Purpose: Show All delivery Methods
    Structure: /Views/Checkout/_DeliveryMethod.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Basket/OnePageCheckout.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 wzc--heading--pannel\"");

WriteLiteral(">\r\n            <h4");

WriteLiteral(" class=\"wzc--h5\"");

WriteLiteral(">Delivery Location</h4>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 wzc--address--border\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"form-group no-margin-bottom margin-top-sm\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral("> Location</label>\r\n                <select");

WriteLiteral(" id=\"ck.model.checkout.shippingAddress.countryCode\"");

WriteLiteral(" name=\"title\"");

WriteLiteral(" tabindex=\"1\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" data-label=\"Title\"");

WriteLiteral(" ng-model=\"ck.model.checkout.shippingAddress.countryCode\"");

WriteLiteral(" ng-change=\" ck.errors = false;ck.ValidateDeliveryMethod();\"");

WriteLiteral(">\r\n                    <option");

WriteLiteral(" ng-repeat=\"countries in ck.model.shippingCountries\"");

WriteLiteral(" ng-selected=\"countries.twoLetterIsoCode==ck.model.checkout.shippingAddress.count" +
"ryCode\"");

WriteLiteral(" value=\"{{countries.twoLetterIsoCode}}\"");

WriteLiteral(" ng-bind=\"countries.name\"");

WriteLiteral("></option>\r\n                </select>\r\n            </div>\r\n        </div>\r\n    </" +
"div>\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 wzc--heading--pannel\"");

WriteLiteral(">\r\n            <h5");

WriteLiteral(" class=\"wzc--h5\"");

WriteLiteral(">Select a delivery method </h5>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"row equal-height-thumbnailAcco\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 wzc--address--border\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-6 col-xs-12 equalboxUserMid\"");

WriteLiteral(" ng-repeat=\"method in ck.basket.shippingMethods\"");

WriteLiteral(" ng-show=\"method.countryCode==ck.model.checkout.shippingAddress.countryCode\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 checkout-method\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"control-group\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"control control--radio\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"label-span\"");

WriteLiteral(" ng-bind=\"method.displayName\"");

WriteLiteral("><strong");

WriteLiteral(" class=\"pull-right\"");

WriteLiteral(" ng-bind=\"method.price.formatted.withTax\"");

WriteLiteral("></strong></span>\r\n                            <span");

WriteLiteral(" class=\"label-span-desc\"");

WriteLiteral(" ng-bind=\"method.description\"");

WriteLiteral("></span>\r\n                            <input");

WriteLiteral(" id=\"delivery\"");

WriteLiteral(" name=\"delivery\"");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" value=\"{{method.id}}\"");

WriteLiteral(" class=\"ng-pristine ng-valid\"");

WriteLiteral(" ng-checked=\"method.id==ck.model.checkout.selectedShipping.id;\"");

WriteLiteral(" ng-init=\"ck.getShippingMethod(method,ck.model.checkout.selectedShipping.id)\"");

WriteLiteral(" ng-click=\"ck.selectedDelivery=method;\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"control__indicator\"");

WriteLiteral("></div>\r\n                        </label>\r\n                    </div>\r\n          " +
"      </div>\r\n            </div>\r\n        </div>\r\n\r\n");

            
            #line 51 "..\..\Views\Checkout\_WizardDeliveryMethod.cshtml"
        
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Checkout\_WizardDeliveryMethod.cshtml"
          /*Nominated Days*/
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <div");

WriteLiteral(" class=\"nominate-block-delivery\"");

WriteLiteral(" ng-show=\"ck.showDates == true\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"pull-left margin-top-lg margin-right-xs hidden-xs\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" ng-show=\"ck.prevDate\"");

WriteLiteral(" ng-click=\"ck.getNominatedDelivery(0)\"");

WriteLiteral(" class=\"prev-next-week\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon icon-caret-left icon-3x\"");

WriteLiteral("></i>Prev. Week </button>\r\n            </div>\r\n            <ul");

WriteLiteral(" class=\"nominate-block\"");

WriteLiteral(">\r\n                <!-- ngRepeat: method in ck.nominatedDates -->\r\n              " +
"  <li");

WriteLiteral(" ng-repeat=\"day in ck.nominatedDates\"");

WriteLiteral(" class=\"default-light-bg\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"mobile-pull-left \"");

WriteLiteral("><b");

WriteLiteral(" ng-bind=\"day.dayText\"");

WriteLiteral("></b></div>\r\n                        <div");

WriteLiteral(" class=\"default-bottom-border\"");

WriteLiteral("><span");

WriteLiteral(" ng-bind=\"day.deliveryDate | date:\'dd-MM-yyyy\'\"");

WriteLiteral("></span></div>\r\n\r\n                        <div");

WriteLiteral(" class=\"margin-top-xs\"");

WriteLiteral(" ng-show=\"day.price != null\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"mobile-input\"");

WriteLiteral(">\r\n                                <label");

WriteLiteral(" class=\"control control--radio\"");

WriteLiteral(">\r\n                                    <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"nominatedDelivery\"");

WriteLiteral(" value=\"day.dayText\"");

WriteLiteral(" ng-checked=\"day.dayText==ck.selectedDayText\"");

WriteLiteral(" ng-click=\"ck.selectNominatedDelivery(day)\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"control__indicator\"");

WriteLiteral("></div>\r\n                                </label>\r\n                            </" +
"span>\r\n                            <div");

WriteLiteral(" class=\"price-on-mobile\"");

WriteLiteral("><span");

WriteLiteral(" ng-bind=\"day.price.formatted.withTax\"");

WriteLiteral("></span></div>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"margin-top-xs\"");

WriteLiteral(" ng-show=\"day.price == null\"");

WriteLiteral(">\r\n                            Not Available\r\n                        </div>\r\n   " +
"                 </div>\r\n                </li><!-- end ngRepeat: method in ck.no" +
"minatedDates -->\r\n            </ul>\r\n            <div");

WriteLiteral(" class=\"pull-right margin-top-md hidden-xs\"");

WriteLiteral("><a");

WriteLiteral(" href=\"\"");

WriteLiteral(" ng-click=\"ck.getNominatedDelivery(1)\"");

WriteLiteral(" class=\"prev-next-week\"");

WriteLiteral(">Next Week <i");

WriteLiteral(" class=\"glyphicon icon-caret-right icon-3x\"");

WriteLiteral("></i></a></div>\r\n\r\n        </div>\r\n\r\n");

            
            #line 83 "..\..\Views\Checkout\_WizardDeliveryMethod.cshtml"
        
            
            #line default
            #line hidden
            
            #line 83 "..\..\Views\Checkout\_WizardDeliveryMethod.cshtml"
          /*End N D */
            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n            <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" ng-show=\"ck.errors\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 86 "..\..\Views\Checkout\_WizardDeliveryMethod.cshtml"
           Write(LT("Checkout.Text.SelectDelivery", "Select a Delivery Method"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" ng-show=\"ck.basket.shippingMethods.length==0\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"nodata-customer\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"fa fa-truck\"");

WriteLiteral("></i>\r\n            <h1>");

            
            #line 93 "..\..\Views\Checkout\_WizardDeliveryMethod.cshtml"
           Write(LT("Checkout.Text.SelectDelivery", "Delivery not available. Please select a different country"));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n        </div>\r\n    </div>\r\n    ");

WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591