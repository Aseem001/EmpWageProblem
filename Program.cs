using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");


            int if_full_time = 1;
            int empWagePerHour = 20;
            int fullDayHour = 0;
            int empWage = 0;


            Random randNum = new Random();
            int empCheck = randNum.Next(0, 2);
            if(empCheck == if_full_time)
            {
                Console.WriteLine("Employee is present");
                fullDayHour = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                fullDayHour = 0;
            }

            // Employee Wage

            empWage = empWagePerHour * fullDayHour;
            Console.WriteLine("Employee Wage for the day: "+empWage);
        }
    }
}
