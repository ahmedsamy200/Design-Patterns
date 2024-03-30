using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class BankFactory : IBankFactory
    {
        public IBank GetBank(string cardNumber)
        {
            string bankCode = cardNumber.Substring(0, 6);
            switch(bankCode)
            {
                case "123456": return new BankA();
                case "111111": return new BankB();
            }
            return null;
        }
    }
}
