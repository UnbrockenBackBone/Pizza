﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pizza.Domain;

namespace Pizza.Migrations
{
    [DbContext(typeof(PizzaDbContext))]
    partial class PizzaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.3.21201.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                            ConcurrencyStamp = "76c70652-704e-4996-a362-116baeb4eb9e",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "270f294f-6a18-48c2-9a4c-a0e219b7ea4a",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@admin.com",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAECA4KS6F1podpFYz0/E/7JwEsC6bZXS4jWfc/gieo/W1XyqYGGrxXthyWM6tkqoNIA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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

                    b.HasData(
                        new
                        {
                            UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                            RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Pizza.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Subtitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7a7fc4f9-7261-4ba6-bf8b-af8d75f83e37"),
                            Category = "Pizza",
                            Name = "Deluxe",
                            Price = 10,
                            Subtitle = "original & favorite specialty pizza topped",
                            TitleImagePath = "/images/pizza_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("6e4f3dc4-ec51-4530-9f6c-413ec9b81b59"),
                            Category = "Pizza",
                            Name = "Veggie",
                            Price = 10,
                            Subtitle = "Veggie lovers rejoice! Pizza topped with mushrooms",
                            TitleImagePath = "/images/pizza_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("d906b2d4-06a2-4b82-a7c8-05566a92b0f1"),
                            Category = "Pizza",
                            Name = "All Meat",
                            Price = 10,
                            Subtitle = "Our famous meat pizza is topped",
                            TitleImagePath = "/images/pizza_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("00ea4c5f-a510-46da-b02e-4792aa638c37"),
                            Category = "Pizza",
                            Name = "Barbecue Chicken",
                            Price = 10,
                            Subtitle = "Tangy, rich, our homemade BBQ Chicken pizza",
                            TitleImagePath = "/images/pizza_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("59282f83-230d-46b3-8f4b-ad3bc0c927b3"),
                            Category = "Pizza",
                            Name = "Egg-ceptional",
                            Price = 10,
                            Subtitle = "Enjoy breakfast anytime of the day! Our breakfast pizza",
                            TitleImagePath = "/images/pizza_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("3cc7d0f8-1193-4106-b2ad-ea3473da648c"),
                            Category = "Pizza",
                            Name = "lunch Special Pizza",
                            Price = 10,
                            Subtitle = "one-topping pizza and a16 ounce drink Specialties",
                            TitleImagePath = "/images/pizza_img5.png"
                        },
                        new
                        {
                            Id = new Guid("1d7dbe97-5085-453d-b87b-32d9c45ce920"),
                            Category = "Pizza",
                            Name = "Buffalo Chicken",
                            Price = 10,
                            Subtitle = "Pizza with Chicken, Hot Sauce, Ranch Dressing",
                            TitleImagePath = "/images/pizza_img6.jpg"
                        },
                        new
                        {
                            Id = new Guid("fff5d4dc-bc22-4b88-a97f-183c415d4f8e"),
                            Category = "Pizza",
                            Name = "Tuscan Roma",
                            Price = 10,
                            Subtitle = "Pizza with Roma Tomatoes, Spinach, Alfredo Sauce",
                            TitleImagePath = "/images/pizza_img1.jpg"
                        },
                        new
                        {
                            Id = new Guid("120a4319-0bbe-420e-9754-7624b8cf877f"),
                            Category = "Pizza",
                            Name = "Mac & Cheese",
                            Price = 10,
                            Subtitle = "Pizza with Macaroni and Cheese",
                            TitleImagePath = "/images/pizza_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("8f988872-dcda-42ad-8bf9-b8e1d36f447e"),
                            Category = "Burgers",
                            Name = "Luger Burger",
                            Price = 10,
                            Subtitle = "Luger Burger features extra thick bacon and more half pound of beef.",
                            TitleImagePath = "/images/pro_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("f886096f-9f4e-4653-bdbf-11406ecafee7"),
                            Category = "Burgers",
                            Name = "Le Pigeon Burger",
                            Price = 10,
                            Subtitle = "Le Pigeon Burger has smoky flavor enhanced with each topping",
                            TitleImagePath = "/images/pro_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("aeecf8a8-fc02-462c-b282-d6dfe0507e19"),
                            Category = "Burgers",
                            Name = "Taco Burger",
                            Price = 12,
                            Subtitle = "Tacos are amazing, no doubt about it; need this amazing combo",
                            TitleImagePath = "/images/pro_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("66cc2f81-7f37-45cc-a915-c02ed5682e07"),
                            Category = "Burgers",
                            Name = "Chicken Burger",
                            Price = 15,
                            Subtitle = "The Chicken Caesar Burger is special because it retains the freshness of chicken",
                            TitleImagePath = "/images/Burgers.jpg"
                        },
                        new
                        {
                            Id = new Guid("626363bb-584b-482d-8f88-8b28c8bc5cba"),
                            Category = "Burgers",
                            Name = "Cheese Burger",
                            Price = 10,
                            Subtitle = "Easily the best burger in all of Germany, this enormous preparation",
                            TitleImagePath = "/images/Burgers.jpg"
                        },
                        new
                        {
                            Id = new Guid("880b8b7b-8157-4476-b275-10e98f69ae6b"),
                            Category = "Burgers",
                            Name = "Chicken Burger",
                            Price = 15,
                            Subtitle = "The Chicken Caesar Burger is special because it retains the freshness of chicken",
                            TitleImagePath = "/images/Burgers.jpg"
                        },
                        new
                        {
                            Id = new Guid("5e586e22-87cd-44c9-8c2a-493db37fb450"),
                            Category = "Burgers",
                            Name = "Luger Burger",
                            Price = 10,
                            Subtitle = "Luger Burger features extra thick bacon and more half pound of beef.",
                            TitleImagePath = "/images/pro_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("ae4ae0b9-e55e-4ace-a0e8-6e1110a6808d"),
                            Category = "Burgers",
                            Name = "Le Pigeon Burger",
                            Price = 10,
                            Subtitle = "Le Pigeon Burger has smoky flavor enhanced with each topping",
                            TitleImagePath = "/images/pro_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("fd54353a-81c4-4219-bc94-18a37695740e"),
                            Category = "Burgers",
                            Name = "Taco Burger",
                            Price = 12,
                            Subtitle = "Tacos are amazing, no doubt about it; need this amazing combo",
                            TitleImagePath = "/images/pro_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("365fc3f4-7cde-421e-b8ca-1345ecaa19ed"),
                            Category = "Salads",
                            Name = "Cobb salad",
                            Price = 10,
                            Subtitle = "The only way to make this dish heavier is to add bricks",
                            TitleImagePath = "/images/pro_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("f27474bc-e54a-41e2-981a-e2cddf89af28"),
                            Category = "Salads",
                            Name = "Larb",
                            Price = 10,
                            Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                            TitleImagePath = "/images/pro_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("885930fc-b8c2-4bdb-a17b-661a0e7aab8e"),
                            Category = "Salads",
                            Name = "Cobb salad",
                            Price = 10,
                            Subtitle = "The only way to make this dish heavier is to add bricks",
                            TitleImagePath = "/images/pro_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("44435b2e-9d7a-4c26-8149-92e3476ee18c"),
                            Category = "Salads",
                            Name = "Waldorf salad",
                            Price = 10,
                            Subtitle = "Unlike the many folk salads featured here, Waldorf salad",
                            TitleImagePath = "/images/pro_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("3a6f3b4a-bc2e-4c89-a85f-3251447e5ad7"),
                            Category = "Salads",
                            Name = "Gado-gado",
                            Price = 10,
                            Subtitle = "Gado-gado literally means \"mix - mix.\" It's an Indonesian",
                            TitleImagePath = "/images/Salad.jpg"
                        },
                        new
                        {
                            Id = new Guid("dce07631-e581-4113-9d79-50547cb09dda"),
                            Category = "Salads",
                            Name = "Larb",
                            Price = 10,
                            Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                            TitleImagePath = "/images/pro_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("3a8bb641-bf56-4481-822d-5dc76299417b"),
                            Category = "Salads",
                            Name = "Cobb salad",
                            Price = 10,
                            Subtitle = "The only way to make this dish heavier is to add bricks.",
                            TitleImagePath = "/images/pro_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("415d1ed5-12bc-4402-a407-bdf97cae75b7"),
                            Category = "Salads",
                            Name = "Gado-gado",
                            Price = 10,
                            Subtitle = "Gado-gado literally means \"mix - mix.\" It's an Indonesian",
                            TitleImagePath = "/images/Salad.jpg"
                        },
                        new
                        {
                            Id = new Guid("48a7a633-a00b-413e-b81f-3e1d12229b48"),
                            Category = "Salads",
                            Name = "Larb",
                            Price = 10,
                            Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                            TitleImagePath = "/images/pro_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("690b384f-c7c7-43a8-bf38-3830801b11d1"),
                            Category = "Fries",
                            Name = "Potato Wedges",
                            Price = 10,
                            Subtitle = "Potato wedges sit at the very bottom of the french fry totem pole",
                            TitleImagePath = "/images/pro_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("ea958932-ef02-4362-9f52-2d8066cad473"),
                            Category = "Fries",
                            Name = "Waffle Fries",
                            Price = 10,
                            Subtitle = "Waffle fries have the exact opposite problem of the potato wedges",
                            TitleImagePath = "/images/Fries.jpg"
                        },
                        new
                        {
                            Id = new Guid("c6eaa1e1-4a1b-4420-a2fa-3903b483ec5b"),
                            Category = "Fries",
                            Name = "Sweet Potato Fries",
                            Price = 10,
                            Subtitle = "We don't hate sweet potato fries, but we certainly don't love them",
                            TitleImagePath = "/images/pro_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("071f7ddf-18d8-4df5-805f-11057a0f761c"),
                            Category = "Fries",
                            Name = "Crinkle Cut Fries",
                            Price = 10,
                            Subtitle = "Crinkle cut fries just look like a good time. They're thick and heavy",
                            TitleImagePath = "/images/pro_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("f205843f-c0b8-4542-8682-5ad636f03e0a"),
                            Category = "Fries",
                            Name = "Steak Fries",
                            Price = 10,
                            Subtitle = "Steak fries might seem like the less fun-looking version of crinkle cut fries",
                            TitleImagePath = "/images/pro_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("b5797ac8-9cf5-4d1d-bef7-9d6ba4f14e40"),
                            Category = "Fries",
                            Name = "Standard Fries",
                            Price = 10,
                            Subtitle = "Ah, the standard fry—the one that started it all. Despite the fact",
                            TitleImagePath = "/images/pro_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("686812c3-d1e8-4d2f-847c-ec84c22a9830"),
                            Category = "Fries",
                            Name = "Belgian Fries",
                            Price = 10,
                            Subtitle = "Belgian fries might look like the typical fry experience, but they most",
                            TitleImagePath = "/images/pro_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("2503ff7e-6c87-4fb7-b88f-429510055c29"),
                            Category = "Fries",
                            Name = "Shoestring Fries",
                            Price = 10,
                            Subtitle = "Despite the fact that shoestring fries aren't quite as crunchy",
                            TitleImagePath = "/images/pro_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("00b40fba-9546-4027-bb11-63bbe9ef15f3"),
                            Category = "Fries",
                            Name = "Curly Fries",
                            Price = 10,
                            Subtitle = "There's something so satisfying about curly fries. First of all",
                            TitleImagePath = "/images/pro_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("3cd27ebf-80ac-4897-84d3-56941539bfca"),
                            Category = "Drinks",
                            Name = "Coca-Cola",
                            Price = 10,
                            Subtitle = "Coca-Cola is the most popular drink in the world",
                            TitleImagePath = "/images/pro_img5.jpg"
                        },
                        new
                        {
                            Id = new Guid("b984d405-e437-480b-9284-167acc90c97a"),
                            Category = "Drinks",
                            Name = "Pepsi",
                            Price = 10,
                            Subtitle = "Pepsi is a cola drink type manufactured by PepsiCo",
                            TitleImagePath = "/images/pro_img5.jpg"
                        },
                        new
                        {
                            Id = new Guid("ef5c51ba-ec03-410b-900f-eb3caf698937"),
                            Category = "Drinks",
                            Name = "Nestlé S.A",
                            Price = 10,
                            Subtitle = "Nestle is synonymous with instant coffee, bottled water, crunches",
                            TitleImagePath = "/images/pro_img5.jpg"
                        },
                        new
                        {
                            Id = new Guid("d262726e-9163-4ca5-a359-c4cb48d06e0b"),
                            Category = "Drinks",
                            Name = "Sprite",
                            Price = 10,
                            Subtitle = "Sprite is a colorless, lime-lemon flavored, non-caffeinated soft",
                            TitleImagePath = "/images/pro_img5.jpg"
                        },
                        new
                        {
                            Id = new Guid("b6f49903-83b2-483e-bad4-f67ff4f2fb6e"),
                            Category = "Drinks",
                            Name = "Mountain Dew",
                            Price = 10,
                            Subtitle = "This is yet another PepsiCo carbonated soft drink.It comes",
                            TitleImagePath = "/images/pro_img5.jpg"
                        });
                });

            modelBuilder.Entity("Pizza.Domain.Entities.UserProducts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdProduct")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserProducts");
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
