using System;

namespace InvoiceShower
{
    public class Employee
    {
        public string ForeName { get; set; }
        public string SurName { get; set; }
        public int UserId { get; set; }

        public Employee(string foreName, string surName, int userId)
        {
            ForeName = foreName;
            SurName = surName;
            UserId = userId;
        }
        public void ShowEmployee()
        {
            Console.Write($"Mitarbeiter: {UserId}, {ForeName} {SurName}\n");

        }
    }
}
