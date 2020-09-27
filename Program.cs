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
            int working_days = 1;
            int total_work_hour = 0;
            int final_workdays = 0;


            while(total_work_hour<=100 && working_days <=20 )
            {
                Random randNum = new Random();
                int empCheck = randNum.Next(0, 3);
                switch (empCheck)
                {
                    case if_full_time:
                        Console.WriteLine("Day {0}: Employee is present",working_days);
                        workHour = 8;
                        break;

                    case if_part_time:
                        Console.WriteLine("Day {0}: Employee is present and working part time", working_days);
                        workHour = 4;
                        break;

                    default:
                        Console.WriteLine("Day {0}: Employee is absent", working_days);
                        workHour = 0;
                        break;

                }
                empWage = empWagePerHour * workHour;
                monthlyWage += empWage;
                Console.WriteLine("Employee Wage for the day: " + empWage);
                final_workdays = working_days;
                working_days++;
                total_work_hour += workHour;
            }
            Console.WriteLine("\n" + "Monthly wage is: "+monthlyWage+"\n"+"Hours worked : "+ total_work_hour + "\n"+"Days worked: "+ final_workdays);
           
        }
    }
}
