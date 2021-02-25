using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using CookieDemo.Models;

namespace CookieDemo.Controllers
{
    public class CookieController : Controller
    {
        public IActionResult Index()
        {
            string cookieValue = Request.Cookies["has-been-here"];
            bool hasBeenHere = cookieValue != null;
            
            Response.Cookies.Append("has-been-here", DateTime.Now.ToString());
            
            var vm = new CookieViewModel
            {
                HasBeenHere = hasBeenHere
            };
            if (hasBeenHere)
            {
                vm.LastVisit = DateTime.Parse(cookieValue);
            }
            return View(vm);
        }

        public IActionResult Counter()
        {
            string cookieValue = Request.Cookies["number"];
            int number = 1;
            if (!String.IsNullOrEmpty(cookieValue))
            {
                number = int.Parse(cookieValue);
            }
            
            Response.Cookies.Append("number", $"{number + 1}");

            var vm = new CounterViewModel
            {
                Number = number
            };
            return View(vm);
        }
    }
}
