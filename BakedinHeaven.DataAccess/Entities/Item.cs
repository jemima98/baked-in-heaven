using BakedinHeaven.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakedinHeaven1.Entities
{
    public class Item
    {
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public int Quantity { get; set; }

        public float Price { get; set; }

        public float WeightInGrams { get; set; }

        public float Kcal { get; set; }

        public bool IsVeg { get; set; }

        public bool IsSpecial { get; set; }
        public DateTime AvailableDate { get; set; }





    }
}