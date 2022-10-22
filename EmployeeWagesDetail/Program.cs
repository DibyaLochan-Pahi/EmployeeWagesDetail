using System;

namespace EmployeeWagesDetail
{
    class Program
    {
        static void Main(string[] args)
        {
            int empWagePerHour = 20;
            int empHour = 0;
            int empWage = 0;
            int maxDay = 20;
            int totalEmpWage = 0;
            for (int day = 0; day < maxDay; day++)
            {
                Random random = new Random();
                int empStatus = random.Next(0, 3);
                switch (empStatus)
                {
                    case 1:
                        Console.WriteLine("Employee is Present");
                        empHour = 8;
                        break;
                    case 2:
                        Console.WriteLine("Employee is Half Time");
                        empHour = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is absent");
                        empHour = 0;
                        break;
                }
                empWage = empHour * empWagePerHour;
                totalEmpWage = totalEmpWage + empWage;
                Console.WriteLine("Employee Wage : " + empWage);
            }
            Console.WriteLine("Total Employee Wages For 20 Days: " + totalEmpWage);


        }
    }
}
