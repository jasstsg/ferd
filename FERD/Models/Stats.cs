using System.Text.Json.Serialization;

namespace FERD.Models
{
    public class Stats
    {
        public int HP { get; set; }
        public int SM { get; set; }
        public int SKL { get; set; }
        public int SPD { get; set; }
        public int DEF { get; set; }
        public int RES { get; set; }
        public int Length { get { return 6; } }

        [JsonIgnore]
        public int this[string key]
        {
            get
            {
                switch (key.ToLower())
                {
                    case "hp": return HP;
                    case "sm": return SM;
                    case "skl": return SKL;
                    case "spd": return SPD;
                    case "def": return DEF;
                    case "res": return RES;
                    default: throw new Exception($"The key '{key}' does not exist on the 'Stats' object");
                }
            }

            set
            {
                switch (key.ToLower())
                {
                    case "hp": HP = value; break;
                    case "sm": SM = value; break;
                    case "skl": SKL = value; break;
                    case "spd": SPD = value; break;
                    case "def": DEF = value; break;
                    case "res": RES = value; break;
                    default: throw new Exception($"The key '{key}' does not exist on the 'Stats' object");
                }
            }
        }

        [JsonIgnore]
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return HP;
                    case 1: return SM;
                    case 2: return SKL;
                    case 3: return SPD;
                    case 4: return DEF;
                    case 5: return RES;
                    default: throw new Exception($"The index '{index}' does not exist on the 'Stats' object");
                }
            }

            set
            {
                switch (index)
                {
                    case 0: HP = value; break;
                    case 1: SM = value; break;
                    case 2: SKL = value; break;
                    case 3: SPD = value; break;
                    case 4: DEF = value; break;
                    case 5: RES = value; break;
                    default: throw new Exception($"The index '{index}' does not exist on the 'Stats' object");
                }
            }
        }

    }
}
