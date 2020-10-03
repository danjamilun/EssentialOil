using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EssentialOil1.Models;
using EssentialOil1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EssentialOil1.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IEssential_OilRepository _productsRepository;        
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IEssential_OilRepository productsRepository, ShoppingCart shoppingCart)
        {
            _productsRepository = productsRepository;           
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }
        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var selectedProduct = _productsRepository.AllProducts.FirstOrDefault(p => p.EssentialOil_ProductsId==productId);

            if (selectedProduct != null)
            {
                _shoppingCart.AddToCart(selectedProduct, 1);
            }
            return RedirectToAction("Index");
        }        
        public RedirectToActionResult RemoveFromShoppingCart_Oil(int productId)
        {
            var selectedProduct = _productsRepository.AllProducts.FirstOrDefault(c => c.EssentialOil_ProductsId==productId);

            if (selectedProduct != null)
            {
                _shoppingCart.RemoveFromCart(selectedProduct);
            }
            return RedirectToAction("Index");
        }        
    }
}
