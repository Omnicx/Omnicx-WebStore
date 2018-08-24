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
    
    #line 2 "..\..\Views\Search\DynamicListItems.cshtml"
    using Omnicx.API.SDK.Helpers;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 1 "..\..\Views\Search\DynamicListItems.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Search\DynamicListItems.cshtml"
    using Omnicx.WebStore.Models.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Search/DynamicListItems.cshtml")]
    public partial class _Views_Search_DynamicListItems_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Catalog.DynamicListModel>
    {
        public _Views_Search_DynamicListItems_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Search\DynamicListItems.cshtml"
  
    ViewBag.Title = Model != null ? Model.Name : "";
    Layout = "~/Views/Shared/_Layout.cshtml";

    Html.AddTitleParts(Model.Name);
    Html.AddMetaTitle(Model.MetaTitle);
    Html.AddMetaDescriptionParts(Model.MetaDescription);
    Html.AddMetaKeywordsParts(Model.MetaKeywords);
    Html.AddCanonicalUrl(Model.CanonicalTags);
    Html.AddDataLayer(DataLayerObjectType.CollectionDetail, Model);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n        <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n            <li><a");

WriteLiteral(" href=\"/\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\Search\DynamicListItems.cshtml"
                       Write(LT("ProductListing.Breadcrumb.Home", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

            
            #line 24 "..\..\Views\Search\DynamicListItems.cshtml"
    
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Search\DynamicListItems.cshtml"
     if (Model != null)
    {
        if ((Model.ListType == ListDatasetSource.Product && Model.Products == null) || (Model.ListType == ListDatasetSource.Category && Model.Categories == null) || (Model.ListType == ListDatasetSource.Image && Model.Images == null) || (Model.ListType == ListDatasetSource.Brand && Model.Brands == null) || (Model.ListType == ListDatasetSource.SubBrand && Model.SubBrands == null) || (Model.ListType == ListDatasetSource.Blog && Model.Blogs == null))
        {
            
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Search\DynamicListItems.cshtml"
       Write(Html.Partial("~/Views/Search/_NoResults.cshtml"));

            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Search\DynamicListItems.cshtml"
                                                                     
        }

        if (Model.ListType == ListDatasetSource.Product && Model.Products != null)
        {
            foreach (var prod in Model.Products.Results)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-6 col-sm-3 col-md-3 col-lg-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"product-container\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"product-image-384\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1827), Tuple.Create("\"", 1845)
, Tuple.Create(Tuple.Create("", 1834), Tuple.Create("/", 1834), true)
            
            #line 38 "..\..\Views\Search\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 1835), Tuple.Create<System.Object, System.Int32>(prod.Slug
            
            #line default
            #line hidden
, 1835), false)
);

WriteLiteral("> <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1852), Tuple.Create("\"", 1869)
            
            #line 38 "..\..\Views\Search\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 1858), Tuple.Create<System.Object, System.Int32>(prod.Image
            
            #line default
            #line hidden
, 1858), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(" class=\"img-responsive img-full\"");

WriteLiteral("></a>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-detail\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2071), Tuple.Create("\"", 2089)
, Tuple.Create(Tuple.Create("", 2078), Tuple.Create("/", 2078), true)
            
            #line 41 "..\..\Views\Search\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 2079), Tuple.Create<System.Object, System.Int32>(prod.Slug
            
            #line default
            #line hidden
, 2079), false)
);

WriteLiteral("><h4>");

            
            #line 41 "..\..\Views\Search\DynamicListItems.cshtml"
                                                 Write(prod.Name);

            
            #line default
            #line hidden
