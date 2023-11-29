using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaryMgr.Model;
using EmployeeSalaryMgr.Persistence;

namespace EmployeeSalaryMgr.Service
{
    public class EmployeeSearchService : IEmployeeSearchService
    {
        private readonly EmployeeRepository employeeRepo = new EmployeeRepository();
        

        public  Employee? SearchById(long id)
        {
            return employeeRepo.GetEmployeeById(id);
        }

        public DataTable? SearchByName(String name)
        {
            return employeeRepo.GetEmployeeByName(name);
        }
    }
}
