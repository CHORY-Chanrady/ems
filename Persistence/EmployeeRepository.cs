
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using EmployeeSalaryMgr.Model;

namespace EmployeeSalaryMgr.Persistence
{
    public class EmployeeRepository
    {
        public DataTable GetAllEmployees()
        {
            SqlConnection conn = new DBConnection().SqlConnect();
            String cmd = "SELECT * FROM employee_tb WHERE IsDeleted = 0";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }

        public void AddEmployee(Employee employee)
        {
            SqlConnection conn = new DBConnection().SqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO employee_tb(FirstName, LastName, Gender, Email, Position, Salary) VALUES(@FirstName, @LastName, @Gender, @Email, @Position, @Salary)",
                conn
                );
            cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
            cmd.Parameters.AddWithValue("@LastName", employee.LastName);
            cmd.Parameters.AddWithValue("@Gender", employee.Gender.ToString());
            cmd.Parameters.AddWithValue("@Email", employee.Email);
            cmd.Parameters.AddWithValue("@Position", employee.Position);
            cmd.Parameters.AddWithValue("@Salary", employee.Salary);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteEmployeeById(long id)
        {
            SqlConnection conn = new DBConnection().SqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE employee_tb SET IsDeleted = 1 WHERE Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateEmployee(Employee employee)
        {
            SqlConnection conn = new DBConnection().SqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE employee_tb SET" +
                " FirstName = @firstName, LastName = @lastName, Gender = @gender, Email = @email, Position = @position, Salary = @salary" +
                " WHERE Id = @id", conn);
            cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
            cmd.Parameters.AddWithValue("@lastName", employee.LastName);
            cmd.Parameters.AddWithValue("@gender", employee.Gender.ToString());
            cmd.Parameters.AddWithValue("@email", employee.Email);
            cmd.Parameters.AddWithValue("@position", employee.Position);
            cmd.Parameters.AddWithValue("@salary", employee.Salary);
            cmd.Parameters.AddWithValue("@id", employee.ID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Employee? GetEmployeeById(long id)
        {
            SqlConnection conn = new DBConnection().SqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM employee_tb WHERE Id = @id AND IsDeleted = 0", conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                Employee employee = new Employee()
                {
                    ID = Convert.ToInt64(sqlDataReader.GetInt64(0)),
                    FirstName = sqlDataReader.GetString(1),
                    LastName = sqlDataReader.GetString(2),
                    Gender = (Gender)Enum.Parse(typeof(Gender), sqlDataReader.GetString(3)),
                    Email = sqlDataReader.GetString(4),
                    Position = sqlDataReader.GetString(5),
                    Salary = decimal.ToDouble(sqlDataReader.GetDecimal(6))
                };
                conn.Close();
                return employee;
            }
            else return null;

        }

        public DataTable? GetEmployeeByName(string name)
        {
            SqlConnection conn = new DBConnection().SqlConnect();
            conn.Open();
            String cmd = $"SELECT * FROM employee_tb WHERE (FirstName LIKE '%{name}%' OR LastName LIKE '%{name}%' OR CONCAT(FirstName,' ',LastName) LIKE '%{name}%') AND IsDeleted = 0";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }

    }
}
