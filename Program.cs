using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");


            int if_full_time = 1;
            int if_part_time = 2;
            int empWagePerHour = 20;
            int workHour = 0;
            int empWage = 0;


            Random randNum = new Random();
            int empCheck = randNum.Next(0, 3);
            if(empCheck == if_full_time)
            {
                Console.WriteLine("Employee is present");
                workHour = 8;
            }
            else if(empCheck==if_part_time)
            {
                Console.WriteLine("Employee is present and working part time");
                workHour = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                workHour = 0;
            }

            // Employee Wage

            empWage = empWagePerHour * workHour;
            Console.WriteLine("Employee Wage for the day: "+empWage);


            // Employee Attendance and Wage using Switch-Case

            Console.WriteLine();
            Console.WriteLine("Employee Attendance and Wage using Switch-Case:");

            switch (empCheck)
            {
                case 1:
                    Console.WriteLine("Employee is present");
                    workHour = 8;
                    break;

                case 2:
                    Console.WriteLine("Employee is present and working part time");
                    workHour = 4;
                    break;

                default:
                    Console.WriteLine("Employee is absent");
                    workHour = 0;
                    break;

            }
            empWage = empWagePerHour * workHour;
            Console.WriteLine("Employee Wage for the day: " + empWage);
        }
    }
}
