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
    
    #line 14 "..\..\Views\Checkout\_AddressView.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    #line 13 "..\..\Views\Checkout\_AddressView.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    #line 15 "..\..\Views\Checkout\_AddressView.cshtml"
    using Omnicx.WebStore.Models.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Checkout/_AddressView.cshtml")]
    public partial class _Views_Checkout__AddressView_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Checkout__AddressView_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Checkout\_AddressView.cshtml"
  
/*
    Name: Address Book
    Purpose: Show Logged in User all Address
    Structure: /Views/Checkout/_AddressView.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Basket/OnePageCheckout.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\Views\Checkout\_AddressView.cshtml"
  
    var customerAddressForm = Html.Angular().ModelFor("am.model");
    var userRole = SessionContext.CurrentUserRole;


            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"modal fade in\"");

WriteLiteral(" id=\"userAddress-modal\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"modal-dialog modal-lg\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">×</span><span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 25 "..\..\Views\Checkout\_AddressView.cshtml"
                                                                                                                           Write(LT("Checkout.Button.Close", "Close"));

            
            #line default
            #line hidden
WriteLiteral("</span></button>\r\n                <h4");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(" ng-show=\"ck.addressText==\'delivery\'\"");

WriteLiteral(">");

            
            #line 26 "..\..\Views\Checkout\_AddressView.cshtml"
                                                                        Write(LT("Checkout.Label.SelectDeliveryAddress", "Select your delivery address"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                <h4");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(" ng-show=\"ck.addressText==\'billing\'\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\Checkout\_AddressView.cshtml"
                                                                       Write(LT("Checkout.Label.SelectBillingAddress", "Select your billing address"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal-body no-padding-top no-padding-bottom\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"row max-65\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 addressBar no-padding\"");

WriteLiteral(" ng-repeat=\"add in ck.userAddresses track by $index\"");

WriteLiteral(" ng-if=\"ck.addressText!=\'delivery\' || add.countryCode==ck.model.checkout.shipping" +
"Address.countryCode\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" id=\"address{{$index}}\"");

WriteLiteral(" name=\"address\"");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" class=\"expand-toggle\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"address{{$index}}\"");

WriteLiteral(" class=\"addressBook\"");

WriteLiteral(" ng-click=\"ck.address=add;ck.addId=add.id\"");

WriteLiteral(" ng-class=\"{\'active\' : ck.address.id == add.id}\"");

WriteLiteral(">\r\n                            <p");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("><span");

WriteLiteral(" class=\"pull-left margin-right-md\"");

WriteLiteral("><strong");

WriteLiteral(" ng-bind=\"add.firstName\"");

WriteLiteral("></strong>&nbsp;<strong");

WriteLiteral(" ng-bind=\"add.lastName\"");

WriteLiteral("></strong></span>&nbsp;&nbsp;<i");

WriteLiteral(" class=\"fa fa-phone\"");

WriteLiteral("></i>&nbsp;<strong");

WriteLiteral(" ng-bind=\"add.phoneNo\"");

WriteLiteral("></strong></p>\r\n                            <p");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("><span");

WriteLiteral(" ng-bind=\"add.companyName\"");

WriteLiteral("></span> &nbsp;<span");

WriteLiteral(" ng-bind=\"add.address1\"");

WriteLiteral("></span>,<span");

WriteLiteral(" ng-bind=\"add.city\"");

WriteLiteral("></span>,&nbsp;<span");

WriteLiteral(" ng-bind=\"add.postCode\"");

WriteLiteral("></span>,&nbsp;<span");

WriteLiteral(" ng-bind=\"add.country\"");

WriteLiteral("></span></p>\r\n                        </label>\r\n                    </div>\r\n     " +
"           </div>                \r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-12 col-lg-12 text-right\"");

WriteLiteral(">\r\n");

            
            #line 43 "..\..\Views\Checkout\_AddressView.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 43 "..\..\Views\Checkout\_AddressView.cshtml"
                         if (userRole == (CompanyUserRole.None) || userRole == (CompanyUserRole.Admin))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" class=\"animate btn-default\"");

WriteLiteral(" ng-click=\"ck.changeAddress(ck.addressText,\'new\')\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-caret-left\"");

WriteLiteral("></i> Add New Address</a>\r\n");

            
            #line 46 "..\..\Views\Checkout\_AddressView.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteLiteral(" class=\"animate btn-primary\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" ng-click=\"ck.changeAddress(ck.addressText,ck.address)\"");

WriteLiteral(">");

            
            #line 47 "..\..\Views\Checkout\_AddressView.cshtml"
                                                                                                                              Write(LT("Checkout.Button.Continue", "Continue"));

            
            #line default
            #line hidden
WriteLiteral(" <i");

WriteLiteral(" class=\"fa fa-caret-right\"");

WriteLiteral("></i></a>\r\n                    </div>\r\n                </div>\r\n            </div>" +
"\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
