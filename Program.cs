using System;
namespace EmployeesWageComputation
{
    public class Program
    {
        static void Main(String[] args)
        {
           // EmployeeDetails.Attendance();

            
           // EmployeeDetails employee = new EmployeeDetails();
           // employee.CalculateWage();

            EmployeeDetails employeeDetails = new EmployeeDetails();

            employeeDetails.CalculateWageTillCondition();
        }
    }
}