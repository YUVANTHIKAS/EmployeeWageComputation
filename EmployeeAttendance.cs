using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8;
        public void EmployeeAttendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is Absent");
        }
        public void CalculateEmpWage()
        {
            int daiLyEmpWage = WAGE_PER_HR * FULL_DAY_HR;
            Console.WriteLine(daiLyEmpWage);

        }
    }
}
