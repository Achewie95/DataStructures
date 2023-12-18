using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Project_1
{
    public partial class Form3 : Form
    {
        private SortedSet<Manager> managers;
        private SortedSet<Employee> employees;
        Form1 form1;

        public Form3(SortedSet<Manager> managers, SortedSet<Employee> employees, Form1 form1)
        {
            InitializeComponent();
            this.managers = managers;
            this.employees = employees;
            this.form1 = form1;
            
            
        }

        public Form3(Form1 form1)
        {
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_Status.Text = "Status: ";

            // Check if the employee ID or manager ID fields are empty or whitespace
            if (string.IsNullOrWhiteSpace(txt_EmployeeID.Text) || string.IsNullOrWhiteSpace(txt_ManagerID.Text))
            {
                lbl_Status.Text = "Status: Error. Please enter all fields."; // If so, set the status text to an error message and return
                return;
            }

            // Parse the employee ID input to an integer, if it is not a valid integer, set the status text to an error message and return
            if (!int.TryParse(txt_EmployeeID.Text, out int employeeID))
            {
                lbl_Status.Text = "Status: Error. Invalid employee ID.";
                return;
            }

            // Parse the manager ID input to an integer, if it is not a valid integer, set the status text to an error message and return
            if (!int.TryParse(txt_ManagerID.Text, out int managerID))
            {
                lbl_Status.Text = "Status: Error. Invalid manager ID.";
                return;
            }

            // Get the employee and manager objects based on their IDs
            Employee employee = employees.FirstOrDefault(emp => emp.EmployeeID == employeeID);
            Manager manager = managers.FirstOrDefault(mgr => mgr.EmployeeID == managerID);

            // Check if both employee and manager objects are found
            if (employee != null && manager != null)
            {
                // Remove the employee from the list of employees
                employees.Remove(employee);
                // Set the employee's manager to the new manager
                employee.manager = manager;
                // Add the employee back to the list of employees
                employees.Add(employee);
                lbl_Status.Text = "Status: Employee assigned";
                txt_EmployeeID.Clear();
                txt_ManagerID.Clear();
            }
            else
            {
                // If either the employee or manager objects are not found, set the status text to an error message
                lbl_Status.Text = "Status: Error. Please try again";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the status label text
            lbl_Status.Text = "Status: ";

            // Try to parse the entered employee ID into an integer
            if (!int.TryParse(txt_EmployeeID.Text, out int employeeID))
            {
                lbl_Status.Text = "Status: Error. Please enter a valid employee ID.";
                return;
            }

            // Find the employee with the specified ID
            Employee employee = employees.FirstOrDefault(emp => emp.EmployeeID == employeeID);

            if (employee != null)
            {
                // Remove the employee from the list of employees
                employees.Remove(employee);

                // Set the employee's manager to null
                employee.manager = null;

                // Add the updated employee back to the list of employees
                employees.Add(employee);
                lbl_Status.Text = "Status: Employee removed";
                txt_EmployeeID.Clear();
                txt_ManagerID.Clear();
            }
            else
            {
                // Display an error message if the specified employee was not found
                lbl_Status.Text = "Status: Error. Please try again";
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            lbx_display.Items.Clear();
            lbl_Status.Text = "Status: ";
            // Try to parse the manager ID input from the textbox
            if (!int.TryParse(txt_ManagerID.Text, out int managerID))
            {
                lbl_Status.Text = "Status: Error. Invalid manager ID.";
                return;
            }

            // Find the manager with the specified ID
            Manager manager = managers.FirstOrDefault(mgr => mgr.EmployeeID == managerID);

            // If no manager was found, display an error message and return
            if (manager == null)
            {
                lbl_Status.Text = "Status: Error. Manager not found.";
                return;
            }

            // Loop through all employees
            foreach (Employee employee in employees)
            {
                // If the employee's manager matches the specified manager, display the employee's information in the ListBox
                if (employee.manager == manager)
                {
                    lbx_display.Items.Add("ID: " + employee.EmployeeID);
                    lbx_display.Items.Add("First Name: " + employee.FirstName);
                    lbx_display.Items.Add("Last Name: " + employee.LastName);
                    lbx_display.Items.Add("Department: " + employee.Department);
                    lbx_display.Items.Add("Age: " + employee.Age);
                    lbx_display.Items.Add("");
                }
            }
        }

        private void btn_Form1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }
    }
}
