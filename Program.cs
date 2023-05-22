using System;
namespace EmployeesWageComputation
{
    public class Program
    {
        static void Main(String[] args)
        {
           // EmployeeDetails.Attendance();

            
            EmployeeDetails employee = new EmployeeDetails();
            //employee.CalculateWagesForMonth();

           // EmployeeDetails employeeDetails = new EmployeeDetails();

           // employee.CalculateWageTillCondition();

            EmployeeDetails.ComputeEmployeeWage();

        }
    }
}