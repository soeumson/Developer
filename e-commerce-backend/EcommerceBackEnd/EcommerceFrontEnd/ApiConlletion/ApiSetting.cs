using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceFrontEnd.ApiConlletion
{
    public class ApiSetting : IApiSetting
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string UrlBase { get; set; }
        public string UrlAuthorize { get; set; }
        public string UrlProducts { get; set; }
        public string UrlByIdProduct { get; set; }
        public string UrlCategory { get; set; }
        public string UrlShop { get; set; }
        public string UrlOtherProduct { get; set; }
        public string UrlSingleProduct { get; set; }
    }
}
