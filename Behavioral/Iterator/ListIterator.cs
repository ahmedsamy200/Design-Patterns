using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class ListIterator : Iterator
    {
        private BrowserHistory history;
        private int index;

        public ListIterator(BrowserHistory history)
        {
            this.history = history;
        }

        public string Current()
        {
            return history.GetUrls()[index];
        }

        public bool HasNext()
        {
            return (index < history.GetUrls().Count());
        }

        public void Next()
        {
            index++;
        }
    }
}
