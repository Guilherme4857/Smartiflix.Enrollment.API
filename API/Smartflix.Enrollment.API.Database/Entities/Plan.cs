namespace Enrollment.API.Database.Entities
{
    public class Plan
    {
        public Plan(string name, decimal monthlyValue, int classTotal)
        {
            Name = name;
            MonthlyValue = monthlyValue;
            ClassTotal = classTotal;
        }

        public string Name { get; set; }

        public decimal MonthlyValue { get; set; }

        public int ClassTotal { get; set; }

        public virtual ICollection<ClassCategory> ClassCategories { get; set; }
    }
}
