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
    
    #line 18 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
    using Omnicx.API.SDK.Helpers;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 17 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    #line 16 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
    using Omnicx.WebStore.Models.Keys;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_LayoutHeadTag.cshtml")]
    public partial class _Views_Shared__LayoutHeadTag_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__LayoutHeadTag_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
  
/*
    Name: Body Tags
    Purpose: Place all the css and head tags
    Structure: /Views/Shared/_LayoutHeadTag.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Shared/_Layout.cshtml
        b-/Views/Shared/_LayoutAccount.cshtml
        c-/Views/Shared/_LayoutBlog.cshtml
        d-/Views/Shared/_LayoutCMS.cshtml
        e-/Views/Shared/_OpcLayout.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 19 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
  
    var StoreTheme = ConfigKeys.StoreTheme;

            
            #line default
            #line hidden
WriteLiteral("\r\n<head>\r\n    <title>");

            
            #line 23 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
      Write(Html.Title(false));

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n");

WriteLiteral("    ");

            
            #line 24 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
Write(Html.GetGlobalSnipptes(SnippetPlacements.TopHead));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <meta");

WriteLiteral(" name=\"description\"");

WriteAttribute("content", Tuple.Create(" content=\"", 772), Tuple.Create("\"", 807)
            
            #line 25 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 782), Tuple.Create<System.Object, System.Int32>(Html.MetaDescription()
            
            #line default
            #line hidden
, 782), false)
);

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"title\"");

WriteAttribute("content", Tuple.Create(" content=\"", 835), Tuple.Create("\"", 864)
            
            #line 26 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 845), Tuple.Create<System.Object, System.Int32>(Html.MetaTitle()
            
            #line default
            #line hidden
, 845), false)
);

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"keywords\"");

WriteAttribute("content", Tuple.Create(" content=\"", 893), Tuple.Create("\"", 925)
            
            #line 27 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 903), Tuple.Create<System.Object, System.Int32>(Html.MetaKeywords()
            
            #line default
            #line hidden
, 903), false)
);

WriteLiteral(">\r\n    <meta");

WriteLiteral(" charset=\"UTF-8\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"x-ua-compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0, maximum-scale=1, user-scalable=n" +
"o\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"57x57\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1173), Tuple.Create("\"", 1241)
, Tuple.Create(Tuple.Create("", 1180), Tuple.Create("/assets/theme/", 1180), true)
            
            #line 31 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 1194), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 1194), false)
, Tuple.Create(Tuple.Create("", 1205), Tuple.Create("/images/favicon/apple-icon-57x57.png", 1205), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"60x60\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1291), Tuple.Create("\"", 1359)
, Tuple.Create(Tuple.Create("", 1298), Tuple.Create("/assets/theme/", 1298), true)
            
            #line 32 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 1312), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 1312), false)
, Tuple.Create(Tuple.Create("", 1323), Tuple.Create("/images/favicon/apple-icon-60x60.png", 1323), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"72x72\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1409), Tuple.Create("\"", 1477)
, Tuple.Create(Tuple.Create("", 1416), Tuple.Create("/assets/theme/", 1416), true)
            
            #line 33 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 1430), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 1430), false)
, Tuple.Create(Tuple.Create("", 1441), Tuple.Create("/images/favicon/apple-icon-72x72.png", 1441), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"76x76\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1527), Tuple.Create("\"", 1595)
, Tuple.Create(Tuple.Create("", 1534), Tuple.Create("/assets/theme/", 1534), true)
            
            #line 34 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 1548), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 1548), false)
, Tuple.Create(Tuple.Create("", 1559), Tuple.Create("/images/favicon/apple-icon-76x76.png", 1559), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"114x114\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1647), Tuple.Create("\"", 1717)
, Tuple.Create(Tuple.Create("", 1654), Tuple.Create("/assets/theme/", 1654), true)
            
            #line 35 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 1668), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 1668), false)
, Tuple.Create(Tuple.Create("", 1679), Tuple.Create("/images/favicon/apple-icon-114x114.png", 1679), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"120x120\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1769), Tuple.Create("\"", 1839)
, Tuple.Create(Tuple.Create("", 1776), Tuple.Create("/assets/theme/", 1776), true)
            
            #line 36 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 1790), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 1790), false)
, Tuple.Create(Tuple.Create("", 1801), Tuple.Create("/images/favicon/apple-icon-120x120.png", 1801), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"144x144\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1891), Tuple.Create("\"", 1961)
, Tuple.Create(Tuple.Create("", 1898), Tuple.Create("/assets/theme/", 1898), true)
            
            #line 37 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 1912), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 1912), false)
, Tuple.Create(Tuple.Create("", 1923), Tuple.Create("/images/favicon/apple-icon-144x144.png", 1923), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"152x152\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2013), Tuple.Create("\"", 2083)
, Tuple.Create(Tuple.Create("", 2020), Tuple.Create("/assets/theme/", 2020), true)
            
            #line 38 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 2034), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 2034), false)
, Tuple.Create(Tuple.Create("", 2045), Tuple.Create("/images/favicon/apple-icon-152x152.png", 2045), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"180x180\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2135), Tuple.Create("\"", 2205)
, Tuple.Create(Tuple.Create("", 2142), Tuple.Create("/assets/theme/", 2142), true)
            
            #line 39 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 2156), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 2156), false)
, Tuple.Create(Tuple.Create("", 2167), Tuple.Create("/images/favicon/apple-icon-180x180.png", 2167), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"icon\"");

WriteLiteral(" type=\"image/png\"");

WriteLiteral(" sizes=\"192x192\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2262), Tuple.Create("\"", 2334)
, Tuple.Create(Tuple.Create("", 2269), Tuple.Create("/assets/theme/", 2269), true)
            
            #line 40 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 2283), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 2283), false)
, Tuple.Create(Tuple.Create("", 2294), Tuple.Create("/images/favicon/android-icon-192x192.png", 2294), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"icon\"");

WriteLiteral(" type=\"image/png\"");

WriteLiteral(" sizes=\"32x32\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2389), Tuple.Create("\"", 2454)
, Tuple.Create(Tuple.Create("", 2396), Tuple.Create("/assets/theme/", 2396), true)
            
            #line 41 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 2410), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 2410), false)
, Tuple.Create(Tuple.Create("", 2421), Tuple.Create("/images/favicon/favicon-32x32.png", 2421), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"icon\"");

WriteLiteral(" type=\"image/png\"");

WriteLiteral(" sizes=\"96x96\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2509), Tuple.Create("\"", 2574)
, Tuple.Create(Tuple.Create("", 2516), Tuple.Create("/assets/theme/", 2516), true)
            
            #line 42 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 2530), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 2530), false)
, Tuple.Create(Tuple.Create("", 2541), Tuple.Create("/images/favicon/favicon-96x96.png", 2541), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"icon\"");

WriteLiteral(" type=\"image/png\"");

WriteLiteral(" sizes=\"16x16\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2629), Tuple.Create("\"", 2694)
, Tuple.Create(Tuple.Create("", 2636), Tuple.Create("/assets/theme/", 2636), true)
            
            #line 43 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 2650), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 2650), false)
, Tuple.Create(Tuple.Create("", 2661), Tuple.Create("/images/favicon/favicon-16x16.png", 2661), true)
);

WriteLiteral(">\r\n\r\n    <link");

WriteLiteral(" rel=\"shortcut icon\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2729), Tuple.Create("\"", 2788)
, Tuple.Create(Tuple.Create("", 2736), Tuple.Create("/assets/theme/", 2736), true)
            
            #line 45 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 2750), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 2750), false)
, Tuple.Create(Tuple.Create("", 2761), Tuple.Create("/images/favicon/favicon.ico", 2761), true)
);

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"msapplication-TileColor\"");

WriteLiteral(" content=\"#ffffff\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"msapplication-TileImage\"");

WriteAttribute("content", Tuple.Create(" content=\"", 2893), Tuple.Create("\"", 2963)
, Tuple.Create(Tuple.Create("", 2903), Tuple.Create("/assets/theme/", 2903), true)
            
            #line 47 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 2917), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 2917), false)
, Tuple.Create(Tuple.Create("", 2928), Tuple.Create("/images/favicon/ms-icon-144x144.png", 2928), true)
);

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"theme-color\"");

WriteLiteral(" content=\"#ffffff\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("    ");

            
            #line 50 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
Write(Html.CanonicalUrl());

            
            #line default
            #line hidden
WriteLiteral("\r\n    <link");

WriteLiteral(" href=\"//maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n");

WriteLiteral("    ");

            
            #line 52 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
Write(Styles.Render("~/bundles/style-css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <!-- Responsivity for older IE -->\r\n    <!--[if lt IE 9]>\r\n        <scrip" +
"t src=\"~/assets/js/js-lib/respond.min.js\"></script>\r\n    <![endif]-->\r\n");

WriteLiteral("    ");

            
            #line 58 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
Write(Html.Action("DynamicHeadTag", "Home", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 59 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
    
            
            #line default
            #line hidden
            
            #line 59 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
     if (@Html.GetOmnilyticId().ToString() != "")
    {

            
            #line default
            #line hidden
WriteLiteral("        <!--Start Omnilytics -->\r\n");

WriteLiteral("        <script>\r\n            (function(i, s, o, g, r, a, m){\r\n                a " +
"= s.createElement(o);m = s.getElementsByTagName(o)[0];a.async = 1;a.src = g;m.pa" +
"rentNode.insertBefore(a, m);\r\n                a.onload = function () { i[r].init" +
"(\'");

            
            #line 65 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
                                               Write(Html.GetOmnilyticId());

            
            #line default
            #line hidden
WriteLiteral("\', \'dataLayer\');};\r\n            })(window, document, \'script\', \"");

            
            #line 66 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
                                       Write(Html.GetOmnilyticUrl());

            
            #line default
            #line hidden
WriteLiteral("\", \'omnilytics\');\r\n        </script>\r\n");

WriteLiteral("        <!-- End Omnilytics -->\r\n");

            
            #line 69 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 70 "..\..\Views\Shared\_LayoutHeadTag.cshtml"
Write(Html.GetGlobalSnipptes(SnippetPlacements.Head));

            
            #line default
            #line hidden
WriteLiteral("\r\n</head>\r\n");

        }
    }
}
#pragma warning restore 1591
