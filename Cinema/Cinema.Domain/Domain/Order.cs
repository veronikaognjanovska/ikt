using Cinema.Domain.identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Domain
{
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public IEnumerable<TicketInOrder> TicketInOrders { get; set; }
    }
}
