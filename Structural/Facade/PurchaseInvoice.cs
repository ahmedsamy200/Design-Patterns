﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class PurchaseInvoice
    {
        public double discount = 0;
        public double totalAmount = 0;
        public double netTotal = 0;
        public PurchaseInvoice CreateInvoce(ShoppingBasket basket,
                                            string customerInfo)
        {
            var invoice = new PurchaseInvoice();
            var items = basket.GetItems();
            foreach (BasketItem item in items)
            {
                invoice.totalAmount += item.Price * item.Quantity;
            }

            // applay discount 
            if (items.Count > 5) invoice.discount = 20;

            invoice.netTotal = invoice.totalAmount - invoice.discount;
            return invoice;
        }
    }
}
