using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");


            const int if_full_time = 1;
            const int if_part_time = 2;
            int no_of_working_days = 20;
            int empWagePerHour = 20;
            int monthlyWage = 0;
            int workHour = 0;
            int empWage = 0;


            for(int day=1; day <= no_of_working_days;day++)
            {
                Random randNum = new Random();
                int empCheck = randNum.Next(0, 3);
                switch (empCheck)
                {
                    case if_full_time:
                        Console.WriteLine("Day {0}: Employee is present",day);
                        workHour = 8;
                        break;

                    case if_part_time:
                        Console.WriteLine("Day {0}: Employee is present and working part time",day);
                        workHour = 4;
                        break;

                    default:
                        Console.WriteLine("Day{0}: Employee is absent",day);
                        workHour = 0;
                        break;

                }
                empWage = empWagePerHour * workHour;
                monthlyWage += empWage;
                Console.WriteLine("Employee Wage for the day: " + empWage);
            }
            Console.WriteLine("\n" + "Monthly wage is: "+monthlyWage);
           
        }
    }
}
