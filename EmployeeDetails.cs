﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesWageComputation
{
    public class EmployeeDetails
    {
       public  void CalculateWage()
        {
            int emp_Hr = 0;
            int emp_Wage = 0;

            Random random = new Random();
            int check = random.Next(2);

            if (check == IS_FULL_TIME)
            {
                emp_Hr = 8;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                emp_Hr = 0;
                Console.WriteLine("Employee is Absent");
            }
            emp_Wage = emp_Hr * WAGE_PER_HR;
            Console.WriteLine($"Employee Wage: {emp_Wage}");
        }
    }
}
