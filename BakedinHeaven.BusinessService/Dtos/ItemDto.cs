using System;
using System.Collections.Generic;
using System.Text;

namespace BakedinHeaven.BusinessService.Dtos
{
    public class ItemDto
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

