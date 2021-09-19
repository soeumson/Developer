using EcommerceFrontEnd.Extentions;
using EcommerceFrontEnd.Models.Products;
using EcommerceFrontEnd.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceFrontEnd.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IMasterData _master;
        public ProductsController(IMasterData master)
        {
            _master = master;
        }
        [HttpGet]
        public async Task<IActionResult> SingleProduct(string key)
        {
            try
            {
                var token = await _master.Authorize();
                var product = await _master.GetProductSingleModel(token.Token,key.UnProtection());
                return View(product);
            }
            catch (Exception)
            {

            }
            return View(new ProductSingleModel());
        }
        public IActionResult ProductDetail()
        {
            return View();
        }
        public async Task<IActionResult> AllProduct()
        {
            try
            {
               var token = await _master.Authorize();
               var product = await _master.GetProducts(token.Token);
            }
            catch(Exception)
            {
                
            }
            return View();
        }
    }
}
