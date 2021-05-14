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
                TitleImagePath = "~/images/pizza_img2.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Veggie",
                Price = 10,
                Subtitle = "Veggie lovers rejoice! Pizza topped with mushrooms",
                TitleImagePath = "~/images/pizza_img2.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "All Meat",
                Price = 10,
                Subtitle = "Our famous meat pizza is topped",
                TitleImagePath = "~/images/pizza_img3.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Barbecue Chicken",
                Price = 10,
                Subtitle = "Tangy, rich, our homemade BBQ Chicken pizza",
                TitleImagePath = "~/images/pizza_img4.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Egg-ceptional",
                Price = 10,
                Subtitle = "Enjoy breakfast anytime of the day! Our breakfast pizza",
                TitleImagePath = "~/images/pizza_img4.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "lunch Special Pizza",
                Price = 10,
                Subtitle = "one-topping pizza and a16 ounce drink Specialties",
                TitleImagePath = "~/images/pizza_img5.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Buffalo Chicken",
                Price = 10,
                Subtitle = "Pizza with Chicken, Hot Sauce, Ranch Dressing",
                TitleImagePath = "~/images/pizza_img6.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Tuscan Roma",
                Price = 10,
                Subtitle = "Pizza with Roma Tomatoes, Spinach, Alfredo Sauce",
                TitleImagePath = "~/images/pizza_img1.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Pizza",
                Name = "Mac & Cheese",
                Price = 10,
                Subtitle = "Pizza with Macaroni and Cheese",
                TitleImagePath = "~/images/pizza_img2.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Luger Burger",
                Price = 10,
                Subtitle = "Luger Burger features extra thick bacon and more half pound of beef.",
                TitleImagePath = "~/images/pro_img2.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Le Pigeon Burger",
                Price = 10,
                Subtitle = "Le Pigeon Burger has smoky flavor enhanced with each topping",
                TitleImagePath = "~/images/pro_img2.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Taco Burger",
                Price = 12,
                Subtitle = "Tacos are amazing, no doubt about it; need this amazing combo",
                TitleImagePath = "~/images/pro_img2.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Chicken Burger",
                Price = 15,
                Subtitle = "The Chicken Caesar Burger is special because it retains the freshness of chicken",
                TitleImagePath = "~/images/Burgers.jpg"
            }, new Product
            {
                Id = Guid.NewGuid(),
                Category = "Burgers",
                Name = "Cheese Burger",
                Price = 10,
                Subtitle = "Easily the best burger in all of Germany, this enormous preparation",
                TitleImagePath = "~/images/Burgers.jpg"
            }); 
        }
    }
}
