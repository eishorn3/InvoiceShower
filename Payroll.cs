using System;

namespace InvoiceShower
{
    public abstract class Payroll
    {
        public Employee Employee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public Payroll(Employee employee, int startMonth, int months, int startYear)
        {
            Employee = employee;
            StartDate = new DateTime(startYear, startMonth, 01);
            EndDate = StartDate.AddMonths(months).AddDays(-1);
        }
        public abstract string CalculateWage();
        public abstract string ShowPayroll();


    }
}
