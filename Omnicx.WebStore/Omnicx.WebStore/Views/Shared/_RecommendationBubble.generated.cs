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
    
    #line 3 "..\..\Views\Shared\_RecommendationBubble.cshtml"
    using Omnicx.API.SDK.Helpers;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 2 "..\..\Views\Shared\_RecommendationBubble.cshtml"
    using Omnicx.WebStore.Models.Commerce;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Shared\_RecommendationBubble.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Shared\_RecommendationBubble.cshtml"
    using Omnicx.WebStore.Models.Keys;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_RecommendationBubble.cshtml")]
    public partial class _Views_Shared__RecommendationBubble_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Shared__RecommendationBubble_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"modal fade in\"");

WriteLiteral(" id=\"bubbleOption\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" data-backdrop=\"false\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"modal-dialog modal-full\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(">");

            
            #line 11 "..\..\Views\Shared\_RecommendationBubble.cshtml"
                                    Write(LT("YourBag.Message.BulkOrderPad", "Your OmniCX Store"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close search-close-btn\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">×</span><span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Shared\_RecommendationBubble.cshtml"
                                                                                                                                            Write(LT("Checkout.Button.Close", "Close"));

            
            #line default
            #line hidden
WriteLiteral("</span></button>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal-body no-padding\"");

WriteLiteral(" >\r\n                <div");

WriteLiteral(" class=\"row maxHeight\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 tagScroll\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"tags\"");

WriteLiteral(">\r\n                            <img");

WriteLiteral(" ng-src=\"https://devocxblob.blob.core.windows.net/demostore/products/77S520_48_BL" +
"U.jpg\"");

WriteLiteral(" alt=\"Recommended Banner\"");

WriteLiteral(" />\r\n                            <strong>Recommended</strong>\r\n                  " +
"      </span>\r\n                        <span");

WriteLiteral(" class=\"tags\"");

WriteLiteral(">\r\n                            <img");

WriteLiteral(" src=\"https://devocxblob.blob.core.windows.net/demostore/products/75B492XX_94_OCH" +
"RE.jpg\"");

WriteLiteral("  alt=\"Recommended Banner\"");

WriteLiteral("/>\r\n                            <strong>Bags</strong>\r\n                        </" +
"span>\r\n                        <span");

WriteLiteral(" class=\"tags active\"");

WriteLiteral(">\r\n                            <img");

WriteLiteral(" src=\"https://devocxblob.blob.core.windows.net/demostore/products/73726.jpg\"");

WriteLiteral(" alt=\"Recommended Banner\"");

WriteLiteral(" />\r\n                            <strong>Perfumes</strong>\r\n                     " +
"   </span>\r\n                        <span");

WriteLiteral(" class=\"tags\"");

WriteLiteral(">\r\n                            <img");

WriteLiteral(" src=\"https://devocxblob.blob.core.windows.net/demostore/products/73726.jpg\"");

WriteLiteral("  alt=\"Recommended Banner\"");

WriteLiteral("/>\r\n                            <strong>Perfumes</strong>\r\n                      " +
"  </span>\r\n                        <span");

WriteLiteral(" class=\"tags\"");

WriteLiteral(">\r\n                            <img");

WriteLiteral(" src=\"https://devocxblob.blob.core.windows.net/demostore/products/73726.jpg\"");

WriteLiteral(" alt=\"Recommended Banner\"");

WriteLiteral(" />\r\n                            <strong>Perfumes</strong>\r\n                     " +
"   </span>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 gridView\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" ng-repeat=\"prod in gm.recomendations.products\"");

WriteLiteral(" class=\"col-md-5ths col-sm-5ths col-xs-5ths col-lg-5ths resultContainerRelated ng" +
"-scope\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"product-container-panel\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"imagePanel\"");

WriteLiteral(">\r\n                                    <a");

WriteLiteral(" ng-href=\"{{prod.slug}}\"");

WriteLiteral(">\r\n                                        <span");

WriteLiteral(" class=\"tooltiptext ng-binding\"");

WriteLiteral("></span>\r\n                                        <img");

WriteLiteral(" ng-src=\"{{prod.image}}\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" class=\"image1\"");

WriteLiteral(">\r\n                                    </a>\r\n                                </di" +
"v>\r\n                                <div");

WriteLiteral(" class=\"dataPanel\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"ribbon-info\"");

WriteLiteral(">\r\n                                        <a");

WriteLiteral(" ng-href=\"{{prod.slug}}\"");

WriteLiteral(">\r\n                                            <span");

WriteLiteral(" class=\"ng-binding\"");

WriteLiteral(" ng-bind=\"prod.name\"");

WriteLiteral("></span>\r\n                                        </a>\r\n                         " +
"           </div>\r\n                                    <div>\r\n                  " +
"                      <span><strong>SKU: </strong><span");

WriteLiteral(" class=\"ng-binding\"");

WriteLiteral(" ng-bind=\"prod.sku\"");

WriteLiteral("></span></span>\r\n                                    </div>\r\n                    " +
"                <div");

WriteLiteral(" class=\"price-info\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"col-sm-8 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                                            <h3>\r\n                            " +
"                    <span");

WriteLiteral(" class=\"ng-binding\"");

WriteLiteral(" ng-bind=\"prod.price.formatted.withTax\"");

WriteLiteral("></span>\r\n                                                <span");

WriteLiteral(" class=\"sml ng-binding\"");

WriteLiteral(" ng-bind=\"prod.price.formatted.withTax\"");

WriteLiteral(@"></span>
                                            </h3>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>          
                    </div>
                </div>
            </div>
            <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral("></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n   \r\n");

        }
    }
}
#pragma warning restore 1591
