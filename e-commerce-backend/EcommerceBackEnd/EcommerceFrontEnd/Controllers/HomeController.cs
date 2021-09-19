using EcommerceFrontEnd.Models;
using EcommerceFrontEnd.Models.OtherProductModel;
using EcommerceFrontEnd.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMasterData _master;
        public HomeController(IMasterData master)
        {
            _master = master;
        }
        public IActionResult About()
        {
            return View();
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var token = await _master.Authorize();
                var products =await _master.GetOtherProduct(token.Token);
                return View(products);

            }catch(Exception)
            {

            }
            return View(new OtherProductModel());
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Faq()
        {
            return View();
        }
        public IActionResult NotFoundPage()
        {
            return View();
        }
    }
}
