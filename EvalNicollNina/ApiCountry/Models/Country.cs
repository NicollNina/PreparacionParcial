using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiCountry.Models
{
    public class Country
    {
        [Key]
        public String Name { get; set; }
        [Required]
        public String Capital { get; set; }
        public int Population { get; set; }
        public List<double> Latlng { get; set; }
        public List<String> Timezones { get; set; }
        public List<Currency> Currencies { get; set; }
        public String flag { get; set; }
    }
}