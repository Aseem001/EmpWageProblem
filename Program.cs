using System;

namespace EmpWageComputation
{
    class Program
    {
        //Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int NO_OF_WORKING_DAYS = 20;
        public const int EMP_WAGE_PER_HOUR = 20;
        public const int MAX_HRS_IN_A_MONTH = 100;
        static void Main(string[] args)
        {
            computeEmpWage();
        }
        
        public static void computeEmpWage()
        {
            //Variables
            int monthlyWage = 0;
            int workHour = 0;
            int empWage = 0;
            int workingDays = 1;
            int totalWorkHour = 0;

            Console.WriteLine("Welcome to Employee Wage Computation:\n");

            //Computation condition:
            while (totalWorkHour < MAX_HRS_IN_A_MONTH && workingDays <= NO_OF_WORKING_DAYS)
            {
                Random randNum = new Random();
                int empCheck = randNum.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Day {0}: Employee is present", workingDays);
                        workHour = 8;
                        break;

                    case IS_PART_TIME:
                        Console.WriteLine("Day {0}: Employee is present and working part time", workingDays);
                        workHour = 4;
                        break;

                    default:
                        Console.WriteLine("Day {0}: Employee is absent", workingDays);
                        workHour = 0;
                        break;

                }
                if (totalWorkHour == 96)
                {
                    workHour = 4;
                }
                empWage = EMP_WAGE_PER_HOUR * workHour;
                monthlyWage += empWage;
                Console.WriteLine("Employee Wage for the day: " + empWage + "\n");
                workingDays++;
                totalWorkHour += workHour;
            }
            Console.WriteLine("\n" + "Monthly wage is: " + monthlyWage + "\n" + "Hours worked : " + totalWorkHour + "\n" + "Days worked: " + (workingDays - 1));
            Console.ReadKey();
        }
    }
}
