using System.Xml.Schema;

namespace EmployeeWageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Part_Time = 1;
            const int Full_Time = 2;
            const int Emp_Rate_Per_Hour = 20;
            const int Num_Of_Working_Days = 20;

            
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 1; day < Num_Of_Working_Days; day++)
            {
                Random random = new Random();
                int cheCheck = random.Next(0, 3);
                switch (cheCheck)
                {
                    case Full_Time:
                        empHrs = 8;
                        break;
                    case Part_Time:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * Emp_Rate_Per_Hour;
                totalEmpWage  += empWage;
                Console.WriteLine("Employee Daily Wage " + empWage);
            }
            Console.WriteLine("Total empWage  " + totalEmpWage);






        }
    }
}