using Cinema.Domain.identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Domain
{
    public class ShoppingCart : BaseEntity
    {
        public string OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }
        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }
    }
}
