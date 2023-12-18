using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public class Task : IComparable<Task>
    {

        // Constructor

        public Task() 
        { 
        }

        public Task(string taskName, string description, string department, string startDate, string deadline)
        {
            TaskName = taskName;
            Description = description;
            Department = department;
            StartDate = startDate;
            Deadline = deadline;
         
        }

        //Properties with Getters and Setters
        public string TaskName { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
        public string StartDate { get; set; }
        public string Deadline { get; set; }
        public Employee AssignedTo { get; set; }

        public int CompareTo(Task other)
        {
            return this.TaskName.CompareTo(other.TaskName);
        }

    }

}
