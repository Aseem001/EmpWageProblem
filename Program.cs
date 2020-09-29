using System;

namespace EmpWageComputation
{
    class Program
    {
       
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 15, 80);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 20, 100);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }                       
    }
    public class EmpWageBuilderObject
    {
        //Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        //Variables
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void computeEmpWage()
        {
            int monthlyWage = 0;
            int workHour = 0;
            int workingDays = 1;
            int totalWorkHour = 0;

                Console.WriteLine("Welcome to Employee Wage Computation in : " + company + "\n");

                //Computation condition:
                while (totalWorkHour < maxHoursPerMonth && workingDays <= numOfWorkingDays)
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
                    totalEmpWage = empRatePerHour * workHour;
                    monthlyWage += totalEmpWage;
                    Console.WriteLine("Employee Wage for the day: " + totalEmpWage + "\n");
                    workingDays++;
                    totalWorkHour += workHour;
                }
            totalEmpWage = monthlyWage;
                Console.WriteLine("Monthly wage is: " + monthlyWage + "\n" + "Hours worked : " + totalWorkHour + "\n" + "Days worked: " + (workingDays - 1));
            
        }
        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + " is " + this.totalEmpWage+"\n\n\n";
        }
        
    }
}
