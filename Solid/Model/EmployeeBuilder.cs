using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Model
{
    public class EmployeeBuilder
    {
        private Employee employee;

        public EmployeeBuilder(string name)
        {
            employee = new Employee(name);
        }

        public EmployeeBuilder SetSalary(double salary)
        {
            employee.Salary = salary;
            return this;
        }

        public Employee Build()
        {
            return employee;
        }



    }
}
