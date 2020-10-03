using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssentialOil1.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public EssentialOil_Products Product { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
