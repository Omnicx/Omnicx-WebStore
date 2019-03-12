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
    
    #line 1 "..\..\Views\Checkout\_Store.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Checkout/_Store.cshtml")]
    public partial class _Views_Checkout__Store_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Checkout__Store_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"col-xs-12\"");

WriteAttribute("ng-show", Tuple.Create(" ng-show=\"", 59), Tuple.Create("\"", 152)
, Tuple.Create(Tuple.Create("", 69), Tuple.Create("ck.model.checkout.selectedShipping.type", 69), true)
, Tuple.Create(Tuple.Create(" ", 108), Tuple.Create("==", 109), true)
, Tuple.Create(Tuple.Create(" ", 111), Tuple.Create("\'", 112), true)
            
            #line 2 "..\..\Views\Checkout\_Store.cshtml"
, Tuple.Create(Tuple.Create("", 113), Tuple.Create<System.Object, System.Int32>(ShippingMethodTypes.Pickup.ToString()
            
            #line default
            #line hidden
, 113), false)
, Tuple.Create(Tuple.Create("", 151), Tuple.Create("\'", 151), true)
);

WriteLiteral(">\r\n    <form");

WriteLiteral(" name=\"clickCollectForm\"");

WriteLiteral(" role=\"form\"");

WriteLiteral(" class=\"form-horizontal ng-dirty ng-valid ng-valid-required\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"clickCollectContainer\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n                    <h5");

WriteLiteral(" class=\"margin-top-sm margin-bottom-sm checkout-h3\"");

WriteLiteral("> Search For Your Nearest Store </h5>\r\n                </div>\r\n            </div>" +
"\r\n            <div");

WriteLiteral(" class=\"input-group col-sm-6 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" ng-model=\"ck.postCode\"");

WriteLiteral(" placeholder=\"Enter Post/Zip Code\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"input-group-btn\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" class=\"btn btn-orange\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" ng-click=\"ck.searchPhysicalStore(ck.postCode)\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-search\"");

WriteLiteral("></i> Search</button>\r\n                </span>\r\n            </div>\r\n        </div" +
">\r\n    </form>\r\n    <input");

WriteLiteral(" id=\"delivery\"");

WriteLiteral(" name=\"delivery\"");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" value=\"{{method.id}}\"");

WriteLiteral(" class=\"ng-pristine ng-valid\"");

WriteLiteral(" ng-checked=\"method.id==ck.basket.shippingMethodId\"");

WriteLiteral(" ng-click=\"ck.selectedDelivery=method;ck.setShipping(method)\"");

WriteLiteral(">\r\n\r\n    <div");

WriteLiteral(" class=\"col-sm-12 equalboxUserFull\"");

WriteLiteral(" ng-repeat=\"store in ck.stores\"");

WriteLiteral(" ng-show=\"$index<3 || ck.viewMoreStore==false\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 checkout-method\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-xs-12 col-sm-7 no-padding border-right-dsk\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"control-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control control--radio\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"label-span\"");

WriteLiteral(" ng-bind=\"store.name\"");

WriteLiteral("><strong");

WriteLiteral(" class=\"pull-right\"");

WriteLiteral(" ng-bind=\"store.distanceInMiles\"");

WriteLiteral("> Miles</strong></span>\r\n                        <span");

WriteLiteral(" class=\"label-span-desc-address\"");

WriteLiteral(" ng-bind=\"store.address1\"");

WriteLiteral("></span>\r\n                        <span");

WriteLiteral(" class=\"label-span-desc-address\"");

WriteLiteral(" ng-bind=\"store.address2\"");

WriteLiteral("></span>\r\n                        <span");

WriteLiteral(" class=\"label-span-desc-address\"");

WriteLiteral(" ng-bind=\"store.city\"");

WriteLiteral("></span>\r\n                        <span");

WriteLiteral(" class=\"label-span-desc-address\"");

WriteLiteral(" ng-bind=\"store.postCode\"");

WriteLiteral("></span>\r\n                        <strong");

WriteLiteral(" class=\"col-xs-12 col-sm-12 pull-left no-padding label-strong\"");

WriteLiteral(">Available to collect in: <span");

WriteLiteral(" ng-bind=\"store.leadTimeMin\"");

WriteLiteral("></span> <span");

WriteLiteral(" ng-bind=\"store.leadTimeUnit\"");

WriteLiteral("></span></strong>\r\n                        <strong");

WriteLiteral(" class=\"col-xs-12 col-sm-12 pull-left no-padding label-strong\"");

WriteLiteral("><span");

WriteLiteral(" ng-bind=\"store.distanceFromPostCode\"");

WriteLiteral("></span> Miles Away</strong>\r\n                        <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"clickandcollectstore\"");

WriteLiteral(" value=\"{{store}}\"");

WriteLiteral(" ng-click=\"store.phoneNumber=phoneNumber;store.selectedSlot=selectedSlot;ck.showS" +
"lots = $index;ck.setStoreAddress(store)\"");

WriteLiteral(" class=\"menu-item active\"");

WriteLiteral(" ng-bind=\"store.name\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"control__indicator\"");

WriteLiteral("></div>\r\n                    </label>\r\n                </div>\r\n            </div>" +
"\r\n            ");

WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-md-12 text-center\"");

WriteLiteral(" ng-click=\"ck.viewMoreStore=false\"");

WriteLiteral(" ng-show=\"ck.viewMoreStore==true && ck.stores.length>3\"");

WriteLiteral("><a");

WriteLiteral(" href=\"\"");

WriteLiteral(">View More </a></div>\r\n    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding margin-top-sm\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-4 col-xs-12 no-padding\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" ng-model=\"phoneNumber\"");

WriteLiteral(" placeholder=\"Enter Mobile Number\"");

WriteLiteral(" ng-show=\"ck.stores.length > 0\"");

WriteLiteral(">\r\n        </div>\r\n    </div>\r\n\r\n</div>");

        }
    }
}
#pragma warning restore 1591
