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
        public DbSet<Product> TextFields { get; set; }

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
                Name = "Deluxe",
                Price = 10,
                Subtitle = "original & favorite specialty pizza topped",
                TitleImagePath = "~/images/pizza_img2.jpg"
            });
        }
    }
}
