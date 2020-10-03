using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using EssentialOil1.Models;
using EssentialOil1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EssentialOil1.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IEssential_OilRepository _oilRepository;
        public ProductsController(IEssential_OilRepository oilRepository)
        {
            _oilRepository = oilRepository;
        }
        public IActionResult List()
        {
            IEnumerable<EssentialOil_Products> products;

            products = _oilRepository.AllProducts.OrderBy(p => p.EssentialOil_ProductsId);

            if (products == null)
                return NotFound();
            else
                return View(new ProductViewModel
                {
                    ProductsOfOil = products
                });

        }

        public IActionResult Details(int id)
        {
            var item = _oilRepository.AllProducts.FirstOrDefault(p => p.EssentialOil_ProductsId == id);

            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }
        public IActionResult Oil_Products()
        {
            ViewBag.ProductName = "Essential Oil";
            string ProductName = "Essential Oil";            
            var oils = _oilRepository.AllProducts.Where(p => p.ProductsName == ProductName);
            if(oils == null)
            {
                NotFound();
            }
            return View(new ProductViewModel
            {
                ProductsOfOil = oils
            });
        }
        public IActionResult Soap_Products()
        {
            ViewBag.ProductName = "Soap of Essential Oil";
            string ProductName = "Soap of Essential Oil";
            var soap = _oilRepository.AllProducts.Where(p => p.ProductsName == ProductName);
            if (soap == null)
            {
                NotFound();
            }
            return View(new ProductViewModel
            {
                ProductsOfOil = soap
            });
        }
    }
}
    

