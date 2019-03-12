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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_SearchBox.cshtml")]
    public partial class _Views_Shared__SearchBox_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Shared__SearchBox_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_SearchBox.cshtml"
  
/*
    Name: Search Box
    Purpose: Autocomplete Search box 
    Structure: /Views/Shared/_SearchBox.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Shared/_HeaderLayout.cshtml        (Link in Top Header Bar)
        b-/Views/Shared/_MobileHeaderLayout.cshtml  (Link in Mobile Header)
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("<bt-auto-complete");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 466), Tuple.Create("\"", 530)
            
            #line 14 "..\..\Views\Shared\_SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 480), Tuple.Create<System.Object, System.Int32>(LT("SearchBox.Text.Search", "I'm looking for.. ")
            
            #line default
            #line hidden
, 480), false)
);

WriteLiteral(" pause=\"1\"");

WriteLiteral(" selectedobject=\"autoCompleteSelected\"");

WriteLiteral("\r\n                  localdata=\"\"");

WriteLiteral(" searchfields=\"\"");

WriteLiteral(" titlefield=\"name\"");

WriteLiteral(" minlength=\"2\"");

WriteLiteral("\r\n                  descriptionfield=\"name\"");

WriteLiteral("\r\n                  imagefield=\"url\"");

WriteLiteral("\r\n                  inputclass=\"form-control siteSearch__input\"");

WriteLiteral(" matchclass=\"autocomplete-highlight\"");

WriteAttribute("url", Tuple.Create("\r\n                  url=\"", 837), Tuple.Create("\"", 938)
, Tuple.Create(Tuple.Create("", 862), Tuple.Create("//", 862), true)
            
            #line 19 "..\..\Views\Shared\_SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 864), Tuple.Create<System.Object, System.Int32>(Request.ServerVariables["HTTP_HOST"]
            
            #line default
            #line hidden
, 864), false)
, Tuple.Create(Tuple.Create("", 901), Tuple.Create("/search/SearchAutoComplete/?freeText=", 901), true)
);

WriteAttribute("returnkeyios", Tuple.Create("\r\n                  returnkeyios=\"", 939), Tuple.Create("\"", 1011)
            
            #line 20 "..\..\Views\Shared\_SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 973), Tuple.Create<System.Object, System.Int32>(LT("SearchBox.Text.Search", "Search")
            
            #line default
            #line hidden
, 973), false)
);

WriteLiteral(" />\r\n");

        }
    }
}
#pragma warning restore 1591
