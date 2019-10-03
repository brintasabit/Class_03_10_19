using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop3LayerArchitecture.Repository;
using CoffeeShop3LayerArchitecture.Model;
namespace CoffeeShop3LayerArchitecture.Bill
{
    class ItemManager
    {
        ItemRepository _itemRepository=new ItemRepository();
        public List<Item> ShowItem()
        {
            return _itemRepository.ShowItem();
        }
        public List<Item> SearchItem(Item _item)
        {
            return _itemRepository.SearchItem(_item);
        }
        public bool AddItem(Item _item)
        {
            return _itemRepository.AddItem(_item);
        }
        public bool UpdateItem(Item _item)
        {
            return _itemRepository.UpdateItem(_item);
        }
        public bool DeleteItem(Item _item)
        {
            return _itemRepository.DeleteItem(_item);
        }
    }
}
