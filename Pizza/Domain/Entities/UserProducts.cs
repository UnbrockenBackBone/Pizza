using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Domain.Entities
{
    public class UserProducts
    {

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "ID покупателя")]
        public Guid IdUser { get; set; }

        [Display(Name = "ID товара")]
        public Guid IdProduct { get; set; }
    }
}
