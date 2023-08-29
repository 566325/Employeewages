using System.Data;
using System.Xml.Schema;

namespace EmployeeWageApp
{
    internal class Program
    {
        const int Part_Time = 1;
        const int Full_Time = 2;
        
        public static int EmpWage(String Company,int Emp_Rate_Per_Hour, int Num_Of_Working_Days, int Max_Hrs_In_Month)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_Working_Days)
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
                Console.WriteLine(" Days : " + totalWorkingDays +  "  Employee Hours :" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine(" Total EmpWage  " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            EmpWage("SMart", 20, 20, 100);
            EmpWage("Amezon", 40, 10, 130);
            EmpWage("Microsoft", 70, 10, 140);

        }
    }
}