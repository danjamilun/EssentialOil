using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssentialOil1.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<EssentialOil_Products> EssentialOil_Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<EssentialOil_Products>().HasData(new EssentialOil_Products
            {
                EssentialOil_ProductsId = 1,
                Name= "Lavender Oil",
                LongDescription="The most popular essential oil because of its versatility and well-liked floral, herbal aroma, lavender can be used in a variety of ways to inspire calm and relaxation. Most commonly known for its relaxing effects on the body, terapeutic-grade lavender has been highly regarded for the skin. It may be used to cleanse cuts, bruises and skin irritations. The fragrance is calming, relaxing and balancing-phsysically and emotionally", 
                Aroma="Floral, herbal",           
                ImageUrl= "https://insigniaseniorliving.com/wp-content/uploads/2020/05/lavender-essential-oil-1.jpg",
                InStock=true,             
                Price = 11.99M,
                ProductsName = "Essential Oil",
               
            }) ;
            modelBuilder.Entity<EssentialOil_Products>().HasData(new EssentialOil_Products
            {
                EssentialOil_ProductsId = 2,
                Name = "Peppermint Oil",
                LongDescription = "The menthol, herbal aroma of peppermmint essential oil can be used in many ways to uplift and invigorate. You can also apply it topically to create a cool, tingling sensation on the skin, which can be very soothing after hard physical activity.",
                Aroma = "Menthol, herbal",
                ImageUrl = "https://i0.wp.com/cdn-prod.medicalnewstoday.com/content/images/articles/321/321598/essential-oils-such-as-peppermint-are-good-for-sore-throat.jpg?w=1155&h=1541",
                InStock = true,                
                Price = 11.99M,
                ProductsName = "Essential Oil",
               
            });
            modelBuilder.Entity<EssentialOil_Products>().HasData(new EssentialOil_Products
            {
                EssentialOil_ProductsId = 3,
                Name = "Eucalyptus Oil",
                LongDescription = "Its one of the best essential oils for sore throats, cough, seasonal allergies and headache. Eucalyptus oil benefit are due to its ability to stimulate immunity, provide antioxidant protection and improve respiratory circulation",
                Aroma = "Foresty, medical",                
                ImageUrl = "https://www.aromaweb.com/images/botanicals/eucalyptus-globulus-essential-oil.jpg",
                InStock = true,                
                Price = 11.99M,
                ProductsName = "Essential Oil",
                
            });
            modelBuilder.Entity<EssentialOil_Products>().HasData(new EssentialOil_Products
            {
                EssentialOil_ProductsId = 4,
                Name = "Rosemary Oil",
                LongDescription = "Rosemary essential oil can bring uplifting, energizing and purifying benefits to your airspace and body care",
                Aroma = "Herbal, medical",                
                ImageUrl = "https://wellnessaromas.b-cdn.net/wp-content/uploads/2018/08/wellnessaromas-aromatherapy-essential-oil_rosemary-oil-benefits-uses-1024x683.jpg",
                InStock = true,                
                Price = 11.99M,
                ProductsName = "Essential Oil",
                
            });
            modelBuilder.Entity<EssentialOil_Products>().HasData(new EssentialOil_Products
            {
                EssentialOil_ProductsId = 5,
                Name = "Grapefruit Oil",
                LongDescription = "The health benefits of grapefruit essential oil can be attributed to its properties as a diuretic, stimulant, antidepressant, antiseptic and tonic substance. This oil is effective in protecting the body from all harm done by various oxidants and toxins.",
                Aroma = "Tangy, citrusy",                
                ImageUrl = "https://i0.wp.com/images-prod.healthline.com/hlcmsresource/images/AN_images/grapefruit-essential-oil-1296x728-feature.jpg?w=1155&h=1528",
                InStock = true,                
                Price = 11.99M,
                ProductsName = "Essential Oil",
                
            });
            modelBuilder.Entity<EssentialOil_Products>().HasData(new EssentialOil_Products
            {
                EssentialOil_ProductsId = 6,
                Name = "Lemon Oil",
                LongDescription = "Fresh and fruity, lemon essential oil is often used for home cleaning and air freshening, but also be used for many body care products",
                Aroma = "Fruity, like lemon peel",                
                ImageUrl = "https://cdn.thetruthaboutcancer.com/wp-content/uploads/20190125170948/lemon-essential-oil-cancer-fighting-benefits.jpg",
                InStock = true,                
                Price = 11.99M,
                ProductsName = "Essential Oil"

                
            });
            modelBuilder.Entity<EssentialOil_Products>().HasData(new EssentialOil_Products
            {
                EssentialOil_ProductsId = 7,
                Name="Lavender soap",
                LongDescription= "Refreshing and rejuvenating to even the most sensitive skin, just a small amount of this fragrant soap cleanses and conditions your skin without leaving it dry or irritated. Infused with lavender essential oil",
                Aroma = "Floral, herbal",
                InStock=true,
                Price=14.99M,
                ImageUrl= "https://knickoftime.net/wp-content/uploads/2018/04/Homemade-Lavender-Rosemary-Essential-Oil-Goats-Milk-Soap-Knick-of-Time.jpg",
                ProductsName = "Soap of Essential Oil",
                
            });
            modelBuilder.Entity<EssentialOil_Products>().HasData(new EssentialOil_Products
            {
                EssentialOil_ProductsId = 8,
                Name = "Peppermint soap",
                LongDescription= "Deeply hydrate your skin while gently extracting excess oil with the Peppermint bar. Its stimulating aroma invigorates the senses while reviving natural energy. Perfect for a morning cleanse, the Peppermint bar has a tingling effect to help heal muscle and joint soreness",
                Aroma = "Menthol, herbal",
                InStock = true,
                Price = 14.99M,
                ImageUrl = "https://sep.yimg.com/ay/yhst-11598564130842/peppermint-tea-tree-shampoo-bar-5.gif",
                ProductsName = "Soap of Essential Oil",
                
            });
            modelBuilder.Entity<EssentialOil_Products>().HasData(new EssentialOil_Products
            {
                EssentialOil_ProductsId = 9,
                Name = "Eucalyptus soap",
                LongDescription= "Inhaling the oils in eucalyptus soap can help loosen congestion, ease coughs, help treat mild asthma, and sinus problems.",
                Aroma = "Foresty, medical",
                InStock = true,
                Price = 14.99M,
                ImageUrl = "https://i.pinimg.com/originals/69/ba/a6/69baa63c9776e013e289f5a0bdc3f8c1.jpg",
                ProductsName = "Soap of Essential Oil",
                
            });
            modelBuilder.Entity<EssentialOil_Products>().HasData(new EssentialOil_Products
            {
                EssentialOil_ProductsId = 10,
                Name = "Rosemary soap",
                LongDescription= "Rosemary has natural antiseptic properties and free radicals that can protect skin cells from sun damage",
                Aroma= "Herbal, medical",
                InStock=true,
                Price=14.99M,
                ImageUrl = "https://image.freepik.com/free-photo/natural-soap-with-rosemary-essential-oil_163253-7.jpg",
                ProductsName = "Soap of Essential Oil",
                
            });
            modelBuilder.Entity<EssentialOil_Products>().HasData(new EssentialOil_Products
            {
                EssentialOil_ProductsId = 11,
                Name = "Grapefruit soap",
                LongDescription= "Gently Exfoliating, Moisturizing, Calming, Soothing, Purifying, Invigorating and Refreshing",
                Aroma = "Tangy, citrusy",
                InStock = true,
                Price = 14.99M,
                ImageUrl = "https://sep.yimg.com/ay/yhst-11598564130842/grapefruit-all-natural-soap-facial-soap-handmade-essential-oil-soap-7.gif",
                ProductsName = "Soap of Essential Oil",
                
            });
            modelBuilder.Entity<EssentialOil_Products>().HasData(new EssentialOil_Products
            {
                EssentialOil_ProductsId = 12,
                Name = "Lemon soap",
                LongDescription= "Leaves your skin feeling soft, smooth and re-hydrated.Natural hand made hand soap, great for hand,face or body.",
                Aroma = "Fruity, like lemon peel",
                InStock = true,
                Price = 14.99M,
                ImageUrl = "https://img.tradees.com/file/upload/2020/07/19/lemon-essential-oil-glycerin-soap-handmade-soap-beauty-soap-281004.jpg",
                ProductsName = "Soap of Essential Oil",
               
            });

        }
                 
    }
}
