using FERD.Data;
using FERD.Helpers;
using FERD.Models;

namespace FERD
{
    public partial class CharacterForm : Form
    {
        private Character? _character = null;
        private ComboBox[] _invSlots;
        private int _selectedInvSlot;
        private bool _formLoading = true;
        public CharacterForm() : this(new Character()) { }

        public CharacterForm(Character c)
        {
            InitializeComponent();
            updateCharacter(c);
            _invSlots = [inv1, inv2, inv3, inv4, inv5, inv6, inv7, inv8, inv9, inv10];
            _formLoading = false;
            setToolTips();
            pictureBox_portrait.Image = c.Portrait;
        }
        private void setToolTips()
        {
            label_hp.setHpToolTip();
            label_sm.setSmToolTip();
            label_skl.setSklToolTip();
            label_spd.setSpdToolTip();
            label_def.setDefToolTip();
            label_res.setResToolTip();
            label_mov.setToolTip("The number of places you can move in a single turn");
            pictureBox_swords.setToolTip("Your expertise with swords.  You can only use weapons of this type that are of the same grade or lower");
            pictureBox_axes.setToolTip("Your expertise with axes.  You can only use weapons of this type that are of the same grade or lower");
            pictureBox_lances.setToolTip("Your expertise with lances.  You can only use weapons of this type that are of the same grade or lower");
            pictureBox_bows.setToolTip("Your expertise with bows.  You can only use weapons of this type that are of the same grade or lower");
            pictureBox_anima.setToolTip("Your expertise with anima magic.  You can only use weapons of this type that are of the same grade or lower");
            pictureBox_light.setToolTip("Your expertise with light magic.  You can only use weapons of this type that are of the same grade or lower");
            pictureBox_dark.setToolTip("Your expertise with dark magic.  You can only use weapons of this type that are of the same grade or lower");
            pictureBox_staves.setToolTip("Your expertise with staves.  You can only use weapons of this type that are of the same grade or lower");
            label_hit.setToolTip("Your hit rate (accuracy) bonus");
            label_crt.setToolTip("If you hit the roll needed land a critical hit");
            label_dmg.setToolTip("The amount of damage you will do with your current weapon (minus your target's def/res)");
            label_as.setToolTip("Your attack speed in combat.  If it is 4+ more than your opponent's, you attack twice");
            label_avd.setToolTip("The roll an opponent must make in order to hit you");
            label_defCombat.setToolTip("Your defense stat.  If you are hit by a martial weapon, reduce the damage taken by this amount.");
            label_resCombat.setToolTip("Your resistance stat.  If you are hit by a magic weapon, reduce the damage taken by this amount.");
            label_movCombat.setToolTip("The number of places you can move in a single turn");
            button_levelUp.setToolTip("You can level up once you have 100 or more experience!");
        }

        public void updateCharacter(Character c)
        {
            _character = c;
            initFormFields();
        }

        private void initFormFields()
        {
            groupBox_characterDetails.Text = $"{_character.Name} - Level {_character.Level}";
            numberBox_exp.Value = _character.Experience;
            textBox_features.AddFeatures(_character.Features);
            _character.initClassDropdowns(comboBox_class1, comboBox_class2, comboBox_class3);
            initStats();
            initCombatStats();
            initInventory();
            initWeaponRanks();
            initLevelUpButton();
        }

        private void initLevelUpButton(bool disable = false)
        {
            if (!disable && _character.Experience >= 100)
            {
                button_levelUp.Enabled = true;
                button_levelUp.ForeColor = Color.Black;
            }
            else
            {
                button_levelUp.Enabled = false;
                button_levelUp.ForeColor = Color.DarkGray;
            }
        }

