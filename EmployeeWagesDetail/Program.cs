using System;

namespace EmployeeWagesDetail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isFullTime = 1;
            int empWagePerHour = 20;
            int empWages = 0;
            int empHour = 0;
            Random random = new Random();
            int empStatus = random.Next(0, 2);
            if (empStatus == isFullTime)
            {
                Console.WriteLine("Employee is Present");
                empHour = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHour = 0;
            }
            empWages = empWagePerHour * empHour;
            Console.WriteLine("Employee Wages is " + empWages);
        }
    }
}
