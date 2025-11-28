using FERD.Models;

namespace FERD.Helpers
{
    public static class FormHelper
    {
        private static readonly Dictionary<string, string> _featDefs = new Dictionary<string, string>()
        {
            { "Armoured",        "Vulnerable to weapons that are effective against armoured units" },
            { "Climber",         "Can traverse mountains as if it  were rough terrain" },
            { "Critical Hitter", "-3 to critical hit DC" },
            { "Dragon",          "Vulnerable to weapons that are effective against dragon units" },
            { "Focus",           "Ignore the weapon triangle, you have advantage on all attacks" },
            { "Horseback",       "Vulnerable to weapons that are effective against horseback units" },
            { "Mount",           "-2 Movement in rough terrain, cannot traverse hills" },
            { "Mount (Flying)",  "Can traverse over any terrain unaffected, vulnerable to bows" },
            { "Mount (Sturdy)",  "-2 Movement in rough terrain" },
            { "Silence",         "-1 to critical hit DC, when you crit you have a 1/2 chance to do x5 damage" },
            { "Steal",           "Instead of attacking, you may steal a non-weapon item from an enemy" },
            { "Summon",          "Summon a melee minion with STR = your MAG/2, and your HIT" },
            { "Sure Strike",     "+3 to HIT" },
            { "Swimmer",         "Can traverse water as if it were rough terrain" }
        };

        public static void AddFeatures(this TextBox tb, string[] features)
        {
            tb.Text = "";
            string caption = "";
            foreach (var feature in features)
            {
                if (!string.IsNullOrEmpty(feature))
                {
                    tb.Text += $"{feature}{Environment.NewLine}";
                    caption += $"{feature.PadRight(15)}: {_featDefs[feature]}{Environment.NewLine}";
                }
            }

            if (!string.IsNullOrEmpty(caption))
            {
                tb.setToolTip(caption);
            }
        }
    }
}