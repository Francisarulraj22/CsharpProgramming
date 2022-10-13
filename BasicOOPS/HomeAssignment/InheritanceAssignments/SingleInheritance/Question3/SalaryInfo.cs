using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class SalaryInfo
    {
        // Properties: SalaryOfTheMonth, Month
        // Method: Calculate Salary-> for given month , DisplaySalary - > for a given month 
        public int SalaryOfMonth{get;set;}
        public DateTime Month { get; set; }

        public SalaryInfo(int salaryofmonth,DateTime month)
        {
            SalaryOfMonth=salaryofmonth;
            Month=month;        
        }

    }
}