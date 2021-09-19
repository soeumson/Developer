using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceFrontEnd.Models.Products
{
    public class Product
    {
        [JsonProperty("productID")]
        public string ProductID { get; set; }

        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("categoryID")]
        public string CategoryID { get; set; }

        [JsonProperty("subCategoryID")]
        public string SubCategoryID { get; set; }

        [JsonProperty("modelID")]
        public string ModelID { get; set; }

        [JsonProperty("uomID")]
        public string UomID { get; set; }

        [JsonProperty("qty")]
        public double Qty { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("images")]
        public string Images { get; set; }

        [JsonProperty("manageStock")]
        public bool ManageStock { get; set; }

        [JsonProperty("statusAvailable")]
        public bool StatusAvailable { get; set; }

        [JsonProperty("discountActive")]
        public bool DiscountActive { get; set; }

        [JsonProperty("discountValue")]
        public double? DiscountValue { get; set; }

        [JsonProperty("discountType")]
        public string DiscountType { get; set; }

        [JsonProperty("feeIncluded")]
        public int? FeeIncluded { get; set; }

        [JsonProperty("vatIncluded")]
        public string? VatIncluded { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("delete")]
        public bool Delete { get; set; }

        [JsonProperty("totalOrder")]
        public double? TotalOrder { get; set; }

        [JsonProperty("favourite")]
        public double? Favourite { get; set; }

        [JsonProperty("companyID")]
        public string CompanyID { get; set; }

        [JsonProperty("createBy")]
        public string CreateBy { get; set; }

        [JsonProperty("updateBy")]
        public string UpdateBy { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("codeTemp")]
        public string CodeTemp { get; set; }

        [JsonProperty("encryted")]
        public string Encryted { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("subCategoryName")]
        public string SubCategoryName { get; set; }

        [JsonProperty("modelName")]
        public string ModelName { get; set; }

        [JsonProperty("uomName")]
        public string UomName { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }
        [JsonProperty("formFile")]
        public object FormFile { get; set; }
    }
}
