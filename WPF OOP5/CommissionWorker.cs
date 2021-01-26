using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_OOP5
{
    class CommissionWorker:Employee
    {

        private int _number;
        private decimal _commission;

        public int Number;
        public decimal Commission;

        public CommissionWorker(string firstName, string lastName, decimal salary, decimal commission, int number):base(firstName,lastName,salary)
        {
            this.Commission = commission;
            this.Number = number;


        }

        public override string ToString()
        {
            return base.ToString() + " - Commission Worker";
        }

        public override decimal Income()
        {
            return Salary + Number * Commission;
        }


    }
}
