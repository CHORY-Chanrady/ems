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
    public interface IEmployeeService
    {
        DataTable GetAll();
        void Add(Employee employee);
        void DeleteById(long id);
        void Update(Employee employee);
    }

    public interface CopyOfIEmployeeService
    {
        DataTable GetAll();
        void Add(Employee employee);
        void DeleteById(long id);
        void Update(Employee employee);
    }
}
