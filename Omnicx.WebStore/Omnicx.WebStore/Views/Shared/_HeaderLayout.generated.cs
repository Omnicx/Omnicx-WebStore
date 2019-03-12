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
    
    #line 14 "..\..\Views\Shared\_HeaderLayout.cshtml"
    using Omnicx.API.SDK.Helpers;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 15 "..\..\Views\Shared\_HeaderLayout.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    #line 13 "..\..\Views\Shared\_HeaderLayout.cshtml"
    using Omnicx.WebStore.Models.Keys;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_HeaderLayout.cshtml")]
    public partial class _Views_Shared__HeaderLayout_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Shared__HeaderLayout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_HeaderLayout.cshtml"
  
/*
    Name: Header
    Purpose: Header UI for all the big screens
    Structure: /Views/Shared/_HeaderLayout.cshtml
    Contains (Partial Views Used):
        a-/Views/Shared/_SearchBox.cshtml

    Contained In (Where we Use this View):
        a-/Views/Shared/_LayoutHeader.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 17 "..\..\Views\Shared\_HeaderLayout.cshtml"
   
    bool? showBulkOrderPad = SessionContext.CurrentSiteConfig?.B2BSettings?.ShowBulkOrderPad;
    bool? isB2b = SessionContext.CurrentSiteConfig?.B2BSettings?.EnableB2B;

            
            #line default
            #line hidden
WriteLiteral("\r\n<nav");

WriteLiteral(" class=\"userControls hidden\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            ");

WriteLiteral("\r\n            <ul");

WriteLiteral(" class=\"left list-inline col-sm-6 col-xs-5 pull-left text-left\"");

WriteLiteral(">\r\n                <li");

WriteLiteral(" class=\"pos-rel\"");

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 951), Tuple.Create("\"", 986)
            
            #line 27 "..\..\Views\Shared\_HeaderLayout.cshtml"
, Tuple.Create(Tuple.Create("", 958), Tuple.Create<System.Object, System.Int32>(Url.Action("blogs", "blog")
            
            #line default
            #line hidden
, 958), false)
);

WriteLiteral(" class=\"userControls__langBtn\"");

WriteLiteral(">Blogs</a>\r\n                </li>\r\n                <li>\r\n                    <spa" +
"n");

WriteLiteral(" class=\"userControls__linkSeperator\"");

WriteLiteral(">|</span>\r\n                </li>\r\n                <li");

WriteLiteral(" class=\"pos-rel\"");

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1229), Tuple.Create("\"", 1269)
            
            #line 33 "..\..\Views\Shared\_HeaderLayout.cshtml"
, Tuple.Create(Tuple.Create("", 1236), Tuple.Create<System.Object, System.Int32>(Url.Action("BrandList", "Brand")
            
            #line default
            #line hidden
, 1236), false)
);

WriteLiteral(" class=\"userControls__currencyBtn\"");

WriteLiteral(">Brand Directory</a>\r\n                </li>\r\n            </ul>\r\n\r\n            ");

WriteLiteral("\r\n            <ul");

WriteLiteral(" class=\"left list-inline col-sm-6 col-xs-7 pull-right text-right\"");

WriteLiteral(">\r\n                \r\n            </ul>\r\n        </div>\r\n    </div>\r\n</nav>\r\n<sect" +
"ion");

WriteLiteral(" class=\"meta\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container pos-rel\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row xs-no-margin\"");

WriteLiteral(">\r\n            ");

WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-xs-1 visible-xs xs-padding-lr-0\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" class=\"mobileMenuBtn hamburger hamburger--squeeze\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" aria-label=\"Mobile Menu\"");

WriteLiteral(" aria-controls=\"navigation\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"hamburger-box\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"hamburger-inner\"");

WriteLiteral("></span>\r\n                    </span>\r\n                </button>\r\n            </d" +
"iv>\r\n\r\n            ");

WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-xs-2 visible-xs xs-padding-lr-0 xs-text-center\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"mobileSearchBtn\"");

WriteLiteral(" href=\"/\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"mobileSearchBtn__text hidden-xs\"");

WriteLiteral(">Search Site</span>\r\n                    <span");

WriteLiteral(" class=\"icon icon-search\"");

WriteLiteral("></span>\r\n                </a>\r\n            </div>\r\n\r\n            ");

WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-xs-3 col-sm-1 no-padding\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 66 "..\..\Views\Shared\_HeaderLayout.cshtml"
           Write(Html.Partial(CustomViews.SITE_LOGO));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n\r\n            ");

WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"mobShowHide col-xs-12 col-sm-5\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"mobShowHide__container\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 72 "..\..\Views\Shared\_HeaderLayout.cshtml"
               Write(Html.Partial(CustomViews.HEADER_SEARCHBOX));

            
            #line default
            #line hidden
WriteLiteral("                   \r\n                </div>\r\n            </div>\r\n\r\n            ");

WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-xs-6 col-sm-6 no-padding\"");

WriteLiteral(">\r\n                <nav");

WriteLiteral(" class=\"metaLinks\"");

WriteLiteral(">\r\n                    <ul");

WriteLiteral(" class=\"list-inline\"");

WriteLiteral(">\r\n                        <li>\r\n                            <div");

WriteLiteral(" id=\"miniBag\"");

WriteLiteral(" class=\"open\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 82 "..\..\Views\Shared\_HeaderLayout.cshtml"
                           Write(Html.Action("HeaderBasket", "Basket", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </li>\r\n");

WriteLiteral("                        ");

            
            #line 85 "..\..\Views\Shared\_HeaderLayout.cshtml"
                   Write(Html.Action("HeaderLoginInfo", "Home", true));

            
            #line default
            #line hidden
WriteLiteral("      \r\n                        <li>\r\n                            <a");

WriteLiteral(" class=\"userControls__accountLinks\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3506), Tuple.Create("\"", 3550)
            
            #line 87 "..\..\Views\Shared\_HeaderLayout.cshtml"
, Tuple.Create(Tuple.Create("", 3513), Tuple.Create<System.Object, System.Int32>(Url.Action("StoreLocator", "Common")
            
            #line default
            #line hidden
, 3513), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"sprite sprite-browsers-store\"");

WriteLiteral("></i><span");

WriteLiteral(" class=\"label-0\"");

WriteLiteral(">Login</span></a>\r\n                        </li>\r\n                    </ul>\r\n    " +
"            </nav>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"header-toggle\"");

WriteAttribute("ng-init", Tuple.Create(" ng-init=\"", 3776), Tuple.Create("\"", 3859)
, Tuple.Create(Tuple.Create("", 3786), Tuple.Create("gm.getAllcurrencyandCountries();langCulture=\'", 3786), true)
            
            #line 92 "..\..\Views\Shared\_HeaderLayout.cshtml"
             , Tuple.Create(Tuple.Create("", 3831), Tuple.Create<System.Object, System.Int32>(SessionContext.LangCulture
            
            #line default
            #line hidden
, 3831), false)
, Tuple.Create(Tuple.Create("", 3858), Tuple.Create("\'", 3858), true)
);

WriteLiteral(">\r\n                <ul>\r\n                    <li");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"dropdown-toggle text-white\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-chevron-down\"");

WriteLiteral("></i>");

            
            #line 95 "..\..\Views\Shared\_HeaderLayout.cshtml"
                                                                                                                           Write(SessionContext.CurrencyCode);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        <ul");

WriteLiteral(" class=\"dropdown-menu\"");

WriteLiteral(">\r\n                            <li");

WriteLiteral(" ng-repeat=\"currency in gm.currencies\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"#\"");

WriteLiteral(" ng-click=\"gm.currencySettings(currency.currencyCode)\"");

WriteLiteral("><strong");

WriteLiteral(" ng-bind=\"currency.currencySymbol\"");

WriteLiteral("></strong>&nbsp;<span");

WriteLiteral(" ng-bind=\"currency.currencyCode\"");

WriteLiteral("></span> </a>\r\n                            </li>\r\n                        </ul>\r\n" +
"                    </li>\r\n                </ul>\r\n                <ul>\r\n        " +
"            <li");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"dropdown-toggle text-white\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-chevron-down\"");

WriteLiteral("></i><img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 4735), Tuple.Create("\"", 4789)
, Tuple.Create(Tuple.Create("", 4744), Tuple.Create<System.Object, System.Int32>(Href("~/assets/theme/ocx/images/{{langCulture}}.png")
, 4744), false)
);

WriteLiteral(" alt=\"Country\"");

WriteLiteral(" /></a>\r\n                        <ul");

WriteLiteral(" class=\"dropdown-menu\"");

WriteLiteral(">\r\n                            <li");

WriteLiteral(" ng-repeat=\"language in gm.langCulture\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"#\"");

WriteLiteral(" ng-click=\"gm.languageSettings(language.languageCulture)\"");

WriteLiteral("><img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 5044), Tuple.Create("\"", 5111)
, Tuple.Create(Tuple.Create("", 5053), Tuple.Create<System.Object, System.Int32>(Href("~/assets/theme/ocx/images/{{language.languageCulture}}.png")
, 5053), false)
);

WriteLiteral(" alt=\"Country\"");

WriteLiteral(" /></a>\r\n                            </li>\r\n                        </ul>\r\n      " +
"              </li>\r\n                </ul>    \r\n                ");

WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

WriteLiteral("    ");

            
            #line 118 "..\..\Views\Shared\_HeaderLayout.cshtml"
Write(Html.GetGlobalSnipptes(SnippetPlacements.HeaderMenuBefore));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 119 "..\..\Views\Shared\_HeaderLayout.cshtml"
Write(Html.Action("GetNav", "Home"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 120 "..\..\Views\Shared\_HeaderLayout.cshtml"
Write(Html.GetGlobalSnipptes(SnippetPlacements.HeaderMenuAfter));

            
            #line default
            #line hidden
WriteLiteral("\r\n</section>");

        }
    }
}
#pragma warning restore 1591
