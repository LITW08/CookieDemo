using CookieDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CookieDemo.Controllers
{
    public class HomeController : Controller
    {
        private int _number = 0;
        
        public IActionResult Index()
        {
            _number++;
            var vm = new HomeViewModel()
            {
                Number = _number
            };
            
            return View(vm);
        }
    }
}