WriteLiteral("</h4></a>\r\n                            <p>");

            
            #line 42 "..\..\Views\Search\DynamicListItems.cshtml"
                          Write(prod.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <h5>");

            
            #line 43 "..\..\Views\Search\DynamicListItems.cshtml"
                           Write(prod.Brand);

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n                            <p");

WriteLiteral(" class=\"price\"");

WriteLiteral(">\r\n");

            
            #line 45 "..\..\Views\Search\DynamicListItems.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Search\DynamicListItems.cshtml"
                                 if (@prod.Price != null)
                                { 
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\Search\DynamicListItems.cshtml"
                             Write(prod.Price.Formatted.WithTax);

            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\Search\DynamicListItems.cshtml"
                                                                }

            
            #line default
            #line hidden
WriteLiteral("                            </p>\r\n                        </div>\r\n               " +
"         <div");

WriteLiteral(" class=\"product-button\"");

WriteLiteral(">\r\n                            <button");

WriteAttribute("ng-click", Tuple.Create(" ng-click=\"", 2548), Tuple.Create("\"", 2595)
, Tuple.Create(Tuple.Create("", 2559), Tuple.Create("gm.addToBasket(\'", 2559), true)
            
            #line 50 "..\..\Views\Search\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 2575), Tuple.Create<System.Object, System.Int32>(prod.RecordId
            
            #line default
            #line hidden
, 2575), false)
, Tuple.Create(Tuple.Create("", 2589), Tuple.Create("\',1,0)", 2589), true)
);

WriteLiteral(" class=\"btn btn-success\"");

WriteLiteral(">Buy Now</button>\r\n                        </div>\r\n                    </div>\r\n  " +
"              </div>\r\n");

            
            #line 54 "..\..\Views\Search\DynamicListItems.cshtml"
            }
        }


        if (Model.ListType == ListDatasetSource.Image && Model.Images != null)
        {
            foreach (var img in Model.Images)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-6 col-sm-3 col-md-3 col-lg-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"product-container\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"product-image-384\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3113), Tuple.Create("\"", 3129)
            
            #line 65 "..\..\Views\Search\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 3120), Tuple.Create<System.Object, System.Int32>(img.Link
            
            #line default
            #line hidden
, 3120), false)
);

WriteLiteral(">\r\n                                <img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 3169), Tuple.Create("\"", 3186)
            
            #line 66 "..\..\Views\Search\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 3178), Tuple.Create<System.Object, System.Int32>(img.Url
            
            #line default
            #line hidden
, 3178), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(" class=\"img-responsive img-full\"");

WriteLiteral(">\r\n                            </a>\r\n                        </div>\r\n            " +
"        </div>\r\n                </div>\r\n");

            
            #line 71 "..\..\Views\Search\DynamicListItems.cshtml"
            }
        }

        if (Model.ListType == ListDatasetSource.Brand && Model.Brands != null)
        {
            foreach (var brand in Model.Brands)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-6 col-sm-3 col-md-3 col-lg-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"product-container\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"product-image-384\"");

WriteLiteral(">\r\n                            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 3778), Tuple.Create("\"", 3804)
            
            #line 81 "..\..\Views\Search\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 3784), Tuple.Create<System.Object, System.Int32>(brand.LogoImageName
            
            #line default
            #line hidden
, 3784), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(" class=\"img-responsive img-full\"");

WriteLiteral(">\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-detail\"");

WriteLiteral(">\r\n                            <h4>");

            
            #line 84 "..\..\Views\Search\DynamicListItems.cshtml"
                           Write(brand.ManufacturerName);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                            <p>");

            
            #line 85 "..\..\Views\Search\DynamicListItems.cshtml"
                          Write(brand.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-button\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4205), Tuple.Create("\"", 4224)
, Tuple.Create(Tuple.Create("", 4212), Tuple.Create("/", 4212), true)
            
            #line 88 "..\..\Views\Search\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 4213), Tuple.Create<System.Object, System.Int32>(brand.Link
            
            #line default
            #line hidden
, 4213), false)
);

WriteLiteral(" class=\"shop-now\"");

WriteLiteral(">View</a>\r\n                        </div>\r\n                    </div>\r\n          " +
"      </div>\r\n");

            
            #line 92 "..\..\Views\Search\DynamicListItems.cshtml"
            }
        }
        if (Model.ListType == ListDatasetSource.SubBrand && Model.SubBrands != null)
        {
            foreach (var brand in Model.SubBrands)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-6 col-sm-3 col-md-3 col-lg-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"product-container\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"product-image-384\"");

WriteLiteral(">\r\n                            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 4736), Tuple.Create("\"", 4762)
            
            #line 101 "..\..\Views\Search\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 4742), Tuple.Create<System.Object, System.Int32>(brand.LogoImageName
            
            #line default
            #line hidden
