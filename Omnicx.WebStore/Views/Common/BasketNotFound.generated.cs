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
    
    #line 12 "..\..\Views\Common\BasketNotFound.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 14 "..\..\Views\Common\BasketNotFound.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 16 "..\..\Views\Common\BasketNotFound.cshtml"
    using Omnicx.WebStore.Core.Helpers;
    
    #line default
    #line hidden
    
    #line 13 "..\..\Views\Common\BasketNotFound.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    #line 17 "..\..\Views\Common\BasketNotFound.cshtml"
    using Omnicx.WebStore.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Common/BasketNotFound.cshtml")]
    public partial class _Views_Common_BasketNotFound_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Common_BasketNotFound_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Common\BasketNotFound.cshtml"
  
/*
    Name: Basket Not Found
    Purpose: Show This Error Page when No Basket found
    Structure: /Views/Common/BasketNotFound.cshtml
    Contains (Partial Views Used):
        a-/Views/Shared/_Layout.cshtml    (For base Structure)

    Contained In (Where we Use this View):
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 19 "..\..\Views\Common\BasketNotFound.cshtml"
  
    ViewBag.Title = "Basket Not Found";
    Layout = "~/Views/Shared/_OpcLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"section-block replicable-content \"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"notFound-bg text-center\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"fa fa-shopping-bag\"");

WriteLiteral("></i>\r\n            <h3");

WriteLiteral(" class=\"error-h4\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\Common\BasketNotFound.cshtml"
                            Write(LT("YourBag.Text.NoItem", "Basket Not Found"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n            <p");

WriteLiteral(" class=\"message-desc\"");

WriteLiteral(">");

            
            #line 28 "..\..\Views\Common\BasketNotFound.cshtml"
                               Write(LT("YourBag.Text.Basket", "The Basket you are looking for has already been"));

            
            #line default
            #line hidden
WriteLiteral(" <strong>");

            
            #line 28 "..\..\Views\Common\BasketNotFound.cshtml"
                                                                                                                     Write(LT("YourBag.Text.Basket", "Closed / Converted"));

            
            #line default
            #line hidden
WriteLiteral("</strong> ");

            
            #line 28 "..\..\Views\Common\BasketNotFound.cshtml"
                                                                                                                                                                               Write(LT("YourBag.Text.Or", "or"));

            
            #line default
            #line hidden
WriteLiteral(" <strong>");

            
            #line 28 "..\..\Views\Common\BasketNotFound.cshtml"
                                                                                                                                                                                                                    Write(LT("YourBag.Text.exist", "does not exist"));

            
            #line default
            #line hidden
WriteLiteral("</strong>.</p>\r\n            <p><a");

WriteLiteral(" href=\"/\"");

WriteLiteral(" class=\"animate btn-bordered\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-caret-left\"");

WriteLiteral("></i>");

            
            #line 29 "..\..\Views\Common\BasketNotFound.cshtml"
                                                                                   Write(LT("YourBag.Text.ContinueShopping", "Continue Shopping"));

            
            #line default
            #line hidden
WriteLiteral("</a></p>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
