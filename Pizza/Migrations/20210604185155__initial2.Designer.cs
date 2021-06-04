﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pizza.Domain;

namespace Pizza.Migrations
{
    [DbContext(typeof(PizzaDbContext))]
    [Migration("20210604185155__initial2")]
    partial class _initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            ConcurrencyStamp = "fccf5be8-f262-40a8-9f01-e93184420886",
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
                            ConcurrencyStamp = "9c96c6fa-7caf-40e9-a054-e85e33bce758",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@admin.com",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEDHP9bemSaQuArpkk/KEghVoLyU81A2CBCZLC0WRwdlgQbQfhuwXMbcfMrC7alAQlA==",
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
                            Id = new Guid("afdc384d-7402-4590-be36-fe36525532bd"),
                            Category = "Pizza",
                            Name = "Deluxe",
                            Price = 10,
                            Subtitle = "original & favorite specialty pizza topped",
                            TitleImagePath = "/images/menu_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("0c28fc98-f2c2-4877-80a6-1253dce3463b"),
                            Category = "Pizza",
                            Name = "Veggie",
                            Price = 10,
                            Subtitle = "Veggie lovers rejoice! Pizza topped with mushrooms",
                            TitleImagePath = "/images/menu_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("3035483b-16d3-47b5-b627-fee89d6a80f5"),
                            Category = "Pizza",
                            Name = "All Meat",
                            Price = 10,
                            Subtitle = "Our famous meat pizza is topped",
                            TitleImagePath = "/images/menu_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("ff31bded-6eed-44e8-9510-1ac676f58919"),
                            Category = "Pizza",
                            Name = "Barbecue Chicken",
                            Price = 10,
                            Subtitle = "Tangy, rich, our homemade BBQ Chicken pizza",
                            TitleImagePath = "/images/menu_img14.jpg"
                        },
                        new
                        {
                            Id = new Guid("99d6f6fa-6e57-48a3-8b0e-3411f372ca06"),
                            Category = "Pizza",
                            Name = "Egg-ceptional",
                            Price = 10,
                            Subtitle = "Enjoy breakfast anytime of the day! Our breakfast pizza",
                            TitleImagePath = "/images/menu_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("12dbf5f5-2bd0-453f-8f54-d8671b4090ec"),
                            Category = "Pizza",
                            Name = "lunch Special Pizza",
                            Price = 10,
                            Subtitle = "one-topping pizza and a16 ounce drink Specialties",
                            TitleImagePath = "/images/menu_img5.png"
                        },
                        new
                        {
                            Id = new Guid("61594b98-ecc5-4383-be24-b5682f9e4441"),
                            Category = "Pizza",
                            Name = "Buffalo Chicken",
                            Price = 10,
                            Subtitle = "Pizza with Chicken, Hot Sauce, Ranch Dressing",
                            TitleImagePath = "/images/menu_img6.jpg"
                        },
                        new
                        {
                            Id = new Guid("a3cf8718-80b5-42b1-b9c5-500a419990ec"),
                            Category = "Pizza",
                            Name = "Tuscan Roma",
                            Price = 10,
                            Subtitle = "Pizza with Roma Tomatoes, Spinach, Alfredo Sauce",
                            TitleImagePath = "/images/menu_img1.jpg"
                        },
                        new
                        {
                            Id = new Guid("31590848-d2e0-4549-b60c-a499fd600876"),
                            Category = "Pizza",
                            Name = "Mac & Cheese",
                            Price = 10,
                            Subtitle = "Pizza with Macaroni and Cheese",
                            TitleImagePath = "/images/menu_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("8fe551ef-1e73-49fd-9af7-b63287dc376e"),
                            Category = "Burgers",
                            Name = "Luger Burger",
                            Price = 10,
                            Subtitle = "Luger Burger features extra thick bacon and more half pound of beef.",
                            TitleImagePath = "/images/menu_img7.jpg"
                        },
                        new
                        {
                            Id = new Guid("b70c0249-8fe1-42af-b539-fdaf33db7c7b"),
                            Category = "Burgers",
                            Name = "Le Pigeon Burger",
                            Price = 10,
                            Subtitle = "Le Pigeon Burger has smoky flavor enhanced with each topping",
                            TitleImagePath = "/images/menu_img7.jpg"
                        },
                        new
                        {
                            Id = new Guid("554fdff3-52d4-417a-b242-861c7f229a00"),
                            Category = "Burgers",
                            Name = "Taco Burger",
                            Price = 12,
                            Subtitle = "Tacos are amazing, no doubt about it; need this amazing combo",
                            TitleImagePath = "/images/menu_img7.jpg"
                        },
                        new
                        {
                            Id = new Guid("e54c5def-eb8b-40ef-9292-b80c5840ab7f"),
                            Category = "Burgers",
                            Name = "Chicken Burger",
                            Price = 15,
                            Subtitle = "The Chicken Caesar Burger is special because it retains the freshness of chicken",
                            TitleImagePath = "/images/menu_img8.jpg"
                        },
                        new
                        {
                            Id = new Guid("a5e20c0c-f512-4c52-9331-0bd087642dfd"),
                            Category = "Burgers",
                            Name = "Cheese Burger",
                            Price = 10,
                            Subtitle = "Easily the best burger in all of Germany, this enormous preparation",
                            TitleImagePath = "/images/menu_img8.jpg"
                        },
                        new
                        {
                            Id = new Guid("3511fce2-a51f-4a2f-b357-d33448a3a715"),
                            Category = "Burgers",
                            Name = "Chicken Burger",
                            Price = 15,
                            Subtitle = "The Chicken Caesar Burger is special because it retains the freshness of chicken",
                            TitleImagePath = "/images/menu_img8.jpg"
                        },
                        new
                        {
                            Id = new Guid("70bf0a24-8138-4cb5-b1d9-e6affac5054f"),
                            Category = "Burgers",
                            Name = "Luger Burger",
                            Price = 10,
                            Subtitle = "Luger Burger features extra thick bacon and more half pound of beef.",
                            TitleImagePath = "/images/menu_img7.jpg"
                        },
                        new
                        {
                            Id = new Guid("ad7fbecd-4c7d-4877-bb06-f32865cb2d78"),
                            Category = "Burgers",
                            Name = "Le Pigeon Burger",
                            Price = 10,
                            Subtitle = "Le Pigeon Burger has smoky flavor enhanced with each topping",
                            TitleImagePath = "/images/menu_img7.jpg"
                        },
                        new
                        {
                            Id = new Guid("9b7de6e6-c8af-4f06-ac07-2d7b7e89f196"),
                            Category = "Burgers",
                            Name = "Taco Burger",
                            Price = 12,
                            Subtitle = "Tacos are amazing, no doubt about it; need this amazing combo",
                            TitleImagePath = "/images/menu_img7.jpg"
                        },
                        new
                        {
                            Id = new Guid("98c265bc-090a-493c-9a77-72f8613a3fbd"),
                            Category = "Salads",
                            Name = "Cobb salad",
                            Price = 10,
                            Subtitle = "The only way to make this dish heavier is to add bricks",
                            TitleImagePath = "/images/menu_img9.jpg"
                        },
                        new
                        {
                            Id = new Guid("968147be-c8ea-4920-96b9-e291247d3362"),
                            Category = "Salads",
                            Name = "Larb",
                            Price = 10,
                            Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                            TitleImagePath = "/images/menu_img9.jpg"
                        },
                        new
                        {
                            Id = new Guid("8c04e4a5-6fef-4cef-8d85-c3cd6115cde9"),
                            Category = "Salads",
                            Name = "Cobb salad",
                            Price = 10,
                            Subtitle = "The only way to make this dish heavier is to add bricks",
                            TitleImagePath = "/images/menu_img9.jpg"
                        },
                        new
                        {
                            Id = new Guid("bd620fb9-b8c0-4403-a756-882de9a8efc0"),
                            Category = "Salads",
                            Name = "Waldorf salad",
                            Price = 10,
                            Subtitle = "Unlike the many folk salads featured here, Waldorf salad",
                            TitleImagePath = "/images/menu_img9.jpg"
                        },
                        new
                        {
                            Id = new Guid("1f3d5985-b7af-4999-a2a4-b60587973b7c"),
                            Category = "Salads",
                            Name = "Gado-gado",
                            Price = 10,
                            Subtitle = "Gado-gado literally means \"mix - mix.\" It's an Indonesian",
                            TitleImagePath = "/images/menu_img10.jpg"
                        },
                        new
                        {
                            Id = new Guid("a89e38c4-c8ad-45f8-bf02-c5a6189304fa"),
                            Category = "Salads",
                            Name = "Larb",
                            Price = 10,
                            Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                            TitleImagePath = "/images/menu_img9.jpg"
                        },
                        new
                        {
                            Id = new Guid("f3eea6e5-6bfc-476a-9aca-da716843447a"),
                            Category = "Salads",
                            Name = "Cobb salad",
                            Price = 10,
                            Subtitle = "The only way to make this dish heavier is to add bricks.",
                            TitleImagePath = "/images/menu_img9.jpg"
                        },
                        new
                        {
                            Id = new Guid("da457e8c-bbb5-47a0-b675-103ceb7c7cca"),
                            Category = "Salads",
                            Name = "Gado-gado",
                            Price = 10,
                            Subtitle = "Gado-gado literally means \"mix - mix.\" It's an Indonesian",
                            TitleImagePath = "/images/menu_img10.jpg"
                        },
                        new
                        {
                            Id = new Guid("ab327f8d-2a33-408a-a75b-148a546ee8cf"),
                            Category = "Salads",
                            Name = "Larb",
                            Price = 10,
                            Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                            TitleImagePath = "/images/menu_img9.jpg"
                        },
                        new
                        {
                            Id = new Guid("f1039a75-e76f-417c-96bf-3567f27905fc"),
                            Category = "Fries",
                            Name = "Potato Wedges",
                            Price = 10,
                            Subtitle = "Potato wedges sit at the very bottom of the french fry totem pole",
                            TitleImagePath = "/images/menu_img11.jpg"
                        },
                        new
                        {
                            Id = new Guid("bb75ffa5-4fd9-4aad-a750-b436a0c072b8"),
                            Category = "Fries",
                            Name = "Waffle Fries",
                            Price = 10,
                            Subtitle = "Waffle fries have the exact opposite problem of the potato wedges",
                            TitleImagePath = "/images/menu_img12.jpg"
                        },
                        new
                        {
                            Id = new Guid("ea674181-578f-4010-ae28-82228538080b"),
                            Category = "Fries",
                            Name = "Sweet Potato Fries",
                            Price = 10,
                            Subtitle = "We don't hate sweet potato fries, but we certainly don't love them",
                            TitleImagePath = "/images/menu_img11.jpg"
                        },
                        new
                        {
                            Id = new Guid("3a76f75d-d0c5-42d0-b707-21567ab66981"),
                            Category = "Fries",
                            Name = "Crinkle Cut Fries",
                            Price = 10,
                            Subtitle = "Crinkle cut fries just look like a good time. They're thick and heavy",
                            TitleImagePath = "/images/menu_img11.jpg"
                        },
                        new
                        {
                            Id = new Guid("4ef845ef-d197-4fb7-9b2f-4c7472ac0b36"),
                            Category = "Fries",
                            Name = "Steak Fries",
                            Price = 10,
                            Subtitle = "Steak fries might seem like the less fun-looking version of crinkle cut fries",
                            TitleImagePath = "/images/menu_img11.jpg"
                        },
                        new
                        {
                            Id = new Guid("869a5463-c1f2-4cf2-af16-8d4e371222bf"),
                            Category = "Fries",
                            Name = "Standard Fries",
                            Price = 10,
                            Subtitle = "Ah, the standard fry—the one that started it all. Despite the fact",
                            TitleImagePath = "/images/menu_img11.jpg"
                        },
                        new
                        {
                            Id = new Guid("7ffa30a0-c369-4405-9506-da4fbba42602"),
                            Category = "Fries",
                            Name = "Belgian Fries",
                            Price = 10,
                            Subtitle = "Belgian fries might look like the typical fry experience, but they most",
                            TitleImagePath = "/images/menu_img11.jpg"
                        },
                        new
                        {
                            Id = new Guid("efeffe0c-5665-433b-bf06-edd74a14cc42"),
                            Category = "Fries",
                            Name = "Shoestring Fries",
                            Price = 10,
                            Subtitle = "Despite the fact that shoestring fries aren't quite as crunchy",
                            TitleImagePath = "/images/menu_img11.jpg"
                        },
                        new
                        {
                            Id = new Guid("2878d04f-efe6-4a83-b4c4-495469f69709"),
                            Category = "Fries",
                            Name = "Curly Fries",
                            Price = 10,
                            Subtitle = "There's something so satisfying about curly fries. First of all",
                            TitleImagePath = "/images/menu_img11.jpg"
                        },
                        new
                        {
                            Id = new Guid("3fe2f198-9819-4879-b7d5-580eb23cfd6c"),
                            Category = "Drinks",
                            Name = "Coca-Cola",
                            Price = 10,
                            Subtitle = "Coca-Cola is the most popular drink in the world",
                            TitleImagePath = "/images/menu_img13.jpg"
                        },
                        new
                        {
                            Id = new Guid("cf8535c5-90f4-47f3-8161-170d2cf487af"),
                            Category = "Drinks",
                            Name = "Pepsi",
                            Price = 10,
                            Subtitle = "Pepsi is a cola drink type manufactured by PepsiCo",
                            TitleImagePath = "/images/menu_img13.jpg"
                        },
                        new
                        {
                            Id = new Guid("6f23cc43-4fc5-4edf-a8db-bf1a4eedc9ba"),
                            Category = "Drinks",
                            Name = "Nestlé S.A",
                            Price = 10,
                            Subtitle = "Nestle is synonymous with instant coffee, bottled water, crunches",
                            TitleImagePath = "/images/menu_img13.jpg"
                        },
                        new
                        {
                            Id = new Guid("03110d6c-410e-4383-a9cd-53361431f8d3"),
                            Category = "Drinks",
                            Name = "Sprite",
                            Price = 10,
                            Subtitle = "Sprite is a colorless, lime-lemon flavored, non-caffeinated soft",
                            TitleImagePath = "/images/menu_img13.jpg"
                        },
                        new
                        {
                            Id = new Guid("0ec22c2b-d8ed-4b5e-81b5-a6a99a10c210"),
                            Category = "Drinks",
                            Name = "Mountain Dew",
                            Price = 10,
                            Subtitle = "This is yet another PepsiCo carbonated soft drink.It comes",
                            TitleImagePath = "/images/menu_img13.jpg"
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
