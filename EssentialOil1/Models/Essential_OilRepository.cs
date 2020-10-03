using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace EssentialOil1.Models
{
    public class Essential_OilRepository : IEssential_OilRepository
    {
        private readonly AppDbContext _appDbContext;

        public Essential_OilRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<EssentialOil_Products> AllProducts
        {
            get
            {
                return _appDbContext.EssentialOil_Products;
            }

        }
        public EssentialOil_Products GetProductById(int OilId)
        {
            return _appDbContext.EssentialOil_Products.Include(p => p.Products).FirstOrDefault(s => s.EssentialOil_ProductsId == OilId);
        }
        
    }
}
