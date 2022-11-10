using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        const int IS_FULL_TIME = 0, WAGE_PER_HR = 20, FULL_TIME_HR = 8;
        public void CalculateEmpWage()
        {
            int emphr = 0;
            int Empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 2);

            if (empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("employee is fulltime");
                emphr = 8;
            }

            else
            {
                Console.WriteLine("employee is absent");
                emphr = 0;
            }

            Empwage = emphr * WAGE_PER_HR;
            Console.WriteLine(Empwage);

        }
    }
}
