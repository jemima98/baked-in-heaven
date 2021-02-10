using BakedinHeaven.BusinessService;
using BakedinHeaven.BusinessService.Dtos;
using BakedinHeaven1.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakedinHeaven1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BakeryController : ControllerBase
    {
        private readonly IItemService _itemService;


        public BakeryController(IItemService itemService)
        {
            _itemService = itemService;

        }
        [HttpGet]
        public List<ItemDto> Getitem()
        {

            return _itemService.GetAllItems();
        }

        [HttpPost]
        public void AddItem(Item item)
        {
            _itemService.AddItem(item);
        }

        [HttpDelete("{Id}")]
        public void Delete(int Id)
        {
            _itemService.Delete(Id);
        }


        [HttpPut("{Id}")]
        public void UpdateItem(Item item, int Id)
        {
            _itemService.UpdateItem(item, Id);
        }
        [HttpGet("{Id}")]
        public Item Getitem(int Id)
        {

            return _itemService.Getitem(Id);
        }
    }
}
