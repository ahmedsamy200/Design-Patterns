using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class RegularEmployee : Employee
    {
        
        public override Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }

        public override Employee DeepCopy()
        {
            
            RegularEmployee employee = new RegularEmployee();
            employee = (RegularEmployee)this.MemberwiseClone();
            employee.EmpAddress = new Address
            {
                City = EmpAddress.City,
                Building = EmpAddress.Building,
                StreetName = EmpAddress.StreetName
            };
            employee.Name = this.Name;
            return employee;
        }
    }
}
