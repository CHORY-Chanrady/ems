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
using EmployeeSalaryMgr.View;
using Microsoft.VisualBasic;

namespace EmployeeSalaryMgr
{
    public partial class EmployeeView : Form
    {
        public EmployeeView()
        {
            InitializeComponent();
            employeeDgv.SelectionChanged += onSelectDgvRow;
        }
        private DataTable employeeDataTable;
        private BindingSource employeeBidingSrc;
        private void EmployeeView_Load(object sender, EventArgs e)
        {
            employeeDataTable = new EmployeeService().GetAll();
            employeeBidingSrc = new BindingSource();
            employeeBidingSrc.DataSource = employeeDataTable;
            employeeDgv.DataSource = employeeBidingSrc;
            employeeDgv.Columns["IsDeleted"].Visible = false;
            filterComboBox.DataSource = new List<String>() {
                new string("Id"),
                new string("Name")
            };
        }

        private void employeeDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            new AddEmployeeView(this).ShowDialog();
        }

        public void OnAddEmployee()
        {
            employeeDataTable.Clear();
            employeeDataTable.Merge(new EmployeeService().GetAll());

        }

        private void deleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete Employee", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int rowIndex = employeeDgv.CurrentCell.RowIndex;
                long id = (long)employeeDgv.Rows[rowIndex].Cells[0].Value;
                new EmployeeService().DeleteById(id);
                employeeDgv.Rows.RemoveAt(rowIndex);
            }
        }

        private void onSelectDgvRow(object? sender, EventArgs e)
        {
            if (employeeDgv.SelectedRows.Count > 0)
            {
                deleteEmployeeBtn.Enabled = true;
                editEmployeeBtn.Enabled = true;
                calculateSalaryBtn.Enabled = true;
            }
            else
            {
                deleteEmployeeBtn.Enabled = false;
                editEmployeeBtn.Enabled = false;
                calculateSalaryBtn.Enabled = false;
            }
        }

        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {
            new EditEmployeeView(this).ShowDialog();
        }

        public DataGridView GetDataGridView() => employeeDgv;

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            switch (filterComboBox.Text)
            {
                case "Id":
                    if (!string.IsNullOrEmpty(searchTxtBox.Text))
                    {
                        Employee? employee = null;
                        try
                        {
                            employee = new EmployeeSearchService().SearchById(long.Parse(searchTxtBox.Text));
                        }
                        catch (FormatException exception)
                        {
                            filterComboBox.Text = "Name";
                        }

                        if (employee != null)
                        {
                            DataRow result = employeeDataTable.NewRow();
                            result["Id"] = employee.ID;
                            result["FirstName"] = employee.FirstName;
                            result["LastName"] = employee.LastName;
                            result["Gender"] = employee.Gender.ToString();
                            result["Email"] = employee.Email;
                            result["Position"] = employee.Position;
                            result["Salary"] = employee.Salary;

                            employeeDataTable.Rows.Clear();
                            employeeDataTable.Rows.Add(result);
                        }
                        else employeeDataTable.Rows.Clear();
                    }
                    else
                    {
                        employeeDataTable.Rows.Clear();
                        employeeDataTable.Merge(new EmployeeService().GetAll());
                    }
                    break;
                case "Name":
                    if (!string.IsNullOrEmpty(searchTxtBox.Text))
                    {
                        DataTable? result = new EmployeeSearchService().SearchByName(searchTxtBox.Text);
                        employeeDataTable.Clear();
                        employeeDataTable.Merge(result);
                    }
                    else
                    {
                        employeeDataTable.Clear();
                        employeeDataTable.Merge(new EmployeeService().GetAll());
                    }
                    break;
            }
        }

        private void calculateSalaryBtn_Click(object sender, EventArgs e)
        {
            new CalculateSalaryView(this).ShowDialog();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            new GeneratePaySlipsView().ShowDialog();
        }
    }
}
