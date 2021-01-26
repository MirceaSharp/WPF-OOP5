using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_OOP5
{
    class TemporaryWorker : Employee
    {

        private int _number;
        public int Number { get; set; }

        public TemporaryWorker(string firstName, string lastName, decimal salaryPerAssignment, int number) : base( firstName, lastName,salaryPerAssignment)
        {
            this.Number = number;

        }

        public override decimal Income()
        {
            return Salary * Number;
        }

        public override string ToString()
        {
            return base.ToString() + " - Temporary Worker";
        }

    }
}
