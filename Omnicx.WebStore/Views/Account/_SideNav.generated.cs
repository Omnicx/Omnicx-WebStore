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
    
    #line 23 "..\..\Views\Account\_SideNav.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    #line 24 "..\..\Views\Account\_SideNav.cshtml"
    using Omnicx.WebStore.Models.Keys;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/_SideNav.cshtml")]
    public partial class _Views_Account__SideNav_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Account__SideNav_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Account\_SideNav.cshtml"
  
    /*
        Name: Site Nav
        Purpose: List all the Navigation links for desktop and big screen
        Structure: /Views/Account/_SideNav.cshtml
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
WriteLiteral("\r\n");

            
            #line 27 "..\..\Views\Account\_SideNav.cshtml"
  
    bool isB2B = false;
    CompanyUserRole userRole = CompanyUserRole.None;
    if (SessionContext.CurrentUser != null)
    {
        if (SessionContext.CurrentUser.CompanyId != Guid.Empty.ToString())
        {
            isB2B = true;
            userRole = SessionContext.CurrentUser.CompanyUserRole;
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"panel panel-default sidebar-menu\"");

WriteLiteral(">\r\n    ");

WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"panel-body no-padding\"");

WriteLiteral(">\r\n        <ul");

WriteLiteral(" class=\"nav nav-pills nav-stacked\"");

WriteLiteral(">\r\n            <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 1672), Tuple.Create("\"", 1729)
, Tuple.Create(Tuple.Create("", 1683), Tuple.Create("{\'active-ac\'", 1683), true)
, Tuple.Create(Tuple.Create(" ", 1695), Tuple.Create(":\'", 1696), true)
            
            #line 43 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 1698), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 1698), false)
, Tuple.Create(Tuple.Create("", 1712), Tuple.Create("\'==", 1712), true)
, Tuple.Create(Tuple.Create(" ", 1715), Tuple.Create("\'MyAccount\'", 1716), true)
, Tuple.Create(Tuple.Create(" ", 1727), Tuple.Create("}", 1728), true)
);

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1751), Tuple.Create("\"", 1793)
            
            #line 44 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 1758), Tuple.Create<System.Object, System.Int32>(Url.Action("myaccount", "account")
            
            #line default
            #line hidden
, 1758), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i>");

            
            #line 44 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                       Write(LT("MyAccount.Text.Name", "My Account"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n");

            
            #line 46 "..\..\Views\Account\_SideNav.cshtml"
            
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\Account\_SideNav.cshtml"
             if (ConfigKeys.DisplayUserActivity)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 1990), Tuple.Create("\"", 2048)
, Tuple.Create(Tuple.Create("", 2001), Tuple.Create("{\'active-ac\'", 2001), true)
, Tuple.Create(Tuple.Create(" ", 2013), Tuple.Create(":\'", 2014), true)
            
            #line 48 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2016), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 2016), false)
, Tuple.Create(Tuple.Create("", 2030), Tuple.Create("\'==", 2030), true)
, Tuple.Create(Tuple.Create(" ", 2033), Tuple.Create("\'MyActivity\'", 2034), true)
, Tuple.Create(Tuple.Create(" ", 2046), Tuple.Create("}", 2047), true)
);

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2074), Tuple.Create("\"", 2117)
            
            #line 49 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2081), Tuple.Create<System.Object, System.Int32>(Url.Action("myactivity", "account")
            
            #line default
            #line hidden
, 2081), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-clock-o\"");

WriteLiteral("></i>");

            
            #line 49 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                               Write(LT("MyActivity.Text.Name", "My Activity"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </li>\r\n");

            
            #line 51 "..\..\Views\Account\_SideNav.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 52 "..\..\Views\Account\_SideNav.cshtml"
               if (isB2B)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 2323), Tuple.Create("\"", 2380)
, Tuple.Create(Tuple.Create("", 2334), Tuple.Create("{\'active-ac\'", 2334), true)
, Tuple.Create(Tuple.Create(" ", 2346), Tuple.Create(":\'", 2347), true)
            
            #line 54 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2349), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 2349), false)
, Tuple.Create(Tuple.Create("", 2363), Tuple.Create("\'==", 2363), true)
, Tuple.Create(Tuple.Create(" ", 2366), Tuple.Create("\'MyCompany\'", 2367), true)
, Tuple.Create(Tuple.Create(" ", 2378), Tuple.Create("}", 2379), true)
);

WriteLiteral(">\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2410), Tuple.Create("\"", 2448)
            
            #line 55 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2417), Tuple.Create<System.Object, System.Int32>(Url.Action("MyCompany", "b2b")
            
            #line default
            #line hidden
, 2417), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-building\"");

WriteLiteral("></i>");

            
            #line 55 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                               Write(LT("MyAccount.Text.Name", "My Company"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </li>\r\n");

WriteLiteral("                    <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 2596), Tuple.Create("\"", 2650)
, Tuple.Create(Tuple.Create("", 2607), Tuple.Create("{\'active-ac\'", 2607), true)
, Tuple.Create(Tuple.Create(" ", 2619), Tuple.Create(":\'", 2620), true)
            
            #line 57 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2622), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 2622), false)
, Tuple.Create(Tuple.Create("", 2636), Tuple.Create("\'==", 2636), true)
, Tuple.Create(Tuple.Create(" ", 2639), Tuple.Create("\'Quotes\'", 2640), true)
, Tuple.Create(Tuple.Create(" ", 2648), Tuple.Create("}", 2649), true)
);

WriteLiteral(">\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2680), Tuple.Create("\"", 2715)
            
            #line 58 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2687), Tuple.Create<System.Object, System.Int32>(Url.Action("quotes", "b2b")
            
            #line default
            #line hidden
, 2687), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-file\"");

WriteLiteral("></i>");

            
            #line 58 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                        Write(LT("MyAccount.Text.Name", "Quotes"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </li>\r\n");

            
            #line 60 "..\..\Views\Account\_SideNav.cshtml"
                    if (userRole == (CompanyUserRole.Admin))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 2944), Tuple.Create("\"", 2997)
, Tuple.Create(Tuple.Create("", 2955), Tuple.Create("{\'active-ac\'", 2955), true)
, Tuple.Create(Tuple.Create(" ", 2967), Tuple.Create(":\'", 2968), true)
            
            #line 62 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2970), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 2970), false)
, Tuple.Create(Tuple.Create("", 2984), Tuple.Create("\'==", 2984), true)
, Tuple.Create(Tuple.Create(" ", 2987), Tuple.Create("\'Users\'", 2988), true)
, Tuple.Create(Tuple.Create(" ", 2995), Tuple.Create("}", 2996), true)
);

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3031), Tuple.Create("\"", 3065)
            
            #line 63 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 3038), Tuple.Create<System.Object, System.Int32>(Url.Action("users", "b2b")
            
            #line default
            #line hidden
, 3038), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i>");

            
            #line 63 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                           Write(LT("MyAccount.Text.Name", "My Users"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        </li>\r\n");

            
            #line 65 "..\..\Views\Account\_SideNav.cshtml"
                    }
                }
            
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 3262), Tuple.Create("\"", 3390)
, Tuple.Create(Tuple.Create("", 3273), Tuple.Create("{\'active-ac\'", 3273), true)
, Tuple.Create(Tuple.Create(" ", 3285), Tuple.Create(":\'", 3286), true)
            
            #line 69 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 3288), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 3288), false)
, Tuple.Create(Tuple.Create("", 3302), Tuple.Create("\'==", 3302), true)
, Tuple.Create(Tuple.Create(" ", 3305), Tuple.Create("\'Orders\'||", 3306), true)
, Tuple.Create(Tuple.Create(" ", 3316), Tuple.Create("\'", 3317), true)
            
            #line 69 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 3318), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 3318), false)
, Tuple.Create(Tuple.Create("", 3332), Tuple.Create("\'==\'Return", 3332), true)
, Tuple.Create(Tuple.Create(" ", 3342), Tuple.Create("Request\'||", 3343), true)
, Tuple.Create(Tuple.Create(" ", 3353), Tuple.Create("\'", 3354), true)
            
            #line 69 "..\..\Views\Account\_SideNav.cshtml"
                            , Tuple.Create(Tuple.Create("", 3355), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 3355), false)
, Tuple.Create(Tuple.Create("", 3369), Tuple.Create("\'", 3369), true)
, Tuple.Create(Tuple.Create(" ", 3370), Tuple.Create("==", 3371), true)
, Tuple.Create(Tuple.Create(" ", 3373), Tuple.Create("\'CustomerOrder\'}", 3374), true)
);

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3412), Tuple.Create("\"", 3457)
            
            #line 70 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 3419), Tuple.Create<System.Object, System.Int32>(Url.Action("orderhistory", "account")
            
            #line default
            #line hidden
, 3419), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-shopping-cart\"");

WriteLiteral("></i>");

            
            #line 70 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                                   Write(LT("MyAccount.Links.MyOrders", "My Orders"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n");

            
            #line 72 "..\..\Views\Account\_SideNav.cshtml"
            
            
            #line default
            #line hidden
            
            #line 72 "..\..\Views\Account\_SideNav.cshtml"
             if (userRole == (CompanyUserRole.None) || userRole == (CompanyUserRole.Admin))
            {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 3710), Tuple.Create("\"", 3770)
, Tuple.Create(Tuple.Create("", 3721), Tuple.Create("{\'active-ac\'", 3721), true)
, Tuple.Create(Tuple.Create(" ", 3733), Tuple.Create(":", 3734), true)
, Tuple.Create(Tuple.Create(" ", 3735), Tuple.Create("\'", 3736), true)
            
            #line 74 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 3737), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 3737), false)
, Tuple.Create(Tuple.Create("", 3751), Tuple.Create("\'", 3751), true)
, Tuple.Create(Tuple.Create(" ", 3752), Tuple.Create("==", 3753), true)
, Tuple.Create(Tuple.Create(" ", 3755), Tuple.Create("\'AddressBook\'}", 3756), true)
);

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3796), Tuple.Create("\"", 3840)
            
            #line 75 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 3803), Tuple.Create<System.Object, System.Int32>(Url.Action("AddressBook", "account")
            
            #line default
            #line hidden
, 3803), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-home\"");

WriteLiteral("></i>");

            
            #line 75 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                             Write(LT("MyAccount.Links.AddressBook", "Address Book"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </li>\r\n");

            
            #line 77 "..\..\Views\Account\_SideNav.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 3997), Tuple.Create("\"", 4060)
, Tuple.Create(Tuple.Create("", 4008), Tuple.Create("{\'active-ac\'", 4008), true)
, Tuple.Create(Tuple.Create(" ", 4020), Tuple.Create(":", 4021), true)
, Tuple.Create(Tuple.Create(" ", 4022), Tuple.Create("\'", 4023), true)
            
            #line 78 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 4024), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 4024), false)
, Tuple.Create(Tuple.Create("", 4038), Tuple.Create("\'", 4038), true)
, Tuple.Create(Tuple.Create(" ", 4039), Tuple.Create("==", 4040), true)
, Tuple.Create(Tuple.Create(" ", 4042), Tuple.Create("\'Return", 4043), true)
, Tuple.Create(Tuple.Create(" ", 4050), Tuple.Create("History\'}", 4051), true)
);

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4082), Tuple.Create("\"", 4128)
            
            #line 79 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 4089), Tuple.Create<System.Object, System.Int32>(Url.Action("returnhistory", "account")
            
            #line default
            #line hidden
, 4089), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-external-link-square\"");

WriteLiteral("></i>");

            
            #line 79 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                                           Write(LT("MyAccount.Links.ReturnHistory", "Return History"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n            <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 4286), Tuple.Create("\"", 4341)
, Tuple.Create(Tuple.Create("", 4297), Tuple.Create("{\'active-ac\'", 4297), true)
, Tuple.Create(Tuple.Create(" ", 4309), Tuple.Create(":\'", 4310), true)
            
            #line 81 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 4312), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 4312), false)
, Tuple.Create(Tuple.Create("", 4326), Tuple.Create("\'==", 4326), true)
, Tuple.Create(Tuple.Create(" ", 4329), Tuple.Create("\'Wishlist\'}", 4330), true)
);

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4363), Tuple.Create("\"", 4404)
            
            #line 82 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 4370), Tuple.Create<System.Object, System.Int32>(Url.Action("wishlist", "account")
            
            #line default
            #line hidden
, 4370), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-heart\"");

WriteLiteral("></i>");

            
            #line 82 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                       Write(LT("MyAccount.Links.Wishlist", "My Wishlist"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n\r\n            <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 4541), Tuple.Create("\"", 4602)
, Tuple.Create(Tuple.Create("", 4552), Tuple.Create("{\'active-ac\'", 4552), true)
, Tuple.Create(Tuple.Create(" ", 4564), Tuple.Create(":\'", 4565), true)
            
            #line 85 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 4567), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 4567), false)
, Tuple.Create(Tuple.Create("", 4581), Tuple.Create("\'==\'Change", 4581), true)
, Tuple.Create(Tuple.Create(" ", 4591), Tuple.Create("Password\'}", 4592), true)
);

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4624), Tuple.Create("\"", 4672)
            
            #line 86 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 4631), Tuple.Create<System.Object, System.Int32>(Url.Action("PasswordChange" , "account")
            
            #line default
            #line hidden
, 4631), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-key\"");

WriteLiteral("></i>");

            
            #line 86 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                            Write(LT("Global.Buttons.PasswordChange", "Change Password"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n            <li>\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4835), Tuple.Create("\"", 4874)
            
            #line 89 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 4842), Tuple.Create<System.Object, System.Int32>(Url.Action("logout", "account")
            
            #line default
            #line hidden
, 4842), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-sign-out\"");

WriteLiteral("></i>");

            
            #line 89 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                        Write(LT("Global.Buttons.Logout", "LogOut"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n        </ul>\r\n    </div>\r\n\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
