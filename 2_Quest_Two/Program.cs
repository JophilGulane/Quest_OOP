namespace _2_Quest_Two
{
    // 2. Employee Payroll System
    // An initial program calculates a basic payroll for employees, but it lacks any structure. Refactor it to improve readability and reusability.

    // Given Code:
    /*
    string employeeName = "Alice";
    double hourlyRate = 15.0;
    int hoursWorked = 160;

    double monthlySalary = hourlyRate * hoursWorked;
    Console.WriteLine($"{employeeName} earned {monthlySalary:C} this month.");
    */

    // Requirements:
    // - Create an Employee class with properties for name, hourly rate, and hours worked.
    // - Add a CalculateMonthlySalary method to calculate and return the salary.
    // - Create a DisplayEmployeePayroll method to show the employee’s monthly salary in a formatted way.
    internal class Program
    {
        static void Main(string[] args)
        {
            string employeeName = "Alice";
            double hourlyRate = 15.0;
            int hoursWorked = 160;

            Employee employee = new Employee(employeeName, hourlyRate, hoursWorked);

            employee.DisplayEmployeePayroll();

        }


    }

    public class Employee
    {
        private string employeeName;
        private double hourlyRate;
        private int hoursWorked;

        public Employee(string employeeName, double hourlyRate, int hoursWorked) 
        {
            this.employeeName = employeeName;
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }

        private double CalculateMonthlySalary()
        {
            return hourlyRate * hoursWorked;
        }

        public void DisplayEmployeePayroll() 
        {
            Console.WriteLine($"{employeeName} Payroll This Month is {CalculateMonthlySalary():C}");
        }
    }
}
