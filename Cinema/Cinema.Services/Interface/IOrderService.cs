using Cinema.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.Interface
{
    public interface IOrderService
    {
        List<Order> getAllOrders(string userId);
        Order getOrderDetails(BaseEntity model);
    }
}
