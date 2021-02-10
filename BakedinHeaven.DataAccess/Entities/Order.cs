using BakedinHeaven1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakedinHeaven.DataAccess.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public DateTime OrderDate { get; set; }

    }
}