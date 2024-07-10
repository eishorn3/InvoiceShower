namespace InvoiceShower
{
    public class HourlyPayroll : Payroll
    {
        public int HoursWorked { get; set; }
        public decimal HourlySalary { get; set; }

        public HourlyPayroll(decimal hourlySalary, int hoursWorked, Employee employee, int startMonth, int months, int startYear) : base(employee, startMonth, months, startYear)
        {
            HourlySalary = hourlySalary;
            HoursWorked = hoursWorked;

        }

        public override string CalculateWage()
        {
            decimal wage = HourlySalary * HoursWorked;
            string starMonthLetterYear = StartDate.ToString("MMMM yyyy", System.Globalization.CultureInfo.GetCultureInfo("de-DE"));
            return $"{Employee.ForeName} {Employee.SurName} bekommt im {starMonthLetterYear}: {HourlySalary * HoursWorked}\n";
        }

        public override string ShowPayroll()
        {
            string starMonthLetterYear = StartDate.ToString("MMMM yyyy", System.Globalization.CultureInfo.GetCultureInfo("de-DE"));
            return $"Neue Abrechnung {Employee.ForeName} {Employee.SurName}, {HoursWorked} Std. zu {HourlySalary} EUR pro Stunde im {starMonthLetterYear}\n";
        }
    }
}

