using FERD.Controls;
using FERD.Data;
using FERD.Helpers;
using FERD.Models;

namespace FERD
{
    public partial class CharacterForm : Form
    {
        private Character? _character = null;
        private int _selectedInvSlot;
        private bool _formLoading = true;

        private InventorySlot[] InventorySlots => [invSlot1, invSlot2, invSlot3, invSlot4, invSlot5];
        public CharacterForm() : this(new Character()) { }

        public CharacterForm(Character c)
        {
            InitializeComponent();
            updateCharacter(c);
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

        private string GetWeaponRankDisplay(string weaponType)
        {
            return ItemHelper.WeaponSkillToGrade(_character.WeaponRanks[weaponType]);
        }

        private void initInventory()
        {
            Slot slot;
            for (int i = 0; i < InventorySlots.Length; i++)
            {
                slot = _character.Inventory[i + 1];
                InventorySlots[i].SetSelectedItem(slot.Name, slot.Uses);
                InventorySlots[i].SetDisplay(_character);
            }
        }

        private void initCombatStats()
        {
            string hit = " - ";
            string crt = " - ";
            string att_spd = " - ";
            string dmg = " - ";

            if (_character.IsEquippedWeaponAllowed)
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

        private void equipInvSlot(int slotNum)
        {
            _selectedInvSlot = slotNum;
            InventorySlot selectedInvSlot = InventorySlots[slotNum - 1];
            Item prevEquippedItem = _character.EquippedItem;

            // Return early if no item in selected slot, or it is not equippable 
            _character.EquippedItem = selectedInvSlot.GetSelectedItem();
            if (_character.EquippedItem.IsEmpty || !_character.IsEquippedWeaponAllowed)
            {
                _character.EquippedItem = prevEquippedItem;
                return;
            }

            // Reassess all slots
            foreach (InventorySlot inv in InventorySlots)
            {
                inv.SetDisplay(_character);
            }

            // Higlight selected slot
            selectedInvSlot.DisplaySelected();

            // Set description
            textBox_selectedItemDesc.Text =
                $"{_character.EquippedItem.Name}" +
                (!string.IsNullOrEmpty(_character.EquippedItem.Rank) ? $", Rank : {_character.EquippedItem.Rank}" : "") +
                $", Range: {_character.EquippedItem.Range}" +
                $"{Environment.NewLine}{_character.EquippedItem.Effects}";

            initCombatStats();
        }

        private void onItemChanged(int slotNum)
        {
            // Update Selected Inventory Slot
            if (_selectedInvSlot == slotNum)
            {
                equipInvSlot(_selectedInvSlot);
            }

            // Save Character (but only if the form has initialized already)
            if (_formLoading)
            {
                return;
            }

            // Update inventory slot on the form
            InventorySlot slot = InventorySlots[slotNum - 1];
            slot.OnSelectedItemChanged();

            // Update character inventory data
            _character.Inventory[slotNum].Set(InventorySlots[slotNum - 1]);
            FileHelper.save(_character);

            // Determine display behaviour for this slot
            slot.SetDisplay(_character);
        }

        private void OnValueChanged(int slotNum)
        {
            _character.Inventory[slotNum].Uses = (int)InventorySlots[slotNum - 1].NumberBox.Value;
            FileHelper.save(_character);
        }

        private void button_selectInv1_Click(object sender, EventArgs e)
        {
            equipInvSlot(1);
        }

        private void button_selectInv2_Click(object sender, EventArgs e)
        {
            equipInvSlot(2);
        }

        private void button_selectInv3_Click(object sender, EventArgs e)
        {
            equipInvSlot(3);
        }

        private void button_selectInv4_Click(object sender, EventArgs e)
        {
            equipInvSlot(4);
        }

        private void button_selectInv5_Click(object sender, EventArgs e)
        {
            equipInvSlot(5);
        }

        private void inv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            onItemChanged(1);
        }

        private void inv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            onItemChanged(2);
        }

        private void inv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            onItemChanged(3);
        }

        private void inv4_SelectedIndexChanged(object sender, EventArgs e)
        {
            onItemChanged(4);
        }

        private void inv5_SelectedIndexChanged(object sender, EventArgs e)
        {
            onItemChanged(5);
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

        private void invSlot1_ValueChanged(object sender, EventArgs e)
        {
            OnValueChanged(1);
        }

        private void invSlot2_ValueChanged(object sender, EventArgs e)
        {
            OnValueChanged(2);
        }

        private void invSlot3_ValueChanged(object sender, EventArgs e)
        {
            OnValueChanged(3);
        }

        private void invSlot4_ValueChanged(object sender, EventArgs e)
        {
            OnValueChanged(4);
        }

        private void invSlot5_ValueChanged(object sender, EventArgs e)
        {
            OnValueChanged(5);
        }
    }
}
