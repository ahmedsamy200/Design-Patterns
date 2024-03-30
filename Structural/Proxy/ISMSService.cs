using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public interface ISMSService
    {
        void SendSMS(string custID, string mobile, string sms);
    }
}
