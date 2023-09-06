using System.Data;
using System.Xml.Schema;

namespace EmployeeWageApp
{
    internal class Program
    {
        const int Part_Time = 1;
        const int Full_Time = 2;

        String Company;
        int Emp_Rate_Per_Hour;
        int Num_Of_Working_Days;
        int Max_Hrs_In_Month;
        int Total_EmpWage;

        public Program(String Company, int Emp_Rate_Per_Hour, int Num_Of_Working_Days, int Max_Hrs_In_Month)
        {
            this.Company = Company;
            this.Emp_Rate_Per_Hour = Emp_Rate_Per_Hour;
            this.Num_Of_Working_Days = Num_Of_Working_Days;
            this.Max_Hrs_In_Month = Max_Hrs_In_Month;


        }
        public void EmpWage()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= this.Max_Hrs_In_Month && totalWorkingDays <this.Num_Of_Working_Days)
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
                Console.WriteLine(" Days : " + totalWorkingDays +  "  Employee Hours :" + totalEmpHrs);
            }
            int totalEmpWage = totalEmpHrs * this.Emp_Rate_Per_Hour;
            Console.WriteLine(" Total EmpWage for company: " + Company + " is :" + totalEmpWage);
            
        }
        public string toString()
        {
            return "Total EmpWage For Company :" + Company +" is " + Total_EmpWage;
        }

        static void Main(string[] args)
        {
            Program Dmart = new Program("Dmart",20,8,100);
            Program Walmart = new Program("Walmart", 30, 10, 120);
            Dmart.EmpWage();
            Console.WriteLine(Dmart.toString());
            Walmart.EmpWage();
            Console.WriteLine(Walmart.toString());


        }
    }
}