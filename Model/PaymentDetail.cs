using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryMgr.Model
{
    public class PaymentDetail
    {
        private long id;
        private Employee employee;
        private DateTime date;
        private double ot;
        private double bonus;
        private double deduction;
        private double total;

        public long Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public Employee Employee
        {
            get { return this.employee; }
            set { this.employee = value; }
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public double Ot
        {
            get { return this.ot; }
            set { this.ot = value; }
        }
        public double Bonus
        {
            get { return this.bonus; }
            set { this.bonus = value; }
        }
        public double Deduction
        {
            get { return this.deduction; }
            set { this.deduction = value; }
        }
        public double Total
        {
            get { return this.total;}
        }
        public PaymentDetail()
        {
        }
        public PaymentDetail(long id, Employee employee, DateTime date, double ot, double bonus, double deduction)
        {
            this.id = id;
            this.employee = employee;
            this.date = date;
            this.ot = ot;
            this.bonus = bonus;
            this.deduction = deduction;
            calcTotal();
        }
        public PaymentDetail(Employee employee, DateTime date, double ot, double bonus, double deduction)
        {
            this.employee = employee;
            this.date = date;
            this.ot = ot;
            this.bonus = bonus;
            this.deduction = deduction;
            calcTotal();
        }
        public void calcTotal()
        {
            this.total = (employee.Salary + ot + bonus) - deduction;
        }
        
    }
}
