using System;
using System.Collections.Generic;

namespace InvoiceShower
{


    internal class Program
    {

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            var employeeId_1 = new Employee("Heinz", "Muster", 1);
            var employeeId_2 = new Employee("Heinz", "Montag", 2);
            var employeeId_3 = new Employee("Fred", "Feuerstein", 3);

            employees.Add(employeeId_1);
            employees.Add(employeeId_2);
            employees.Add(employeeId_3);

            List<Payroll> payrolls = new List<Payroll>
            {
            new HourlyPayroll(18, 160, employeeId_1, 05, 1, 2024),
            new MonthlyPayroll(4500, employeeId_2, 05, 1, 2024),
            new HourlyPayroll(20, 172, employeeId_3, 05, 1, 2024),
            new HourlyPayroll(18, 150, employeeId_1, 06,1, 2024)
            };


            foreach (var employee in employees)
            {
                employee.ShowEmployee();
            }
            Console.WriteLine();

            foreach (var payroll in payrolls)
            {
                Console.Write(payroll.ShowPayroll());

            }
            Console.WriteLine();
            foreach (var payroll in payrolls)
            {
                Console.Write(payroll.CalculateWage());
            }
            Console.WriteLine();



        }
    }
}
