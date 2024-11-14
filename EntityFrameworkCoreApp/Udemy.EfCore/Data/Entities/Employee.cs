namespace Udemy.EfCore.Data.Entities
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class PartTimeEmployee : Employee
    {
        public decimal DailyWage { get; set; }
    }

    public class FullTimeEmployee : Employee
    {
        public decimal HourlWage { get; set; }
    }
}
