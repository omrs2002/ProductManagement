﻿using ProductManagement.Products;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace ProductManagement.Web.PageModels
{
    public class CreateEditProductViewModel
    {
        [SelectItems("Categories")]
        [DisplayName("Category")]
        public Guid CategoryId { get; set; }
        [Required]
        [StringLength(ProductConsts.MaxNameLength)]
        public string Name { get; set; }
        public float Price { get; set; }
        public bool IsFreeCargo { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public ProductStockState StockState { get; set; }
    }

}
