using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaryMgr.Persistence;

namespace EmployeeSalaryMgr.Service
{
    public class AddRemainPaymentDetailService
    {
        private readonly AddRemainPaymentDetail addRemainPaymentDetail = new AddRemainPaymentDetail();

        public void addPaymentDetail(DateTime from, DateTime to)
        {
            addRemainPaymentDetail.addPaymentDetail(from, to);
        }
    }
}
