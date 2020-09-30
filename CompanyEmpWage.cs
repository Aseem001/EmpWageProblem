using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    public class CompanyEmpWage
    {
        public string company;
        public int ratePerHours;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int ratePerHours, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.ratePerHours = ratePerHours;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalEmpWage = 0;
        }

        public void settotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + " is " + this.totalEmpWage+"\n";
        }
    }

}
