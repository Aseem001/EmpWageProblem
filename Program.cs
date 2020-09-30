using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompanyEmpWage("Dmart", 20, 10, 60);
            empWageBuilder.AddCompanyEmpWage("Reliance", 15, 7, 40);         
            empWageBuilder.ComputeEmpWage();
            Console.ReadKey();
        }
    }

    

}
