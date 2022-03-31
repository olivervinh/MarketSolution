using Market.Domain.Base;
using Market.Domain.Users.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Domain.Orders.Models
{
    public class Order : AuditEntity<short>
    {      
        public DateTime DateCreated { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public string? FkUserId { get; set; }
        [ForeignKey("FkUserId")]
        public virtual User User { get; set; }
    }
}
