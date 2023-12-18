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
    public partial class Form1 : Form
    {
        SortedSet<Employee> employees;
        SortedSet<Manager> managers;
        SortedSet<Task> tasks;
        Form2 form2;
        Form3 form3;
        Form4 form4;
        

        public Form1()
        {
            InitializeComponent();
            employees = new SortedSet<Employee>();
            managers = new SortedSet<Manager>();
            tasks = new SortedSet<Task>();
            form2 = new Form2(tasks, employees, this);
            form3 = new Form3(managers, employees, this);
            form4 = new Form4(employees,this);
        }

        private void txt_EmployeeID_ss_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_EmpAdd_ss_Click(object sender, EventArgs e)
        {
            lbl_EmpError.Text = "Status:";
            if (txt_EmployeeID_ss.Text != "" && txt_EmpFName_ss.Text != "" && txt_EmpLName_ss.Text != "" && txt_EmpDept_ss.Text != "" && txt_EmpAge_ss.Text != "")
            {

                int age, id;


                if (!Int32.TryParse(txt_EmployeeID_ss.Text, out id))
                {
                    lbl_EmpError.Text += "Error. Please enter a valid ID.";
                }
                else if (!Int32.TryParse(txt_EmpAge_ss.Text, out age))
                {
                    lbl_EmpError.Text += "Error. Please enter a valid Age.";
                }
                else if ((age < 18))
                {
                    lbl_EmpError.Text += "Error. Illegal age. ";
                }
                else
                {
                    Employee employee = new Employee(Int32.Parse(txt_EmployeeID_ss.Text), txt_EmpFName_ss.Text, txt_EmpLName_ss.Text, txt_EmpDept_ss.Text, Int32.Parse(txt_EmpAge_ss.Text));
                    if (!employees.Contains(employee))
                    {

                        employees.Add(employee);
                        txt_EmployeeID_ss.Clear();
                        txt_EmpFName_ss.Clear();
                        txt_EmpLName_ss.Clear();
                        txt_EmpDept_ss.Clear();
                        txt_EmpAge_ss.Clear();
                        lbl_EmpError.Text = "Status: Employee Created";
                    }
                    else
                    {
                        lbl_EmpError.Text = "Status: Employee ID already exist.";
                    }
                }

            }
            else
            {
                lbl_EmpError.Text = "Status: Textfields not complete.";
            }
        }

        private void btn_EmpDisplay_ss_Click(object sender, EventArgs e)
        {
            lbl_EmpError.Text = "Status:";
            lbx_emp.Items.Clear();
            if (employees.Count > 0)
            {
                foreach (Employee emp in employees)
                {
                    lbx_emp.Items.Add("ID: " + emp.EmployeeID);
                    lbx_emp.Items.Add("First Name: " + emp.FirstName);
                    lbx_emp.Items.Add("Last Name: " + emp.LastName);
                    lbx_emp.Items.Add("Department: " + emp.Department);
                    lbx_emp.Items.Add("Age: " + emp.Age);
                    lbx_emp.Items.Add("");
                }
            }
            else
            {
                lbl_EmpError.Text = "Status: No Employees to show.";
            }

        }

        private void btn_EmpRemove_ss_Click(object sender, EventArgs e)
        {
            lbl_EmpError.Text = "Status:";
            if (txt_EmployeeID_ss.Text != "" && txt_EmpFName_ss.Text != "" && txt_EmpLName_ss.Text != "" && txt_EmpDept_ss.Text != "" && txt_EmpAge_ss.Text != "")
            {
                Employee employee = new Employee(Int32.Parse(txt_EmployeeID_ss.Text), txt_EmpFName_ss.Text, txt_EmpLName_ss.Text, txt_EmpDept_ss.Text, Int32.Parse(txt_EmpAge_ss.Text));
                if (employees.Contains(employee))
                {
                    employees.Remove(employee);
                    txt_EmployeeID_ss.Clear();
                    txt_EmpFName_ss.Clear();
                    txt_EmpLName_ss.Clear();
                    txt_EmpDept_ss.Clear();
                    txt_EmpAge_ss.Clear();
                    lbl_EmpError.Text = "Status: Employee Removed";

                }
                else
                {
                    lbl_EmpError.Text = "Status: Employee not found";
                }
            }
            else
            {
                lbl_EmpError.Text = "Status: Textfields not complete.";
            }
        }

        private void btn_EmpClear_ss_Click(object sender, EventArgs e)
        {
            lbl_EmpError.Text = "Status:";
            if (employees.Count > 0)
            {
                employees.Clear();
                lbl_EmpError.Text = "Status: All employees cleared";
                lbx_emp.Items.Clear();
            }
            else
            {
                lbl_EmpError.Text = "Status: No data to clear";
            }
        }

        private void btn_TaskAdd_ss_Click(object sender, EventArgs e)
        {
            lbl_TaskError.Text = "Status: ";
            if (txt_TaskName_ss.Text != "" && txt_Desc_ss.Text != "" && txt_TaskDept_ss.Text != "")
            {
                Task task = new Task(txt_TaskName_ss.Text, txt_Desc_ss.Text, txt_TaskDept_ss.Text, txt_TaskStartDate_ss.Text, txt_TaskDeadline_ss.Text);
                if (!tasks.Contains(task))
                {
                    tasks.Add(task);
                    txt_TaskName_ss.Clear();
                    txt_TaskDept_ss.Clear();
                    txt_Desc_ss.Clear();
                    txt_TaskStartDate_ss.Clear();
                    txt_TaskDeadline_ss.Clear();
                    lbl_TaskError.Text = "Status: Task Added";

                }
                else
                {
                    lbl_TaskError.Text = "Status: Task Name already present";
                }
                    
                
            }
            else
            {
                lbl_TaskError.Text = "Status: Textfields not complete.";
            }
        }

        private void btn_TaskRemove_ss_Click(object sender, EventArgs e)
        {
            lbl_TaskError.Text = "Status: ";
            if (txt_TaskName_ss.Text != "" && txt_ManFname_ss.Text != "" && txt_TaskDept_ss.Text != "")
            {
                Task task = new Task(txt_TaskName_ss.Text, txt_ManFname_ss.Text, txt_TaskDept_ss.Text, txt_TaskStartDate_ss.Text, txt_TaskDeadline_ss.Text);
                if (tasks.Contains(task))
                {
                    tasks.Remove(task);
                    txt_TaskName_ss.Clear();
                    txt_TaskDept_ss.Clear();
                    txt_ManFname_ss.Clear();
                    txt_TaskStartDate_ss.Clear();
                    txt_TaskDeadline_ss.Clear();
                    lbl_TaskError.Text = "Status: Task Deleted";
                }
                else
                {
                    lbl_TaskError.Text = "Status: Task not found";
                }
            }
            else
            {
                lbl_TaskError.Text = "Status: Textfields not complete";
            }
        }

        private void btn_TaskClear_ss_Click(object sender, EventArgs e)
        {
            lbl_TaskError.Text = "Status: ";
            if(tasks.Count > 0)
            {
                tasks.Clear();
                lbl_TaskError.Text = "Status: All Tasks cleared";
                lbx_Task_ss.Items.Clear();
            }
            else
            {
                lbl_TaskError.Text = "Status: No data to clear";
            }
        }

        private void btn_TaskDisplay_ss_Click_1(object sender, EventArgs e)
        {
            lbl_TaskError.Text = "Status: ";
            lbx_Task_ss.Items.Clear();
            if (tasks.Count > 0)
            {
                foreach(Task t in tasks)
                {
                    lbx_Task_ss.Items.Add("Task Name: " + t.TaskName);
                    lbx_Task_ss.Items.Add("Task Desc: " + t.Description);
                    lbx_Task_ss.Items.Add("Task Dept: " + t.Department);
                    lbx_Task_ss.Items.Add("Start Date: " + t.StartDate);
                    lbx_Task_ss.Items.Add("Dateline: " + t.Deadline);
                    lbx_Task_ss.Items.Add("");
                }   
            }
            else
            {
                lbl_TaskError.Text = "Status: No tasks to show";
            }

        }

        private void btn_form3_Click(object sender, EventArgs e)
        {
            form3.Show();
            this.Hide();
        }

        private void btn_ManAdd_ss_Click_1(object sender, EventArgs e)
        {

            lbl_manerror.Text = "Status: ";

            if (txt_ManagerID_ss.Text != "" && txt_ManLName_ss.Text != "" && txt_ManFname_ss.Text != "" && txt_ManDept_ss.Text != "" && txt_ManAge_ss.Text != "")
            {
                int id, age;

                if (!Int32.TryParse(txt_ManagerID_ss.Text, out id))
                {
                    lbl_manerror.Text += "Error. Please enter a valid ID.";
                }
                else if (!Int32.TryParse(txt_ManAge_ss.Text, out age))
                {
                    lbl_manerror.Text += "Error. Please enter a valid Age.";
                }
                else if ((age < 18))
                {
                    lbl_manerror.Text += "Error. Illegal age. ";
                }
                else
                {
                    Manager manager = new Manager(Int32.Parse(txt_ManagerID_ss.Text), txt_ManFname_ss.Text, txt_ManLName_ss.Text, txt_ManDept_ss.Text, Int32.Parse(txt_ManAge_ss.Text));
                    if (!employees.Contains(manager))
                    {

                        managers.Add(manager);
                        txt_ManagerID_ss.Clear();
                        txt_ManFname_ss.Clear();
                        txt_ManLName_ss.Clear();
                        txt_ManDept_ss.Clear();
                        txt_ManAge_ss.Clear();
                        lbl_manerror.Text = "Status: Manager Created";
                    }
                    else
                    {
                        lbl_manerror.Text = "Status: Manager ID already exist.";
                    }
                }

            }
            else
            {
                lbl_manerror.Text = "Status: Textfields not complete.";
            }
        }

        private void btn_ManRemove_ss_Click_1(object sender, EventArgs e)
        {
            lbl_manerror.Text = "Status:";
            if (txt_ManagerID_ss.Text != "" && txt_ManFname_ss.Text != "" && txt_ManLName_ss.Text != "" && txt_ManDept_ss.Text != "" && txt_ManAge_ss.Text != "")
            {
                Manager manager = new Manager(Int32.Parse(txt_ManagerID_ss.Text), txt_ManFname_ss.Text, txt_ManLName_ss.Text, txt_ManDept_ss.Text, Int32.Parse(txt_ManAge_ss.Text));
                if (managers.Contains(manager))
                {
                    managers.Remove(manager);
                    txt_ManagerID_ss.Clear();
                    txt_ManFname_ss.Clear();
                    txt_ManLName_ss.Clear();
                    txt_ManDept_ss.Clear();
                    txt_ManAge_ss.Clear();
                    lbl_manerror.Text = "Status: Manager deleted";

                }
                else
                {
                    lbl_manerror.Text = "Status: Manager not found";
                }
            }
            else
            {
                lbl_manerror.Text = "Status: Textfields not complete.";
            }
        }

        private void btn_ManClear_ss_Click_1(object sender, EventArgs e)
        {
            lbl_manerror.Text = "Status:";
            if (managers.Count > 0)
            {
                managers.Clear();
                lbl_manerror.Text = "Status: All managers cleared";
                lbx_man.Items.Clear();
            }
            else
            {
                lbl_manerror.Text = "Status: No data to clear";
            }
        }

        private void btn_ManDisplay_ss_Click_1(object sender, EventArgs e)
        {
            lbl_manerror.Text = "Status:";
            lbx_man.Items.Clear();
            if (managers.Count > 0)
            {
                foreach (Manager man in managers)
                {
                    lbx_man.Items.Add("ID: " + man.EmployeeID);
                    lbx_man.Items.Add("First Name: " + man.FirstName);
                    lbx_man.Items.Add("Last Name: " + man.LastName);
                    lbx_man.Items.Add("Department: " + man.Department);
                    lbx_man.Items.Add("Age: " + man.Age);
                    lbx_man.Items.Add("");
                }
            }
            else
            {
                lbl_manerror.Text = "Status: No Employees to show.";
            }
        }

        private void btn_form2_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void btn_Form4_Click(object sender, EventArgs e)
        {
            form4.Show();
            this.Hide();
        }
    }
}