        private void initWeaponRanks()
        {
            table_weaponRanks.AddText(GetWeaponRankDisplay(Weapons.SWORDS), 1, 0);
            table_weaponRanks.AddText(GetWeaponRankDisplay(Weapons.AXES), 1, 1);
            table_weaponRanks.AddText(GetWeaponRankDisplay(Weapons.LANCES), 1, 2);
            table_weaponRanks.AddText(GetWeaponRankDisplay(Weapons.BOWS), 1, 3);
            table_weaponRanks.AddText(GetWeaponRankDisplay(Weapons.ANIMA), 3, 0);
            table_weaponRanks.AddText(GetWeaponRankDisplay(Weapons.LIGHT), 3, 1);
            table_weaponRanks.AddText(GetWeaponRankDisplay(Weapons.DARK), 3, 2);
            table_weaponRanks.AddText(GetWeaponRankDisplay(Weapons.STAVES), 3, 3);
        }

        private string WeaponSkillToGrade(int weaponSkill)
        {
            switch (weaponSkill)
            {
                case 1: return "D";
                case 2: return "B";
                case 3: return "S";
                default: return "-";
            }
        }

        private string GetWeaponRankDisplay(string weaponType)
        {
            return WeaponSkillToGrade(_character.WeaponRanks[weaponType]);
        }

        private void initInventory()
        {
            inv1.initInvDropdown(_character.Inventory.Slot1);
            inv2.initInvDropdown(_character.Inventory.Slot2);
            inv3.initInvDropdown(_character.Inventory.Slot3);
            inv4.initInvDropdown(_character.Inventory.Slot4);
            inv5.initInvDropdown(_character.Inventory.Slot5);
            inv6.initInvDropdown(_character.Inventory.Slot6);
            inv7.initInvDropdown(_character.Inventory.Slot7);
            inv8.initInvDropdown(_character.Inventory.Slot8);
            inv9.initInvDropdown(_character.Inventory.Slot9);
            inv10.initInvDropdown(_character.Inventory.Slot10);
        }

        private void initCombatStats()
        {
            string hit = " - ";
            string crt = " - ";
            string att_spd = " - ";
            string dmg = " - ";

            if (_character.IsSelectedWeaponAllowed)
            {
                hit = _character.CombatStats.HIT.ToString();
                hit = _character.CombatStats.HIT > 0 ? "+" + hit : hit;

                crt = $"Nat {21 - _character.CombatStats.CRT}+";
                att_spd = $"{_character.CombatStats.AS}";
                dmg = $"{_character.CombatStats.DMG}";
            }

            table_combatStats.AddText(hit, 1, 0);
            table_combatStats.AddText(crt, 1, 1);
            table_combatStats.AddText(dmg, 1, 2);
            table_combatStats.AddText(att_spd, 1, 3);
            table_combatStats.AddText(_character.CombatStats.AVD, 1, 4);
            table_combatStats.AddText(_character.CombatStats.DEF, 1, 5);
            table_combatStats.AddText(_character.CombatStats.RES, 1, 6);
            table_combatStats.AddText(_character.MOV, 1, 7);
        }

        private void initStats()
        {
            table_stats.AddText(_character.Stats.HP, 1, 0);
            table_stats.AddText(_character.Stats.SM, 1, 1);
            table_stats.AddText(_character.Stats.SKL, 1, 2);
            table_stats.AddText(_character.Stats.SPD, 1, 3);
            table_stats.AddText(_character.Stats.DEF, 1, 4);
            table_stats.AddText(_character.Stats.RES, 1, 5);
            table_stats.AddText(_character.MOV, 1, 6);
        }

        private void button_levelUp_Click(object sender, EventArgs e)
        {
            LevelUpForm f = new LevelUpForm(_character, this);
            initLevelUpButton(true);
            f.Show();
        }

        private void numberBox_exp_ValueChanged(object sender, EventArgs e)
        {
            _character.Experience = (int)numberBox_exp.Value;
            FileHelper.save(_character);

            initLevelUpButton();
        }

