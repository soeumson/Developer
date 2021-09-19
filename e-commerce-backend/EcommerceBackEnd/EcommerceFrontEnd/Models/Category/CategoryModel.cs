using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceFrontEnd.Models.Category
{

    public class CategoryModel
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
        [JsonProperty("categoryID")]
        public string CategoryID { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("companyID")]
        public string CompanyID { get; set; }

        [JsonProperty("delete")]
        public bool Delete { get; set; }

        [JsonProperty("createBy")]
        public string CreateBy { get; set; }

        [JsonProperty("updateBy")]
        public string UpdateBy { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("encryted")]
        public object Encryted { get; set; }

    }


}
