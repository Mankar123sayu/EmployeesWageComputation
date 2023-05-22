using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesWageComputation
{
    public class MultipleCompany
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public int ComputeEmployeeWage(string CompanyName,int WAGE_PER_HR, int WORKING_DAYS, int TOTAL_HRS)
        {
            int total_Working_Hrs = 0;
            int total_Working_Days = 0;
            while (total_Working_Hrs < TOTAL_HRS && total_Working_Days < WORKING_DAYS)
            {
                int emp_Hr = 0;
                total_Working_Days++;
                Random random = new Random();
                int check = random.Next(3);
                switch (check)
                {
                    case IS_FULL_TIME:
                        emp_Hr = 8;
                        break;
                    case IS_PART_TIME:
                        emp_Hr = 4;
                        break;
                    default:
                        emp_Hr = 0;
                        break;
                }
                total_Working_Hrs += emp_Hr;
            }
           int MONTHLY_WAGE = total_Working_Hrs * WAGE_PER_HR;

            Console.WriteLine($"Employee Monthly Wage: {MONTHLY_WAGE}");
            Console.WriteLine($"Total Employee Wage of {CompanyName} is {MONTHLY_WAGE}");
            return MONTHLY_WAGE;

        }
    }
}
