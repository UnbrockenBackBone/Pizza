using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizza.Migrations
{
    public partial class _initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "d2e76dee-545a-4734-96c7-4ca966b5806d", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b62472e-4f66-49fa-a20f-e7685b9565d8", 0, "434ad436-e884-4322-a43e-929dd39cde4a", null, true, false, null, "admin@admin.com", "ADMIN", "AQAAAAEAACcQAAAAEAx2VJ2emr+CFFF3jFTr875Zj78giUPLjuQ5LMIvPDV8Ia48UBvXLr13/Evy2uydeg==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Price", "Subtitle", "TitleImagePath" },
                values: new object[,]
                {
                    { new Guid("870641f1-e1c0-48a7-b2cf-4f411f2dde71"), "Salads", "Gado-gado", 10, "Gado-gado literally means \"mix - mix.\" It's an Indonesian", "/images/Salad.jpg" },
                    { new Guid("1143d521-1a53-457b-a0d5-882ec67d2dfa"), "Salads", "Larb", 10, "It's usually served with raw vegetables and sticky rice. vegetables", "/images/pro_img3.jpg" },
                    { new Guid("056e0bfc-3c6b-4c52-be4c-d1ed78c1f6a3"), "Salads", "Cobb salad", 10, "The only way to make this dish heavier is to add bricks.", "/images/pro_img3.jpg" },
                    { new Guid("73c0d289-4aa8-4400-b77a-1334eadc1e4d"), "Salads", "Gado-gado", 10, "Gado-gado literally means \"mix - mix.\" It's an Indonesian", "/images/Salad.jpg" },
                    { new Guid("30438fe3-171d-46cc-b253-f6c50ce9867d"), "Salads", "Larb", 10, "It's usually served with raw vegetables and sticky rice. vegetables", "/images/pro_img3.jpg" },
                    { new Guid("ef636bd2-1f52-4b5e-bd52-d5d4f7d2a1fb"), "Fries", "Potato Wedges", 10, "Potato wedges sit at the very bottom of the french fry totem pole", "/images/pro_img4.jpg" },
                    { new Guid("1f3ecd85-108d-4170-a0b1-4686f2ac0c65"), "Fries", "Waffle Fries", 10, "Waffle fries have the exact opposite problem of the potato wedges", "/images/Fries.jpg" },
                    { new Guid("f6c190fe-c966-4a1b-986d-35d5705de5eb"), "Fries", "Sweet Potato Fries", 10, "We don't hate sweet potato fries, but we certainly don't love them", "/images/pro_img4.jpg" },
                    { new Guid("99462512-e31e-4aa4-9e8f-e88b93b735d8"), "Fries", "Crinkle Cut Fries", 10, "Crinkle cut fries just look like a good time. They're thick and heavy", "/images/pro_img4.jpg" },
                    { new Guid("581e1a78-7371-49ce-ac78-27fa8484476f"), "Fries", "Steak Fries", 10, "Steak fries might seem like the less fun-looking version of crinkle cut fries", "/images/pro_img4.jpg" },
                    { new Guid("f91b9a53-5faf-4e5e-810b-1bbc465e6a30"), "Fries", "Standard Fries", 10, "Ah, the standard fry—the one that started it all. Despite the fact", "/images/pro_img4.jpg" },
                    { new Guid("f4e2e1b8-19c2-4ffe-befd-6535db38020a"), "Fries", "Belgian Fries", 10, "Belgian fries might look like the typical fry experience, but they most", "/images/pro_img4.jpg" },
                    { new Guid("c65a72d0-3dc2-425c-90ca-f97867b459d5"), "Fries", "Shoestring Fries", 10, "Despite the fact that shoestring fries aren't quite as crunchy", "/images/pro_img4.jpg" },
                    { new Guid("25073ff0-2ae5-43c2-ab45-45399639f550"), "Fries", "Curly Fries", 10, "There's something so satisfying about curly fries. First of all", "/images/pro_img4.jpg" },
                    { new Guid("bea828ff-7b58-4119-b877-5602a9944f7a"), "Drinks", "Coca-Cola", 10, "Coca-Cola is the most popular drink in the world", "/images/pro_img5.jpg" },
                    { new Guid("d0ee61e4-866f-4d10-a25d-ea329db0140c"), "Drinks", "Pepsi", 10, "Pepsi is a cola drink type manufactured by PepsiCo", "/images/pro_img5.jpg" },
                    { new Guid("fecf5c79-d1f1-4e0f-b2aa-6bf5e63e1217"), "Drinks", "Nestlé S.A", 10, "Nestle is synonymous with instant coffee, bottled water, crunches", "/images/pro_img5.jpg" },
                    { new Guid("b7356081-2022-4755-9388-dfcd8909b8a9"), "Salads", "Waldorf salad", 10, "Unlike the many folk salads featured here, Waldorf salad", "/images/pro_img3.jpg" },
                    { new Guid("e8750912-a5a1-4934-9060-de4ace641ae7"), "Salads", "Cobb salad", 10, "The only way to make this dish heavier is to add bricks", "/images/pro_img3.jpg" },
                    { new Guid("fc3e2232-9d9b-4978-93d7-37afa7c37cea"), "Salads", "Larb", 10, "It's usually served with raw vegetables and sticky rice. vegetables", "/images/pro_img3.jpg" },
                    { new Guid("e48a69f8-e6bc-47cd-8fb5-5e65b9c3e1f6"), "Salads", "Cobb salad", 10, "The only way to make this dish heavier is to add bricks", "/images/pro_img3.jpg" },
                    { new Guid("4a68aada-dffa-45db-9485-62709253fd05"), "Pizza", "Deluxe", 10, "original & favorite specialty pizza topped", "/images/pizza_img2.jpg" },
                    { new Guid("92f703c2-5815-4d07-8d04-54175ae10d06"), "Pizza", "Veggie", 10, "Veggie lovers rejoice! Pizza topped with mushrooms", "/images/pizza_img2.jpg" },
                    { new Guid("78613b8f-0948-4b7f-abe7-9088b37c9ae7"), "Pizza", "All Meat", 10, "Our famous meat pizza is topped", "/images/pizza_img3.jpg" },
                    { new Guid("137529e6-2091-4442-8eee-2d4edf12d4b4"), "Pizza", "Barbecue Chicken", 10, "Tangy, rich, our homemade BBQ Chicken pizza", "/images/pizza_img4.jpg" },
                    { new Guid("091178ba-62c9-4c1f-bb60-a3031b4b7448"), "Pizza", "Egg-ceptional", 10, "Enjoy breakfast anytime of the day! Our breakfast pizza", "/images/pizza_img4.jpg" },
                    { new Guid("ddcc2452-fdf6-447b-b2be-36de12825857"), "Pizza", "lunch Special Pizza", 10, "one-topping pizza and a16 ounce drink Specialties", "/images/pizza_img5.png" },
                    { new Guid("f091a9ab-7ad5-48fe-8512-c314ebac05d3"), "Pizza", "Buffalo Chicken", 10, "Pizza with Chicken, Hot Sauce, Ranch Dressing", "/images/pizza_img6.jpg" },
                    { new Guid("90bc6d8f-d234-49ce-8929-ae64ca63f033"), "Pizza", "Tuscan Roma", 10, "Pizza with Roma Tomatoes, Spinach, Alfredo Sauce", "/images/pizza_img1.jpg" },
                    { new Guid("cd8b677e-5b44-4b81-a391-88d38b298ac0"), "Drinks", "Sprite", 10, "Sprite is a colorless, lime-lemon flavored, non-caffeinated soft", "/images/pro_img5.jpg" },
                    { new Guid("55f2b081-622c-4960-bd23-ab31411b64ef"), "Pizza", "Mac & Cheese", 10, "Pizza with Macaroni and Cheese", "/images/pizza_img2.jpg" },
                    { new Guid("00775c10-b5f3-4009-aa85-7261330c6aed"), "Burgers", "Le Pigeon Burger", 10, "Le Pigeon Burger has smoky flavor enhanced with each topping", "/images/pro_img2.jpg" },
                    { new Guid("19a0d40f-c79e-474b-bf8e-117832d60b13"), "Burgers", "Taco Burger", 12, "Tacos are amazing, no doubt about it; need this amazing combo", "/images/pro_img2.jpg" },
                    { new Guid("6b352896-71a5-4b12-bd7d-9d79c2fb0c40"), "Burgers", "Chicken Burger", 15, "The Chicken Caesar Burger is special because it retains the freshness of chicken", "/images/Burgers.jpg" },
                    { new Guid("016555a8-31ca-4230-8698-1d78f0638eef"), "Burgers", "Cheese Burger", 10, "Easily the best burger in all of Germany, this enormous preparation", "/images/Burgers.jpg" },
                    { new Guid("e9d0ec93-d4ce-4810-aaaa-47793464425b"), "Burgers", "Chicken Burger", 15, "The Chicken Caesar Burger is special because it retains the freshness of chicken", "/images/Burgers.jpg" },
                    { new Guid("9fc42768-221a-4d21-bf0b-565b4dc19bd5"), "Burgers", "Luger Burger", 10, "Luger Burger features extra thick bacon and more half pound of beef.", "/images/pro_img2.jpg" },
                    { new Guid("94344499-7fd4-4d0d-80e4-830091eb0ef7"), "Burgers", "Le Pigeon Burger", 10, "Le Pigeon Burger has smoky flavor enhanced with each topping", "/images/pro_img2.jpg" },
                    { new Guid("bad6879d-b5a6-42de-a5b0-d6be1c1d6716"), "Burgers", "Taco Burger", 12, "Tacos are amazing, no doubt about it; need this amazing combo", "/images/pro_img2.jpg" },
                    { new Guid("a470dac9-db4a-4aaf-8961-441c78854f31"), "Burgers", "Luger Burger", 10, "Luger Burger features extra thick bacon and more half pound of beef.", "/images/pro_img2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Price", "Subtitle", "TitleImagePath" },
                values: new object[] { new Guid("337731d7-8549-490b-a96e-9ee02f6abd08"), "Drinks", "Mountain Dew", 10, "This is yet another PepsiCo carbonated soft drink.It comes", "/images/pro_img5.jpg" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "3b62472e-4f66-49fa-a20f-e7685b9565d8" });

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
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
