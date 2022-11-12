using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        const int IS_FULL_TIME = 0, WAGE_PER_HR = 20, FULL_TIME_HR = 8, PART_TIME_HR = 8, PART_TIME = 1, 
            ABSENT=2, WORKING_DAYS = 20, EMP_RATE_PER_HR =20, MAX_HR_IN_MONTH = 100, NUM_OF_WORKING_DAY = 20;
        int emphr = 0;
        int totalWorkingDays = 0;
        int totalEmpHrs = 0;
        public void CalculateEmpWage()
        { 
            while (totalEmpHrs <= MAX_HR_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAY)
            {
                totalWorkingDays++;
                emphr++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        emphr += FULL_TIME_HR;
                        break;
                    case PART_TIME:
                        emphr += PART_TIME_HR;
                        break;
                    default:
                        emphr = 0;
                        break;
                }
                totalEmpHrs += emphr;
                Console.WriteLine("Day:" +totalWorkingDays + "\n Employee Working Hours:" +emphr);

                int totalempwage = totalEmpHrs * EMP_RATE_PER_HR;
                Console.WriteLine("Total Employee Wage:" + totalempwage);
            }
            
        }
    }
}
