using EssentialOil1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssentialOil1.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<EssentialOil_Products> oils { get; set; }        
        
    }
}
