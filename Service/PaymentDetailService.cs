using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaryMgr.Model;
using EmployeeSalaryMgr.Persistence;

namespace EmployeeSalaryMgr.Service
{
    public class PaymentDetailService : IPaymetDetailService
    {
        public void add(PaymentDetail paymentDetail)
        {
            new PaymentDetailRepository().addPaymentDetail(paymentDetail);
        }
    }
}
