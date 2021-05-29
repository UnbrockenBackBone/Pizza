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
    [Migration("20210516105059__initial")]
    partial class _initial
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
                            ConcurrencyStamp = "d2e76dee-545a-4734-96c7-4ca966b5806d",
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
                            ConcurrencyStamp = "434ad436-e884-4322-a43e-929dd39cde4a",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@admin.com",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEAx2VJ2emr+CFFF3jFTr875Zj78giUPLjuQ5LMIvPDV8Ia48UBvXLr13/Evy2uydeg==",
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
                            Id = new Guid("4a68aada-dffa-45db-9485-62709253fd05"),
                            Category = "Pizza",
                            Name = "Deluxe",
                            Price = 10,
                            Subtitle = "original & favorite specialty pizza topped",
                            TitleImagePath = "/images/pizza_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("92f703c2-5815-4d07-8d04-54175ae10d06"),
                            Category = "Pizza",
                            Name = "Veggie",
                            Price = 10,
                            Subtitle = "Veggie lovers rejoice! Pizza topped with mushrooms",
                            TitleImagePath = "/images/pizza_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("78613b8f-0948-4b7f-abe7-9088b37c9ae7"),
                            Category = "Pizza",
                            Name = "All Meat",
                            Price = 10,
                            Subtitle = "Our famous meat pizza is topped",
                            TitleImagePath = "/images/pizza_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("137529e6-2091-4442-8eee-2d4edf12d4b4"),
                            Category = "Pizza",
                            Name = "Barbecue Chicken",
                            Price = 10,
                            Subtitle = "Tangy, rich, our homemade BBQ Chicken pizza",
                            TitleImagePath = "/images/pizza_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("091178ba-62c9-4c1f-bb60-a3031b4b7448"),
                            Category = "Pizza",
                            Name = "Egg-ceptional",
                            Price = 10,
                            Subtitle = "Enjoy breakfast anytime of the day! Our breakfast pizza",
                            TitleImagePath = "/images/pizza_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("ddcc2452-fdf6-447b-b2be-36de12825857"),
                            Category = "Pizza",
                            Name = "lunch Special Pizza",
                            Price = 10,
                            Subtitle = "one-topping pizza and a16 ounce drink Specialties",
                            TitleImagePath = "/images/pizza_img5.png"
                        },
                        new
                        {
                            Id = new Guid("f091a9ab-7ad5-48fe-8512-c314ebac05d3"),
                            Category = "Pizza",
                            Name = "Buffalo Chicken",
                            Price = 10,
                            Subtitle = "Pizza with Chicken, Hot Sauce, Ranch Dressing",
                            TitleImagePath = "/images/pizza_img6.jpg"
                        },
                        new
                        {
                            Id = new Guid("90bc6d8f-d234-49ce-8929-ae64ca63f033"),
                            Category = "Pizza",
                            Name = "Tuscan Roma",
                            Price = 10,
                            Subtitle = "Pizza with Roma Tomatoes, Spinach, Alfredo Sauce",
                            TitleImagePath = "/images/pizza_img1.jpg"
                        },
                        new
                        {
                            Id = new Guid("55f2b081-622c-4960-bd23-ab31411b64ef"),
                            Category = "Pizza",
                            Name = "Mac & Cheese",
                            Price = 10,
                            Subtitle = "Pizza with Macaroni and Cheese",
                            TitleImagePath = "/images/pizza_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("a470dac9-db4a-4aaf-8961-441c78854f31"),
                            Category = "Burgers",
                            Name = "Luger Burger",
                            Price = 10,
                            Subtitle = "Luger Burger features extra thick bacon and more half pound of beef.",
                            TitleImagePath = "/images/pro_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("00775c10-b5f3-4009-aa85-7261330c6aed"),
                            Category = "Burgers",
                            Name = "Le Pigeon Burger",
                            Price = 10,
                            Subtitle = "Le Pigeon Burger has smoky flavor enhanced with each topping",
                            TitleImagePath = "/images/pro_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("19a0d40f-c79e-474b-bf8e-117832d60b13"),
                            Category = "Burgers",
                            Name = "Taco Burger",
                            Price = 12,
                            Subtitle = "Tacos are amazing, no doubt about it; need this amazing combo",
                            TitleImagePath = "/images/pro_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("6b352896-71a5-4b12-bd7d-9d79c2fb0c40"),
                            Category = "Burgers",
                            Name = "Chicken Burger",
                            Price = 15,
                            Subtitle = "The Chicken Caesar Burger is special because it retains the freshness of chicken",
                            TitleImagePath = "/images/Burgers.jpg"
                        },
                        new
                        {
                            Id = new Guid("016555a8-31ca-4230-8698-1d78f0638eef"),
                            Category = "Burgers",
                            Name = "Cheese Burger",
                            Price = 10,
                            Subtitle = "Easily the best burger in all of Germany, this enormous preparation",
                            TitleImagePath = "/images/Burgers.jpg"
                        },
                        new
                        {
                            Id = new Guid("e9d0ec93-d4ce-4810-aaaa-47793464425b"),
                            Category = "Burgers",
                            Name = "Chicken Burger",
                            Price = 15,
                            Subtitle = "The Chicken Caesar Burger is special because it retains the freshness of chicken",
                            TitleImagePath = "/images/Burgers.jpg"
                        },
                        new
                        {
                            Id = new Guid("9fc42768-221a-4d21-bf0b-565b4dc19bd5"),
                            Category = "Burgers",
                            Name = "Luger Burger",
                            Price = 10,
                            Subtitle = "Luger Burger features extra thick bacon and more half pound of beef.",
                            TitleImagePath = "/images/pro_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("94344499-7fd4-4d0d-80e4-830091eb0ef7"),
                            Category = "Burgers",
                            Name = "Le Pigeon Burger",
                            Price = 10,
                            Subtitle = "Le Pigeon Burger has smoky flavor enhanced with each topping",
                            TitleImagePath = "/images/pro_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("bad6879d-b5a6-42de-a5b0-d6be1c1d6716"),
                            Category = "Burgers",
                            Name = "Taco Burger",
                            Price = 12,
                            Subtitle = "Tacos are amazing, no doubt about it; need this amazing combo",
                            TitleImagePath = "/images/pro_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("e48a69f8-e6bc-47cd-8fb5-5e65b9c3e1f6"),
                            Category = "Salads",
                            Name = "Cobb salad",
                            Price = 10,
                            Subtitle = "The only way to make this dish heavier is to add bricks",
                            TitleImagePath = "/images/pro_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("fc3e2232-9d9b-4978-93d7-37afa7c37cea"),
                            Category = "Salads",
                            Name = "Larb",
                            Price = 10,
                            Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                            TitleImagePath = "/images/pro_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("e8750912-a5a1-4934-9060-de4ace641ae7"),
                            Category = "Salads",
                            Name = "Cobb salad",
                            Price = 10,
                            Subtitle = "The only way to make this dish heavier is to add bricks",
                            TitleImagePath = "/images/pro_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("b7356081-2022-4755-9388-dfcd8909b8a9"),
                            Category = "Salads",
                            Name = "Waldorf salad",
                            Price = 10,
                            Subtitle = "Unlike the many folk salads featured here, Waldorf salad",
                            TitleImagePath = "/images/pro_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("870641f1-e1c0-48a7-b2cf-4f411f2dde71"),
                            Category = "Salads",
                            Name = "Gado-gado",
                            Price = 10,
                            Subtitle = "Gado-gado literally means \"mix - mix.\" It's an Indonesian",
                            TitleImagePath = "/images/Salad.jpg"
                        },
                        new
                        {
                            Id = new Guid("1143d521-1a53-457b-a0d5-882ec67d2dfa"),
                            Category = "Salads",
                            Name = "Larb",
                            Price = 10,
                            Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                            TitleImagePath = "/images/pro_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("056e0bfc-3c6b-4c52-be4c-d1ed78c1f6a3"),
                            Category = "Salads",
                            Name = "Cobb salad",
                            Price = 10,
                            Subtitle = "The only way to make this dish heavier is to add bricks.",
                            TitleImagePath = "/images/pro_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("73c0d289-4aa8-4400-b77a-1334eadc1e4d"),
                            Category = "Salads",
                            Name = "Gado-gado",
                            Price = 10,
                            Subtitle = "Gado-gado literally means \"mix - mix.\" It's an Indonesian",
                            TitleImagePath = "/images/Salad.jpg"
                        },
                        new
                        {
                            Id = new Guid("30438fe3-171d-46cc-b253-f6c50ce9867d"),
                            Category = "Salads",
                            Name = "Larb",
                            Price = 10,
                            Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                            TitleImagePath = "/images/pro_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("ef636bd2-1f52-4b5e-bd52-d5d4f7d2a1fb"),
                            Category = "Fries",
                            Name = "Potato Wedges",
                            Price = 10,
                            Subtitle = "Potato wedges sit at the very bottom of the french fry totem pole",
                            TitleImagePath = "/images/pro_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("1f3ecd85-108d-4170-a0b1-4686f2ac0c65"),
                            Category = "Fries",
                            Name = "Waffle Fries",
                            Price = 10,
                            Subtitle = "Waffle fries have the exact opposite problem of the potato wedges",
                            TitleImagePath = "/images/Fries.jpg"
                        },
                        new
                        {
                            Id = new Guid("f6c190fe-c966-4a1b-986d-35d5705de5eb"),
                            Category = "Fries",
                            Name = "Sweet Potato Fries",
                            Price = 10,
                            Subtitle = "We don't hate sweet potato fries, but we certainly don't love them",
                            TitleImagePath = "/images/pro_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("99462512-e31e-4aa4-9e8f-e88b93b735d8"),
                            Category = "Fries",
                            Name = "Crinkle Cut Fries",
                            Price = 10,
                            Subtitle = "Crinkle cut fries just look like a good time. They're thick and heavy",
                            TitleImagePath = "/images/pro_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("581e1a78-7371-49ce-ac78-27fa8484476f"),
                            Category = "Fries",
                            Name = "Steak Fries",
                            Price = 10,
                            Subtitle = "Steak fries might seem like the less fun-looking version of crinkle cut fries",
                            TitleImagePath = "/images/pro_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("f91b9a53-5faf-4e5e-810b-1bbc465e6a30"),
                            Category = "Fries",
                            Name = "Standard Fries",
                            Price = 10,
                            Subtitle = "Ah, the standard fry—the one that started it all. Despite the fact",
                            TitleImagePath = "/images/pro_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("f4e2e1b8-19c2-4ffe-befd-6535db38020a"),
                            Category = "Fries",
                            Name = "Belgian Fries",
                            Price = 10,
                            Subtitle = "Belgian fries might look like the typical fry experience, but they most",
                            TitleImagePath = "/images/pro_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("c65a72d0-3dc2-425c-90ca-f97867b459d5"),
                            Category = "Fries",
                            Name = "Shoestring Fries",
                            Price = 10,
                            Subtitle = "Despite the fact that shoestring fries aren't quite as crunchy",
                            TitleImagePath = "/images/pro_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("25073ff0-2ae5-43c2-ab45-45399639f550"),
                            Category = "Fries",
                            Name = "Curly Fries",
                            Price = 10,
                            Subtitle = "There's something so satisfying about curly fries. First of all",
                            TitleImagePath = "/images/pro_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("bea828ff-7b58-4119-b877-5602a9944f7a"),
                            Category = "Drinks",
                            Name = "Coca-Cola",
                            Price = 10,
                            Subtitle = "Coca-Cola is the most popular drink in the world",
                            TitleImagePath = "/images/pro_img5.jpg"
                        },
                        new
                        {
                            Id = new Guid("d0ee61e4-866f-4d10-a25d-ea329db0140c"),
                            Category = "Drinks",
                            Name = "Pepsi",
                            Price = 10,
                            Subtitle = "Pepsi is a cola drink type manufactured by PepsiCo",
                            TitleImagePath = "/images/pro_img5.jpg"
                        },
                        new
                        {
                            Id = new Guid("fecf5c79-d1f1-4e0f-b2aa-6bf5e63e1217"),
                            Category = "Drinks",
                            Name = "Nestlé S.A",
                            Price = 10,
                            Subtitle = "Nestle is synonymous with instant coffee, bottled water, crunches",
                            TitleImagePath = "/images/pro_img5.jpg"
                        },
                        new
                        {
                            Id = new Guid("cd8b677e-5b44-4b81-a391-88d38b298ac0"),
                            Category = "Drinks",
                            Name = "Sprite",
                            Price = 10,
                            Subtitle = "Sprite is a colorless, lime-lemon flavored, non-caffeinated soft",
                            TitleImagePath = "/images/pro_img5.jpg"
                        },
                        new
                        {
                            Id = new Guid("337731d7-8549-490b-a96e-9ee02f6abd08"),
                            Category = "Drinks",
                            Name = "Mountain Dew",
                            Price = 10,
                            Subtitle = "This is yet another PepsiCo carbonated soft drink.It comes",
                            TitleImagePath = "/images/pro_img5.jpg"
                        });
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