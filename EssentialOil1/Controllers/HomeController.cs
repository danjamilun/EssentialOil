using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EssentialOil1.Models;
using EssentialOil1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EssentialOil1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            return View(new HomeViewModel
            {
            });
        }
    }
}
