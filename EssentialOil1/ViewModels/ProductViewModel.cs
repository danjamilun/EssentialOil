using EssentialOil1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssentialOil1.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<EssentialOil_Products> ProductsOfOil { get; set; }
        
    }
}
