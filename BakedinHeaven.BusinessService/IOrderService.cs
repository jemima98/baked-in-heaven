using BakedinHeaven.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakedinHeaven.BusinessService
{
    public interface IOrderService
    {
        List<Order> GetOrders();

    }
}