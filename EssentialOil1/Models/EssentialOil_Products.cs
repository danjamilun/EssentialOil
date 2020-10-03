using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EssentialOil1.Models
{
    public class EssentialOil_Products
    {
        
        public int EssentialOil_ProductsId { get; set; }
        public string Name { get; set; }
        public string LongDescription { get; set; }
        public string Aroma { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool InStock { get; set; }
        public Products Products { get; set; }
        public string ProductsName  { get; set; }

    }
}
