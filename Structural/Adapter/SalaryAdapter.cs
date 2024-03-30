using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class SalaryAdapter:SalaryCalculator
    {
        private Employee _employee;

        public double CalcSalary(MachineOperator machineOperator)
        {
            _employee = new Employee();
            _employee.Salary = machineOperator.Salary;
            return base.CalcSalary(_employee);
        }
    }
}
