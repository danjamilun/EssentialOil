using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssentialOil1.Models
{
    public interface IEssential_OilRepository
    {
        IEnumerable<EssentialOil_Products> AllProducts { get; }
        EssentialOil_Products GetProductById(int Oil_Id);
       
    }
}
