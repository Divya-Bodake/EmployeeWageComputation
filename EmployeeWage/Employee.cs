using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        const int IS_FULL_TIME = 0, WAGE_PER_HR = 20, FULL_TIME_HR = 8, PART_TIME_HR = 8, PART_TIME = 1;
        public void CalculateEmpWage()
        {
            int emphr = 0;
            int Empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 2);

            switch (empcheck)
            {
                case IS_FULL_TIME:
                    Console.WriteLine("Employee is FullTime");
                    emphr = 8;
                    break;
                case PART_TIME:
                    Console.WriteLine("Employee is PartTime");
                    emphr = 8;
                    break;
                
            }

            Empwage = emphr * WAGE_PER_HR;
            Console.WriteLine(Empwage);

        }
    }
}
