// See https://aka.ms/new-console-template for more information


namespace Employeewagecomputation
{
    class Programm
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");

            Employeewagecomputation objEmp = new Employeewagecomputation();


            //Employee Attendance
            objEmp.checkEmpISPresentOrNot();


            //Calculate Daily Employee Wage
            objEmp.calcEmpDailywage();


            //Calculate Full/PartTime Employee Wage
            objEmp.checkEmpFullOrPartTime();


            //Solving using Switch Case
            objEmp.switchcase();

            //Calculating Wages for a month
            objEmp.WagesForMonth();
            
           

            WagesTillCondition wagesTillCondition = new WagesTillCondition();
            //Calculating Wages till the condition of 100 hours of month or 20 days…
            wagesTillCondition.GetWageTillCondition();





        }
    }
}