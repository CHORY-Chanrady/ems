using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaryMgr.Model;
using EmployeeSalaryMgr.Persistence;

namespace EmployeeSalaryMgr.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository employeeRepository = new EmployeeRepository();
        public DataTable GetAll()
        {
            return employeeRepository.GetAllEmployees();
        }

        public void Add(Employee employee)
        {
            employeeRepository.AddEmployee(employee);
        }

        public void DeleteById(long id)
        {
            employeeRepository.DeleteEmployeeById(id);
        }

        public void Update(Employee employee)
        {
            employeeRepository.UpdateEmployee(employee);
        }
    }
}
