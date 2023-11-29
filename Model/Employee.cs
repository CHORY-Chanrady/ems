using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryMgr.Model
{
    public class Employee : Person
    {
        public long ID { get; set; }
        public String Email { get; set; }
        public double Salary { get; set; }
        public String Position { get; set; }
        public Employee(String firstName, String lastName, Gender gender, String email, double salary, String position) : base(firstName, lastName, gender)
        {
            Email = email;
            Salary = salary;
            Position = position;
        }
        public Employee(long id, String firstName, String lastName, Gender gender, String email, double salary, String position) : base(firstName, lastName, gender)
        {
            ID = id;
            Email = email;
            Salary = salary;
            Position = position;
        }
        public Employee() { }
    }
}
