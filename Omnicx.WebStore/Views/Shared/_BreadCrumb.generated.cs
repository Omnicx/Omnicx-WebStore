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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_BreadCrumb.cshtml")]
    public partial class _Views_Shared__BreadCrumb_cshtml : System.Web.Mvc.WebViewPage<Omnicx.WebStore.Models.Catalog.SlugModel>
    {
        public _Views_Shared__BreadCrumb_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\_BreadCrumb.cshtml"
 if (Model != null)
{   

            
            #line default
            #line hidden
WriteLiteral("    <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 87), Tuple.Create("\"", 106)
, Tuple.Create(Tuple.Create("", 94), Tuple.Create("/", 94), true)
            
            #line 5 "..\..\Views\Shared\_BreadCrumb.cshtml"
, Tuple.Create(Tuple.Create("", 95), Tuple.Create<System.Object, System.Int32>(Model.Slug
            
            #line default
            #line hidden
, 95), false)
);

WriteLiteral(">");

            
            #line 5 "..\..\Views\Shared\_BreadCrumb.cshtml"
                          Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 6 "..\..\Views\Shared\_BreadCrumb.cshtml"
    if (Model.ChildSlug != null)
    {
        
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\Shared\_BreadCrumb.cshtml"
   Write(Html.Partial("~/Views/Shared/_BreadCrumb.cshtml", Model.ChildSlug));

            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\Shared\_BreadCrumb.cshtml"
                                                                           ;
    }
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
