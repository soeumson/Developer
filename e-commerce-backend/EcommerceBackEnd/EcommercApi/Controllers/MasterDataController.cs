using EcommercApi.Models;
using EcommercApi.Models.Products;
using EcommercApi.Models.ResponseModel;
using EcommercApi.Services;
using Ecommerce.Core.Model.Category;
using Ecommerce.Core.Model.Company;
using Ecommerce.Core.Model.Model;
using Ecommerce.Core.Model.Product;
using Ecommerce.Core.Model.Uom;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EcommercApi.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class MasterDataController : ControllerBase
    {
        private readonly IMasterData _master;
        public MasterDataController(IMasterData master)
        {
            _master = master;
        }
        [HttpGet("getproducts")]
        public IActionResult GetProduct()
        {
            try
            {
                return Ok(new ResponseModel<Product>
                {
                    Code = 2000,
                    Message = "success",
                    Data = _master.GetProducts()
                });
            }
            catch(Exception ex)
            {
                Log.Error("Something went wrong get api products " + ex);
                return Ok(new ResponseModel<Product>
                {
                    Code=2001,
                    Message="Something went wrong",
                    Data=null
                });
            }
            
        }
        [HttpGet("getsingleproduct")]
        public IActionResult GetSingleProduct(string productid)
        {
            try
            {
                return Ok(new ResponseModelSingle<SingleProduct>
                {
                    Code = 2000,
                    Message = "success",
                    Data = _master.GetSingleProduct(productid)
                });
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong get api single products  " + ex);
                return Ok(new ResponseModelSingle<SingleProduct>
                {
                    Code = 2001,
                    Message = "Something went wrong",
                    Data = null
                });
            }
        }
        [HttpGet("getproductbyid")]
        public IActionResult GetProductById(string productid)
        {
            try
            {
                return Ok(new ResponseModelSingle<Product>
                {
                    Code = 2000,
                    Message = "success",
                    Data = _master.GetProductById(productid)
                });
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong get api products by id  " + ex);
                return Ok(new ResponseModelSingle<Product>
                {
                    Code = 2001,
                    Message = "Something went wrong",
                    Data = null
                });
            }
        }
        [HttpGet("getcategories")]
        public IActionResult GetCategories()
        {
            try
            {
                return Ok(new ResponseModel<Category>
                {
                    Code = 2000,
                    Message = "success",
                    Data = _master.GetCategories()
                });
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong get category " + ex);
                return Ok(new ResponseModel<Category>
                {
                    Code = 2001,
                    Message = "Something went wrong",
                    Data = null
                });
            }
        }
        [HttpGet("getshop")]
        public IActionResult GetShop()
        {
            try
            {
                return Ok(new ResponseModel<CompanyProfile>
                {
                    Code = 2000,
                    Message = "success",
                    Data = _master.GetShop()
                });
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong get shop " + ex);
                return Ok(new ResponseModel<CompanyProfile>
                {
                    Code = 2001,
                    Message = "Something went wrong",
                    Data = null
                });
            }
        }
        [HttpGet("getotherproduct")]
        public IActionResult GetOtherProduct()
        {
            try
            {
                return Ok( new ResponseModelSingle<OtherProducts>
                {
                    Code = 2000,
                    Message = "success",
                    Data = _master.GetOtherProducts()
                });
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong get other product " + ex);
                return Ok(new ResponseModelSingle<OtherProducts>
                {
                    Code = 2001,
                    Message = "Something went wrong",
                    Data = null
                });
            }
        }
        [HttpGet("getsubcategory")]
        public IActionResult GetSubCategory()
        {
            try
            {
                return Ok(new ResponseModel<SubCategory>
                {
                    Code = 2000,
                    Message = "success",
                    Data = _master.GetSubCategories()
                });
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong get sub category " + ex);
                return Ok(new ResponseModel<SubCategory>
                {
                    Code = 2001,
                    Message = "Something went wrong",
                    Data = null
                });
            }
        }
        [HttpGet("getuom")]
        public IActionResult GetUom()
        {
            try
            {
                return Ok(new ResponseModel<Uom>
                {
                    Code = 2000,
                    Message = "success",
                    Data = _master.GetUoms()
                });
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong get uom " + ex);
                return Ok(new ResponseModel<Uom>
                {
                    Code = 2001,
                    Message = "Something went wrong",
                    Data = null
                });
            }
        }
        [HttpGet("getmodelproduct")]
        public IActionResult GetModelProduct()
        {
            try
            {
                return Ok(new ResponseModel<ModelProduct>
                {
                    Code = 2000,
                    Message = "success",
                    Data = _master.GetModelProducts()
                });
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong get model product " + ex);
                return Ok(new ResponseModel<ModelProduct>
                {
                    Code = 2001,
                    Message = "Something went wrong",
                    Data = null
                });
            }
        }
    }
}
