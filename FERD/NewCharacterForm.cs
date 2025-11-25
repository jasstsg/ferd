
using FERD.Data;
using FERD.Helpers;
using FERD.Models;

namespace FERD
{

    public partial class NewCharacterForm : StatSelectionFormBase
    {
        private MainForm _mainForm;

        public NewCharacterForm(MainForm mainForm)
        {
            InitializeComponent();
            this._mainForm = mainForm;
            this.labelStatsTotal = label_statsTotal;
            this.numberBoxHp = numberBox_hp;
            this.numberBoxSm = numberBox_sm;
            this.numberBoxSkl = numberBox_skl;
            this.numberBoxSpd = numberBox_spd;
            this.numberBoxDef = numberBox_def;
            this.numberBoxRes = numberBox_res;
            comboBox_class.initClassDropdown(Classes.Tier1, true);
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
            if (!c.save())
            {
                return;
            }

            // Refresh the character list on the main form
            _mainForm.loadCharacters();

            // Open the character form with the new character
            CharacterForm cf = new CharacterForm(c);
            cf.Show();

            // Close this form
            this.Close();
        }


        private void comboBox_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_classDescription.Text = comboBox_class.GetSelectedClass().Description;
        }
    }
}
