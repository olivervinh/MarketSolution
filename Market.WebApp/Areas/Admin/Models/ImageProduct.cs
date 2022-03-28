using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Market.WebApp.Areas.Admin.Models
{
    public class ImageProduct
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public bool IsThumbnail { get; set; }
        public virtual Product Product { get; set; }
    }
}
