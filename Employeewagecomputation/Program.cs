// See https://aka.ms/new-console-template for more information


namespace Employeewagecomputation
{
    class Programm
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");

            Employeewagecomputation objEmp = new Employeewagecomputation();
            objEmp.checkEmpISPresentOrNot();
            objEmp.checkEmpFullOrPartTime();
            objEmp.calcEmpDailywage();
           

           

        }
    }
}