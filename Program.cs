namespace EmployeeWageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Part_Time = 1;
            const int Full_Time = 2;
            const int Emp_Rate_Per_Hour = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();

            int cheCheck = random.Next(0,3);

            //if (cheCheck == Part_Time) 
            //{
            //    empHrs = 4;

            //}
            //else if (cheCheck == Full_Time)
            //{
            //    empHrs = 8;
            //}
            //else
            //{
            //    empHrs = 0;
            //}
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
            Console.WriteLine("Employee Daily Wage " + empWage);




        }
    }
}