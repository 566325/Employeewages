namespace EmployeeWageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Present = 1;
            int Emp_Rate_Per_Hour = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int cheCheck = random.Next(0,2);
            if (cheCheck == Present) 
            {
                empHrs = 8;

            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Daily Wage " + empWage);




        }
    }
}