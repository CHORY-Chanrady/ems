using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeSalaryMgr.Model;
using EmployeeSalaryMgr.Service;

namespace EmployeeSalaryMgr.View
{
    public partial class AddEmployeeView : Form
    {
        private EmployeeView employeeView;
        public AddEmployeeView(EmployeeView employeeView)
        {
            InitializeComponent();
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
            this.employeeView = employeeView;

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                FirstName = firstNameTxtBox.Text,
                LastName = lastNameTxtBox.Text,
                Gender = (Gender)genderComboBox.SelectedItem,
                Email = emailTxtBox.Text,
                Position = positionTxtBox.Text,
                Salary = double.Parse(salaryTxtBox.Text),
            };
            new EmployeeService().Add(employee);
            firstNameTxtBox.Clear();
            lastNameTxtBox.Clear();
            emailTxtBox.Clear();
            salaryTxtBox.Clear();
            positionTxtBox.Clear();
            employeeView.OnAddEmployee();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
