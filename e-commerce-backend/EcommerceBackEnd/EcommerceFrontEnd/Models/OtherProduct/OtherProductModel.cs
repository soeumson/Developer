using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using EcommerceFrontEnd.Models.Products;

namespace EcommerceFrontEnd.Models.OtherProductModel
{
    
    public class OtherProductModel
    {
        [JsonProperty("Code")]
        public int Code { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("Data")]
        public Data Data { get; set; }
    }
    public class ProductArrival: Product { }

    public class ProductBestseller: Product { }

    public class FeatureProduct: Product { }

    public class SpecialProduct: Product { }

    public class ProductCategory
    {
        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("Products")]
        public List<Product> Products { get; set; }
    }

    public class Data
    {
        [JsonProperty("ProductArrival")]
        public List<ProductArrival> ProductArrival { get; set; }

        [JsonProperty("ProductBestseller")]
        public List<ProductBestseller> ProductBestseller { get; set; }

        [JsonProperty("FeatureProduct")]
        public List<FeatureProduct> FeatureProduct { get; set; }

        [JsonProperty("SpecialProduct")]
        public List<SpecialProduct> SpecialProduct { get; set; }

        [JsonProperty("ProductCategory")]
        public List<ProductCategory> ProductCategory { get; set; }
    }
}
