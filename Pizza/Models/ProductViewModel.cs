using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models
{
    public class ProductViewModel
    {
        [Display(Name = "Категория товара")]
        public string Category { get; set; }

        [Display(Name = "Название товара")]
        public string Name { get; set; }

        [Display(Name = "Цена товара")]
        public int Price { get; set; }

        [Display(Name = "Краткое описание")]
        public string Subtitle { get; set; }

        public IFormFileCollection uploads { get; set; }
    }
}
