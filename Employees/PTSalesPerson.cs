using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    sealed class PTSalesPerson : Salesperson
    {
        public int WorkHours { get; set; }
        public PTSalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales, int wh)
            : base(fullName, age, empID, currPay, ssn, numbOfSales)
        {
            WorkHours = wh;
        }

    
    }
}
