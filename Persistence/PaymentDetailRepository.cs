using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaryMgr.Model;

namespace EmployeeSalaryMgr.Persistence
{
    public class PaymentDetailRepository : IPaymentDetailRepository
    {
        public void addPaymentDetail(PaymentDetail paymentDetail)
        {
            SqlConnection conn = new DBConnection().SqlConnect();
            conn.Open();
            String cmdString = "INSERT INTO payment_info_tb (EmployeeId, GenerateOn, OT, Bonus, Deduction, Total) VALUES (@empId, @generateOn, @ot, @bonus, @deduction, @total)";
            SqlCommand cmd = new SqlCommand(cmdString, conn);
            cmd.Parameters.AddWithValue("@empId", paymentDetail.Employee.ID);
            cmd.Parameters.AddWithValue("@generateOn", paymentDetail.Date);
            cmd.Parameters.AddWithValue("@ot", paymentDetail.Ot);
            cmd.Parameters.AddWithValue("@bonus", paymentDetail.Bonus);
            cmd.Parameters.AddWithValue("@deduction", paymentDetail.Deduction);
            cmd.Parameters.AddWithValue("@total", paymentDetail.Total);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable getAllPaymentDetail(DateTime from, DateTime to)
        {
            SqlConnection conn = new DBConnection().SqlConnect();
            conn.Open();
            DataTable paymentDeatil = new DataTable();
            SqlCommand cmd = new SqlCommand("select emp.*, pay.* from employee_tb emp inner join payment_info_tb pay on emp.id = pay.EmployeeId where pay.GenerateOn between @from and @to", conn);
            cmd.Parameters.AddWithValue("@from", from);
            cmd.Parameters.AddWithValue ("@to", to);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(paymentDeatil);
            conn.Close();
            return paymentDeatil;
        }
    }
}
