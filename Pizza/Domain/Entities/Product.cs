using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Domain.Entities
{
    public class Product
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Категория товара")]
        public string Category { get; set; }

        [Display(Name = "Название товара")]
        public string Name { get; set; }

        [Display(Name = "Цена товара")]
        public int Price { get; set; }

        [Display(Name = "Краткое описание")]
        public string Subtitle { get; set; }

        [Display(Name = "Титульная картинка")]
        public string TitleImagePath { get; set; }
    }
}
