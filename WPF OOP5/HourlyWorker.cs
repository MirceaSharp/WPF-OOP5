using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_OOP5
{
    class HourlyWorker : Employee
    {
        private int _numberOfHours;
        public int numberOfHours { get; set; }

        public HourlyWorker(string firstName, string lastName, decimal salary, int numberOfHours):base(firstName,lastName,salary)
        {

            this.numberOfHours = numberOfHours;


        }
        public override string ToString()
        {
            return base.ToString() + " - Hourly Worker";
        }
        public override decimal Income()
        {
            return Salary * numberOfHours;
        }



    }
}
