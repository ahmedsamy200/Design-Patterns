using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class ItemsDiscountCalc : IDiscountCalaculator
    {

        public double GetDiscountValue(DateTime currentDate, string itemId)
        {
            // call database to calc item discount
            return 0.10;
        }
    }
}
