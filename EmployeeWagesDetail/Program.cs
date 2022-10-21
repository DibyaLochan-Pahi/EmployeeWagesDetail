using System;

namespace EmployeeWagesDetail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isFullTime = 1;
            int isHalfTime = 2;
            int empWagePerHour = 20;
            int empWages = 0;
            int empHour = 0;
            Random random = new Random();
            int empStatus = random.Next(0, 3);
            if (empStatus == isFullTime)
            {
                Console.WriteLine("Employee is Present");
                empHour = 8;
            }
            else if (empStatus == isHalfTime)
            {
                Console.WriteLine("Employee is Half Time");
                empHour = 4;
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
