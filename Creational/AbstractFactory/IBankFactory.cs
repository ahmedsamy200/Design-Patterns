using DesignPatterns.Creational.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public interface IBankFactory
    {
        IBank GetBank(string cardNumber);

        IPaymentCard GetPaymentCard(string cardNumber);
    }
}
