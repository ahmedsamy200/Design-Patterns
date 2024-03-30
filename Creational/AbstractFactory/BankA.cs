using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class BankA : IBank
    {
        public void Withdraw()
        {
            Console.WriteLine("Request handeled by bank A");
        }
    }
}
