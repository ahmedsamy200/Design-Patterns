using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerServices CustomerServices;

        public AddCustomerCommand(CustomerServices customerServices)
        {
            CustomerServices = customerServices;
        }

        public void Execute()
        {
            CustomerServices.AddCustomer();
        }
    }
}
