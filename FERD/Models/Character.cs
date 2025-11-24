using FERD.Data;
using System.Runtime.Intrinsics.X86;
using System.Text.Json.Serialization;
using static FERD.Data.Classes;

namespace FERD.Models
{
    public class Character
    {
        private Stats _totalGrowthRates;
        public string Name { get; set; } = "Mark";
        public int Level { get; set; } = 0;
        public int Experience { get; set; } = 0;
        public Stats Stats { get; set; } = new Stats();
        public Stats BaseGrowthRates { get; set; } = new Stats();
        public ClassType Class1 { get; set; } = Classes.Null;
        public ClassType Class2 { get; set; } = Classes.Null;
        public ClassType Class3 { get; set; } = Classes.Null;
        public CombatStats CombatStats
        {
            get
            {
                // Weapon accuracy + (Skill x 2) + weapon rank
                int hit = (SelectedItem.Hit  + (Stats.SKL * 2) + 0);
                hit -= 100; // So we can get just the 'bonus'
                hit /= 5;   // To scale it from a percentage to a number better suited for a 'D20' roll

                // Weapon critical + (skill / 2) + class bonus + weapon rank
                int crt = SelectedItem.Crt + (Stats.SKL / 2) + 0 + 0;
                crt /= 5;   // To scale it from a percentage to a number better suited for a 'D20' roll

                // Weapon might + Strength/Magic
                int dmg = SelectedItem.Mt + Stats.SM;

                // Speed - weapon weight
                int att_spd = Stats.SPD - Math.Max(SelectedItem.Wt - (Stats.SM / 2), 0);

                // (Attack Speed + weapon rank) x 2 
                int avd = att_spd; // * 2;

                return new CombatStats()
                {
                    HIT = hit,
                    CRT = crt,
                    AVD = avd,
                    AS = att_spd,
                    DMG = dmg,
                    DEF = this.Stats.DEF,
                    RES = this.Stats.RES,
                };
            }
        }

        [JsonIgnore]
        public int MOV
        {
            get
            {
                return Math.Max(Math.Max(Class1.Move, Class2.Move), Class3.Move);
            }
        }

        [JsonIgnore]
        public string[] AllowedWeapons
        {
            get
            {
                return this.Class1.Weapons.Union(this.Class2.Weapons).Union(this.Class3.Weapons).ToArray();
            }
        }

        public Dictionary<string, int> WeaponRanks
        {
            get
            {
                List<string> weapons = [.. this.Class1.Weapons, .. this.Class2.Weapons, .. this.Class3.Weapons];
                Dictionary<string, int> ranks = new Dictionary<string, int>
                {
                    { Weapons.SWORDS, 0 },
                    { Weapons.AXES, 0 },
                    { Weapons.LANCES, 0 },
                    { Weapons.BOWS, 0 },
                    { Weapons.ANIMA, 0 },
                    { Weapons.LIGHT, 0 },
                    { Weapons.DARK, 0 },
                    { Weapons.STAVES, 0 }
                };

                foreach (string weapon in weapons)
                {
                    ranks[weapon]++;
                }
                return ranks;
            }
        }

        [JsonIgnore]
        public bool IsSelectedWeaponAllowed
        {
            get
            {
                return this.AllowedWeapons.Contains(this.SelectedItem.Type);
            }
        }

        public Inventory Inventory { get; set; } = new Inventory();

        [JsonIgnore]
        public Item SelectedItem { get; set; } = Items.Empty;

        [JsonIgnore]
        public Stats TotalGrowthRates 
        {
            get
            {
                if (_totalGrowthRates == null)
                {
                    recalculateGrowthRates();
                }

                return _totalGrowthRates;
            }
        }

        public void recalculateGrowthRates()
        {
            _totalGrowthRates = new Stats()
            {
                HP = BaseGrowthRates.HP + Class1.GrowthRates.HP + Class2.GrowthRates.HP + Class3.GrowthRates.HP,
                SM = BaseGrowthRates.SM + Class1.GrowthRates.SM + Class2.GrowthRates.SM + Class3.GrowthRates.SM,
                SKL = BaseGrowthRates.SKL + Class1.GrowthRates.SKL + Class2.GrowthRates.SKL + Class3.GrowthRates.SKL,
                SPD = BaseGrowthRates.SPD + Class1.GrowthRates.SPD + Class2.GrowthRates.SPD + Class3.GrowthRates.SPD,
                DEF = BaseGrowthRates.DEF + Class1.GrowthRates.DEF + Class2.GrowthRates.DEF + Class3.GrowthRates.DEF,
                RES = BaseGrowthRates.RES + Class1.GrowthRates.RES + Class2.GrowthRates.RES + Class3.GrowthRates.RES
            };
        }
    }
}
