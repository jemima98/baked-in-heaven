using BakedinHeaven.BusinessService.Dtos;
using BakedinHeaven1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakedinHeaven.BusinessService
{
    public interface IItemService
    {
        List<ItemDto> GetAllItems();
        void AddItem(Item newItem);
        void UpdateItem(Item itemChange, int id);
        void Delete(int id);
        Item Getitem(int id);
    }
}