using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaryMgr.Model;

namespace EmployeeSalaryMgr.Service
{
    public interface IEmployeeSearchService
    {
        Employee? SearchById(long id);
        DataTable? SearchByName(String name);
    }

    public interface CopyOfIEmployeeSearchService
    {
        Employee? SearchById(long id);
        DataTable? SearchByName(String name);
    }
}
