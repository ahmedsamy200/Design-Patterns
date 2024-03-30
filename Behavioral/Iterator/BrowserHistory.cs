using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class BrowserHistory
    {
        List<string> urls = new List<string>();

        public void Push(string url)
        {
            urls.Add(url);
        }

        public string Pop()
        {
            var result = urls.Last();
            urls.Remove(result);
            return result;
        }

        public Iterator CreateIterator()
        {
            return new ListIterator(this);
        }

        public List<string> GetUrls()
        {
            return urls;
        }
    }
}
