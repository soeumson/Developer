using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.Menu;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd
{
    [Authorize]
    public class BaseController : Controller
    {
        private readonly DataContext _context;
        public BaseController(DataContext context)  
        {
            _context = context;
        }
    }
}
