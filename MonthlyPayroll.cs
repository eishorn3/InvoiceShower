namespace InvoiceShower
{
    public class MonthlyPayroll : Payroll
    {

        public decimal MonthlySalary { get; set; }

        public MonthlyPayroll(decimal monthlySalary, Employee employee, int startMonth, int months, int startYear) : base(employee, startMonth, months, startYear)
        {
            MonthlySalary = monthlySalary;


        }
        public override string CalculateWage()
        {
            decimal wage = MonthlySalary;
            string starMonthLetterYear = StartDate.ToString("MMMM yyyy", System.Globalization.CultureInfo.GetCultureInfo("de-DE"));
            return $"{Employee.ForeName} {Employee.SurName} bekommt im {starMonthLetterYear}: {wage}\n";
        }


        public override string ShowPayroll()
        {
            string starMonthLetterYear = StartDate.ToString("MMMM yyyy", System.Globalization.CultureInfo.GetCultureInfo("de-DE"));
            return $"Neue Abrechnung {Employee.ForeName} {Employee.SurName} {MonthlySalary}.- pro Monat im {starMonthLetterYear}\n";
        }
    }
}

