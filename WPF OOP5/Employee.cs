using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_OOP5
{
    class Employee
    {

        private decimal _salary;
        private string _lastname;
        private string _firstname;

        public decimal Salary { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(string firstName, string lastName, decimal salary)

        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;

        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return  FirstName +  LastName + Income() + "€";
        }
        public virtual decimal Income()
        {
            return Salary;
        }
    }
}
