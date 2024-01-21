using Newtonsoft.Json;

namespace Enrollment.OR.GetClassCategories.Response
{
    public sealed class FoundClassCategory
    {
        public FoundClassCategory(int id, string name, string icon, string description, string teacher)
        {
            Id = id;
            Name = name;
            Icon = icon;
            Description = description;
            Teacher = teacher;
        }

        [JsonProperty("id")]
        public int Id { get; }

        [JsonProperty("name")]
        public string Name { get; }

        [JsonProperty("icon")]
        public string Icon { get; }

        [JsonProperty("description")]
        public string Description { get; }

        [JsonProperty("teacher")]
        public string Teacher { get; }
    }
}
