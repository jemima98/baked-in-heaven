using BakedinHeaven.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakedinHeaven.DataAccess.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public OrderRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Order> GetAllOrders()
        {
            return _dbContext.Orders.ToList();
        }
    }
}
