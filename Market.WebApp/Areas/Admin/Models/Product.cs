using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Market.WebApp.Areas.Admin.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ImageProduct> ImageProducts { get;set; }
        public virtual User User { get; set; }
    }
}
