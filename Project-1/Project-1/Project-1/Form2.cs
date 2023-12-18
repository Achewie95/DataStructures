using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form2 : Form
    {
        private SortedSet<Task> tasks;
        private SortedSet<Employee> employees;
        Form1 form1;
        public Form2(SortedSet<Task> tasks, SortedSet<Employee> employees, Form1 form1)
        {
            InitializeComponent();
            this.tasks = tasks;
            this.employees = employees;
            this.form1 = form1;
        }

        public Form2(Form1 form1)
        { this.form1 = form1; }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear previous results and set status to default
            lbl_Status_f2.Text = "Status: ";

            // Validate input fields
            if (string.IsNullOrWhiteSpace(txt_EmployeIDf2.Text) || string.IsNullOrWhiteSpace(txt_TaskNamef2.Text))
            {
                lbl_Status_f2.Text = "Status: Error. Please enter all fields.";
                return;
            }

            // Parse employee ID
            if (!int.TryParse(txt_EmployeIDf2.Text, out int employeeID))
            {
                lbl_Status_f2.Text = "Status: Error. Invalid employee ID.";
                return;
            }

            // Trim and validate task name input
            string taskName = txt_TaskNamef2.Text.Trim();
            if (string.IsNullOrWhiteSpace(taskName))
            {
                lbl_Status_f2.Text = "Status: Error. Please enter a task name.";
                return;
            }

            // Find employee and task based on input
            Employee employee = employees.FirstOrDefault(emp => emp.EmployeeID == employeeID);
            Task task = tasks.FirstOrDefault(tsk => tsk.TaskName == taskName);

            // Assign task to employee and update status message
            if (employee != null && task != null)
            {
                employee.tasks.Add(task);
                lbl_Status_f2.Text = "Status: Task assigned";
                txt_EmployeIDf2.Clear();
                txt_TaskNamef2.Clear();
            }
            else
            {
                lbl_Status_f2.Text = "Status: Error. Please try again";
            }
        }

        private void btn_form_1_2_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            // Clear previous results and set status to default
            lbx_f2.Items.Clear();
            lbl_Status_f2.Text = "Status: ";

            // Validate task name input
            if (string.IsNullOrWhiteSpace(txt_TaskNamef2.Text))
            {
                lbl_Status_f2.Text = "Status: Please enter a task name";
                return;
            }
            string taskName = txt_TaskNamef2.Text;

            // Check if any employees are assigned to the task
            bool taskFound = false;
            foreach (Employee employee in employees)
            {
                foreach (Task task in employee.tasks)
                {
                    if (task.TaskName == taskName)
                    {
                        // Display employee details and mark task as found
                        lbx_f2.Items.Add("ID: " + employee.EmployeeID);
                        lbx_f2.Items.Add("First Name: " + employee.FirstName);
                        lbx_f2.Items.Add("Last Name: " + employee.LastName);
                        lbx_f2.Items.Add("Department: " + employee.Department);
                        lbx_f2.Items.Add("Age: " + employee.Age);
                        lbx_f2.Items.Add("");
                        taskFound = true;
                        break; // Move on to the next employee
                    }
                }
                if (taskFound)
                {
                    break; // Stop searching once task is found
                }
            }

            // Update status message based on whether task was found
            if (taskFound)
            {
                lbl_Status_f2.Text = "Status: Employees assigned to the task displayed";
            }
            else
            {
                lbl_Status_f2.Text = "Status: Task not found";
            }
        }

        private void btn_unassigntask_Click(object sender, EventArgs e)
        {
            lbl_Status_f2.Text = "Status: ";
            // Validate employee ID input
            if (!int.TryParse(txt_EmployeIDf2.Text, out int employeeID))
            {
                lbl_Status_f2.Text = "Status: Error. Invalid employee ID.";
                return;
            }

            // Validate task name input
            string taskName = txt_TaskNamef2.Text.Trim();
            if (string.IsNullOrWhiteSpace(taskName))
            {
                lbl_Status_f2.Text = "Status: Error. Please enter a task name.";
                return;
            }

            // Find employee and task
            Employee employee = employees.FirstOrDefault(emp => emp.EmployeeID == employeeID);
            if (employee == null)
            {
                lbl_Status_f2.Text = "Status: Error. Employee not found.";
                return;
            }

            Task task = employee.tasks.FirstOrDefault(tsk => tsk.TaskName == taskName);
            if (task == null)
            {
                lbl_Status_f2.Text = "Status: Error. Task not assigned to employee.";
                return;
            }

            // Unassign task and update status
            employee.tasks.Remove(task);
            lbl_Status_f2.Text = "Status: Task unassigned";
            txt_EmployeIDf2.Clear();
            txt_TaskNamef2.Clear();
        }
    }
}
