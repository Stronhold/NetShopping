using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using NetShopping.Model;

namespace NetShopping.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public int CartId { get; set; }
        [ForeignKey("CartId")]
        public virtual UserCart Cart { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
