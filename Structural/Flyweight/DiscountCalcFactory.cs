using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class DiscountCalcFactory
    {
        Dictionary<string, IDiscountCalaculator> calcLst = new Dictionary<string, IDiscountCalaculator>();

        public IDiscountCalaculator GetDiscountCalc(string calcType)
        {
            IDiscountCalaculator calaculator = null;

            if (calcLst.ContainsKey(calcType))
            {
                return calcLst[calcType];
            }
            else
            {
                switch (calcType)
                {
                    case "day":
                        calaculator = new DayDiscountCalc();
                        calcLst.Add("day", calaculator);
                        break;
                    case "item":
                        calaculator = new ItemsDiscountCalc();
                        calcLst.Add("item", calaculator);
                        break;
                }
                return calaculator;
            }

        }
    }
}
