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
        }
    }
}
