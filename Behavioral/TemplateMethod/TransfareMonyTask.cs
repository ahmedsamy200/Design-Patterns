using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class TransfareMonyTask : Task
    {
       

        protected override void DoExecute()
        {
            Console.WriteLine("Transfare Mony");
        }
    }
}
