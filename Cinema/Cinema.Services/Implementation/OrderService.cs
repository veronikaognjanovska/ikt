using Cinema.Domain.Domain;
using Cinema.Domain.identity;
using Cinema.Domain.Identity;
using Cinema.Repository.Interface;
using Cinema.Services.Interface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUserRepository _userRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public OrderService(IOrderRepository orderRepository, IUserRepository userRepository, UserManager<ApplicationUser> userManager)
        {
            this._orderRepository = orderRepository;
            this._userRepository = userRepository;
            this.userManager = userManager;
        }

        public List<Order> getAllOrders(string userId)
        {
            var loggedInUser = this._userRepository.Get(userId);
            var roles =  userManager.GetRolesAsync(loggedInUser);
            if(roles.Result[0] == RoleName.Admin)
            {
                return this._orderRepository.getAllOrders();
            }
            return this._orderRepository.getAllOrdersForUser(userId);
        }

        public Order getOrderDetails(BaseEntity model)
        {
            return this._orderRepository.getOrderDetails(model);
        }
    }
}
