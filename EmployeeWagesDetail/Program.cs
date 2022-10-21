using System;

namespace EmployeeWagesDetail
{
    class Program
    {
        static void Main(string[] args)
        {
            int ispresent = 1;
            Random ran = new Random();
            int checkEmployee = ran.Next(0, 2);
            if (ispresent == checkEmployee)
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
