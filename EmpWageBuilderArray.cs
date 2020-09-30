using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    public class EmpWageBuilderArray
    {
        //Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }

        public void computeEmpWage()
        {
            for(int i=0;i<numOfCompany;i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int workHour = 0;
            int workingDays = 0;
            int totalWorkHour = 0;


            //Computation condition:
            while (totalWorkHour < companyEmpWage.maxHoursPerMonth && workingDays <= companyEmpWage.numOfWorkingDays)
            {
                Random randNum = new Random();
                int empCheck = randNum.Next(0, 3);
                workingDays++;
                switch (empCheck)
                {
                    case IS_FULL_TIME:                        
                        workHour = 8;
                        break;

                    case IS_PART_TIME:
                        workHour = 4;
                        break;

                    default:                        
                        workHour = 0;
                        break;

                }

                totalWorkHour += workHour;
                Console.WriteLine("Day#:"+workingDays+"Emp workHrs : "+workHour);
            }           
            return totalWorkHour * companyEmpWage.empRatePerHour;

        }
    }
}
