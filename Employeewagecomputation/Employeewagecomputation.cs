using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewagecomputation
{
    public class Employeewagecomputation
    {

        bool IsPresent;
        public void checkEmpISPresentOrNot()
        {
            Random generateNum = new Random();
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


    }
}
