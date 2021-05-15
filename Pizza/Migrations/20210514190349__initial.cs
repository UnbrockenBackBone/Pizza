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
                values: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "59375ace-1ab7-4a23-9a5f-74b62918b90a", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b62472e-4f66-49fa-a20f-e7685b9565d8", 0, "63c50fcf-9e6b-405a-a428-d3126061407b", null, true, false, null, "admin@admin.com", "ADMIN", "AQAAAAEAACcQAAAAEHTaiThIZRvl/YSnqvmCWggZPOmFanpc/YofrC8NkAZ0f6gWxHHDtFaM5Mfa2WpCHg==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Price", "Subtitle", "TitleImagePath" },
                values: new object[,]
                {
                    { new Guid("bfa9d23e-42de-4110-bcb5-b038e40c375c"), "Salads", "Gado-gado", 10, "Gado-gado literally means \"mix - mix.\" It's an Indonesian", "~/images/Salad.jpg" },
                    { new Guid("2f76b39f-90e5-4c4f-b612-45a3dd57c329"), "Salads", "Larb", 10, "It's usually served with raw vegetables and sticky rice. vegetables", "~/images/pro_img3.jpg" },
                    { new Guid("7b96e3e8-7acb-4f79-926e-adbd1cf2fef7"), "Salads", "Cobb salad", 10, "The only way to make this dish heavier is to add bricks.", "~/images/pro_img3.jpg" },
                    { new Guid("c6e0510d-2c5e-47d8-8cb7-bd29d1345cfb"), "Salads", "Gado-gado", 10, "Gado-gado literally means \"mix - mix.\" It's an Indonesian", "~/images/Salad.jpg" },
                    { new Guid("bcfae75f-619b-4cec-b3f9-1a6b686f26f2"), "Salads", "Larb", 10, "It's usually served with raw vegetables and sticky rice. vegetables", "~/images/pro_img3.jpg" },
                    { new Guid("dc608f6f-7e1b-4c2f-9f5c-446b70600331"), "Fries", "Potato Wedges", 10, "Potato wedges sit at the very bottom of the french fry totem pole", "~/images/pro_img4.jpg" },
                    { new Guid("0c858d44-06e9-4a6c-9a70-a64f89f5e231"), "Fries", "Waffle Fries", 10, "Waffle fries have the exact opposite problem of the potato wedges", "~/images/Fries.jpg" },
                    { new Guid("72b95154-2d81-43a9-a2c8-86a66df66024"), "Fries", "Sweet Potato Fries", 10, "We don't hate sweet potato fries, but we certainly don't love them", "~/images/pro_img4.jpg" },
                    { new Guid("4eb65b0e-1a84-4db1-8f05-ccda9daa3577"), "Fries", "Crinkle Cut Fries", 10, "Crinkle cut fries just look like a good time. They're thick and heavy", "~/images/pro_img4.jpg" },
                    { new Guid("4811288f-5c29-424c-868c-e4f333a14c63"), "Fries", "Steak Fries", 10, "Steak fries might seem like the less fun-looking version of crinkle cut fries", "~/images/pro_img4.jpg" },
                    { new Guid("3d43dd0e-c387-4c91-8fe8-7f9872925a5d"), "Fries", "Standard Fries", 10, "Ah, the standard fry—the one that started it all. Despite the fact", "~/images/pro_img4.jpg" },
                    { new Guid("4c7b45a8-2b0f-45f2-8b3e-dccb8379a6a3"), "Fries", "Belgian Fries", 10, "Belgian fries might look like the typical fry experience, but they most", "~/images/pro_img4.jpg" },
                    { new Guid("952e2e9c-5540-4a87-bdff-c9593227c156"), "Fries", "Shoestring Fries", 10, "Despite the fact that shoestring fries aren't quite as crunchy", "~/images/pro_img4.jpg" },
                    { new Guid("0c254aa1-1d35-44cc-b10e-b77c43096cb0"), "Fries", "Curly Fries", 10, "There's something so satisfying about curly fries. First of all", "~/images/pro_img4.jpg" },
                    { new Guid("32de7371-aff9-47fd-9fbd-cd0a49d9efe9"), "Drinks", "Coca-Cola", 10, "Coca-Cola is the most popular drink in the world", "~/images/pro_img5.jpg" },
                    { new Guid("64e6ab28-6758-4ac2-ade5-9d008abf804b"), "Drinks", "Pepsi", 10, "Pepsi is a cola drink type manufactured by PepsiCo", "~/images/pro_img5.jpg" },
                    { new Guid("740f508f-98e8-45b6-a60f-53b2ab1de083"), "Drinks", "Nestlé S.A", 10, "Nestle is synonymous with instant coffee, bottled water, crunches", "~/images/pro_img5.jpg" },
                    { new Guid("f78fd1e7-aa31-4675-a3c0-d7c7e85f3fc6"), "Salads", "Waldorf salad", 10, "Unlike the many folk salads featured here, Waldorf salad", "~/images/pro_img3.jpg" },
                    { new Guid("1bc80b7b-5d29-4531-832d-d8d7d53713d8"), "Salads", "Cobb salad", 10, "The only way to make this dish heavier is to add bricks", "~/images/pro_img3.jpg" },
                    { new Guid("2ec72acb-a02a-4969-87e2-420d51a30f68"), "Salads", "Larb", 10, "It's usually served with raw vegetables and sticky rice. vegetables", "~/images/pro_img3.jpg" },
                    { new Guid("f2ef8b70-5088-4d69-94c5-fc852ebbdd93"), "Salads", "Cobb salad", 10, "The only way to make this dish heavier is to add bricks", "~/images/pro_img3.jpg" },
                    { new Guid("f2b954cd-b523-4deb-9cb2-a0aed73a788f"), "Pizza", "Deluxe", 10, "original & favorite specialty pizza topped", "~/images/pizza_img2.jpg" },
                    { new Guid("0f510f29-4848-4968-99e6-1f01ea512756"), "Pizza", "Veggie", 10, "Veggie lovers rejoice! Pizza topped with mushrooms", "~/images/pizza_img2.jpg" },
                    { new Guid("2474ee16-9d15-42f7-8b8f-5aa842e336d4"), "Pizza", "All Meat", 10, "Our famous meat pizza is topped", "~/images/pizza_img3.jpg" },
                    { new Guid("655b8155-ef33-4675-9710-6b96b68b0b01"), "Pizza", "Barbecue Chicken", 10, "Tangy, rich, our homemade BBQ Chicken pizza", "~/images/pizza_img4.jpg" },
                    { new Guid("24e05ddd-1db5-49ef-80e3-9fc097245aee"), "Pizza", "Egg-ceptional", 10, "Enjoy breakfast anytime of the day! Our breakfast pizza", "~/images/pizza_img4.jpg" },
                    { new Guid("3a8aaedb-8922-4d42-ba5a-94fe75c095a0"), "Pizza", "lunch Special Pizza", 10, "one-topping pizza and a16 ounce drink Specialties", "~/images/pizza_img5.jpg" },
                    { new Guid("9a79203c-2959-46d5-a9a6-cc22fb76a0bd"), "Pizza", "Buffalo Chicken", 10, "Pizza with Chicken, Hot Sauce, Ranch Dressing", "~/images/pizza_img6.jpg" },
                    { new Guid("b369c934-3e9a-4a88-808e-e821bef805fd"), "Pizza", "Tuscan Roma", 10, "Pizza with Roma Tomatoes, Spinach, Alfredo Sauce", "~/images/pizza_img1.jpg" },
                    { new Guid("2049c854-038c-48b6-b7cd-01d439bf7ab6"), "Drinks", "Sprite", 10, "Sprite is a colorless, lime-lemon flavored, non-caffeinated soft", "~/images/pro_img5.jpg" },
                    { new Guid("6bc3af79-e872-4cd5-b4b3-df9430ccb1f6"), "Pizza", "Mac & Cheese", 10, "Pizza with Macaroni and Cheese", "~/images/pizza_img2.jpg" },
                    { new Guid("d4137bdb-4069-4942-adc1-3ffb9038c2b0"), "Burgers", "Le Pigeon Burger", 10, "Le Pigeon Burger has smoky flavor enhanced with each topping", "~/images/pro_img2.jpg" },
                    { new Guid("c086e6b0-1706-4600-adef-535280249df2"), "Burgers", "Taco Burger", 12, "Tacos are amazing, no doubt about it; need this amazing combo", "~/images/pro_img2.jpg" },
                    { new Guid("42eec7ef-8a2b-484c-a3f4-3b7b6ddf332e"), "Burgers", "Chicken Burger", 15, "The Chicken Caesar Burger is special because it retains the freshness of chicken", "~/images/Burgers.jpg" },
                    { new Guid("570cefb8-0dec-4483-a555-706263249f77"), "Burgers", "Cheese Burger", 10, "Easily the best burger in all of Germany, this enormous preparation", "~/images/Burgers.jpg" },
                    { new Guid("13843e91-263a-4952-aac0-e808a7a1c17f"), "Burgers", "Chicken Burger", 15, "The Chicken Caesar Burger is special because it retains the freshness of chicken", "~/images/Burgers.jpg" },
                    { new Guid("d89f1774-4e3c-4100-a6f8-f69108f2d177"), "Burgers", "Luger Burger", 10, "Luger Burger features extra thick bacon and more half pound of beef.", "~/images/pro_img2.jpg" },
                    { new Guid("bb6d9fa7-57f6-4718-af62-413064a39180"), "Burgers", "Le Pigeon Burger", 10, "Le Pigeon Burger has smoky flavor enhanced with each topping", "~/images/pro_img2.jpg" },
                    { new Guid("b3337e7e-20c1-49f1-98a3-1e70becd7498"), "Burgers", "Taco Burger", 12, "Tacos are amazing, no doubt about it; need this amazing combo", "~/images/pro_img2.jpg" },
                    { new Guid("be5510ec-15a4-467b-8a4d-126b17919ff3"), "Burgers", "Luger Burger", 10, "Luger Burger features extra thick bacon and more half pound of beef.", "~/images/pro_img2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Price", "Subtitle", "TitleImagePath" },
                values: new object[] { new Guid("22389f7a-61ac-4b14-8044-ed68221d3ad6"), "Drinks", "Mountain Dew", 10, "This is yet another PepsiCo carbonated soft drink.It comes", "~/images/pro_img5.jpg" });

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
