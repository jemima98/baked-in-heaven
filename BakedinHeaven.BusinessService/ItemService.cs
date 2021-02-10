using BakedinHeaven.BusinessService.Dtos;
using BakedinHeaven.DataAccess.Repositories;
using BakedinHeaven1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakedinHeaven.BusinessService
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public void AddItem(Item newItem)
        {
            List<Item> data = new List<Item>();
            data = _itemRepository.GetItems(); // fetch the entire database
            int Total = data.Where(x => x.AvailableDate == newItem.AvailableDate).Count();
            var count = 0;
            var flag = 0;
            if (Total < 15)
            {
                foreach (var Element in data)
                {
                    if (Element.ItemName == newItem.ItemName)
                    {
                        break;
                        // " with same name already exist for the date";
                    }

                    else { flag = 1; }
                }
            }

            if (flag == 1)
            {

                if (newItem.IsSpecial == true)
                {
                    foreach (var Element in data)
                    {
                        if (Element.AvailableDate == newItem.AvailableDate)
                        {
                            if (Element.IsSpecial == true)
                            {
                                count++;
                            }
                        }

                    }

                    if (count < 4)
                    {
                        _itemRepository.Add(newItem);
                    }
                }

                else
                {
                    _itemRepository.Add(newItem);
                }
            }
        }

        public void Delete(int id)
        {
            _itemRepository.Delete(id);
        }

        public List<ItemDto> GetAllItems()
        {
            var items = _itemRepository.GetAllItems();

            return items.Select(x => new ItemDto
            {
                ItemId = x.ItemId,
                AvailableDate = x.AvailableDate,
                IsSpecial = x.IsSpecial,
                IsVeg = x.IsVeg,
                Kcal = x.Kcal,
                Price = x.Price,
                Quantity = x.Quantity,
                ItemName = x.ItemName,
                WeightInGrams = x.WeightInGrams
            }).OrderBy(x => x.ItemName).ThenBy(x => x.AvailableDate).ToList(); ;
        }

        public void UpdateItem(Item itemChange, int id)
        {
            List<Item> data = new List<Item>();
            data = _itemRepository.GetItems(); // fetch the entire database
            int Total = data.Where(x => x.AvailableDate == itemChange.AvailableDate).Count();
            var count = 0;
            var flag = 0;

            if (Total < 15)
            {
                foreach (var Element in data)
                {
                    if (Element.ItemName == itemChange.ItemName)
                    {
                        break;
                        // " with same name already exist for the date";
                    }

                    else { flag = 1; }

                }
            }

            if (flag == 1)
            {
                if (itemChange.IsSpecial == true)
                {
                    foreach (var Element in data)
                    {
                        if (Element.AvailableDate == itemChange.AvailableDate)
                        {
                            if (Element.IsSpecial == true)
                            {
                                count++;
                            }
                        }

                    }
                    if (count < 4)
                    {
                        _itemRepository.Update(itemChange, id);
                    }
                }
                else
                {
                    _itemRepository.Update(itemChange, id);
                }

            }
        }
        public Item Getitem(int id)
        {
            var items = _itemRepository.GetItem(id);
            return items;



        }


    }
}
