using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        const int IS_FULL_TIME = 0, WAGE_PER_HR = 20, FULL_TIME_HR = 8, PART_TIME_HR = 8, PART_TIME = 1, ABSENT=2, WORKING_DAYS = 20 ;
        int emphr = 0;
        int Empwage = 0;
        int totalempwage = 0;
        public void CalculateEmpWage()
        {
            Random random = new Random();
            for (int i = 0; i < WORKING_DAYS && emphr < 100; i++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        emphr += FULL_TIME_HR;
                        break;
                    case PART_TIME:
                        emphr += PART_TIME_HR;
                        break;

                }
            }

            totalempwage = emphr * WAGE_PER_HR;
            Console.WriteLine("Monthly salary is:" +totalempwage);
        }
    }
}