        private void selectInvSlots(int slotNum)
        {
            _selectedInvSlot = slotNum;
            ComboBox selectedInvSlot = _invSlots[slotNum - 1];

            // Return early if no item in selected slot
            _character.SelectedItem = selectedInvSlot.GetSelectedItem();
            if (_character.SelectedItem.Name.Equals(Items.Empty.Name))
            {
                return;
            }

            // Unhighlight all slots
            foreach (ComboBox inv in _invSlots)
            {
                inv.BackColor = SystemColors.Window;
            }

            // Higlight selected slot
            selectedInvSlot.BackColor = Color.LightBlue;

            // Set description
            textBox_selectedItemDesc.Text =
                $"{_character.SelectedItem.Name}" +
                (!string.IsNullOrEmpty(_character.SelectedItem.Rank) ? $", Rank : {_character.SelectedItem.Rank}" : "") +
                $", Range: {_character.SelectedItem.Range}" +
                $"{Environment.NewLine}{_character.SelectedItem.Effects}";

            initCombatStats();
        }

        private void onItemChanged(int slotNum)
        {
            // Update Selected Inventory Slot
            if (_selectedInvSlot == slotNum)
            {
                selectInvSlots(_selectedInvSlot);
            }

            // Save Character (but only if the form has initialized already)
            if (_formLoading)
            {
                return;
            }
            _character.Inventory[slotNum] = _invSlots[slotNum - 1].GetSelectedItem().Name;
            FileHelper.save(_character);
        }

        private void button_selectInv1_Click(object sender, EventArgs e)
        {
            selectInvSlots(1);
        }

        private void button_selectInv2_Click(object sender, EventArgs e)
        {
            selectInvSlots(2);
        }

        private void button_selectInv3_Click(object sender, EventArgs e)
        {
            selectInvSlots(3);
        }

        private void button_selectInv4_Click(object sender, EventArgs e)
        {
            selectInvSlots(4);
        }

        private void button_selectInv5_Click(object sender, EventArgs e)
        {
            selectInvSlots(5);
        }

        private void button_selectInv6_Click(object sender, EventArgs e)
        {
            selectInvSlots(6);
        }

        private void button_selectInv7_Click(object sender, EventArgs e)
        {
            selectInvSlots(7);
        }

        private void button_selectInv8_Click(object sender, EventArgs e)
        {
            selectInvSlots(8);
        }

        private void button_selectInv9_Click(object sender, EventArgs e)
        {
            selectInvSlots(9);
        }

        private void button_selectInv10_Click(object sender, EventArgs e)
        {
            selectInvSlots(10);
        }

        private void inv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.Inventory[1] = inv1.GetSelectedItem().Name;
            onItemChanged(1);
        }

        private void inv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.Inventory[2] = inv2.GetSelectedItem().Name;
            onItemChanged(2);
        }

        private void inv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.Inventory[3] = inv3.GetSelectedItem().Name;
            onItemChanged(3);
        }

        private void inv4_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.Inventory[4] = inv4.GetSelectedItem().Name;
            onItemChanged(4);
        }

        private void inv5_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.Inventory[5] = inv5.GetSelectedItem().Name;
            onItemChanged(5);
        }

        private void inv6_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.Inventory[6] = inv6.GetSelectedItem().Name;
            onItemChanged(6);
        }

        private void inv7_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.Inventory[7] = inv7.GetSelectedItem().Name;
            onItemChanged(7);
        }

        private void inv8_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.Inventory[8] = inv8.GetSelectedItem().Name;
            onItemChanged(8);
        }

        private void inv9_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.Inventory[9] = inv9.GetSelectedItem().Name;
            onItemChanged(9);
        }

        private void inv10_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.Inventory[10] = inv10.GetSelectedItem().Name;
            onItemChanged(10);
        }

        private void button_uploadPortrait_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image newPortrait = Image.FromFile(openFileDialog.FileName);
                        _character.Portrait = newPortrait;
                        pictureBox_portrait.Image = newPortrait;
                        _character.save();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
