using DesignPatterns.Structural.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural
{
    public abstract class AbstructDecorator:ISMSService
    {
        protected ISMSService notificationService;

        public void SetService(ISMSService service)
        {
            notificationService = service;
        }

        public virtual void SendSMS(string custID, string mobile, string sms)
        {
           if(notificationService != null)
            {
                notificationService.SendSMS(custID, mobile, sms);
            }
            else
            {
                Console.WriteLine("Service not intialized");
            }
        }
    }
}
