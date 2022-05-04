using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewagecomputation
{
    public class Employeewagecomputation
    {
        int WAGE_PER_HOUR = 20;
        int FULL_DAY_HOUR = 8;
        int PART_TIME_HOUR = 4;
        bool IsPresent;
        bool IsFulltime;
        bool IsParttime;

        Random generateNum = new Random();

        public void checkEmpISPresentOrNot()
        {

            int num = generateNum.Next(0, 2);
            if (num == 1)
            {
                IsPresent = true;
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                IsPresent = false;
                Console.WriteLine("Employee Is Absent");
            }

        }
        public void calcEmpDailywage()
        {

            if (IsPresent && IsFulltime)
            {
                int empDailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                Console.WriteLine("Employee Daily Wage is {0}", empDailyWage);
            }
            else if (IsPresent && !IsFulltime)
            {
                int empDailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                Console.WriteLine("Employee Daily Wage is {0}", empDailyWage);
            }
        }
        public void checkEmpFullOrPartTime()
        {

            int num = generateNum.Next(0, 2);
            if (num == 1)
            {
                IsFulltime = true;
                Console.WriteLine("Full Time Employee");
            }
            else
            {
                IsFulltime = false;
                Console.WriteLine("Part Time Employee");
            }
        }
        
        
    }
}
