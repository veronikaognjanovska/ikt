using Cinema.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Repository.Interface
{
    public interface IOrderRepository
    {
        List<Order> getAllOrders();
        List<Order> getAllOrdersForUser(string userId);
        Order getOrderDetails(BaseEntity model);
    }
}
