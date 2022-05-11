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
        int WORKING_DAYS = 20;
        const int FULL_DAY_HOUR = 8;
        const int PART_TIME_HOUR = 4;
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
            Console.WriteLine("\n\n");
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
            Console.WriteLine("\n\n");
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
            Console.WriteLine("\n\n");
        }
        public void switchcase()
        {
            int emphrs = 0;
            int empwage = 0;
            int num = generateNum.Next(0, 3);
            switch (num)
            {
                case FULL_DAY_HOUR:
                    emphrs = 8;
                    break;
                case PART_TIME_HOUR:
                    emphrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    break;

            }
            empwage = emphrs * WAGE_PER_HOUR;
            Console.WriteLine("Employee wage is {0}", empwage);
            Console.WriteLine("\n\n");
        }
        public void WagesForMonth()
        {
            int TotalWage = 0;
            for (int day = 1; day <= WORKING_DAYS; day++)
            {
                
                
                int num = generateNum.Next(0, 3);
                int WorkingHours = 0;
                switch (num)
                {
                    case FULL_DAY_HOUR:
                        WorkingHours = 8;
                        break;
                    case PART_TIME_HOUR:
                        WorkingHours = 4;
                        break;
                    
                }

                int Empwage = WorkingHours * WAGE_PER_HOUR;
                Console.WriteLine("Employee wage is {0}", Empwage);
                TotalWage += Empwage;
            }
            Console.WriteLine("Total Wage For a Month is {0}", TotalWage);
            Console.WriteLine("\n\n");
        }
        
        
    }
}
