using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryMgr.Model
{
    public class Person
    {
        protected String firstName;
        protected String lastName;
        protected Gender gender;
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public Gender Gender
        {
            get { return gender; }
            set { gender = value;}
        }
        protected Person(string firstName, string lastName, Gender gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
        }
        public Person(){ }
    }
}
