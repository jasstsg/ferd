using FERD.Data;
using System.Text.Json.Serialization;

namespace FERD.Models
{
    public class ClassType
    {
        public string Name { get; set; }
        public int Tier { get; set; }
        public Stats GrowthRates { get; set; }
        public int Move { get; set; }
        public IEnumerable<string> Subclasses { get; set; }
        public IEnumerable<string> Weapons { get; set; } = new List<string>();
        public IEnumerable<string> Features { get; set; }
        public string Description {  get; set; }

        public List<ClassType> getSubclassObjects()
        {
            return Classes.ClassMap.Values.Where(c => this.Subclasses.Contains(c.Name)).ToList();
        }

        public bool Equals(ClassType other)
        {
            return this.Name.Equals(other.Name);
        }

        [JsonIgnore]
        public ClassType Value
        {
            get { return this; }
        }
    }
}
