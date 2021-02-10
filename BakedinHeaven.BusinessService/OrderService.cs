using BakedinHeaven.DataAccess.Entities;
using BakedinHeaven.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakedinHeaven.BusinessService
{
    public class OrderService : IOrderService

    {
        private readonly OrderRepository _orderRepository;

        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            orders = _orderRepository.GetAllOrders();
            return orders.ToList();
        }
    }
}
