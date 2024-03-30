using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class SMSServiceProxy
    {
        private SMSService _smsService;
        Dictionary<string, int> sent = new Dictionary<string, int>();

        public void SendSMS(string custID , string moblie , string massage)
        {
            if (_smsService == null) _smsService = new SMSService();

            if(!sent.ContainsKey(custID))
            {
                sent.Add(custID, 1);
                _smsService.SendSMS(custID, moblie, massage);
            }
            else
            {
                var customer = sent.Where(x => x.Key == custID).FirstOrDefault();
                if (customer.Value >= 3) return;
                else
                {
                    sent[custID] = customer.Value + 1;
                    _smsService.SendSMS(custID, moblie, massage);
                }
            }
        }
    }
}
