using BakedinHeaven1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakedinHeaven.DataAccess.Repositories
{
    public interface IItemRepository
    {
        List<Item> GetAllItems();
        void Add(Item itemEntity);
        Item Update(Item itemChange, int id);
        bool Delete(int id);
        List<Item> GetItems();
        Item GetItem(int id);

    }
}