using System;
using System.Collections.Generic;
using System.Text;
using Cinema.Domain.Domain;
using Microsoft.AspNetCore.Identity;

namespace Cinema.Domain.identity
{
    public class ApplicationUser : IdentityUser
    {
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Address { get; set; }
        public virtual ShoppingCart UserCart { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
