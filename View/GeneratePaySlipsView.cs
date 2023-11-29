using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeSalaryMgr.Service;

namespace EmployeeSalaryMgr.View
{
    public partial class GeneratePaySlipsView : Form
    {
        public GeneratePaySlipsView()
        {
            InitializeComponent();
            this.Load += GeneratePaySlipsView_Load;
        }

        public void GeneratePaySlipsView_Load(object? sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            fromDatetimePicker.Value = new DateTime(fromDatetimePicker.Value.Year, fromDatetimePicker.Value.Month, 1);
            toDatetimePicker.Value = new DateTime(fromDatetimePicker.Value.Year, fromDatetimePicker.Value.Month, 30);
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            new AddRemainPaymentDetailService().addPaymentDetail(fromDatetimePicker.Value, toDatetimePicker.Value);

            new GeneratePaySlipsService().generateToPdf(fromDatetimePicker.Value, toDatetimePicker.Value);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
