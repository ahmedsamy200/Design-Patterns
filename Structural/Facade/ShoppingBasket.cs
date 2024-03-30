using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class ShoppingBasket
    {
        private List<BasketItem> _items = new List<BasketItem>();

        public void AddItem(BasketItem item)
        {
            _items.Add(item);
        }

        public void RemoveOneItem(string itemID)
        {
            var item = _items.Where(x => x.ItemID == itemID).FirstOrDefault();
            if (item.Quantity > 0) item.Quantity = item.Quantity - 1;
        }

        public List<BasketItem> GetItems() => _items;
    }
}
