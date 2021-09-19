using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceFrontEnd.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login_Register()
        {
            return View();
        }
        public IActionResult Wishlist()
        {
            return View();
        }
       
    }
}
