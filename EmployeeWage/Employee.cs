using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Employee
    {
        const int IS_FULL_TIME = 0, WAGE_PER_HR = 20, FULL_TIME_HR = 8, PART_TIME_HR = 8, PART_TIME = 1,
            ABSENT = 2, workingDays = 20, EMP_RATE_PER_HR = 20, MAX_HR_IN_MONTH = 100, NUM_OF_WORKING_DAY = 20;
        int emphr = 0;
        int totalEmpWage = 0;
        int totalWorkingDays = 0;
        int totalEmpHrs = 0;
        public int EmpWage(string company, int wage_per_hr, int total_working_hrs, int working_day_month)
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            while (workingDays < working_day_month && emphr < total_working_hrs)
            {
                //workingDays++;

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        emphr += FULL_TIME_HR;
                        break;
                    case PART_TIME:
                        emphr += PART_TIME_HR;
                        break;
                    default:
                        emphr += 0;
                        break;
                }
            }

            Console.WriteLine("Working Hours :" + emphr + "Working Days : " + workingDays);
            totalEmpWage = emphr + WAGE_PER_HR;
            Console.WriteLine("Total Employee Wage for : " + company + "of" + working_day_month + "Day is :" + totalEmpWage + "\n");
            return totalEmpWage;

        }
    }
}