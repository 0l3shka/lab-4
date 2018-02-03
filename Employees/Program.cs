using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void CastingExamples()
        {
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);
            Salesperson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90,4);
            PTSalesPerson TestPTSP = new PTSalesPerson("TestPTSP", 22, 99, 20000, "13337", 20, 4);

            GivePromotion((Manager)frank);
            GivePromotion((Salesperson)TestPTSP);

            Salesperson sp = frank as Salesperson;
            if (sp == null)
                Console.WriteLine("Sorry, frank is not a salesperson...");
        }

        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted!", emp.Name);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy ******\n");
            Manager chucky = new Manager("Chucky", 50, 92, 10000, "333-23-23222", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();
            Salesperson fran = new Salesperson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();

            CastingExamples();

            Console.ReadLine();
           
        }
    }
}
