
namespace FERD.Helpers
{
    public static class ToolTipHelper
    {
        static readonly string HP_CAPTION = "The amount of hit points you have (the amount of damage you can take).  When this reaches zero, you die.";
        static readonly string SM_CAPTION = "The amount of strength (for martial classes) or magic (for magic classes) points you have.  This impacts the amount of damage you can inflict.";
        static readonly string SKL_CAPTION = "The amount of skill points you have.  This impacts your chance of hitting (accuracy) and your chance of landing a critical hit.";
        static readonly string SPD_CAPTION = "The amount of speed points you have.  This impacts your ability to attack twice in a single round of combat, and your chance of avoiding being hit.";
        static readonly string DEF_CAPTION = "The amount of defense points you have.  This reduces the amount of damage you take from martial weapons.";
        static readonly string RES_CAPTION = "The amount of resistance points you have.  This reduces the amount of damage you take from magical weapons.";
        public static void setToolTip(this Control control, string caption)
        {
            ToolTip tt = new ToolTip();
            tt.AutoPopDelay = 5000;
            tt.InitialDelay = 500;
            tt.ReshowDelay = 500;
            tt.ShowAlways = true;
            tt.SetToolTip(control, caption);
        }

        public static void setHpToolTip(this Control control)
        {
            control.setToolTip(HP_CAPTION);
        }

        public static void setSmToolTip(this Control control)
        {
            control.setToolTip(SM_CAPTION);
        }
        public static void setSklToolTip(this Control control)
        {
            control.setToolTip(SKL_CAPTION);
        }
        public static void setSpdToolTip(this Control control)
        {
            control.setToolTip(SPD_CAPTION);
        }
        public static void setDefToolTip(this Control control)
        {
            control.setToolTip(DEF_CAPTION);
        }
        public static void setResToolTip(this Control control)
        {
            control.setToolTip(RES_CAPTION);
        }
    }
}
