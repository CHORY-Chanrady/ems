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
    public partial class CalculateSalaryView : Form
    {
        private EmployeeView employeeView;
        private PaymentDetail paymentDetail;
        private Employee employee;
        public CalculateSalaryView(EmployeeView employeeView)
        {
            InitializeComponent();
            this.employeeView = employeeView;
            this.Load += CalculateSalaryView_Load;
        }


        public void CalculateSalaryView_Load(object? sender, EventArgs e)
        {
            long currentEmpId = (long)employeeView.GetDataGridView().CurrentRow.Cells["ID"].Value;
            employee = new EmployeeSearchService().SearchById(currentEmpId);
            idPlaceHolder.Text = employee.ID.ToString();
            namePlaceHolder.Text = employee.FirstName + " " + employee.LastName;
            positionPlaceHolder.Text = employee.Position;
            baseSalaryPlaceHolder.Text = employee.Salary.ToString();

            idPlaceHolder.Font = new Font(idPlaceHolder.Font, FontStyle.Bold);
            namePlaceHolder.Font = new Font(namePlaceHolder.Font, FontStyle.Bold);
            positionPlaceHolder.Font = new Font(positionPlaceHolder.Font, FontStyle.Bold);
            baseSalaryPlaceHolder.Font = new Font(baseSalaryPlaceHolder.Font, FontStyle.Bold);

            totalOtTxtBox.Text = "0";
            totalBonusTxtbox.Text = "0";
            totalDeductTxtBox.Text = "0";
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            paymentDetail = new PaymentDetail(
                employee,
                dateTimePicker.Value,
                long.Parse(totalOtTxtBox.Text),
                long.Parse(totalBonusTxtbox.Text),
                long.Parse(totalDeductTxtBox.Text)
                );
            new PaymentDetailService().add(paymentDetail);
            this.Close(); 
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
