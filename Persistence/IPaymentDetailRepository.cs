using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaryMgr.Model;

namespace EmployeeSalaryMgr.Persistence
{
    public interface IPaymentDetailRepository
    {
        void addPaymentDetail(PaymentDetail paymentDetail);
        DataTable getAllPaymentDetail(DateTime from, DateTime to);
    }
}
