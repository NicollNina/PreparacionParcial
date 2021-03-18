using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiCountry.Models
{
    public class Currency
    {
        [Key]
        public String Code { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        [StringLength(5,MinimumLength =1,ErrorMessage ="Ingrese entre 1 a 5 caracteres")]
        public String Symbol { get; set; }

    }
}