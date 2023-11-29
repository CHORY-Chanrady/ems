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
    public partial class EditEmployeeView : Form
    {
        private EmployeeView employeeView;
        private DataGridView employeeDgv;
        private int rowIndex;
        public EditEmployeeView(EmployeeView employeeView)
        {
            InitializeComponent();
            this.employeeView = employeeView;
            employeeDgv = employeeView.GetDataGridView();
            rowIndex = employeeDgv.CurrentCell.RowIndex;
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));

            this.Load += EditEmployeeView_Load;
        }



        public void EditEmployeeView_Load(object? sender, EventArgs e)
        {

            firstNameTxtBox.Text = employeeDgv.Rows[rowIndex].Cells[1].Value as string;
            lastNameTxtBox.Text = employeeDgv.Rows[rowIndex].Cells[2].Value as string;
            genderComboBox.Text = employeeDgv.Rows[rowIndex].Cells[3].Value as string;
            emailTxtBox.Text = employeeDgv.Rows[rowIndex].Cells[4].Value as string;
            positionTxtBox.Text = employeeDgv.Rows[rowIndex].Cells[5].Value as string;
            salaryTxtBox.Text = employeeDgv.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void editOkBtn_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                ID = (long)employeeDgv.Rows[rowIndex].Cells[0].Value,
                FirstName = firstNameTxtBox.Text,
                LastName = lastNameTxtBox.Text,
                Gender = (Gender)genderComboBox.SelectedIndex,
                Email = emailTxtBox.Text,
                Position = positionTxtBox.Text,
                Salary = double.Parse(salaryTxtBox.Text)
            };
            new EmployeeService().Update(employee);
            employeeView.OnAddEmployee();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
