using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public class Manager : Employee
    {
        public Manager(int managerId, string firstName, string lastName, string department, int age) :
        base(managerId, firstName, lastName, department, age)
        {
            this.Employees = new List<Employee>();
        }
        public List<Employee> Employees { get; set; }
    }
}