, 4742), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(" class=\"img-responsive img-full\"");

WriteLiteral(">\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-detail\"");

WriteLiteral(">\r\n                            <h4>");

            
            #line 104 "..\..\Views\Search\DynamicListItems.cshtml"
                           Write(brand.ManufacturerName);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                            <p>");

            
            #line 105 "..\..\Views\Search\DynamicListItems.cshtml"
                          Write(brand.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-button\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5163), Tuple.Create("\"", 5182)
, Tuple.Create(Tuple.Create("", 5170), Tuple.Create("/", 5170), true)
            
            #line 108 "..\..\Views\Search\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 5171), Tuple.Create<System.Object, System.Int32>(brand.Link
            
            #line default
            #line hidden
, 5171), false)
);

WriteLiteral(" class=\"shop-now\"");

WriteLiteral(">View</a>\r\n                        </div>\r\n                    </div>\r\n          " +
"      </div>\r\n");

            
            #line 112 "..\..\Views\Search\DynamicListItems.cshtml"
            }
        }
        if (Model.ListType == ListDatasetSource.Category && Model.Categories != null)
        {
            foreach (var cat in Model.Categories)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-6 col-sm-3 col-md-3 col-lg-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"category-container\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"product-image-384\"");

WriteLiteral(">\r\n                            <img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 5695), Tuple.Create("\"", 5714)
            
            #line 121 "..\..\Views\Search\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 5704), Tuple.Create<System.Object, System.Int32>(cat.Image
            
            #line default
            #line hidden
, 5704), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(" class=\"img-responsive img-full\"");

WriteLiteral(">\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-detail\"");

WriteLiteral(">\r\n                            <h4>");

            
            #line 124 "..\..\Views\Search\DynamicListItems.cshtml"
                           Write(cat.Name);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                            ");

WriteLiteral("\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-button\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 6103), Tuple.Create("\"", 6120)
, Tuple.Create(Tuple.Create("", 6110), Tuple.Create("/", 6110), true)
            
            #line 128 "..\..\Views\Search\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 6111), Tuple.Create<System.Object, System.Int32>(cat.Link
            
            #line default
            #line hidden
, 6111), false)
);

WriteLiteral(" class=\"shop-now\"");

WriteLiteral(">View</a>\r\n                        </div>\r\n                    </div>\r\n          " +
"      </div>\r\n");

            
            #line 132 "..\..\Views\Search\DynamicListItems.cshtml"
            }
        }

        if (Model.ListType == ListDatasetSource.Blog && Model.Blogs != null)
        {
            foreach (var blog in Model.Blogs)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-6 col-sm-3 col-md-3 col-lg-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"product-container\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"product-image-384\"");

WriteLiteral(">\r\n                            <img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 6621), Tuple.Create("\"", 6645)
            
            #line 142 "..\..\Views\Search\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 6630), Tuple.Create<System.Object, System.Int32>(blog.BlogImage
            
            #line default
            #line hidden
, 6630), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(" class=\"img-responsive img-full\"");

WriteLiteral(">\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-detail\"");

WriteLiteral(">\r\n                            <h4>");

            
            #line 145 "..\..\Views\Search\DynamicListItems.cshtml"
                           Write(blog.Title);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                            <p>");

            
            #line 146 "..\..\Views\Search\DynamicListItems.cshtml"
                          Write(blog.Category);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <p>");

            
            #line 147 "..\..\Views\Search\DynamicListItems.cshtml"
                          Write(blog.Author);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-button\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 7079), Tuple.Create("\"", 7102)
, Tuple.Create(Tuple.Create("", 7086), Tuple.Create("/blogs/", 7086), true)
            
            #line 150 "..\..\Views\Search\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 7093), Tuple.Create<System.Object, System.Int32>(blog.URL
            
            #line default
            #line hidden
, 7093), false)
);

WriteLiteral(" class=\"shop-now\"");

WriteLiteral(">View Blogs</a>\r\n                        </div>\r\n                    </div>\r\n    " +
"            </div>\r\n");

            
            #line 154 "..\..\Views\Search\DynamicListItems.cshtml"
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
