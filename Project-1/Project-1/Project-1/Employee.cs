using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public class Employee : IComparable<Employee>
    {
        //Constructor

        public Employee() 
        {
            this.tasks = new List<Task>();
        }

        public Employee(int EmpID, string FName, string Lname, string Dept, int Age) 
        {
            this.EmployeeID = EmpID;
            this.FirstName= FName;
            this.LastName= Lname;
            this.Department= Dept;
            this.Age= Age;
            this.tasks = new List<Task>();
        }

        //Properties with Getters and Setters
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public Manager manager { get; set; }
        public List<Task> tasks { get; set; }


        public int CompareTo(Employee other)
        {
            return this.EmployeeID.CompareTo(other.EmployeeID);
        }


        public bool Equals(Employee other)
        {
            if (other == null)
            {
                return false;
            }
            return this.FirstName == other.FirstName && this.LastName == other.LastName;
        }

        //ToString method for testing purposes
        public override string ToString()
        {
            return $"{EmployeeID}::{FirstName}::{LastName}::{Department}::{Age}"; 
        }
    }
}
