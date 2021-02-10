using BakedinHeaven.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BakedinHeaven.DataAccess.Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrders();


    }
}
