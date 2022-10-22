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
            int maxHour = 100;
            int totalEmpWage = 0;
            int totalEmpHour = 0;
            int totalEmpDay = 0;
            while (totalEmpHour < maxHour && totalEmpDay < maxDay)
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
                totalEmpHour = totalEmpHour + empHour;
                Console.WriteLine("Employee Wage : " + empWage);
            }
            Console.WriteLine("Total Employee Wages For a month: " + totalEmpWage);
            Console.WriteLine("Total Employee Hour " + totalEmpHour);


        }
    }
}
