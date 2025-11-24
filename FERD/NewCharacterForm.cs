
using FERD.Data;
using FERD.Helpers;
using FERD.Models;

namespace FERD
{
    public partial class NewCharacterForm : Form
    {
        private int TOTAL_LIMIT = 50;
        private int hp { get; set; } = 15;
        private int sm { get; set; } = 0;
        private int skl { get; set; } = 0;
        private int spd { get; set; } = 0;
        private int def { get; set; } = 0;
        private int res { get; set; } = 0;
        private int total { get; set; } = 15;

        public NewCharacterForm()
        {
            InitializeComponent();
            comboBox_class.initClassDropdown(Classes.Tier1, true);
        }

        public int updateStatValue(NumericUpDown numberBox, int previousValue)
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
            label_statsTotal.Text = $"{total} / 50";
            return previousValue + delta;
        }

        public void numberBox_hp_changed(object sender, EventArgs e)
        {
            hp = updateStatValue(numberBox_hp, hp);
        }

        public void numberBox_sm_changed(object sender, EventArgs e)
        {
            sm = updateStatValue(numberBox_sm, sm);
        }

        public void numberBox_skl_changed(object sender, EventArgs e)
        {
            skl = updateStatValue(numberBox_skl, skl);
        }

        public void numberBox_spd_changed(object sender, EventArgs e)
        {
            spd = updateStatValue(numberBox_spd, spd);
        }

        public void numberBox_def_changed(object sender, EventArgs e)
        {
            def = updateStatValue(numberBox_def, def);
        }

        public void numberBox_res_changed(object sender, EventArgs e)
        {
            res = updateStatValue(numberBox_res, res);
        }

        private void button_createCharacter_Click(object sender, EventArgs e)
        {
            // Do validation
            if (comboBox_class.IsClassSetToNull())
            {
                MessageBox.Show("Please select a class");
                return;
            }

            // Create the character object
            Character c = new Character()
            {
                Name = textBox_Name.Text,
                Class1 = Classes.ClassMap[comboBox_class.SelectedValue.ToString()],
                Stats = new Stats()
                {
                    HP = hp,
                    SM = sm,
                    SKL = skl,
                    SPD = spd,
                    DEF = def,
                    RES = res
                }
            };

            // Try to save the character
            if (!c.save(true))
            {
                return;
            }

            // Open the character form with the new character
            CharacterForm cf = new CharacterForm(c);
            cf.Show();

            // Close this form
            this.Close();
        }

        private void comboBox_class_MouseHover(object sender, EventArgs e)
        {

        }

        private void comboBox_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_classDescription.Text = comboBox_class.GetSelectedClass().Description;
        }
    }
}
