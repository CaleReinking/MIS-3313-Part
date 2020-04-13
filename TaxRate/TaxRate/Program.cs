using System;

namespace TaxRate
{
    class MainClass
    {
    static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("enter salary here");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double salary)) 
                {
                    double Federal = CalculationFederalTax(salary);
                    double FICA = CalculateFICATax(salary);
                    DisplayResults(name, salary, Federal, FICA);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid salary, try again");
                }
            }
        }
        private static double CalculationFederalTax(double salary)
        {
            double percent;
            if (salary <= 9525)
            {
                percent = 10;
            }
            else if (salary <= 38700)
            {
                percent = 12;
            }
            else if (salary <= 82500)
            {
                percent = 22;
            }
            else if (salary <= 157588)
            {
                percent = 24;
            }
            else if (salary <= 200000)
            {
                percent = 32;
            }
            else if (salary <=500000)
            {
                percent = 35;
            }
            else
            {
                percent = 37;
            }
            return (percent * salary) / 100;
        }
        private static double CalculateFICATax(double salary)
        {
            return (6.2 * salary) / 100;
        }
        private static void DisplayResults(string name, double salary, double federal, double FICA)
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Federal Tax: " + federal); 
            Console.WriteLine("FICA Taxx: " + FICA);
            Console.WriteLine("NET Salary: " + (salary - federal - FICA));
        }
    }
}
