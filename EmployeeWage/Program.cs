namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.EmpWage("Atos", 10, 200, 30);
            employee.EmpWage("Barclays", 11, 250, 30);
            employee.EmpWage("Infosys", 12, 300, 31);

        }
    }
}