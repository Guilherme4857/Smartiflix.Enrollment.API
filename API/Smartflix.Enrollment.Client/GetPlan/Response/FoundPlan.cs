using Enrollment.OR.GetClassCategories.Response;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Enrollment.OR.GetPlan.Response
{
    public sealed class FoundPlan
    {
        public FoundPlan(string name, decimal monthlyValue, int classTotal, ICollection<FoundClassCategory> classCategories)
        {
            Name = name;
            MonthlyValue = monthlyValue;
            ClassTotal = classTotal;
            ClassCategories = classCategories;
        }

        [JsonProperty("name")]
        public string Name { get; }

        [JsonProperty("monthlyValue")]
        public decimal MonthlyValue { get; }

        [JsonProperty("classTotal")]
        public int ClassTotal { get; }

        [JsonProperty("classCategories")]
        public ICollection<FoundClassCategory> ClassCategories { get; }
    }
}
