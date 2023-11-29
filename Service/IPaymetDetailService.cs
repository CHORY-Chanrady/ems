using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaryMgr.Model;

namespace EmployeeSalaryMgr.Service
{
    public interface IPaymetDetailService
    {
        void add(PaymentDetail paymentDetail);
    }
}
