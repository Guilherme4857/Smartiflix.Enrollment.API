namespace Enrollment.API.Database.Entities
{
    public class ClassCategory
    {
        public ClassCategory(string name, string icon, string description, string teacher)
        {
            Name = name;
            Icon = icon;
            Description = description;
            Teacher = teacher;
        }

        public ClassCategory(int id, string name, string icon, string description, string teacher)
        {
            Id = id;
            Name = name;
            Icon = icon;
            Description = description;
            Teacher = teacher;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Icon { get; set; }

        public string Description { get; set; }

        public string Teacher { get; set; }
    }
}
