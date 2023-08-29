namespace EmployeeWageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Present = 1;

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == Present)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");

            }
        }
    }
}