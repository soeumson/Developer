using EcommerceFrontEnd.ApiConlletion;
using EcommerceFrontEnd.Models.Authorize;
using EcommerceFrontEnd.Models.Category;
using EcommerceFrontEnd.Models.OtherProductModel;
using EcommerceFrontEnd.Models.Products;
using EcommerceFrontEnd.Models.Shop;
using EcommerceFrontEnd.Service;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFrontEnd.Repository
{
    public class MasterDataRepository :HttpClientWithFactory ,IMasterData
    {
        private readonly IApiSetting _apiSetting;
        public MasterDataRepository(IHttpClientFactory factory,IApiSetting apiSetting) : base(factory) {
            _apiSetting = apiSetting;
        }
        public async Task<ResponseAuthorize> Authorize()
        {
            ResponseAuthorize result = null;
            try
            {
                AuthorizeModel auth = new AuthorizeModel
                {
                    Username = _apiSetting.Username,
                    Password = _apiSetting.Password
                };
                var message = new HttpRequestBuilder(_apiSetting.UrlBase)
                              .SetPath(_apiSetting.UrlAuthorize)
                              .HttpMethod(HttpMethod.Post)
                              .SetJsonContent<AuthorizeModel>(auth)
                              .GetHttpMessage();
                result = await SendRequest<ResponseAuthorize>(message);
                if (result == null)
                {
                    throw new Exception("Service not response");
                }
                else if (result.Code == 2001)
                {
                    throw new Exception(result.Message);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong " + ex.Message);
                throw new Exception("Something went wrong");
            }
            return result;
        }
        public async Task<ProductModel> GetProducts(string token)
        {
            ProductModel result = null;
            try
            {
                var message = new HttpRequestBuilder(_apiSetting.UrlBase)
                              .SetPath(_apiSetting.UrlProducts)
                              .HttpMethod(HttpMethod.Get)
                              .HeaderToken(token)
                              .GetHttpMessage();
                result = await SendRequest<ProductModel>(message);
                if (result == null)
                {
                    throw new Exception("Service not response");
                }
                else if (result.Code == 2001)
                {
                    throw new Exception(result.Message);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong " + ex.Message);
                throw new Exception("Something went wrong");
            }
            return result;
        }
        public async Task<ProductById> GetProductById(string token,string productId)
        {
            ProductById result = null;
            try
            {
                var message = new HttpRequestBuilder(_apiSetting.UrlBase)
                              .SetPath(_apiSetting.UrlByIdProduct)
                              .SetQueryString("?productid="+productId+"")
                              .HttpMethod(HttpMethod.Get)
                              .HeaderToken(token)
                              .GetHttpMessage();
                result = await SendRequest<ProductById>(message);
                if (result == null)
                {
                    throw new Exception("Service not response");
                }
                else if (result.Code == 2001)
                {
                    throw new Exception(result.Message);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong " + ex.Message);
                throw new Exception("Something went wrong");
            }
            return result;
        }
        public async Task<CategoryModel> GetCategories(string token)
        {
            CategoryModel result = null;
            try
            {
                var message = new HttpRequestBuilder(_apiSetting.UrlBase)
                              .SetPath(_apiSetting.UrlCategory)
                              .HttpMethod(HttpMethod.Get)
                              .HeaderToken(token)
                              .GetHttpMessage();
                result = await SendRequest<CategoryModel>(message);
                if (result == null)
                {
                    throw new Exception("Service not response");
                }
                else if (result.Code == 2001)
                {
                    throw new Exception(result.Message);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong " + ex.Message);
                throw new Exception("Something went wrong");
            }
            return result;
        }
        public async Task<ShopModel> GetShops(string token)
        {
            ShopModel result = null;
            try
            {
                var message = new HttpRequestBuilder(_apiSetting.UrlBase)
                              .SetPath(_apiSetting.UrlShop)
                              .HttpMethod(HttpMethod.Get)
                              .HeaderToken(token)
                              .GetHttpMessage();
                result = await SendRequest<ShopModel>(message);
                if (result == null)
                {
                    throw new Exception("Service not response");
                }
                else if (result.Code == 2001)
                {
                    throw new Exception(result.Message);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong " + ex.Message);
                throw new Exception("Something went wrong");
            }
            return result;
        }
        public async Task<OtherProductModel> GetOtherProduct(string token)
        {
            OtherProductModel result = null;
            try
            {
                var message = new HttpRequestBuilder(_apiSetting.UrlBase)
                              .SetPath(_apiSetting.UrlOtherProduct)
                              .HttpMethod(HttpMethod.Get)
                              .HeaderToken(token)
                              .GetHttpMessage();
                result = await SendRequest<OtherProductModel>(message);
                if (result == null)
                {
                    throw new Exception("Service not response");
                }
                else if (result.Code == 2001)
                {
                    throw new Exception(result.Message);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong " + ex.Message);
                throw new Exception("Something went wrong");
            }
            return result;
        }
        public async Task<ProductSingleModel> GetProductSingleModel(string token, string productId)
        {
            ProductSingleModel result = null;
            try
            {
                var message = new HttpRequestBuilder(_apiSetting.UrlBase)
                              .SetPath(_apiSetting.UrlSingleProduct)
                              .HttpMethod(HttpMethod.Get)
                               .SetQueryString("?productid=" + productId + "")
                              .HeaderToken(token)
                              .GetHttpMessage();
                result = await SendRequest<ProductSingleModel>(message);
                if (result == null)
                {
                    throw new Exception("Service not response");
                }
                else if (result.Code == 2001)
                {
                    throw new Exception(result.Message);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong " + ex.Message);
                throw new Exception("Something went wrong");
            }
            return result;
        }
    }
}
