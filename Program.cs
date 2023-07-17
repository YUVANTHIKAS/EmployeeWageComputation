using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            EmpWage appleWage = new EmpWage("Apple", 200, 20, 100);
            //employeeWage.EmployeeAttendance();
            appleWage.CalculateEmpWage();
            EmpWage amazonWage = new EmpWage("Amazon", 100, 20, 100);
            amazonWage.CalculateEmpWage();
        }
    }
}