using NetShopping.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetShopping.Models
{
    public class UserCart
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public double Price { get; set; }
    }
}
