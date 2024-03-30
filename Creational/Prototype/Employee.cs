using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address EmpAddress { get; set; }

        public abstract Employee ShallowCopy();
        public abstract Employee DeepCopy();

        public override string ToString()
        {
            return $"ID: {Id} \n" +
                $"Name: {Name} \n" +
                $"Address: {EmpAddress.City} , {EmpAddress.Building} , {EmpAddress.StreetName}";                    
        }
    }
}
