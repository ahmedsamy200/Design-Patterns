using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class EmailDecorator : AbstructDecorator
    {
        public void SendNotification(string custID , string sms)
        {
            Console.WriteLine($"Notification sent to { custID }");
        }

        public override void SendSMS(string custID, string mobile, string sms)
        {
            base.SendSMS(custID, mobile, sms);
            SendNotification(custID, sms);
        }

    }
}
