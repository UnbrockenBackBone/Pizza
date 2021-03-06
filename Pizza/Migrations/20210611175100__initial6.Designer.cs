// <auto-generated />
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
    [Migration("20210611175100__initial6")]
    partial class _initial6
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
                            ConcurrencyStamp = "04b766e9-f790-4675-a03a-626ed06095e0",
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
                            ConcurrencyStamp = "86eab256-e15d-4676-8932-61a16d08abfa",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@admin.com",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEE159JEZXlxBZXiq13bJCEHh2cNdz6ncK3yIJGEAFyNVfK6R89kmNKZSqdeHjCqSwA==",
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
                            Id = new Guid("704f6780-0474-4089-803a-62c01c1dc460"),
                            Category = "Pizza",
                            Name = "Deluxe",
                            Price = 10,
                            Subtitle = "original & favorite specialty pizza topped",
                            TitleImagePath = "/images/menu_img15.jpg"
                        },
                        new
                        {
                            Id = new Guid("6f0abd41-f120-4fa3-89db-caa3402986c3"),
                            Category = "Pizza",
                            Name = "Veggie",
                            Price = 10,
                            Subtitle = "Veggie lovers rejoice! Pizza topped with mushrooms",
                            TitleImagePath = "/images/menu_img2.jpg"
                        },
                        new
                        {
                            Id = new Guid("48e35bad-6573-44ac-87fc-c351788e4ab0"),
                            Category = "Pizza",
                            Name = "All Meat",
                            Price = 10,
                            Subtitle = "Our famous meat pizza is topped",
                            TitleImagePath = "/images/menu_img3.jpg"
                        },
                        new
                        {
                            Id = new Guid("c84c006c-eafb-46ad-b985-caa394d8e4d4"),
                            Category = "Pizza",
                            Name = "Barbecue Chicken",
                            Price = 10,
                            Subtitle = "Tangy, rich, our homemade BBQ Chicken pizza",
                            TitleImagePath = "/images/menu_img14.jpg"
                        },
                        new
                        {
                            Id = new Guid("10b7f575-e1f2-48c5-b4e1-dd061d067427"),
                            Category = "Pizza",
                            Name = "Egg-ceptional",
                            Price = 10,
                            Subtitle = "Enjoy breakfast anytime of the day! Our breakfast pizza",
                            TitleImagePath = "/images/menu_img4.jpg"
                        },
                        new
                        {
                            Id = new Guid("894cc8ea-5d0e-4698-bb40-bed6b6b096a9"),
                            Category = "Pizza",
                            Name = "lunch Special Pizza",
                            Price = 10,
                            Subtitle = "one-topping pizza and a16 ounce drink Specialties",
                            TitleImagePath = "/images/menu_img5.png"
                        },
                        new
                        {
                            Id = new Guid("49351862-df6a-443c-bd4d-581360b5de62"),
                            Category = "Pizza",
                            Name = "Buffalo Chicken",
                            Price = 10,
                            Subtitle = "Pizza with Chicken, Hot Sauce, Ranch Dressing",
                            TitleImagePath = "/images/menu_img6.jpg"
                        },
                        new
                        {
                            Id = new Guid("82184ceb-e751-4abe-8807-bb7a26043e2f"),
                            Category = "Pizza",
                            Name = "Tuscan Roma",
                            Price = 10,
                            Subtitle = "Pizza with Roma Tomatoes, Spinach, Alfredo Sauce",
                            TitleImagePath = "/images/menu_img1.jpg"
                        },
                        new
                        {
                            Id = new Guid("ee893140-583e-4828-825a-d25625f2edde"),
                            Category = "Pizza",
                            Name = "Mac & Cheese",
                            Price = 10,
                            Subtitle = "Pizza with Macaroni and Cheese",
                            TitleImagePath = "/images/menu_img16.jpg"
                        },
                        new
                        {
                            Id = new Guid("d938949d-1cc5-46d7-9e88-fe2724dc86a4"),
                            Category = "Burgers",
                            Name = "Luger Burger",
                            Price = 10,
                            Subtitle = "Luger Burger features extra thick bacon and more half pound of beef.",
                            TitleImagePath = "/images/menu_img8.jpg"
                        },
                        new
                        {
                            Id = new Guid("5f7aeddc-3cb8-4dd6-b61a-ecc589923147"),
                            Category = "Burgers",
                            Name = "Le Pigeon Burger",
                            Price = 10,
                            Subtitle = "Le Pigeon Burger has smoky flavor enhanced with each topping",
                            TitleImagePath = "/images/menu_img17.jpg"
                        },
                        new
                        {
                            Id = new Guid("38222a34-3e25-4ccf-8e3d-756f92a479d7"),
                            Category = "Burgers",
                            Name = "Taco Burger",
                            Price = 12,
                            Subtitle = "Tacos are amazing, no doubt about it; need this amazing combo",
                            TitleImagePath = "/images/menu_img18.jpg"
                        },
                        new
                        {
                            Id = new Guid("86de964c-a601-4815-ba11-cba8bf191201"),
                            Category = "Burgers",
                            Name = "Chicken Burger",
                            Price = 15,
                            Subtitle = "The Chicken Caesar Burger is special because it retains the freshness of chicken",
                            TitleImagePath = "/images/menu_img19.jpg"
                        },
                        new
                        {
                            Id = new Guid("676343ce-cc79-48dc-a46e-0558e1d3c016"),
                            Category = "Burgers",
                            Name = "Cheese Burger",
                            Price = 10,
                            Subtitle = "Easily the best burger in all of Germany, this enormous preparation",
                            TitleImagePath = "/images/menu_img20.jpg"
                        },
                        new
                        {
                            Id = new Guid("c3f2e19b-47bd-4431-ac25-a3f779d95b50"),
                            Category = "Burgers",
                            Name = "Chicken Burger",
                            Price = 15,
                            Subtitle = "The Chicken Caesar Burger is special because it retains the freshness of chicken",
                            TitleImagePath = "/images/menu_img21.jpg"
                        },
                        new
                        {
                            Id = new Guid("6e04d445-4796-42f5-9379-a30d459ae149"),
                            Category = "Burgers",
                            Name = "Luger Burger",
                            Price = 10,
                            Subtitle = "Luger Burger features extra thick bacon and more half pound of beef.",
                            TitleImagePath = "/images/menu_img22.jpg"
                        },
                        new
                        {
                            Id = new Guid("ed8ae15e-dbf9-4354-8c76-d96d9d30899d"),
                            Category = "Burgers",
                            Name = "Le Pigeon Burger",
                            Price = 10,
                            Subtitle = "Le Pigeon Burger has smoky flavor enhanced with each topping",
                            TitleImagePath = "/images/menu_img23.jpg"
                        },
                        new
                        {
                            Id = new Guid("32c6f50e-d884-4bc1-8678-460889f0e530"),
                            Category = "Burgers",
                            Name = "Taco Burger",
                            Price = 12,
                            Subtitle = "Tacos are amazing, no doubt about it; need this amazing combo",
                            TitleImagePath = "/images/menu_img24.jpg"
                        },
                        new
                        {
                            Id = new Guid("aece00bb-e9cb-4268-b9f0-ffc5301e788d"),
                            Category = "Salads",
                            Name = "Cobb salad",
                            Price = 10,
                            Subtitle = "The only way to make this dish heavier is to add bricks",
                            TitleImagePath = "/images/menu_img9.jpg"
                        },
                        new
                        {
                            Id = new Guid("583d206b-64b8-4c0d-9542-fb615fa85bd4"),
                            Category = "Salads",
                            Name = "Larb",
                            Price = 10,
                            Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                            TitleImagePath = "/images/menu_img25.jpg"
                        },
                        new
                        {
                            Id = new Guid("e89038c0-9a4b-4210-8c70-644118a116e5"),
                            Category = "Salads",
                            Name = "Cobb salad",
                            Price = 10,
                            Subtitle = "The only way to make this dish heavier is to add bricks",
                            TitleImagePath = "/images/menu_img26.jpg"
                        },
                        new
                        {
                            Id = new Guid("b132057a-ab65-4ef5-b940-40902cdeb8c5"),
                            Category = "Salads",
                            Name = "Waldorf salad",
                            Price = 10,
                            Subtitle = "Unlike the many folk salads featured here, Waldorf salad",
                            TitleImagePath = "/images/menu_img27.jpg"
                        },
                        new
                        {
                            Id = new Guid("683cd6a5-21da-421e-bc17-8d18d2df2912"),
                            Category = "Salads",
                            Name = "Gado-gado",
                            Price = 10,
                            Subtitle = "Gado-gado literally means \"mix - mix.\" It's an Indonesian",
                            TitleImagePath = "/images/menu_img10.jpg"
                        },
                        new
                        {
                            Id = new Guid("a0a130e2-1385-4816-807d-88ab44b19923"),
                            Category = "Salads",
                            Name = "Larb",
                            Price = 10,
                            Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                            TitleImagePath = "/images/menu_img28.jpg"
                        },
                        new
                        {
                            Id = new Guid("c9abbc53-2f4c-4c11-849d-446a620baa4e"),
                            Category = "Salads",
                            Name = "Cobb salad",
                            Price = 10,
                            Subtitle = "The only way to make this dish heavier is to add bricks.",
                            TitleImagePath = "/images/menu_img29.jpg"
                        },
                        new
                        {
                            Id = new Guid("c3d98810-bb98-4534-b345-d3a844ebcdaf"),
                            Category = "Salads",
                            Name = "Gado-gado",
                            Price = 10,
                            Subtitle = "Gado-gado literally means \"mix - mix.\" It's an Indonesian",
                            TitleImagePath = "/images/menu_img30.jpg"
                        },
                        new
                        {
                            Id = new Guid("b7fe755f-a4fa-491e-adf4-3d62754f6104"),
                            Category = "Salads",
                            Name = "Larb",
                            Price = 10,
                            Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                            TitleImagePath = "/images/menu_img31.jpg"
                        },
                        new
                        {
                            Id = new Guid("04dc0008-e583-41fe-b085-6b2f95926fca"),
                            Category = "Fries",
                            Name = "Potato Wedges",
                            Price = 10,
                            Subtitle = "Potato wedges sit at the very bottom of the french fry totem pole",
                            TitleImagePath = "/images/menu_img12.jpg"
                        },
                        new
                        {
                            Id = new Guid("840b20d8-e6bd-4b9a-9a40-65ae6eaa3374"),
                            Category = "Drinks",
                            Name = "Coca-Cola",
                            Price = 10,
                            Subtitle = "Coca-Cola is the most popular drink in the world",
                            TitleImagePath = "/images/menu_img13.jpg"
                        },
                        new
                        {
                            Id = new Guid("469c626d-aa4b-47f7-8f8d-fa4aaa2d8f6a"),
                            Category = "Drinks",
                            Name = "Schweppes Pomegranate",
                            Price = 10,
                            Subtitle = "Schweppes Pomegranate is synonymous with instant coffee, bottled water, crunches",
                            TitleImagePath = "/images/menu_img35.jpg"
                        },
                        new
                        {
                            Id = new Guid("6be96699-3eaa-4b66-9c03-4a89bb39a02b"),
                            Category = "Drinks",
                            Name = "Sprite",
                            Price = 10,
                            Subtitle = "Sprite is a colorless, lime-lemon flavored, non-caffeinated soft",
                            TitleImagePath = "/images/menu_img33.jpg"
                        },
                        new
                        {
                            Id = new Guid("45b1702d-422a-4b9a-9082-ddd22de5b1e0"),
                            Category = "Drinks",
                            Name = "Coca-Cola",
                            Price = 10,
                            Subtitle = "Coca-Cola is the most popular drink in the world",
                            TitleImagePath = "/images/menu_img34.jpg"
                        },
                        new
                        {
                            Id = new Guid("84d613b5-7a20-4904-baac-0cee20c8fb63"),
                            Category = "Drinks",
                            Name = "Schweppes Mojito",
                            Price = 10,
                            Subtitle = "Schweppes Mojito is synonymous with instant coffee, bottled water, crunches",
                            TitleImagePath = "/images/menu_img37.png"
                        },
                        new
                        {
                            Id = new Guid("9abe054c-32ff-450e-bd96-59f4dac3c91f"),
                            Category = "Drinks",
                            Name = "Fanta Exotic",
                            Price = 10,
                            Subtitle = "Fanta Exotic is synonymous with instant coffee, bottled water, crunches",
                            TitleImagePath = "/images/menu_img38.png"
                        },
                        new
                        {
                            Id = new Guid("bef1cd29-8647-4557-b921-c137030bd157"),
                            Category = "Drinks",
                            Name = "Fanta",
                            Price = 10,
                            Subtitle = "Fanta is synonymous with instant coffee, bottled water, crunches",
                            TitleImagePath = "/images/menu_img39.jpeg"
                        },
                        new
                        {
                            Id = new Guid("eb9af1ad-e7d3-46df-a7df-e92cc923c932"),
                            Category = "Drinks",
                            Name = "Fanta",
                            Price = 10,
                            Subtitle = "Fanta is synonymous with instant coffee, bottled water, crunches",
                            TitleImagePath = "/images/menu_img32.png"
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
