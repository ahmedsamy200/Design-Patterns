using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class SalaryCalculator
    {
        public double CalcSalary(Employee employee)
        {
            return employee.Salary * 1.5;
        }
    }
}
