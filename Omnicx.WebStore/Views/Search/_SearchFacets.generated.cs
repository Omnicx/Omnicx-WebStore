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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Search/_SearchFacets.cshtml")]
    public partial class _Views_Search__SearchFacets_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Search__SearchFacets_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Search\_SearchFacets.cshtml"
  
/*
    Name: Facet UI
    Purpose: Show facet
    Structure: /Views/Search/_SearchFacets.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Search/Search.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" ng-cloak>\r\n    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 selected-search\"");

WriteLiteral(" ng-hide=\"pm.productResponse == null || pm.productResponse.results==null\"");

WriteLiteral(">\r\n        <h4");

WriteLiteral(" class=\"panel-h3\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\Search\_SearchFacets.cshtml"
                        Write(LT("ProductListing.Label.YouHaveSelected", "Filters"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n        ");

WriteLiteral("\r\n        <div");

WriteLiteral(" ng-repeat=\"group in pm.selectionGroup\"");

WriteLiteral(" class=\"selected-margin\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-12 no-padding\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" ng-repeat=\"selected in pm.searchproductfilter  | filter:{name:group}\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"selected-p\"");

WriteLiteral(" ng-if=\"selected.name!=\'Rating\' && selected.value.indexOf(\'#\')<0 \"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" ng-bind=\"selected.value\"");

WriteLiteral(" style=\"padding-left: 0px;padding-right:10px;\"");

WriteLiteral("></span>&nbsp;\r\n                        <a");

WriteLiteral(" class=\"btn-cross\"");

WriteLiteral(" ng-click=\"pm.removeFilter(selected)\"");

WriteLiteral(">&nbsp;<i");

WriteLiteral(" class=\"fa fa-times\"");

WriteLiteral("></i></a>\r\n                    </span>\r\n                    <span");

WriteLiteral(" class=\"selected-p\"");

WriteLiteral(" ng-if=\"selected.value.indexOf(\'#\')>=0\"");

WriteLiteral(">&nbsp;<span");

WriteLiteral(" class=\"colour\"");

WriteLiteral(" style=\"background-color:{{selected.value}}\"");

WriteLiteral(">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>&nbsp;<a");

WriteLiteral(" class=\"btn-cross\"");

WriteLiteral(" ng-click=\"pm.removeFilter(selected)\"");

WriteLiteral(">&nbsp;<i");

WriteLiteral(" class=\"fa fa-times\"");

WriteLiteral("></i></a></span>\r\n                    <span");

WriteLiteral(" class=\"selected-p\"");

WriteLiteral(">\r\n                        <ul");

WriteLiteral(" class=\"list-inline\"");

WriteLiteral(" ng-if=\"selected.name==\'Rating\'\"");

WriteLiteral(">\r\n                            <li>\r\n                                <i");

WriteLiteral(" class=\"fa fa-star\"");

WriteLiteral(" ng-repeat=\"1 in pm.setRating(selected.value,1)\"");

WriteLiteral("></i><i");

WriteLiteral(" class=\"fa fa-star-o\"");

WriteLiteral(" ng-repeat=\"1 in pm.setRating(selected.value,0)\"");

WriteLiteral("></i>\r\n                                &nbsp;<a");

WriteLiteral(" class=\"btn-cross\"");

WriteLiteral(" ng-click=\"pm.removeFilter(selected)\"");

WriteLiteral(">&nbsp;<i");

WriteLiteral(" class=\"fa fa-times\"");

WriteLiteral("></i></a>\r\n                            </li>\r\n                        </ul>\r\n    " +
"                </span>                    \r\n                </span>\r\n          " +
"  </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

            
            #line 40 "..\..\Views\Search\_SearchFacets.cshtml"
   /* End Selected filter grig */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 42 "..\..\Views\Search\_SearchFacets.cshtml"
   /* Start left filters accordion */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" ng-cloak>\r\n    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"panel panel-default sidebar-menu\"");

WriteLiteral(" ng-repeat=\"filter in pm.productResponse.filters track by $index\"");

WriteLiteral(" ng-hide=\"pm.productResponse == null || pm.productResponse.results==null\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel-heading panel-heading-top col-sm-12 no-padding\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-9 no-padding\"");

WriteLiteral(">\r\n                    <h4");

WriteLiteral(" class=\"panel-title panel-h4\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\"#{{filter.name.split(\' \').join(\'\')}}\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" ng-click=\"i=!i\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"fa fa-caret-right\"");

WriteLiteral(" ng-show=\"i\"");

WriteLiteral("></i><i");

WriteLiteral(" class=\"fa fa-caret-down\"");

WriteLiteral(" ng-show=\"!i\"");

WriteLiteral("></i> <span");

WriteLiteral(" ng-bind=\"filter.name\"");

