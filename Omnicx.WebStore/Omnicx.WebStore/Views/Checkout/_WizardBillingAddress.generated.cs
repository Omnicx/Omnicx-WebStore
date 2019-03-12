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
    
    #line 11 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    #line 12 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Checkout/_WizardBillingAddress.cshtml")]
    public partial class _Views_Checkout__WizardBillingAddress_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Commerce.AddressModel>
    {
        public _Views_Checkout__WizardBillingAddress_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
  
/*
    Name: Billing Address
    Purpose: Show Billing Address Form
    Structure: /Views/Checkout/_BillingAddress.cshtml
    Contains (Partial Views Used):
    Contained In (Where we Use this View):
        a-/Views/Basket/OnePageCheckout.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 14 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
  
    var addressForm = Html.Angular().ModelFor("ck.model.checkout.billingAddress" + ViewData["prefix"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<form");

WriteLiteral(" role=\"form\"");

WriteAttribute("name", Tuple.Create(" name=\"", 600), Tuple.Create("\"", 639)
, Tuple.Create(Tuple.Create("", 607), Tuple.Create("billingForm", 607), true)
            
            #line 18 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
, Tuple.Create(Tuple.Create("", 618), Tuple.Create<System.Object, System.Int32>(ViewData["prefix"]
            
            #line default
            #line hidden
, 618), false)
);

WriteLiteral(" novalidate>\r\n    <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 wzc--heading--pannel border-bottom\"");

WriteLiteral(">\r\n                <h5");

WriteLiteral(" class=\"wzc--h5\"");

WriteLiteral(">");

            
            #line 22 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
                               Write(LT("Checkout.Label.BillingAddress", "Billing Address"));

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"row wzc--address--border\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteAttribute("ng-show", Tuple.Create(" ng-show=\"", 1000), Tuple.Create("\"", 1093)
, Tuple.Create(Tuple.Create("", 1010), Tuple.Create("ck.model.checkout.selectedShipping.type", 1010), true)
, Tuple.Create(Tuple.Create(" ", 1049), Tuple.Create("==", 1050), true)
, Tuple.Create(Tuple.Create(" ", 1052), Tuple.Create("\'", 1053), true)
            
            #line 26 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
  , Tuple.Create(Tuple.Create("", 1054), Tuple.Create<System.Object, System.Int32>(ShippingMethodTypes.Pickup.ToString()
            
            #line default
            #line hidden
, 1054), false)
, Tuple.Create(Tuple.Create("", 1092), Tuple.Create("\'", 1092), true)
);

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"control control--checkbox ng-binding\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 30 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
                       Write(LT("Checkout.Label.SameAs", "Billing Address Same As"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 30 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
                                                                               Write(LT("Checkout.Label.BillingAdd", "Delivery Address"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <input");

WriteAttribute("id", Tuple.Create(" id=\"", 1444), Tuple.Create("\"", 1477)
, Tuple.Create(Tuple.Create("", 1449), Tuple.Create("billing", 1449), true)
            
            #line 31 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
, Tuple.Create(Tuple.Create("", 1456), Tuple.Create<System.Object, System.Int32>(ViewData["prefix"]
            
            #line default
            #line hidden
, 1456), false)
);

WriteLiteral(" name=\"billing\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ng-model=\"ck.sameAsBillAddress\"");

WriteLiteral(" class=\"ng-pristine ng-valid\"");

WriteLiteral(" ng-click=\"ck.setShipAddress(ck.sameAsBillAddress)\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"control__indicator\"");

WriteLiteral("></div>\r\n                        </label>\r\n                    </div>\r\n          " +
"      </div>\r\n            </div>\r\n            <div");

WriteLiteral(" ng-show=\"!ck.sameAsBillAddress\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"row margin-top-lg\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-6 col-md-4 col-lg-4\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" ng-class=\"vm.getValidationClass()\"");

WriteLiteral(" form-group-validation=\"Title\"");

WriteLiteral(">\r\n                                <label");

WriteLiteral(" for=\"Title\"");

WriteLiteral(" class=\"control-label ng-scope\"");

WriteLiteral(">");

            
            #line 42 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
                                                                             Write(LT("MyAccount.Text.Title", "Title"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <select");

WriteLiteral(" name=\"Title\"");

WriteLiteral(" tabindex=\"1\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" data-label=\"Title\"");

WriteLiteral(" ng-model=\"ck.model.checkout.billingAddress.title\"");

WriteLiteral(" ");

WriteLiteral(">\r\n                                    <option");

WriteLiteral(" ng-selected=\"ck.model.checkout.billingAddress.title == null\"");

WriteLiteral(" value=\"\"");

WriteLiteral(">");

            
            #line 44 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
                                                                                                             Write(LT("MyAccount.Text.Title", "Title"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                    <option");

WriteLiteral(" value=\"Miss\"");

WriteLiteral(">Miss</option>\r\n                                    <option");

WriteLiteral(" value=\"Mr\"");

WriteLiteral(">Mr</option>\r\n                                    <option");

WriteLiteral(" value=\"Mrs\"");

WriteLiteral(">Mrs</option>\r\n                                </select>\r\n                       " +
"     </div>\r\n                        </div>\r\n                    </div>\r\n       " +
"         </div>\r\n                <!-- /.row -->\r\n\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 58 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
                       Write(addressForm.FormGroupFor(x => x.FirstName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 63 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
                       Write(addressForm.FormGroupFor(x => x.LastName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </d" +
"iv>\r\n                <!-- /.row -->\r\n\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 72 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
                       Write(addressForm.FormGroupFor(x => x.Address1));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 77 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
                       Write(addressForm.FormGroupFor(x => x.Address2));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </d" +
"iv>\r\n                <!-- /.row -->\r\n\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-6 col-md-3\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 86 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
                       Write(addressForm.FormGroupFor(x => x.City));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" class=\"col-sm-6 col-md-3\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 91 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
                       Write(addressForm.FormGroupFor(x => x.PostCode));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" class=\"col-sm-6 col-md-3\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 96 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
                       Write(addressForm.FormGroupFor(x => x.State));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
"\r\n                    <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 102 "..\..\Views\Checkout\_WizardBillingAddress.cshtml"
                       Write(addressForm.FormGroupFor(x => x.PhoneNo));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </d" +
"iv>\r\n                <!-- /.row -->\r\n            </div>\r\n        </div>\r\n    </d" +
"iv>\r\n</form>");

        }
    }
}
#pragma warning restore 1591
