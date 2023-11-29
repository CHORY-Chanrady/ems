using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaryMgr.Model;

namespace EmployeeSalaryMgr.Persistence
{
    public class AddRemainPaymentDetail
    {
        public void addPaymentDetail(DateTime from, DateTime to)
        {
            SqlConnection conn = new DBConnection().SqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO payment_info_tb SELECT emp.id, @date, 0,0,0,emp.salary FROM employee_tb emp where emp.id not in (select EmployeeId from payment_info_tb where GenerateOn between @from and @to) and emp.IsDeleted=0",
                                            conn);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@from", from);
            cmd.Parameters.AddWithValue("to", to);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
