using FERD.Data;
using FERD.Models;

namespace FERD.Helpers
{
    public static class LevelUpHelper
    {
        public static bool rollStat(this Character c, int statIndex)
        {

            // If the stat is not HP and is at 40, then prevent it from getting any higher
            if (statIndex != 0 && c.Stats[statIndex] >= 40)
            {
                return false;
            }

            int growthRate = c.TotalGrowthRates[statIndex];

            // If the growth rate is more than 100%, get the guaranteed increase
            int statIncrease = growthRate / 100;

            // If the growth rate is more than 100%, get the ramainder for the non-guaranteed increase chance
            int statIncreaseChance = growthRate % 100;

            // If the random int is less or equal to the increase change, increment the statIncrease
            if (new Random().Next(0, 101) <= statIncreaseChance)
            {
                statIncrease++;
            }

            // Increase the character's stat
            c.Stats[statIndex] += statIncrease;

            // Return success status
            return statIncrease > 0;
        }

        public static void rollStats(this Character c)
        {
            for (int i = 0; i < c.Stats.Length; i++)
            {
                c.rollStat(i);
            }
        }

        public static void simulateLevelUp(this Character c, int fromLevel, int toLevel)
        {
            // Initialize temp data to use in simulation
            Character temp = new Character();
            temp.Stats = c.Stats.Copy();
            temp.Class1 = c.Class1;
            temp.recalculateGrowthRates();

            for (int level = fromLevel; level < toLevel; level++)
            {
                if (temp.Class2.Equals(Classes.Empty) && level >= Classes.PromotionLevel.TIER2 + 1)
                {
                    temp.Class2 = c.Class2;
                    temp.recalculateGrowthRates();
                }
                else if (temp.Class3.Equals(Classes.Empty) && level >= Classes.PromotionLevel.TIER3 + 1)
                {
                    temp.Class3 = c.Class3;
                    temp.recalculateGrowthRates();
                }

                temp.rollStats();
            }

            // Set results to the character
            c.Stats = temp.Stats;
        }

        public static void randomlySetStats(this Character c, int statPointsToSet)
        {
            for (int i = 0; i < statPointsToSet; i++)
            {
                c.Stats[(new Random().Next(0, 6))]++;
            }
        }
    }
}
