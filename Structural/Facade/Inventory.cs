﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Inventory
    {
        public bool CheckItemQuantity(string itemID , double quantity)
        {
            return quantity < 100;
        }
    }
}
