using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceFrontEnd.Models.Shop
{
    public class ShopModel
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public List<Data> Data { get; set; }
    } 
    public class Data
    {
        [JsonProperty("companyID")]
        public string CompanyID { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("companyDescription")]
        public string CompanyDescription { get; set; }

        [JsonProperty("companyAddress")]
        public string CompanyAddress { get; set; }

        [JsonProperty("companyPhone")]
        public string CompanyPhone { get; set; }

        [JsonProperty("companyEmail")]
        public string CompanyEmail { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("bannerImage")]
        public object BannerImage { get; set; }

        [JsonProperty("currencyID")]
        public string CurrencyID { get; set; }

        [JsonProperty("userID")]
        public string UserID { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("encryted")]
        public object Encryted { get; set; }

        [JsonProperty("currencyName")]
        public string CurrencyName { get; set; }

        [JsonProperty("createBy")]
        public string CreateBy { get; set; }

        [JsonProperty("updateBy")]
        public string UpdateBy { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }
    }
}
