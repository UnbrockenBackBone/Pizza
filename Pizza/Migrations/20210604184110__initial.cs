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
                name: "UserProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProducts", x => x.Id);
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
                values: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "383a6bc3-58ca-483e-9b3e-c4bc7019a29a", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b62472e-4f66-49fa-a20f-e7685b9565d8", 0, "f26d8449-cb04-44c8-aed4-2644b0351bee", null, true, false, null, "admin@admin.com", "ADMIN", "AQAAAAEAACcQAAAAEIiPEFAYcZYPR1vLRqWC35hqhJGIZywiU5sDj2de/pjZhTlPBVq3TPOWq4T1UDKZSQ==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Price", "Subtitle", "TitleImagePath" },
                values: new object[,]
                {
                    { new Guid("0dde069a-4ba3-4c7b-914d-03668e7b7b89"), "Salads", "Gado-gado", 10, "Gado-gado literally means \"mix - mix.\" It's an Indonesian", "/images/menu_img10.jpg" },
                    { new Guid("33248fc6-04a4-46ac-8a01-b40a09472fe4"), "Salads", "Larb", 10, "It's usually served with raw vegetables and sticky rice. vegetables", "/images/menu_img9.jpg" },
                    { new Guid("98e0c4fc-9f7a-4265-8d33-727592425e84"), "Salads", "Cobb salad", 10, "The only way to make this dish heavier is to add bricks.", "/images/menu_img9.jpg" },
                    { new Guid("9de1240b-7eba-44fa-8d8f-60bfec5b906c"), "Salads", "Gado-gado", 10, "Gado-gado literally means \"mix - mix.\" It's an Indonesian", "/images/menu_img10.jpg" },
                    { new Guid("f9a397ad-d4df-46b7-b12d-d406e5a52a43"), "Salads", "Larb", 10, "It's usually served with raw vegetables and sticky rice. vegetables", "/images/menu_img9.jpg" },
                    { new Guid("7a0ad07c-64d7-45c2-a9d7-b1a86fb11f30"), "Fries", "Potato Wedges", 10, "Potato wedges sit at the very bottom of the french fry totem pole", "/images/menu_img11.jpg" },
                    { new Guid("a8832bfa-82fb-4752-bab2-9fc27d22ea3e"), "Fries", "Waffle Fries", 10, "Waffle fries have the exact opposite problem of the potato wedges", "/images/menu_img12.jpg" },
                    { new Guid("1f4a9d89-40f6-4177-a5d2-ad19364b23b3"), "Fries", "Sweet Potato Fries", 10, "We don't hate sweet potato fries, but we certainly don't love them", "/images/menu_img11.jpg" },
                    { new Guid("72956b97-93f8-409e-a204-f19f5d0034cd"), "Fries", "Crinkle Cut Fries", 10, "Crinkle cut fries just look like a good time. They're thick and heavy", "/images/menu_img11.jpg" },
                    { new Guid("ee0d0faa-53f0-47a9-a1be-487e8755c4e6"), "Fries", "Steak Fries", 10, "Steak fries might seem like the less fun-looking version of crinkle cut fries", "/images/menu_img11.jpg" },
                    { new Guid("a80eff89-2daf-47f0-853f-94fdba61e51b"), "Fries", "Standard Fries", 10, "Ah, the standard fry—the one that started it all. Despite the fact", "/images/menu_img11.jpg" },
                    { new Guid("e9409007-385d-434c-a313-26d9217a70b2"), "Fries", "Belgian Fries", 10, "Belgian fries might look like the typical fry experience, but they most", "/images/menu_img11.jpg" },
                    { new Guid("670d0f4c-a176-4412-bcc0-a9a231ec6203"), "Fries", "Shoestring Fries", 10, "Despite the fact that shoestring fries aren't quite as crunchy", "/images/menu_img11.jpg" },
                    { new Guid("27a062ab-9b65-4516-b481-c3c4f40b3dff"), "Fries", "Curly Fries", 10, "There's something so satisfying about curly fries. First of all", "/images/menu_img11.jpg" },
                    { new Guid("81fb2f70-c1d6-4195-b532-6f6c5abfd6b7"), "Drinks", "Coca-Cola", 10, "Coca-Cola is the most popular drink in the world", "/images/menu_img13.jpg" },
                    { new Guid("a0b62a26-3edd-4359-a252-f8c103c5821b"), "Drinks", "Pepsi", 10, "Pepsi is a cola drink type manufactured by PepsiCo", "/images/menu_img13.jpg" },
                    { new Guid("8b27c78f-4cf3-468d-85c0-a2f0d3a1fe88"), "Drinks", "Nestlé S.A", 10, "Nestle is synonymous with instant coffee, bottled water, crunches", "/images/menu_img13.jpg" },
                    { new Guid("a34c12bd-b280-43f4-9fad-f83a182ba28c"), "Salads", "Waldorf salad", 10, "Unlike the many folk salads featured here, Waldorf salad", "/images/menu_img9.jpg" },
                    { new Guid("f6fba579-fc77-4481-bb38-424a77138d44"), "Salads", "Cobb salad", 10, "The only way to make this dish heavier is to add bricks", "/images/menu_img9.jpg" },
                    { new Guid("5f13eb80-c103-4024-b5f4-6fafad51f227"), "Salads", "Larb", 10, "It's usually served with raw vegetables and sticky rice. vegetables", "/images/menu_img9.jpg" },
                    { new Guid("df11381a-7eb5-44dc-b9a1-56697f166dee"), "Salads", "Cobb salad", 10, "The only way to make this dish heavier is to add bricks", "/images/menu_img9.jpg" },
                    { new Guid("a0de496d-af91-4140-af3e-581569bdff40"), "Pizza", "Deluxe", 10, "original & favorite specialty pizza topped", "/images/menu_img2.jpg" },
                    { new Guid("914470fa-5a09-47d9-b798-3aa4f66dba68"), "Pizza", "Veggie", 10, "Veggie lovers rejoice! Pizza topped with mushrooms", "/images/menu_img2.jpg" },
                    { new Guid("9f06ddce-1209-4f09-8aa3-d9a935a22be0"), "Pizza", "All Meat", 10, "Our famous meat pizza is topped", "/images/menu_img3.jpg" },
                    { new Guid("5891b6e0-6238-4297-97b0-10235b25701e"), "Pizza", "Barbecue Chicken", 10, "Tangy, rich, our homemade BBQ Chicken pizza", "/images/menu_img4.jpg" },
                    { new Guid("b291720f-b2c4-4fe2-9443-24460254c8f4"), "Pizza", "Egg-ceptional", 10, "Enjoy breakfast anytime of the day! Our breakfast pizza", "/images/menu_img4.jpg" },
                    { new Guid("d4111874-b133-4d64-b5cd-8b6430c31cf6"), "Pizza", "lunch Special Pizza", 10, "one-topping pizza and a16 ounce drink Specialties", "/images/menu_img5.png" },
                    { new Guid("fda8b20f-30f4-47e1-b204-e005798787d6"), "Pizza", "Buffalo Chicken", 10, "Pizza with Chicken, Hot Sauce, Ranch Dressing", "/images/menu_img6.jpg" },
                    { new Guid("74293f82-5465-49f1-a8c5-a3e25a6ba547"), "Pizza", "Tuscan Roma", 10, "Pizza with Roma Tomatoes, Spinach, Alfredo Sauce", "/images/menu_img1.jpg" },
                    { new Guid("5ced3c03-21d1-4b42-8ff1-4633e81bd8e4"), "Drinks", "Sprite", 10, "Sprite is a colorless, lime-lemon flavored, non-caffeinated soft", "/images/menu_img13.jpg" },
                    { new Guid("6c879ead-53e0-4488-bca8-55a6f73282a8"), "Pizza", "Mac & Cheese", 10, "Pizza with Macaroni and Cheese", "/images/menu_img2.jpg" },
                    { new Guid("a5b13fd5-a803-41c4-8894-cab8f5a7ee92"), "Burgers", "Le Pigeon Burger", 10, "Le Pigeon Burger has smoky flavor enhanced with each topping", "/images/menu_img7.jpg" },
                    { new Guid("383d5757-211d-487d-a060-3fa15678938a"), "Burgers", "Taco Burger", 12, "Tacos are amazing, no doubt about it; need this amazing combo", "/images/menu_img7.jpg" },
                    { new Guid("76889a81-1608-46a2-a485-8825082477c6"), "Burgers", "Chicken Burger", 15, "The Chicken Caesar Burger is special because it retains the freshness of chicken", "/images/menu_img8.jpg" },
                    { new Guid("9d0b20e4-29c0-4081-b050-6941086a0101"), "Burgers", "Cheese Burger", 10, "Easily the best burger in all of Germany, this enormous preparation", "/images/menu_img8.jpg" },
                    { new Guid("3a7de201-260e-4217-aaca-26d70d22f7ba"), "Burgers", "Chicken Burger", 15, "The Chicken Caesar Burger is special because it retains the freshness of chicken", "/images/menu_img8.jpg" },
                    { new Guid("eb09274e-9fbf-45cd-a352-a082c6b9f1be"), "Burgers", "Luger Burger", 10, "Luger Burger features extra thick bacon and more half pound of beef.", "/images/menu_img7.jpg" },
                    { new Guid("70cf1a6e-efec-4bd3-a8a9-7d15a4bc2ab9"), "Burgers", "Le Pigeon Burger", 10, "Le Pigeon Burger has smoky flavor enhanced with each topping", "/images/menu_img7.jpg" },
                    { new Guid("f37c123b-6151-4a2a-8740-a67bfbc3af62"), "Burgers", "Taco Burger", 12, "Tacos are amazing, no doubt about it; need this amazing combo", "/images/menu_img7.jpg" },
                    { new Guid("0f69050e-4c45-4e7d-9e2c-2d417060edc2"), "Burgers", "Luger Burger", 10, "Luger Burger features extra thick bacon and more half pound of beef.", "/images/menu_img7.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Price", "Subtitle", "TitleImagePath" },
                values: new object[] { new Guid("10c9b634-0c96-43f6-a341-cbff437f0523"), "Drinks", "Mountain Dew", 10, "This is yet another PepsiCo carbonated soft drink.It comes", "/images/menu_img13.jpg" });

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
                name: "UserProducts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
