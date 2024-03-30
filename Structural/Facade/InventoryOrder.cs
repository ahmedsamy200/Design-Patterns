using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class InventoryOrder
    {
        public string CreateOrder(ShoppingBasket basket , string brunchID)
        {
            basket.GetItems();
            return $"Order Number is {Guid.NewGuid().ToString()}";
        }
    }
}
