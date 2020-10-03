using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EssentialOil1.Migrations
{
    public partial class LoginAndRegisterMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductsId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EssentialOil_Products",
                columns: table => new
                {
                    EssentialOil_ProductsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    Aroma = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    InStock = table.Column<bool>(nullable: false),
                    ProductsId = table.Column<int>(nullable: true),
                    ProductsName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EssentialOil_Products", x => x.EssentialOil_ProductsId);
                    table.ForeignKey(
                        name: "FK_EssentialOil_Products_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "ProductsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    EssentialOil_ProductsId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_EssentialOil_Products_EssentialOil_ProductsId",
                        column: x => x.EssentialOil_ProductsId,
                        principalTable: "EssentialOil_Products",
                        principalColumn: "EssentialOil_ProductsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductEssentialOil_ProductsId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_EssentialOil_Products_ProductEssentialOil_ProductsId",
                        column: x => x.ProductEssentialOil_ProductsId,
                        principalTable: "EssentialOil_Products",
                        principalColumn: "EssentialOil_ProductsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "EssentialOil_Products",
                columns: new[] { "EssentialOil_ProductsId", "Aroma", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ProductsId", "ProductsName" },
                values: new object[,]
                {
                    { 1, "Floral, herbal", "https://insigniaseniorliving.com/wp-content/uploads/2020/05/lavender-essential-oil-1.jpg", true, "The most popular essential oil because of its versatility and well-liked floral, herbal aroma, lavender can be used in a variety of ways to inspire calm and relaxation. Most commonly known for its relaxing effects on the body, terapeutic-grade lavender has been highly regarded for the skin. It may be used to cleanse cuts, bruises and skin irritations. The fragrance is calming, relaxing and balancing-phsysically and emotionally", "Lavender Oil", 11.99m, null, "Essential Oil" },
                    { 2, "Menthol, herbal", "https://i0.wp.com/cdn-prod.medicalnewstoday.com/content/images/articles/321/321598/essential-oils-such-as-peppermint-are-good-for-sore-throat.jpg?w=1155&h=1541", true, "The menthol, herbal aroma of peppermmint essential oil can be used in many ways to uplift and invigorate. You can also apply it topically to create a cool, tingling sensation on the skin, which can be very soothing after hard physical activity.", "Peppermint Oil", 11.99m, null, "Essential Oil" },
                    { 3, "Foresty, medical", "https://www.aromaweb.com/images/botanicals/eucalyptus-globulus-essential-oil.jpg", true, "Its one of the best essential oils for sore throats, cough, seasonal allergies and headache. Eucalyptus oil benefit are due to its ability to stimulate immunity, provide antioxidant protection and improve respiratory circulation", "Eucalyptus Oil", 11.99m, null, "Essential Oil" },
                    { 4, "Herbal, medical", "https://wellnessaromas.b-cdn.net/wp-content/uploads/2018/08/wellnessaromas-aromatherapy-essential-oil_rosemary-oil-benefits-uses-1024x683.jpg", true, "Rosemary essential oil can bring uplifting, energizing and purifying benefits to your airspace and body care", "Rosemary Oil", 11.99m, null, "Essential Oil" },
                    { 5, "Tangy, citrusy", "https://i0.wp.com/images-prod.healthline.com/hlcmsresource/images/AN_images/grapefruit-essential-oil-1296x728-feature.jpg?w=1155&h=1528", true, "The health benefits of grapefruit essential oil can be attributed to its properties as a diuretic, stimulant, antidepressant, antiseptic and tonic substance. This oil is effective in protecting the body from all harm done by various oxidants and toxins.", "Grapefruit Oil", 11.99m, null, "Essential Oil" },
                    { 6, "Fruity, like lemon peel", "https://cdn.thetruthaboutcancer.com/wp-content/uploads/20190125170948/lemon-essential-oil-cancer-fighting-benefits.jpg", true, "Fresh and fruity, lemon essential oil is often used for home cleaning and air freshening, but also be used for many body care products", "Lemon Oil", 11.99m, null, "Essential Oil" },
                    { 7, "Floral, herbal", "https://knickoftime.net/wp-content/uploads/2018/04/Homemade-Lavender-Rosemary-Essential-Oil-Goats-Milk-Soap-Knick-of-Time.jpg", true, "Refreshing and rejuvenating to even the most sensitive skin, just a small amount of this fragrant soap cleanses and conditions your skin without leaving it dry or irritated. Infused with lavender essential oil", "Lavender soap", 14.99m, null, "Soap of Essential Oil" },
                    { 8, "Menthol, herbal", "https://sep.yimg.com/ay/yhst-11598564130842/peppermint-tea-tree-shampoo-bar-5.gif", true, "Deeply hydrate your skin while gently extracting excess oil with the Peppermint bar. Its stimulating aroma invigorates the senses while reviving natural energy. Perfect for a morning cleanse, the Peppermint bar has a tingling effect to help heal muscle and joint soreness", "Peppermint soap", 14.99m, null, "Soap of Essential Oil" },
                    { 9, "Foresty, medical", "https://i.pinimg.com/originals/69/ba/a6/69baa63c9776e013e289f5a0bdc3f8c1.jpg", true, "Inhaling the oils in eucalyptus soap can help loosen congestion, ease coughs, help treat mild asthma, and sinus problems.", "Eucalyptus soap", 14.99m, null, "Soap of Essential Oil" },
                    { 10, "Herbal, medical", "https://image.freepik.com/free-photo/natural-soap-with-rosemary-essential-oil_163253-7.jpg", true, "Rosemary has natural antiseptic properties and free radicals that can protect skin cells from sun damage", "Rosemary soap", 14.99m, null, "Soap of Essential Oil" },
                    { 11, "Tangy, citrusy", "https://sep.yimg.com/ay/yhst-11598564130842/grapefruit-all-natural-soap-facial-soap-handmade-essential-oil-soap-7.gif", true, "Gently Exfoliating, Moisturizing, Calming, Soothing, Purifying, Invigorating and Refreshing", "Grapefruit soap", 14.99m, null, "Soap of Essential Oil" },
                    { 12, "Fruity, like lemon peel", "https://img.tradees.com/file/upload/2020/07/19/lemon-essential-oil-glycerin-soap-handmade-soap-beauty-soap-281004.jpg", true, "Leaves your skin feeling soft, smooth and re-hydrated.Natural hand made hand soap, great for hand,face or body.", "Lemon soap", 14.99m, null, "Soap of Essential Oil" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EssentialOil_Products_ProductsId",
                table: "EssentialOil_Products",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_EssentialOil_ProductsId",
                table: "OrderDetails",
                column: "EssentialOil_ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductEssentialOil_ProductsId",
                table: "ShoppingCartItems",
                column: "ProductEssentialOil_ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "EssentialOil_Products");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
