﻿using System.Collections.Generic;
using Omnicx.WebStore.Models.Catalog;
using System;
using Omnicx.WebStore.Models.Keys;
using Omnicx.WebStore.Models.Enums;

namespace Omnicx.WebStore.Models.Site
{
    [Serializable]
    public class SiteViewModel : IHaveSeoInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ViewType { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string HtmlBody { get; set; }
        public string HrefLang { get; set; }
        public string Canonical { get; set; }
        public bool NoFollow { get; set; }
        public bool ShowInSitemap { get; set; }
        public bool? AllowAnonymous { get; set; }
        public List<SiteViewComponentModel> Components { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string CanonicalTags { get; set; }
        public int RedirectTypeValue { get; set; }
        public int VersionNo { get; set; }
        public List<ScheduleItemModel> ScheduleItems { get; set; }

    }
    [Serializable]
    public class SiteViewComponentModel
    {
        public string ComponentId { get; set; }
        public SiteViewComponentTypes ComponentType { get; set; }
        public string Content { get; set; }
        public List<ProductModel> Products { get; set; }
        public List<BrandModel> Brands { get; set; }
        public List<BrandModel> SubBrands { get; set; }
        public List<CategoryModel> Categories{ get; set; }
        public List<CategoryModel> SubCategories{ get; set; }
        public List<ImageModel> Images { get; set; }
        public ImageModel Image { get; set; }
        public string DataType { get; set; }
        public string DataNumItemsRow { get; set; }
        public bool Autoplay { get; set; }
        public string SliderTime { get; set; }
        public List<BlogModel> Blogs { get; set; }
        public string Link { get; set; }
        public int DisplayOrder { get; set; }
        public string ProductListDisplayType { get; set; }
        public string CategoryListDisplayType { get; set; }
        public string BrandListDisplayType { get; set; }
        public string ProductEnableButton { get; set; }
        public string CategoryEnableButton { get; set; }
        public string BrandEnableButton { get; set; }

    }
}