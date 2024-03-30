﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class BankB : IBank
    {
        public void Withdraw()
        {
            Console.WriteLine("Request handeled by bank B");
        }
    }
}