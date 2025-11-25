namespace FERD
{
    public class StatSelectionFormBase : Form
    {
        protected int TOTAL_LIMIT = 50;
        protected int hp { get; set; } = 15;
        protected int sm { get; set; } = 0;
        protected int skl { get; set; } = 0;
        protected int spd { get; set; } = 0;
        protected int def { get; set; } = 0;
        protected int res { get; set; } = 0;
        protected int total { get; set; } = 15;
        protected Label labelStatsTotal { get; set; }
        protected NumericUpDown numberBoxHp { get; set; }
        protected NumericUpDown numberBoxSm { get; set; }
        protected NumericUpDown numberBoxSkl { get; set; }
        protected NumericUpDown numberBoxSpd { get; set; }
        protected NumericUpDown numberBoxDef { get; set; }
        protected NumericUpDown numberBoxRes { get; set; }


        protected int updateStatValue(NumericUpDown numberBox, int previousValue)
        {
            // Get the change in value
            int delta = (int)numberBox.Value - previousValue;

            // Get the new total
            int newTotal = total + delta;

            // If the new total is greater than the limit, set the value back to previous value and return it
            if (newTotal > TOTAL_LIMIT)
            {
                numberBox.Value = previousValue;
                return previousValue;
            }

            // Otherwise record the new total and return the new value
            total = newTotal;
            labelStatsTotal.Text = $"{total} / 50";
            return previousValue + delta;
        }

        public void numberBox_hp_changed(object sender, EventArgs e)
        {
            hp = updateStatValue(numberBoxHp, hp);
        }

        public void numberBox_sm_changed(object sender, EventArgs e)
        {
            sm = updateStatValue(numberBoxSm, sm);
        }

        public void numberBox_skl_changed(object sender, EventArgs e)
        {
            skl = updateStatValue(numberBoxSkl, skl);
        }

        public void numberBox_spd_changed(object sender, EventArgs e)
        {
            spd = updateStatValue(numberBoxSpd, spd);
        }

        public void numberBox_def_changed(object sender, EventArgs e)
        {
            def = updateStatValue(numberBoxDef, def);
        }

        public void numberBox_res_changed(object sender, EventArgs e)
        {
            res = updateStatValue(numberBoxRes, res);
        }
    }
}
