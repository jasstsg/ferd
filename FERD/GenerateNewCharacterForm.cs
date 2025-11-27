using FERD.Data;
using FERD.Helpers;
using FERD.Models;

namespace FERD
{
    public partial class GenerateNewCharacterForm : StatSelectionFormBase
    {

        private MainForm _mainForm;
        private Character c = new Character();
        public GenerateNewCharacterForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            this.labelStatsTotal = label_statsTotal;
            this.numberBoxHp = numberBox_hp;
            this.numberBoxSm = numberBox_sm;
            this.numberBoxSkl = numberBox_skl;
            this.numberBoxSpd = numberBox_spd;
            this.numberBoxDef = numberBox_def;
            this.numberBoxRes = numberBox_res;
            c.initClassDropdowns(comboBox_class1, comboBox_class2, comboBox_class3, true);
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
            numberBoxHp.setHpToolTip();
            numberBoxSm.setSmToolTip();
            numberBoxSkl.setSklToolTip();
            numberBoxSpd.setSpdToolTip();
            numberBoxDef.setDefToolTip();
            numberBoxRes.setResToolTip();
        }

        private void comboBox_class1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_class2.initClassDropdown(comboBox_class1.getSubclasses(), true);
        }

        private void comboBox_class2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_class3.initClassDropdown(comboBox_class2.getSubclasses(), true);
        }

        private void comboBox_class3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveAndOpenCharacter()
        {
            if (c.save())
            {
                // Refresh the character list on the main form
                _mainForm.loadCharacters();

                // Open the character form with the new character
                CharacterForm cf = new CharacterForm(c);
                cf.Show();

                // Close this form
                this.Close();
            }
        }

        private bool setNameLevelAndClass()
        {
            c.Name = textBox_Name.Text;
            c.Level = (int)numberBox_level.Value;

            if (comboBox_class1.IsClassSetToNull())
            {
                MessageBox.Show("Please select the your tier 1 class promotion before continuing");
                return false;
            }
            else if (comboBox_class2.IsClassSetToNull() && c.Level > Classes.PromotionLevel.TIER2)
            {
                MessageBox.Show("Please select the your tier 2 class promotion before continuing");
                return false;
            }
            else if (comboBox_class3.IsClassSetToNull() && c.Level > Classes.PromotionLevel.TIER3)
            {
                MessageBox.Show("Please select the your tier 3 class promotion before continuing");
                return false;
            }

            c.Class1 = comboBox_class1.GetSelectedClass();
            c.Class2 = comboBox_class2.GetSelectedClass();
            c.Class3 = comboBox_class3.GetSelectedClass();
            return true;
        }

        private void button_useStatsAndGenerate_Click(object sender, EventArgs e)
        {
            // Set base stats from form
            c.Stats.HP = (int)this.numberBoxHp.Value;
            c.Stats.SM = (int)this.numberBoxSm.Value;
            c.Stats.SKL = (int)this.numberBoxSkl.Value;
            c.Stats.SPD = (int)this.numberBoxSpd.Value;
            c.Stats.DEF = (int)this.numberBoxDef.Value;
            c.Stats.RES = (int)this.numberBoxRes.Value;

            if (setNameLevelAndClass())
            {
                c.simulateLevelUp(0, c.Level);
                saveAndOpenCharacter();
            }
        }

        private void button_randomStatsAndGenerate_Click(object sender, EventArgs e)
        {
            // Set base stats to minimum values
            c.Stats.HP = 15;
            c.Stats.SM = 0;
            c.Stats.SKL = 0;
            c.Stats.SPD = 0;
            c.Stats.DEF = 0;
            c.Stats.RES = 0;

            // Randomly allocate the remaining points
            c.randomlySetStats(35);

            if (setNameLevelAndClass())
            {
                c.simulateLevelUp(0, c.Level);
                saveAndOpenCharacter();
            }
        }
    }
}
