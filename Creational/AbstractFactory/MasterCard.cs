﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class MasterCard : IPaymentCard
    {
        public string GetName()
        {
            return "Master Card";
        }
    }
}
