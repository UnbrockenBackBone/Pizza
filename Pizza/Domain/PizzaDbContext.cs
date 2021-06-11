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

            builder.Entity<Product>().HasData(
            #region Pizza
              new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Deluxe",
                Price = 10,
                Subtitle = "original & favorite specialty pizza topped",
                TitleImagePath = "/images/menu_img15.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Veggie",
                Price = 10,
                Subtitle = "Veggie lovers rejoice! Pizza topped with mushrooms",
                TitleImagePath = "/images/menu_img2.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "All Meat",
                Price = 10,
                Subtitle = "Our famous meat pizza is topped",
                TitleImagePath = "/images/menu_img3.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Barbecue Chicken",
                Price = 10,
                Subtitle = "Tangy, rich, our homemade BBQ Chicken pizza",
                TitleImagePath = "/images/menu_img14.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Egg-ceptional",
                Price = 10,
                Subtitle = "Enjoy breakfast anytime of the day! Our breakfast pizza",
                TitleImagePath = "/images/menu_img4.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "lunch Special Pizza",
                Price = 10,
                Subtitle = "one-topping pizza and a16 ounce drink Specialties",
                TitleImagePath = "/images/menu_img5.png"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Buffalo Chicken",
                Price = 10,
                Subtitle = "Pizza with Chicken, Hot Sauce, Ranch Dressing",
                TitleImagePath = "/images/menu_img6.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Tuscan Roma",
                Price = 10,
                Subtitle = "Pizza with Roma Tomatoes, Spinach, Alfredo Sauce",
                TitleImagePath = "/images/menu_img1.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Mac & Cheese",
                Price = 10,
                Subtitle = "Pizza with Macaroni and Cheese",
                TitleImagePath = "/images/menu_img16.jpg"
            #endregion
            #region Burgers
            }, new Product
                {
                    Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Luger Burger",
                Price = 10,
                Subtitle = "Luger Burger features extra thick bacon and more half pound of beef.",
                TitleImagePath = "/images/menu_img8.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Le Pigeon Burger",
                Price = 10,
                Subtitle = "Le Pigeon Burger has smoky flavor enhanced with each topping",
                TitleImagePath = "/images/menu_img17.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Taco Burger",
                Price = 12,
                Subtitle = "Tacos are amazing, no doubt about it; need this amazing combo",
                TitleImagePath = "/images/menu_img18.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Chicken Burger",
                Price = 15,
                Subtitle = "The Chicken Caesar Burger is special because it retains the freshness of chicken",
                TitleImagePath = "/images/menu_img19.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Cheese Burger",
                Price = 10,
                Subtitle = "Easily the best burger in all of Germany, this enormous preparation",
                TitleImagePath = "/images/menu_img20.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Chicken Burger",
                Price = 15,
                Subtitle = "The Chicken Caesar Burger is special because it retains the freshness of chicken",
                TitleImagePath = "/images/menu_img21.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Luger Burger",
                Price = 10,
                Subtitle = "Luger Burger features extra thick bacon and more half pound of beef.",
                TitleImagePath = "/images/menu_img22.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Le Pigeon Burger",
                Price = 10,
                Subtitle = "Le Pigeon Burger has smoky flavor enhanced with each topping",
                TitleImagePath = "/images/menu_img23.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Taco Burger",
                Price = 12,
                Subtitle = "Tacos are amazing, no doubt about it; need this amazing combo",
                TitleImagePath = "/images/menu_img24.jpg"
        #endregion
            #region Salad
            }, new Product
             {
                    Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Cobb salad",
                Price = 10,
                Subtitle = "The only way to make this dish heavier is to add bricks",
                TitleImagePath = "/images/menu_img9.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Larb",
                Price = 10,
                Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                TitleImagePath = "/images/menu_img25.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Cobb salad",
                Price = 10,
                Subtitle = "The only way to make this dish heavier is to add bricks",
                TitleImagePath = "/images/menu_img26.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Waldorf salad",
                Price = 10,
                Subtitle = "Unlike the many folk salads featured here, Waldorf salad",
                TitleImagePath = "/images/menu_img27.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Gado-gado",
                Price = 10,
                Subtitle = "Gado-gado literally means \"mix - mix.\" It's an Indonesian",
                TitleImagePath = "/images/menu_img10.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Larb",
                Price = 10,
                Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                TitleImagePath = "/images/menu_img28.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Cobb salad",
                Price = 10,
                Subtitle = "The only way to make this dish heavier is to add bricks.",
                TitleImagePath = "/images/menu_img29.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Gado-gado",
                Price = 10,
                Subtitle = "Gado-gado literally means \"mix - mix.\" It's an Indonesian",
                TitleImagePath = "/images/menu_img30.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Salads",
                Name = "Larb",
                Price = 10,
                Subtitle = "It's usually served with raw vegetables and sticky rice. vegetables",
                TitleImagePath = "/images/menu_img31.jpg"
        #endregion
            #region Fries
            }, new Product
                {
                    Id = Guid.NewGuid(),
                Category = "Fries",
                Name = "Potato Wedges",
                Price = 10,
                Subtitle = "Potato wedges sit at the very bottom of the french fry totem pole",
                TitleImagePath = "/images/menu_img12.jpg"
     #endregion
            #region Drinks
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Drinks",
                Name = "Coca-Cola",
                Price = 10,
                Subtitle = "Coca-Cola is the most popular drink in the world",
                TitleImagePath = "/images/menu_img13.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Drinks",
                Name = "Schweppes Pomegranate",
                Price = 10,
                Subtitle = "Schweppes Pomegranate is synonymous with instant coffee, bottled water, crunches",
                TitleImagePath = "/images/menu_img35.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Drinks",
                Name = "Sprite",
                Price = 10,
                Subtitle = "Sprite is a colorless, lime-lemon flavored, non-caffeinated soft",
                TitleImagePath = "/images/menu_img33.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Drinks",
                Name = "Coca-Cola",
                Price = 10,
                Subtitle = "Coca-Cola is the most popular drink in the world",
                TitleImagePath = "/images/menu_img34.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Drinks",
                Name = "Schweppes Mojito",
                Price = 10,
                Subtitle = "Schweppes Mojito is synonymous with instant coffee, bottled water, crunches",
                TitleImagePath = "/images/menu_img37.png"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Drinks",
                Name = "Fanta",
                Price = 10,
                Subtitle = "Fanta is synonymous with instant coffee, bottled water, crunches",
                TitleImagePath = "/images/menu_img39.jpeg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Drinks",
                Name = "Fanta",
                Price = 10,
                Subtitle = "Fanta is synonymous with instant coffee, bottled water, crunches",
                TitleImagePath = "/images/menu_img32.png"
            }
            #endregion
            ); 
        }
    }
}
