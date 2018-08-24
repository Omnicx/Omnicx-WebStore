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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/_MobileSideNav.cshtml")]
    public partial class _Views_Account__MobileSideNav_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Account__MobileSideNav_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Account\_MobileSideNav.cshtml"
  
/*
    Name: Site Nav FOr Mobile
    Purpose: List all the Navigation links for Mobile View
    Structure: /Views/Account/_MobileSideNav.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Account/Wishlist.cshtml
        b-/Views/Account/ReturnRequest.cshtml
        c-/Views/Account/ReturnHistory.cshtml
        d-/Views/Account/PasswordChange.cshtml)
        e-/Views/Account/OrderHistory.cshtml
        f-/Views/Account/OrderDetail.cshtml
        g-/Views/Account/MyActivity.cshtml
        h-/Views/Account/MyAccount.cshtml
        i-/Views/Account/AddressBook.cshtml   
        j-/Views/B2B/Users.cshtml
        k-/Views/B2B/Quotes.cshtml
        l-/Views/B2B/MyCompany.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n<ul");

WriteLiteral(" class=\"nav nav-pills border-bottom-blog\"");

WriteLiteral(">\r\n    <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 924), Tuple.Create("\"", 978)
, Tuple.Create(Tuple.Create("", 935), Tuple.Create("{\'active\'", 935), true)
, Tuple.Create(Tuple.Create(" ", 944), Tuple.Create(":\'", 945), true)
            
            #line 24 "..\..\Views\Account\_MobileSideNav.cshtml"
, Tuple.Create(Tuple.Create("", 947), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 947), false)
, Tuple.Create(Tuple.Create("", 961), Tuple.Create("\'==", 961), true)
, Tuple.Create(Tuple.Create(" ", 964), Tuple.Create("\'MyAccount\'", 965), true)
, Tuple.Create(Tuple.Create(" ", 976), Tuple.Create("}", 977), true)
);

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 992), Tuple.Create("\"", 1034)
            
            #line 25 "..\..\Views\Account\_MobileSideNav.cshtml"
, Tuple.Create(Tuple.Create("", 999), Tuple.Create<System.Object, System.Int32>(Url.Action("myaccount", "account")
            
            #line default
            #line hidden
, 999), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral(" title=\"My Account\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i></a>\r\n    </li>\r\n    <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 1125), Tuple.Create("\"", 1180)
, Tuple.Create(Tuple.Create("", 1136), Tuple.Create("{\'active\'", 1136), true)
, Tuple.Create(Tuple.Create(" ", 1145), Tuple.Create(":\'", 1146), true)
            
            #line 27 "..\..\Views\Account\_MobileSideNav.cshtml"
, Tuple.Create(Tuple.Create("", 1148), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 1148), false)
, Tuple.Create(Tuple.Create("", 1162), Tuple.Create("\'==", 1162), true)
, Tuple.Create(Tuple.Create(" ", 1165), Tuple.Create("\'MyActivity\'", 1166), true)
, Tuple.Create(Tuple.Create(" ", 1178), Tuple.Create("}", 1179), true)
);

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1194), Tuple.Create("\"", 1237)
            
            #line 28 "..\..\Views\Account\_MobileSideNav.cshtml"
, Tuple.Create(Tuple.Create("", 1201), Tuple.Create<System.Object, System.Int32>(Url.Action("myactivity", "account")
            
            #line default
            #line hidden
, 1201), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-clock-o\"");

WriteLiteral("></i></a>\r\n    </li>\r\n    <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 1312), Tuple.Create("\"", 1437)
, Tuple.Create(Tuple.Create("", 1323), Tuple.Create("{\'active\'", 1323), true)
, Tuple.Create(Tuple.Create(" ", 1332), Tuple.Create(":\'", 1333), true)
            
            #line 30 "..\..\Views\Account\_MobileSideNav.cshtml"
, Tuple.Create(Tuple.Create("", 1335), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 1335), false)
, Tuple.Create(Tuple.Create("", 1349), Tuple.Create("\'==", 1349), true)
, Tuple.Create(Tuple.Create(" ", 1352), Tuple.Create("\'Orders\'||", 1353), true)
, Tuple.Create(Tuple.Create(" ", 1363), Tuple.Create("\'", 1364), true)
            
            #line 30 "..\..\Views\Account\_MobileSideNav.cshtml"
, Tuple.Create(Tuple.Create("", 1365), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 1365), false)
, Tuple.Create(Tuple.Create("", 1379), Tuple.Create("\'==\'Return", 1379), true)
, Tuple.Create(Tuple.Create(" ", 1389), Tuple.Create("Request\'||", 1390), true)
, Tuple.Create(Tuple.Create(" ", 1400), Tuple.Create("\'", 1401), true)
            
            #line 30 "..\..\Views\Account\_MobileSideNav.cshtml"
                 , Tuple.Create(Tuple.Create("", 1402), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 1402), false)
, Tuple.Create(Tuple.Create("", 1416), Tuple.Create("\'", 1416), true)
, Tuple.Create(Tuple.Create(" ", 1417), Tuple.Create("==", 1418), true)
, Tuple.Create(Tuple.Create(" ", 1420), Tuple.Create("\'CustomerOrder\'}", 1421), true)
);

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1451), Tuple.Create("\"", 1496)
            
            #line 31 "..\..\Views\Account\_MobileSideNav.cshtml"
, Tuple.Create(Tuple.Create("", 1458), Tuple.Create<System.Object, System.Int32>(Url.Action("orderhistory", "account")
            
            #line default
            #line hidden
, 1458), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral(" title=\"Order History\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-shopping-cart\"");

WriteLiteral("></i></a>\r\n    </li>\r\n    <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 1599), Tuple.Create("\"", 1659)
, Tuple.Create(Tuple.Create("", 1610), Tuple.Create("{\'active\'", 1610), true)
, Tuple.Create(Tuple.Create(" ", 1619), Tuple.Create(":", 1620), true)
, Tuple.Create(Tuple.Create(" ", 1621), Tuple.Create("\'", 1622), true)
            
            #line 33 "..\..\Views\Account\_MobileSideNav.cshtml"
, Tuple.Create(Tuple.Create("", 1623), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 1623), false)
, Tuple.Create(Tuple.Create("", 1637), Tuple.Create("\'", 1637), true)
, Tuple.Create(Tuple.Create(" ", 1638), Tuple.Create("==", 1639), true)
, Tuple.Create(Tuple.Create(" ", 1641), Tuple.Create("\'Return", 1642), true)
, Tuple.Create(Tuple.Create(" ", 1649), Tuple.Create("History\'}", 1650), true)
);

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1673), Tuple.Create("\"", 1719)
            
            #line 34 "..\..\Views\Account\_MobileSideNav.cshtml"
, Tuple.Create(Tuple.Create("", 1680), Tuple.Create<System.Object, System.Int32>(Url.Action("returnhistory", "account")
            
            #line default
            #line hidden
, 1680), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral(" title=\"Return History\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-external-link-square\"");

WriteLiteral("></i></a>\r\n    </li>\r\n    <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 1830), Tuple.Create("\"", 1882)
, Tuple.Create(Tuple.Create("", 1841), Tuple.Create("{\'active\'", 1841), true)
, Tuple.Create(Tuple.Create(" ", 1850), Tuple.Create(":\'", 1851), true)
            
            #line 36 "..\..\Views\Account\_MobileSideNav.cshtml"
, Tuple.Create(Tuple.Create("", 1853), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 1853), false)
, Tuple.Create(Tuple.Create("", 1867), Tuple.Create("\'==", 1867), true)
, Tuple.Create(Tuple.Create(" ", 1870), Tuple.Create("\'Wishlist\'}", 1871), true)
);

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1896), Tuple.Create("\"", 1937)
            
            #line 37 "..\..\Views\Account\_MobileSideNav.cshtml"
, Tuple.Create(Tuple.Create("", 1903), Tuple.Create<System.Object, System.Int32>(Url.Action("wishlist", "account")
            
            #line default
            #line hidden
, 1903), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral(" title=\"My Wishlist\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-heart\"");

WriteLiteral("></i></a>\r\n    </li>\r\n    <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 2030), Tuple.Create("\"", 2084)
, Tuple.Create(Tuple.Create("", 2041), Tuple.Create("{\'active\'", 2041), true)
, Tuple.Create(Tuple.Create(" ", 2050), Tuple.Create(":\'", 2051), true)
            
            #line 39 "..\..\Views\Account\_MobileSideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2053), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 2053), false)
, Tuple.Create(Tuple.Create("", 2067), Tuple.Create("\'==\'AddressBook\'}", 2067), true)
);

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2098), Tuple.Create("\"", 2142)
            
            #line 40 "..\..\Views\Account\_MobileSideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2105), Tuple.Create<System.Object, System.Int32>(Url.Action("addressbook", "account")
            
            #line default
            #line hidden
, 2105), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral(" title=\"Address Book\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-book\"");

WriteLiteral("></i></a>\r\n    </li>\r\n    <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 2235), Tuple.Create("\"", 2293)
, Tuple.Create(Tuple.Create("", 2246), Tuple.Create("{\'active\'", 2246), true)
, Tuple.Create(Tuple.Create(" ", 2255), Tuple.Create(":\'", 2256), true)
            
            #line 42 "..\..\Views\Account\_MobileSideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2258), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 2258), false)
, Tuple.Create(Tuple.Create("", 2272), Tuple.Create("\'==\'Change", 2272), true)
, Tuple.Create(Tuple.Create(" ", 2282), Tuple.Create("Password\'}", 2283), true)
);

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2307), Tuple.Create("\"", 2355)
            
            #line 43 "..\..\Views\Account\_MobileSideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2314), Tuple.Create<System.Object, System.Int32>(Url.Action("PasswordChange" , "account")
            
            #line default
            #line hidden
, 2314), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral(" title=\"Change Password\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-key\"");

WriteLiteral("></i></a>\r\n    </li>\r\n    <li>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2463), Tuple.Create("\"", 2502)
            
            #line 46 "..\..\Views\Account\_MobileSideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2470), Tuple.Create<System.Object, System.Int32>(Url.Action("logout", "account")
            
            #line default
            #line hidden
, 2470), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral(" title=\"Logout\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-sign-out\"");

WriteLiteral("></i></a>\r\n    </li>\r\n</ul>");

        }
    }
}
#pragma warning restore 1591
