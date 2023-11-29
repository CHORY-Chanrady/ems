using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryMgr.Persistence
{
    internal class DBConnection
    {
        private string? server = ConfigurationManager.AppSettings["Server"];
        private string? database = ConfigurationManager.AppSettings["Database"];
        private string? userId = ConfigurationManager.AppSettings["User ID"];
        private string? password = ConfigurationManager.AppSettings["Password"];
        private string? connectionString;
        public SqlConnection SqlConnect()
        {
            if(userId == string.Empty && password == string.Empty)
            {
                connectionString = $"Server={server};Database={database};Integrated Security=true";
            }
            else
            {
                connectionString = $"Server={server};Database={database};User ID={userId};Password={password}";
            }
            return new SqlConnection(connectionString);
        }
    }
}
