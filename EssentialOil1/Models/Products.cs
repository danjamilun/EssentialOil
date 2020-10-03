using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssentialOil1.Models
{
    public class Products
    {
        public int ProductsId { get; set; }
        public string ProductsName { get; set; }
        IEnumerable<EssentialOil_Products> ProductsOfOil { get; set; }
    }
}
