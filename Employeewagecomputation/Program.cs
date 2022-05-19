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
            wagesTillCondition.GetWageTillCondition();

            Console.WriteLine("Employee Wage  for multiple companies ");

            MultipleCompanies campany1 = new MultipleCompanies("Google", 20, 2, 10);
            campany1.ComputeEmpWage();

            MultipleCompanies campany2= new MultipleCompanies("Microsoft", 10, 4, 20);
            campany2.ComputeEmpWage();
            MultipleCompanies campany3 = new MultipleCompanies("Deloitte", 15, 3, 15);
            campany3.ComputeEmpWage();


            SaveTotalWageByCompany google = new SaveTotalWageByCompany("Google", 10, 4, 20);
            google.TotalWageForEachCompany();
            

            SaveTotalWageByCompany microsoft = new SaveTotalWageByCompany("Microsoft", 20, 5, 20);
            microsoft.TotalWageForEachCompany();
            

            SaveTotalWageByCompany deloitte = new SaveTotalWageByCompany("Deloitte", 30, 3, 30);
            deloitte.TotalWageForEachCompany();
            




        }
    }
}