using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public interface IDiscountCalaculator
    {
        double GetDiscountValue(DateTime currentDate, string itemId = null);
    }
}
