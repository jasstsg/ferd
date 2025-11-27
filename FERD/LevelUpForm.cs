using FERD.Data;
using FERD.Helpers;
using FERD.Models;

namespace FERD
{
    public partial class LevelUpForm : Form
    {
        private Character _character;
        private CharacterForm _characterForm;
        public LevelUpForm(Character c, CharacterForm cf)
        {
            InitializeComponent();
            _character = c;
            _characterForm = cf;
            initFields();
            setToolTips();
        }

        private void setToolTips()
        {
            label_hp.setHpToolTip();
            label_sm.setSmToolTip();
            label_skl.setSklToolTip();
            label_spd.setSpdToolTip();
            label_def.setDefToolTip();
            label_res.setResToolTip();
            label_hpValue.setHpToolTip();
            label_smValue.setSmToolTip();
            label_sklValue.setSklToolTip();
            label_spdValue.setSpdToolTip();
            label_defValue.setDefToolTip();
            label_resValue.setResToolTip();
        }

        private void initFields()
        {
            this.Text = $"{_character.Name} is leveling up!";
            label_levelUpText.Text = $"Level {_character.Level} -> {_character.Level + 1} ";
            _character.initClassDropdowns(comboBox_class1, comboBox_class2, comboBox_class3);

            if (_character.Level == Classes.PromotionLevel.TIER2)
            {
                comboBox_class2.Enabled = true;
                comboBox_class2.ForeColor = Color.Black;
                label_levelUpText.Text += "and promote to tier 2";
            }
            else if (_character.Level == Classes.PromotionLevel.TIER3)
            {
                comboBox_class3.Enabled = true;
                comboBox_class3.ForeColor = Color.Black;
                label_levelUpText.Text += "and promote to tier 3";
            }

            initStats();
        }

        private void initStats()
        {
            label_hpValue.Text = _character.Stats.HP.ToString();
            label_smValue.Text = _character.Stats.SM.ToString();
            label_sklValue.Text = _character.Stats.SKL.ToString();
            label_spdValue.Text = _character.Stats.SPD.ToString();
            label_defValue.Text = _character.Stats.DEF.ToString();
            label_resValue.Text = _character.Stats.RES.ToString();
        }

        private async void button_startLevelUp_Click(object sender, EventArgs e)
        {
            // Disable start level up button immediately after it is clicked
            button_startLevelUp.Enabled = false;
            button_startLevelUp.ForeColor = Color.DarkGray;

            // Roll for stats
            for (int row = 0; row < _character.TotalGrowthRates.Length; row++)
            {
                await Task.Delay(250);
                setStatColor(row, _character.rollStat(row) ? Color.Goldenrod : Color.DarkGray);
                initStats();
            }

            // Enable finish level up button
            button_finishLevelUp.Enabled = true;
            button_finishLevelUp.ForeColor = Color.Black;
        }

        private void setStatColor(int row, Color color)
        {
            Control label = table_stats.GetControlFromPosition(0, row);
            Control value = table_stats.GetControlFromPosition(1, row);
            label.Font = new Font(label.Font, FontStyle.Bold);
            value.Font = new Font(label.Font, FontStyle.Bold);
            label.ForeColor = color;
            value.ForeColor = color;
        }
        private void comboBox_class2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_character.Level == Classes.PromotionLevel.TIER2)
            {
                textBox_classDescription.Text = comboBox_class2.GetSelectedClass().Description;
            }
        }

        private void comboBox_class3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_character.Level == Classes.PromotionLevel.TIER3)
            {
                textBox_classDescription.Text = comboBox_class3.GetSelectedClass().Description;
            }
        }

        private void button_finishLevelUp_Click(object sender, EventArgs e)
        {
            if (comboBox_class2.Enabled && comboBox_class2.IsClassSetToNull())
            {
                MessageBox.Show("Please select the your tier 2 class promotion before continuing");
                return;
            }
            else if (comboBox_class3.Enabled && comboBox_class3.IsClassSetToNull())
            {
                MessageBox.Show("Please select the your tier 3 class promotion before continuing");
                return;
            }

            // Set new classes in case of promotion
            _character.Class2 = comboBox_class2.GetSelectedClass();
            _character.Class3 = comboBox_class3.GetSelectedClass();

            // Increase level and consume 100 exp
            _character.Level++;
            _character.Experience -= 100;

            // Update the calling character form with the new character data
            _characterForm.updateCharacter(_character);

            // Try to save the character
            if (!_character.save())
            {
                return;
            }

            // Close this form
            this.Close();

        }
    }
}
