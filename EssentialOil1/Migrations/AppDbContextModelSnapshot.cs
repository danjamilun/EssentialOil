﻿// <auto-generated />
using System;
using EssentialOil1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EssentialOil1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EssentialOil1.Models.EssentialOil_Products", b =>
                {
                    b.Property<int>("EssentialOil_ProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aroma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProductsId")
                        .HasColumnType("int");

                    b.Property<string>("ProductsName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EssentialOil_ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("EssentialOil_Products");

                    b.HasData(
                        new
                        {
                            EssentialOil_ProductsId = 1,
                            Aroma = "Floral, herbal",
                            ImageUrl = "https://insigniaseniorliving.com/wp-content/uploads/2020/05/lavender-essential-oil-1.jpg",
                            InStock = true,
                            LongDescription = "The most popular essential oil because of its versatility and well-liked floral, herbal aroma, lavender can be used in a variety of ways to inspire calm and relaxation. Most commonly known for its relaxing effects on the body, terapeutic-grade lavender has been highly regarded for the skin. It may be used to cleanse cuts, bruises and skin irritations. The fragrance is calming, relaxing and balancing-phsysically and emotionally",
                            Name = "Lavender Oil",
                            Price = 11.99m,
                            ProductsName = "Essential Oil"
                        },
                        new
                        {
                            EssentialOil_ProductsId = 2,
                            Aroma = "Menthol, herbal",
                            ImageUrl = "https://i0.wp.com/cdn-prod.medicalnewstoday.com/content/images/articles/321/321598/essential-oils-such-as-peppermint-are-good-for-sore-throat.jpg?w=1155&h=1541",
                            InStock = true,
                            LongDescription = "The menthol, herbal aroma of peppermmint essential oil can be used in many ways to uplift and invigorate. You can also apply it topically to create a cool, tingling sensation on the skin, which can be very soothing after hard physical activity.",
                            Name = "Peppermint Oil",
                            Price = 11.99m,
                            ProductsName = "Essential Oil"
                        },
                        new
                        {
                            EssentialOil_ProductsId = 3,
                            Aroma = "Foresty, medical",
                            ImageUrl = "https://www.aromaweb.com/images/botanicals/eucalyptus-globulus-essential-oil.jpg",
                            InStock = true,
                            LongDescription = "Its one of the best essential oils for sore throats, cough, seasonal allergies and headache. Eucalyptus oil benefit are due to its ability to stimulate immunity, provide antioxidant protection and improve respiratory circulation",
                            Name = "Eucalyptus Oil",
                            Price = 11.99m,
                            ProductsName = "Essential Oil"
                        },
                        new
                        {
                            EssentialOil_ProductsId = 4,
                            Aroma = "Herbal, medical",
                            ImageUrl = "https://wellnessaromas.b-cdn.net/wp-content/uploads/2018/08/wellnessaromas-aromatherapy-essential-oil_rosemary-oil-benefits-uses-1024x683.jpg",
                            InStock = true,
                            LongDescription = "Rosemary essential oil can bring uplifting, energizing and purifying benefits to your airspace and body care",
                            Name = "Rosemary Oil",
                            Price = 11.99m,
                            ProductsName = "Essential Oil"
                        },
                        new
                        {
                            EssentialOil_ProductsId = 5,
                            Aroma = "Tangy, citrusy",
                            ImageUrl = "https://i0.wp.com/images-prod.healthline.com/hlcmsresource/images/AN_images/grapefruit-essential-oil-1296x728-feature.jpg?w=1155&h=1528",
                            InStock = true,
                            LongDescription = "The health benefits of grapefruit essential oil can be attributed to its properties as a diuretic, stimulant, antidepressant, antiseptic and tonic substance. This oil is effective in protecting the body from all harm done by various oxidants and toxins.",
                            Name = "Grapefruit Oil",
                            Price = 11.99m,
                            ProductsName = "Essential Oil"
                        },
                        new
                        {
                            EssentialOil_ProductsId = 6,
                            Aroma = "Fruity, like lemon peel",
                            ImageUrl = "https://cdn.thetruthaboutcancer.com/wp-content/uploads/20190125170948/lemon-essential-oil-cancer-fighting-benefits.jpg",
                            InStock = true,
                            LongDescription = "Fresh and fruity, lemon essential oil is often used for home cleaning and air freshening, but also be used for many body care products",
                            Name = "Lemon Oil",
                            Price = 11.99m,
                            ProductsName = "Essential Oil"
                        },
                        new
                        {
                            EssentialOil_ProductsId = 7,
                            Aroma = "Floral, herbal",
                            ImageUrl = "https://knickoftime.net/wp-content/uploads/2018/04/Homemade-Lavender-Rosemary-Essential-Oil-Goats-Milk-Soap-Knick-of-Time.jpg",
                            InStock = true,
                            LongDescription = "Refreshing and rejuvenating to even the most sensitive skin, just a small amount of this fragrant soap cleanses and conditions your skin without leaving it dry or irritated. Infused with lavender essential oil",
                            Name = "Lavender soap",
                            Price = 14.99m,
                            ProductsName = "Soap of Essential Oil"
                        },
                        new
                        {
                            EssentialOil_ProductsId = 8,
                            Aroma = "Menthol, herbal",
                            ImageUrl = "https://sep.yimg.com/ay/yhst-11598564130842/peppermint-tea-tree-shampoo-bar-5.gif",
                            InStock = true,
                            LongDescription = "Deeply hydrate your skin while gently extracting excess oil with the Peppermint bar. Its stimulating aroma invigorates the senses while reviving natural energy. Perfect for a morning cleanse, the Peppermint bar has a tingling effect to help heal muscle and joint soreness",
                            Name = "Peppermint soap",
                            Price = 14.99m,
                            ProductsName = "Soap of Essential Oil"
                        },
                        new
                        {
                            EssentialOil_ProductsId = 9,
                            Aroma = "Foresty, medical",
                            ImageUrl = "https://i.pinimg.com/originals/69/ba/a6/69baa63c9776e013e289f5a0bdc3f8c1.jpg",
                            InStock = true,
                            LongDescription = "Inhaling the oils in eucalyptus soap can help loosen congestion, ease coughs, help treat mild asthma, and sinus problems.",
                            Name = "Eucalyptus soap",
                            Price = 14.99m,
                            ProductsName = "Soap of Essential Oil"
                        },
                        new
                        {
                            EssentialOil_ProductsId = 10,
                            Aroma = "Herbal, medical",
                            ImageUrl = "https://image.freepik.com/free-photo/natural-soap-with-rosemary-essential-oil_163253-7.jpg",
                            InStock = true,
                            LongDescription = "Rosemary has natural antiseptic properties and free radicals that can protect skin cells from sun damage",
                            Name = "Rosemary soap",
                            Price = 14.99m,
                            ProductsName = "Soap of Essential Oil"
                        },
                        new
                        {
                            EssentialOil_ProductsId = 11,
                            Aroma = "Tangy, citrusy",
                            ImageUrl = "https://sep.yimg.com/ay/yhst-11598564130842/grapefruit-all-natural-soap-facial-soap-handmade-essential-oil-soap-7.gif",
                            InStock = true,
                            LongDescription = "Gently Exfoliating, Moisturizing, Calming, Soothing, Purifying, Invigorating and Refreshing",
                            Name = "Grapefruit soap",
                            Price = 14.99m,
                            ProductsName = "Soap of Essential Oil"
                        },
                        new
                        {
                            EssentialOil_ProductsId = 12,
                            Aroma = "Fruity, like lemon peel",
                            ImageUrl = "https://img.tradees.com/file/upload/2020/07/19/lemon-essential-oil-glycerin-soap-handmade-soap-beauty-soap-281004.jpg",
                            InStock = true,
                            LongDescription = "Leaves your skin feeling soft, smooth and re-hydrated.Natural hand made hand soap, great for hand,face or body.",
                            Name = "Lemon soap",
                            Price = 14.99m,
                            ProductsName = "Soap of Essential Oil"
                        });
                });

            modelBuilder.Entity("EssentialOil1.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EssentialOil1.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("EssentialOil_ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("EssentialOil_ProductsId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("EssentialOil1.Models.Products", b =>
                {
                    b.Property<int>("ProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductsName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductsId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EssentialOil1.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ProductEssentialOil_ProductsId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductEssentialOil_ProductsId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EssentialOil1.Models.EssentialOil_Products", b =>
                {
                    b.HasOne("EssentialOil1.Models.Products", "Products")
                        .WithMany()
                        .HasForeignKey("ProductsId");
                });

            modelBuilder.Entity("EssentialOil1.Models.OrderDetail", b =>
                {
                    b.HasOne("EssentialOil1.Models.EssentialOil_Products", "OilProduct")
                        .WithMany()
                        .HasForeignKey("EssentialOil_ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EssentialOil1.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EssentialOil1.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("EssentialOil1.Models.EssentialOil_Products", "Product")
                        .WithMany()
                        .HasForeignKey("ProductEssentialOil_ProductsId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
