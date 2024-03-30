using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class SMSService : ISMSService
    {
        public void SendSMS(string custID, string mobile, string sms)
        {
            Console.WriteLine($"Massage sent to {mobile}");
        }
    }
}
