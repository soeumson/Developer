using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceFrontEnd.Controllers
{
    public class CheckOutController : Controller
    {
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult ViewCart()
        {
            return View();
        }
    }
}
