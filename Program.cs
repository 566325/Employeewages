using System.Data;
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
            const int Max_Hrs_In_Month = 100;

            
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while(totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_Working_Days)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Total Employee working days   " + totalWorkingDays);
            }
            int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Total EmpWage  " + totalEmpWage);






        }
    }
}