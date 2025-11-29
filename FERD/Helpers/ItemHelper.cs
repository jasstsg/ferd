namespace FERD.Helpers
{
    public static class ItemHelper
    {
        public static string WeaponSkillToGrade(int weaponSkill)
        {
            switch (weaponSkill)
            {
                case 1: return "D";
                case 2: return "B";
                case 3: return "S";
                default: return "-";
            }
        }

        public static int WeaponGradeToSkill(string weaponGrade)
        {
            switch (weaponGrade)
            {
                case "S":
                case "A": 
                    return 3;
                case "B":
                case "C":
                    return 2;
                case "D":
                case "E":
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
