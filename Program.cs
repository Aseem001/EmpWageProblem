using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompanyEmpWage("Dmart", 20, 10, 60);
            empWageBuilder.AddCompanyEmpWage("Reliance", 15, 14, 40);
            empWageBuilder.ComputeEmpWage();
            Console.WriteLine("\nTotal wage for Dmart is: " + empWageBuilder.GetTotalWage("Dmart"));
            Console.ReadKey();
        }
    }

    public interface IComputeWage
    {
        void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);

        void ComputeEmpWage();
        int GetTotalWage(string company);
    }

}
