namespace FERD.Models
{
    public class CombatStats
    {
        // Hit chance / Accuracy
        public int HIT { get; set; } = 0;

        // Critical hit chance
        public int CRT { get; set; } = 0;

        // Avoid / Dodge chance
        public int AVD { get; set; } = 0;

        // Attack speed / Agility
        public int AS { get; set; } = 0;

        // Damage
        public int DMG { get; set; } = 0;

        // Defense
        public int DEF { get; set; } = 0;

        // Resistance 
        public int RES { get; set; } = 0;

    }
}
