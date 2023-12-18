using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Project_1
{
    public partial class Form4 : Form
    {

        private SortedSet<Employee> employees;
        Form1 form1;
        public Form4(SortedSet<Employee> employees, Form1 form1)
        {
            InitializeComponent();
            this.employees = employees;
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear the ListBox and set the status label text
            lbx_display.Items.Clear();
            lbl_status.Text = "Status:";

            // Get the first and last names from the corresponding textboxes
            string fName = txt_Fname.Text.Trim();
            string lName = txt_Lname.Text.Trim();

            // If either the first or last name is empty or whitespace, show an error message
            if (string.IsNullOrWhiteSpace(fName) || string.IsNullOrWhiteSpace(lName))
            {
                lbl_status.Text = "Status: Error. Please enter both First Name and Last Name.";
                return;
            }

            // Find the employee with the matching first and last names
            Employee employee = employees.FirstOrDefault(emp => emp.FirstName == fName && emp.LastName == lName);

            // If the employee is found, display their details and assigned tasks
            if (employee != null)
            {
                lbx_display.Items.Add("Employee Details: ");
                lbx_display.Items.Add("ID: " + employee.EmployeeID);
                lbx_display.Items.Add("First Name: " + employee.FirstName);
                lbx_display.Items.Add("Last Name: " + employee.LastName);
                lbx_display.Items.Add("Department: " + employee.Department);
                lbx_display.Items.Add("Age: " + employee.Age);
                lbx_display.Items.Add("");
                lbx_display.Items.Add("Tasks Assigned: ");

                // Display each task assigned to the employee
                foreach (Task task in employee.tasks)
                {
                    lbx_display.Items.Add("- " + task.TaskName);
                }
                lbx_display.Items.Add("");

                // Display the details of the employee's manager
                lbx_display.Items.Add("Manager Details: ");
                lbx_display.Items.Add("Manager First Name: " + employee.manager.FirstName);
                lbx_display.Items.Add("Manager Last Name: " + employee.manager.LastName);

            }
            // If the employee is not found, show an error message
            else
            {
                lbl_status.Text = "Status: Employee not found";
            }
        }

        private void btn_Form4_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }
    }
}
