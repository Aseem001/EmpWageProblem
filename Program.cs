using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");


            //UC1-Employee Attendance Check

            int if_full_time = 1;
            Random randNum = new Random();
            int empCheck = randNum.Next(1, 2);
            if(empCheck == if_full_time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }


        }
    }
}