WriteLiteral("></span>\r\n                        </a>\r\n                    </h4>\r\n              " +
"  </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-3 no-padding\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" ng-click=\"pm.clearAddProduct(filter.key)\"");

WriteLiteral(" class=\"panel-clear\"");

WriteLiteral(">");

            
            #line 55 "..\..\Views\Search\_SearchFacets.cshtml"
                                                                                        Write(LT("ProductListing.Label.Clear", "Clear"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"panel-body max-panel collapse in panel-padding-top\"");

WriteLiteral(" id=\"{{filter.name.split(\' \').join(\'\')}}\"");

WriteLiteral(">\r\n                <form>\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(" ng-repeat=\"item in filter.items | orderBy : \'priceFilter\'\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" ng-if=\"filter.name==\'Rating\'\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ng-selected=\"item.isSelected\"");

WriteLiteral(" ng-click=\"pm.productTosearch(filter,item)\"");

WriteLiteral(" ng-model=\"item.isSelected\"");

WriteLiteral(" class=\"{{pm.removeChar(filter.key,item.name)}}\"");

WriteLiteral(">\r\n                                <ul");

WriteLiteral(" class=\"list-inline\"");

WriteLiteral(">\r\n                                    <li><i");

WriteLiteral(" class=\"fa fa-star\"");

WriteLiteral(" ng-repeat=\"1 in pm.setRating(item.name,1)\"");

WriteLiteral("></i><i");

WriteLiteral(" class=\"fa fa-star-o\"");

WriteLiteral(" ng-repeat=\"1 in pm.setRating(item.name,0)\"");

WriteLiteral("></i></li>\r\n                                    <li> (<span");

WriteLiteral(" class=\"text-bold\"");

WriteLiteral(" ng-bind=\"item.count\"");

WriteLiteral("></span>)</li>\r\n                                </ul>\r\n                          " +
"  </label>\r\n                            <label");

WriteLiteral(" ng-if=\"filter.name!=\'Rating\' && item.name.indexOf(\'#\')<0 && filter.name !=\'Price" +
"\'\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ng-selected=\"item.isSelected\"");

WriteLiteral(" ng-click=\"pm.productTosearch(filter,item)\"");

WriteLiteral(" ng-model=\"item.isSelected\"");

WriteLiteral(" class=\"{{pm.removeChar(filter.key,item.name)}}\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" ng-bind=\"item.name\"");

WriteLiteral("></span> (<span");

WriteLiteral(" class=\"text-bold\"");

WriteLiteral(" ng-bind=\"item.count\"");

WriteLiteral("></span>)\r\n                            </label>\r\n                            <lab" +
"el");

WriteLiteral(" ng-if=\"filter.name ==\'Price\'\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ng-selected=\"item.isSelected\"");

WriteLiteral(" ng-click=\"pm.productTosearch(filter,item)\"");

WriteLiteral(" ng-model=\"item.isSelected\"");

WriteLiteral(" class=\"{{pm.removeChar(filter.key,item.name)}}\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" ng-bind=\"item.from.split(\'.\')[0]\"");

WriteLiteral("></span><span");

WriteLiteral(" ng-if=\"item.name.indexOf(\'*\')>=0\"");

WriteLiteral(">*</span>\r\n                                <span");

WriteLiteral(" ng-show=\"item.to!=null && item.to !=\'\'\"");

WriteLiteral(">&nbsp;-&nbsp;</span>\r\n                                <span");

WriteLiteral(" ng-bind=\"item.to.split(\'.\')[0]\"");

WriteLiteral("></span> (<span");

WriteLiteral(" class=\"text-bold\"");

WriteLiteral(" ng-bind=\"item.count\"");

WriteLiteral("></span>)\r\n                            </label>\r\n                        </div>\r\n" +
"                        <div");

WriteLiteral(" class=\"checkbox color-box\"");

WriteLiteral(" ng-repeat=\"item in filter.items\"");

WriteLiteral(" ng-if=\"item.name.indexOf(\'#\')>=0 && item.count>0\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" ng-if=\"item.name.indexOf(\'#\')>=0\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ng-selected=\"item.isSelected\"");

WriteLiteral(" ng-click=\"pm.productTosearch(filter,item)\"");

WriteLiteral(" ng-model=\"item.isSelected\"");

WriteLiteral(" class=\"{{pm.removeChar(filter.key,item.name)}}\"");

WriteLiteral("><span");

WriteLiteral(" class=\"colour\"");

WriteLiteral(" style=\"background-color:{{item.name}}\"");

WriteLiteral("></span> ");

WriteLiteral("\r\n                            </label>\r\n                        </div>\r\n         " +
"           </div>\r\n                </form>\r\n            </div>\r\n        </div>\r\n" +
"    </div>\r\n</div>\r\n");

            
            #line 91 "..\..\Views\Search\_SearchFacets.cshtml"
   /* End left filters accordion */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
