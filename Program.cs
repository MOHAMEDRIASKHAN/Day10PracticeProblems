// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace EmployeeWageProblem
{
    class program
    {
        public static void Main(string[] agrs)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computerEmpWage();
            Console.WriteLine("Total Wage for DMart Company : " + empWageBuilder.getTotalWage("DMart"));
        }
    }
}