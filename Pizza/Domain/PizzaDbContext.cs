using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pizza.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Domain
{
    public class PizzaDbContext : IdentityDbContext<IdentityUser>
    {
        public PizzaDbContext(DbContextOptions<PizzaDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserProducts> UserProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                NormalizedEmail = "admin@admin.com",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "admin"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });

            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Deluxe",
                Price = 10,
                Subtitle = "original & favorite specialty pizza topped",
                TitleImagePath = "/images/pizza_img2.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Veggie",
                Price = 10,
                Subtitle = "Veggie lovers rejoice! Pizza topped with mushrooms",
                TitleImagePath = "/images/pizza_img2.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "All Meat",
                Price = 10,
                Subtitle = "Our famous meat pizza is topped",
                TitleImagePath = "/images/pizza_img3.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Barbecue Chicken",
                Price = 10,
                Subtitle = "Tangy, rich, our homemade BBQ Chicken pizza",
                TitleImagePath = "/images/pizza_img4.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Egg-ceptional",
                Price = 10,
                Subtitle = "Enjoy breakfast anytime of the day! Our breakfast pizza",
                TitleImagePath = "/images/pizza_img4.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "lunch Special Pizza",
                Price = 10,
                Subtitle = "one-topping pizza and a16 ounce drink Specialties",
                TitleImagePath = "/images/pizza_img5.png"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Buffalo Chicken",
                Price = 10,
                Subtitle = "Pizza with Chicken, Hot Sauce, Ranch Dressing",
                TitleImagePath = "/images/pizza_img6.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Tuscan Roma",
                Price = 10,
                Subtitle = "Pizza with Roma Tomatoes, Spinach, Alfredo Sauce",
                TitleImagePath = "/images/pizza_img1.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Mac & Cheese",
                Price = 10,
                Subtitle = "Pizza with Macaroni and Cheese",
                TitleImagePath = "/images/pizza_img2.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Luger Burger",
                Price = 10,
                Subtitle = "Luger Burger features extra thick bacon and more half pound of beef.",
                TitleImagePath = "/images/pro_img2.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Le Pigeon Burger",
                Price = 10,
                Subtitle = "Le Pigeon Burger has smoky flavor enhanced with each topping",
                TitleImagePath = "/images/pro_img2.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Taco Burger",
                Price = 12,
                Subtitle = "Tacos are amazing, no doubt about it; need this amazing combo",
                TitleImagePath = "/images/pro_img2.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Chicken Burger",
                Price = 15,
                Subtitle = "The Chicken Caesar Burger is special because it retains the freshness of chicken",
                TitleImagePath = "/images/Burgers.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Cheese Burger",
                Price = 10,
                Subtitle = "Easily the best burger in all of Germany, this enormous preparation",
                TitleImagePath = "/images/Burgers.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Chicken Burger",
                Price = 15,
                Subtitle = "The Chicken Caesar Burger is special because it retains the freshness of chicken",
                TitleImagePath = "/images/Burgers.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Luger Burger",
                Price = 10,
                Subtitle = "Luger Burger features extra thick bacon and more half pound of beef.",
                TitleImagePath = "/images/pro_img2.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Le Pigeon Burger",
                Price = 10,
                Subtitle = "Le Pigeon Burger has smoky flavor enhanced with each topping",
                TitleImagePath = "/images/pro_img2.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Taco Burger",
                Price = 12,
                Subtitle = "Tacos are amazing, no doubt about it; need this amazing combo",
                TitleImagePath = "/images/pro_img2.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Cobb salad",
                Price = 10,
                Subtitle = "The only way to make this dish heavier is to add bricks",
                TitleImagePath = "/images/pro_img3.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Larb",
                Price = 10,
                Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                TitleImagePath = "/images/pro_img3.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Cobb salad",
                Price = 10,
                Subtitle = "The only way to make this dish heavier is to add bricks",
                TitleImagePath = "/images/pro_img3.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Waldorf salad",
                Price = 10,
                Subtitle = "Unlike the many folk salads featured here, Waldorf salad",
                TitleImagePath = "/images/pro_img3.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Gado-gado",
                Price = 10,
                Subtitle = "Gado-gado literally means \"mix - mix.\" It's an Indonesian",
                TitleImagePath = "/images/Salad.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Larb",
                Price = 10,
                Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                TitleImagePath = "/images/pro_img3.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Cobb salad",
                Price = 10,
                Subtitle = "The only way to make this dish heavier is to add bricks.",
                TitleImagePath = "/images/pro_img3.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Gado-gado",
                Price = 10,
                Subtitle = "Gado-gado literally means \"mix - mix.\" It's an Indonesian",
                TitleImagePath = "/images/Salad.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Larb",
                Price = 10,
                Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                TitleImagePath = "/images/pro_img3.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Fries",
                Name = "Potato Wedges",
                Price = 10,
                Subtitle = "Potato wedges sit at the very bottom of the french fry totem pole",
                TitleImagePath = "/images/pro_img4.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Fries",
                Name = "Waffle Fries",
                Price = 10,
                Subtitle = "Waffle fries have the exact opposite problem of the potato wedges",
                TitleImagePath = "/images/Fries.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Fries",
                Name = "Sweet Potato Fries",
                Price = 10,
                Subtitle = "We don't hate sweet potato fries, but we certainly don't love them",
                TitleImagePath = "/images/pro_img4.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Fries",
                Name = "Crinkle Cut Fries",
                Price = 10,
                Subtitle = "Crinkle cut fries just look like a good time. They're thick and heavy",
                TitleImagePath = "/images/pro_img4.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Fries",
                Name = "Steak Fries",
                Price = 10,
                Subtitle = "Steak fries might seem like the less fun-looking version of crinkle cut fries",
                TitleImagePath = "/images/pro_img4.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Fries",
                Name = "Standard Fries",
                Price = 10,
                Subtitle = "Ah, the standard fry—the one that started it all. Despite the fact",
                TitleImagePath = "/images/pro_img4.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Fries",
                Name = "Belgian Fries",
                Price = 10,
                Subtitle = "Belgian fries might look like the typical fry experience, but they most",
                TitleImagePath = "/images/pro_img4.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Fries",
                Name = "Shoestring Fries",
                Price = 10,
                Subtitle = "Despite the fact that shoestring fries aren't quite as crunchy",
                TitleImagePath = "/images/pro_img4.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Fries",
                Name = "Curly Fries",
                Price = 10,
                Subtitle = "There's something so satisfying about curly fries. First of all",
                TitleImagePath = "/images/pro_img4.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Drinks",
                Name = "Coca-Cola",
                Price = 10,
                Subtitle = "Coca-Cola is the most popular drink in the world",
                TitleImagePath = "/images/pro_img5.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Drinks",
                Name = "Pepsi",
                Price = 10,
                Subtitle = "Pepsi is a cola drink type manufactured by PepsiCo",
                TitleImagePath = "/images/pro_img5.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Drinks",
                Name = "Nestlé S.A",
                Price = 10,
                Subtitle = "Nestle is synonymous with instant coffee, bottled water, crunches",
                TitleImagePath = "/images/pro_img5.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Drinks",
                Name = "Sprite",
                Price = 10,
                Subtitle = "Sprite is a colorless, lime-lemon flavored, non-caffeinated soft",
                TitleImagePath = "/images/pro_img5.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Drinks",
                Name = "Mountain Dew",
                Price = 10,
                Subtitle = "This is yet another PepsiCo carbonated soft drink.It comes",
                TitleImagePath = "/images/pro_img5.jpg"
            }); 
        }
    }
}
