using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {


        public class BenefitPackage
        {
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }

        //variables
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;

        protected BenefitPackage empBenefits = new BenefitPackage();

        public double GetBenefitCost()
        { return empBenefits.ComputePayDeduction(); }

        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }

        //methods

        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }
        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID:{0}", ID);
            Console.WriteLine("Age:{0}", Age);
            Console.WriteLine("Pay: {0}", Pay);

        }


    }
}
