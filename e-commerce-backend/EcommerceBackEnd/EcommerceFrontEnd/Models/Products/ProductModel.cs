using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceFrontEnd.Models.Products
{
    public class ProductModel
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public List<Product> Products { get; set; }
    }
    public class ProductById
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public Product Product { get; set; }
    }
    public class ProductSingleModel
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ProductSingelTemp Product { get; set; }
    }
    public class ProductSingelTemp
    {
        [JsonProperty("product")]
        public Product Product { get; set; }

        [JsonProperty("relateProducts")]
        public List<Product> RelateProducts { get; set; }
        [JsonProperty("modelProducts")]
        public List<Product> ModelProducts { get; set; }
    }
}
