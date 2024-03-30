using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class Counter
    {
        public static int count = 0;

        private static Counter instance = null;
        private static object lockobj = new object();

        private Counter() { }

        public static Counter GetInstance()
        {
            lock(lockobj)
            {
                if (instance == null) instance = new Counter();
                return instance;
            }
           
        }
        public void AddOne() {
            count++; 
        }
    }
}
