namespace FERD
{
    partial class CharacterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox_characterDetails = new GroupBox();
            button_uploadPortrait = new Button();
            groupBox8 = new GroupBox();
            invSlot5 = new FERD.Controls.InventorySlot();
            invSlot3 = new FERD.Controls.InventorySlot();
            invSlot2 = new FERD.Controls.InventorySlot();
            invSlot4 = new FERD.Controls.InventorySlot();
            invSlot1 = new FERD.Controls.InventorySlot();
            textBox_selectedItemDesc = new TextBox();
            button_levelUp = new Button();
            groupBox5 = new GroupBox();
            table_combatStats = new TableLayoutPanel();
            label_movCombat = new Label();
            label_hit = new Label();
            label_defCombat = new Label();
            label_resCombat = new Label();
            label_avd = new Label();
            label_crt = new Label();
            label_as = new Label();
            label_dmg = new Label();
            numberBox_exp = new NumericUpDown();
            label2 = new Label();
            groupBox7 = new GroupBox();
            textBox_features = new TextBox();
            groupBox4 = new GroupBox();
            comboBox_class3 = new ComboBox();
            comboBox_class2 = new ComboBox();
            comboBox_class1 = new ComboBox();
            pictureBox_portrait = new PictureBox();
            groupBox2 = new GroupBox();
            table_stats = new TableLayoutPanel();
            label_sm = new Label();
            label_skl = new Label();
            label_spd = new Label();
            label_def = new Label();
            label_res = new Label();
            label_mov = new Label();
            label_hp = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox6 = new GroupBox();
            table_weaponRanks = new TableLayoutPanel();
            pictureBox_swords = new PictureBox();
            pictureBox_axes = new PictureBox();
            pictureBox_lances = new PictureBox();
            pictureBox_bows = new PictureBox();
            pictureBox_anima = new PictureBox();
            pictureBox_light = new PictureBox();
            pictureBox_dark = new PictureBox();
            pictureBox_staves = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            label8 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label13 = new Label();
            label14 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox_characterDetails.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox5.SuspendLayout();
            table_combatStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberBox_exp).BeginInit();
            groupBox7.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_portrait).BeginInit();
            groupBox2.SuspendLayout();
            table_stats.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox6.SuspendLayout();
            table_weaponRanks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_swords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_axes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_lances).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_bows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_anima).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_light).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_dark).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_staves).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_characterDetails
            // 
            groupBox_characterDetails.Controls.Add(button_uploadPortrait);
            groupBox_characterDetails.Controls.Add(groupBox8);
            groupBox_characterDetails.Controls.Add(button_levelUp);
            groupBox_characterDetails.Controls.Add(groupBox5);
            groupBox_characterDetails.Controls.Add(numberBox_exp);
            groupBox_characterDetails.Controls.Add(label2);
            groupBox_characterDetails.Controls.Add(groupBox7);
            groupBox_characterDetails.Controls.Add(groupBox4);
            groupBox_characterDetails.Controls.Add(pictureBox_portrait);
            groupBox_characterDetails.Location = new Point(6, 6);
            groupBox_characterDetails.Name = "groupBox_characterDetails";
            groupBox_characterDetails.Size = new Size(440, 507);
            groupBox_characterDetails.TabIndex = 0;
            groupBox_characterDetails.TabStop = false;
            groupBox_characterDetails.Text = "Character Name - Level 0";
            // 
            // button_uploadPortrait
            // 
            button_uploadPortrait.Location = new Point(6, 148);
            button_uploadPortrait.Name = "button_uploadPortrait";
            button_uploadPortrait.Size = new Size(129, 25);
            button_uploadPortrait.TabIndex = 28;
            button_uploadPortrait.Text = "Upload Portrait";
            button_uploadPortrait.UseVisualStyleBackColor = true;
            button_uploadPortrait.Click += button_uploadPortrait_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(invSlot5);
            groupBox8.Controls.Add(invSlot3);
            groupBox8.Controls.Add(invSlot2);
            groupBox8.Controls.Add(invSlot4);
            groupBox8.Controls.Add(invSlot1);
            groupBox8.Controls.Add(textBox_selectedItemDesc);
            groupBox8.Location = new Point(141, 131);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(299, 269);
            groupBox8.TabIndex = 27;
            groupBox8.TabStop = false;
            groupBox8.Text = "Inventory";
            // 
            // invSlot5
            // 
            invSlot5.LabelText = "/ 00";
            invSlot5.Location = new Point(6, 239);
            invSlot5.Name = "invSlot5";
            invSlot5.NumericValue = new decimal(new int[] { 0, 0, 0, 0 });
            invSlot5.SelectedItem = null;
            invSlot5.Size = new Size(284, 23);
            invSlot5.TabIndex = 22;
            invSlot5.ButtonEquipClick += button_selectInv5_Click;
            invSlot5.ButtonUpClick += swapSlots4and5;
            invSlot5.ButtonDownClick += swapSlots5and1;
            invSlot5.ValueChanged += invSlot5_ValueChanged;
            invSlot5.SelectedIndexChanged += inv5_SelectedIndexChanged;
            invSlot5.Enter += invSlot5_Enter;
            // 
            // invSlot3
            // 
            invSlot3.LabelText = "/ 00";
            invSlot3.Location = new Point(6, 181);
            invSlot3.Name = "invSlot3";
            invSlot3.NumericValue = new decimal(new int[] { 0, 0, 0, 0 });
            invSlot3.SelectedItem = null;
            invSlot3.Size = new Size(284, 23);
            invSlot3.TabIndex = 21;
            invSlot3.ButtonEquipClick += button_selectInv3_Click;
            invSlot3.ButtonUpClick += swapSlots2and3;
            invSlot3.ButtonDownClick += swapSlots3and4;
            invSlot3.ValueChanged += invSlot3_ValueChanged;
            invSlot3.SelectedIndexChanged += inv3_SelectedIndexChanged;
            invSlot3.Enter += invSlot3_Enter;
            // 
            // invSlot2
            // 
            invSlot2.LabelText = "/ 00";
            invSlot2.Location = new Point(6, 152);
            invSlot2.Name = "invSlot2";
            invSlot2.NumericValue = new decimal(new int[] { 0, 0, 0, 0 });
            invSlot2.SelectedItem = null;
            invSlot2.Size = new Size(284, 23);
            invSlot2.TabIndex = 20;
            invSlot2.ButtonEquipClick += button_selectInv2_Click;
            invSlot2.ButtonUpClick += swapSlots1and2;
            invSlot2.ButtonDownClick += swapSlots2and3;
            invSlot2.ValueChanged += invSlot2_ValueChanged;
            invSlot2.SelectedIndexChanged += inv2_SelectedIndexChanged;
            invSlot2.Enter += invSlot2_Enter;
            // 
            // invSlot4
            // 
            invSlot4.LabelText = "/ 00";
            invSlot4.Location = new Point(6, 210);
            invSlot4.Name = "invSlot4";
            invSlot4.NumericValue = new decimal(new int[] { 0, 0, 0, 0 });
            invSlot4.SelectedItem = null;
            invSlot4.Size = new Size(284, 23);
            invSlot4.TabIndex = 19;
            invSlot4.ButtonEquipClick += button_selectInv4_Click;
            invSlot4.ButtonUpClick += swapSlots3and4;
            invSlot4.ButtonDownClick += swapSlots4and5;
            invSlot4.ValueChanged += invSlot4_ValueChanged;
            invSlot4.SelectedIndexChanged += inv4_SelectedIndexChanged;
            invSlot4.Enter += invSlot4_Enter;
            // 
            // invSlot1
            // 
            invSlot1.LabelText = "/ 00";
            invSlot1.Location = new Point(6, 123);
            invSlot1.Name = "invSlot1";
            invSlot1.NumericValue = new decimal(new int[] { 0, 0, 0, 0 });
            invSlot1.SelectedItem = null;
            invSlot1.Size = new Size(284, 23);
            invSlot1.TabIndex = 16;
            invSlot1.ButtonEquipClick += button_selectInv1_Click;
            invSlot1.ButtonUpClick += swapSlots5and1;
            invSlot1.ButtonDownClick += swapSlots1and2;
            invSlot1.ValueChanged += invSlot1_ValueChanged;
            invSlot1.SelectedIndexChanged += inv1_SelectedIndexChanged;
            invSlot1.Enter += invSlot1_Enter;
            // 
            // textBox_selectedItemDesc
            // 
            textBox_selectedItemDesc.Location = new Point(6, 17);
            textBox_selectedItemDesc.Multiline = true;
            textBox_selectedItemDesc.Name = "textBox_selectedItemDesc";
            textBox_selectedItemDesc.ReadOnly = true;
            textBox_selectedItemDesc.Size = new Size(286, 100);
            textBox_selectedItemDesc.TabIndex = 10;
            // 
            // button_levelUp
            // 
            button_levelUp.Enabled = false;
            button_levelUp.ForeColor = SystemColors.ControlDark;
            button_levelUp.Location = new Point(312, 49);
            button_levelUp.Name = "button_levelUp";
            button_levelUp.Size = new Size(122, 76);
            button_levelUp.TabIndex = 26;
            button_levelUp.Text = "LEVEL UP";
            button_levelUp.UseVisualStyleBackColor = true;
            button_levelUp.Click += button_levelUp_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(table_combatStats);
            groupBox5.Location = new Point(6, 175);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(129, 225);
            groupBox5.TabIndex = 24;
            groupBox5.TabStop = false;
            groupBox5.Text = "Combat Stats";
            // 
            // table_combatStats
            // 
            table_combatStats.ColumnCount = 2;
            table_combatStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_combatStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_combatStats.Controls.Add(label_movCombat, 0, 7);
            table_combatStats.Controls.Add(label_hit, 0, 0);
            table_combatStats.Controls.Add(label_defCombat, 0, 5);
            table_combatStats.Controls.Add(label_resCombat, 0, 6);
            table_combatStats.Controls.Add(label_avd, 0, 4);
            table_combatStats.Controls.Add(label_crt, 0, 1);
            table_combatStats.Controls.Add(label_as, 0, 3);
            table_combatStats.Controls.Add(label_dmg, 0, 2);
            table_combatStats.Location = new Point(6, 16);
            table_combatStats.Name = "table_combatStats";
            table_combatStats.RowCount = 8;
            table_combatStats.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            table_combatStats.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            table_combatStats.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            table_combatStats.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            table_combatStats.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            table_combatStats.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            table_combatStats.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            table_combatStats.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            table_combatStats.Size = new Size(118, 200);
            table_combatStats.TabIndex = 30;
            // 
            // label_movCombat
            // 
            label_movCombat.Anchor = AnchorStyles.None;
            label_movCombat.AutoSize = true;
            label_movCombat.Location = new Point(12, 180);
            label_movCombat.Name = "label_movCombat";
            label_movCombat.Size = new Size(34, 15);
            label_movCombat.TabIndex = 26;
            label_movCombat.Text = "MOV";
            // 
            // label_hit
            // 
            label_hit.Anchor = AnchorStyles.None;
            label_hit.AutoSize = true;
            label_hit.Location = new Point(17, 5);
            label_hit.Name = "label_hit";
            label_hit.Size = new Size(25, 15);
            label_hit.TabIndex = 20;
            label_hit.Text = "HIT";
            // 
            // label_defCombat
            // 
            label_defCombat.Anchor = AnchorStyles.None;
            label_defCombat.AutoSize = true;
            label_defCombat.Location = new Point(16, 130);
            label_defCombat.Name = "label_defCombat";
            label_defCombat.Size = new Size(27, 15);
            label_defCombat.TabIndex = 29;
            label_defCombat.Text = "DEF";
            // 
            // label_resCombat
            // 
            label_resCombat.Anchor = AnchorStyles.None;
            label_resCombat.AutoSize = true;
            label_resCombat.Location = new Point(16, 155);
            label_resCombat.Name = "label_resCombat";
            label_resCombat.Size = new Size(26, 15);
            label_resCombat.TabIndex = 30;
            label_resCombat.Text = "RES";
            // 
            // label_avd
            // 
            label_avd.Anchor = AnchorStyles.None;
            label_avd.AutoSize = true;
            label_avd.Location = new Point(15, 105);
            label_avd.Name = "label_avd";
            label_avd.Size = new Size(29, 15);
            label_avd.TabIndex = 28;
            label_avd.Text = "AVD";
            // 
            // label_crt
            // 
            label_crt.Anchor = AnchorStyles.None;
            label_crt.AutoSize = true;
            label_crt.Location = new Point(16, 30);
            label_crt.Name = "label_crt";
            label_crt.Size = new Size(27, 15);
            label_crt.TabIndex = 25;
            label_crt.Text = "CRT";
            // 
            // label_as
            // 
            label_as.Anchor = AnchorStyles.None;
            label_as.AutoSize = true;
            label_as.Location = new Point(19, 80);
            label_as.Name = "label_as";
            label_as.Size = new Size(21, 15);
            label_as.TabIndex = 24;
            label_as.Text = "AS";
            // 
            // label_dmg
            // 
            label_dmg.Anchor = AnchorStyles.None;
            label_dmg.AutoSize = true;
            label_dmg.Location = new Point(12, 55);
            label_dmg.Name = "label_dmg";
            label_dmg.Size = new Size(34, 15);
            label_dmg.TabIndex = 22;
            label_dmg.Text = "DMG";
            // 
            // numberBox_exp
            // 
            numberBox_exp.Location = new Point(384, 20);
            numberBox_exp.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
            numberBox_exp.Name = "numberBox_exp";
            numberBox_exp.Size = new Size(50, 23);
            numberBox_exp.TabIndex = 8;
            numberBox_exp.ValueChanged += numberBox_exp_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 22);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 7;
            label2.Text = "EXPERIENCE";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(textBox_features);
            groupBox7.Location = new Point(5, 406);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(130, 87);
            groupBox7.TabIndex = 2;
            groupBox7.TabStop = false;
            groupBox7.Text = "Features";
            // 
            // textBox_features
            // 
            textBox_features.Location = new Point(6, 19);
            textBox_features.Multiline = true;
            textBox_features.Name = "textBox_features";
            textBox_features.ReadOnly = true;
            textBox_features.Size = new Size(117, 60);
            textBox_features.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox_class3);
            groupBox4.Controls.Add(comboBox_class2);
            groupBox4.Controls.Add(comboBox_class1);
            groupBox4.Location = new Point(141, 15);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(165, 110);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Class";
            // 
            // comboBox_class3
            // 
            comboBox_class3.FormattingEnabled = true;
            comboBox_class3.Location = new Point(6, 80);
            comboBox_class3.Name = "comboBox_class3";
            comboBox_class3.Size = new Size(151, 23);
            comboBox_class3.TabIndex = 0;
            // 
            // comboBox_class2
            // 
            comboBox_class2.FormattingEnabled = true;
            comboBox_class2.Location = new Point(6, 51);
            comboBox_class2.Name = "comboBox_class2";
            comboBox_class2.Size = new Size(151, 23);
            comboBox_class2.TabIndex = 0;
            // 
            // comboBox_class1
            // 
            comboBox_class1.FormattingEnabled = true;
            comboBox_class1.Location = new Point(6, 22);
            comboBox_class1.Name = "comboBox_class1";
            comboBox_class1.Size = new Size(151, 23);
            comboBox_class1.TabIndex = 0;
            // 
            // pictureBox_portrait
            // 
            pictureBox_portrait.Image = Properties.Resources.default_portrait;
            pictureBox_portrait.Location = new Point(6, 15);
            pictureBox_portrait.Name = "pictureBox_portrait";
            pictureBox_portrait.Size = new Size(128, 128);
            pictureBox_portrait.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_portrait.TabIndex = 0;
            pictureBox_portrait.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(table_stats);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(147, 236);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Stats";
            // 
            // table_stats
            // 
            table_stats.Anchor = AnchorStyles.Top;
            table_stats.ColumnCount = 2;
            table_stats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_stats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_stats.Controls.Add(label_sm, 0, 1);
            table_stats.Controls.Add(label_skl, 0, 2);
            table_stats.Controls.Add(label_spd, 0, 3);
            table_stats.Controls.Add(label_def, 0, 4);
            table_stats.Controls.Add(label_res, 0, 5);
            table_stats.Controls.Add(label_mov, 0, 6);
            table_stats.Controls.Add(label_hp, 0, 0);
            table_stats.Location = new Point(6, 19);
            table_stats.Name = "table_stats";
            table_stats.RowCount = 7;
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            table_stats.Size = new Size(137, 210);
            table_stats.TabIndex = 29;
            // 
            // label_sm
            // 
            label_sm.Anchor = AnchorStyles.None;
            label_sm.AutoSize = true;
            label_sm.Location = new Point(19, 37);
            label_sm.Name = "label_sm";
            label_sm.Size = new Size(29, 15);
            label_sm.TabIndex = 26;
            label_sm.Text = "S/M";
            // 
            // label_skl
            // 
            label_skl.Anchor = AnchorStyles.None;
            label_skl.AutoSize = true;
            label_skl.Location = new Point(21, 67);
            label_skl.Name = "label_skl";
            label_skl.Size = new Size(26, 15);
            label_skl.TabIndex = 27;
            label_skl.Text = "SKL";
            // 
            // label_spd
            // 
            label_spd.Anchor = AnchorStyles.None;
            label_spd.AutoSize = true;
            label_spd.Location = new Point(20, 97);
            label_spd.Name = "label_spd";
            label_spd.Size = new Size(28, 15);
            label_spd.TabIndex = 28;
            label_spd.Text = "SPD";
            // 
            // label_def
            // 
            label_def.Anchor = AnchorStyles.None;
            label_def.AutoSize = true;
            label_def.Location = new Point(20, 127);
            label_def.Name = "label_def";
            label_def.Size = new Size(27, 15);
            label_def.TabIndex = 29;
            label_def.Text = "DEF";
            // 
            // label_res
            // 
            label_res.Anchor = AnchorStyles.None;
            label_res.AutoSize = true;
            label_res.Location = new Point(21, 157);
            label_res.Name = "label_res";
            label_res.Size = new Size(26, 15);
            label_res.TabIndex = 30;
            label_res.Text = "RES";
            // 
            // label_mov
            // 
            label_mov.Anchor = AnchorStyles.None;
            label_mov.AutoSize = true;
            label_mov.Location = new Point(17, 187);
            label_mov.Name = "label_mov";
            label_mov.Size = new Size(34, 15);
            label_mov.TabIndex = 31;
            label_mov.Text = "MOV";
            // 
            // label_hp
            // 
            label_hp.Anchor = AnchorStyles.None;
            label_hp.AutoSize = true;
            label_hp.Location = new Point(22, 7);
            label_hp.Name = "label_hp";
            label_hp.Size = new Size(23, 15);
            label_hp.TabIndex = 25;
            label_hp.Text = "HP";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(460, 537);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox_characterDetails);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(452, 509);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Character Details";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox6);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(452, 509);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Stats & Weapon Rank";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(table_weaponRanks);
            groupBox6.Location = new Point(159, 6);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(290, 191);
            groupBox6.TabIndex = 29;
            groupBox6.TabStop = false;
            groupBox6.Text = "Weapon Rank";
            // 
            // table_weaponRanks
            // 
            table_weaponRanks.Anchor = AnchorStyles.Top;
            table_weaponRanks.ColumnCount = 4;
            table_weaponRanks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            table_weaponRanks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            table_weaponRanks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            table_weaponRanks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            table_weaponRanks.Controls.Add(pictureBox_swords, 0, 0);
            table_weaponRanks.Controls.Add(pictureBox_axes, 0, 1);
            table_weaponRanks.Controls.Add(pictureBox_lances, 0, 2);
            table_weaponRanks.Controls.Add(pictureBox_bows, 0, 3);
            table_weaponRanks.Controls.Add(pictureBox_anima, 2, 0);
            table_weaponRanks.Controls.Add(pictureBox_light, 2, 1);
            table_weaponRanks.Controls.Add(pictureBox_dark, 2, 2);
            table_weaponRanks.Controls.Add(pictureBox_staves, 2, 3);
            table_weaponRanks.Location = new Point(6, 19);
            table_weaponRanks.Name = "table_weaponRanks";
            table_weaponRanks.RowCount = 4;
            table_weaponRanks.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            table_weaponRanks.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            table_weaponRanks.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            table_weaponRanks.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            table_weaponRanks.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            table_weaponRanks.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            table_weaponRanks.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            table_weaponRanks.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            table_weaponRanks.Size = new Size(278, 160);
            table_weaponRanks.TabIndex = 29;
            // 
            // pictureBox_swords
            // 
            pictureBox_swords.Anchor = AnchorStyles.None;
            pictureBox_swords.Image = Properties.Resources.sword;
            pictureBox_swords.Location = new Point(18, 4);
            pictureBox_swords.Name = "pictureBox_swords";
            pictureBox_swords.Size = new Size(32, 32);
            pictureBox_swords.TabIndex = 30;
            pictureBox_swords.TabStop = false;
            // 
            // pictureBox_axes
            // 
            pictureBox_axes.Anchor = AnchorStyles.None;
            pictureBox_axes.Image = Properties.Resources.axe;
            pictureBox_axes.Location = new Point(18, 44);
            pictureBox_axes.Name = "pictureBox_axes";
            pictureBox_axes.Size = new Size(32, 32);
            pictureBox_axes.TabIndex = 31;
            pictureBox_axes.TabStop = false;
            // 
            // pictureBox_lances
            // 
            pictureBox_lances.Anchor = AnchorStyles.None;
            pictureBox_lances.Image = Properties.Resources.lance;
            pictureBox_lances.Location = new Point(18, 84);
            pictureBox_lances.Name = "pictureBox_lances";
            pictureBox_lances.Size = new Size(32, 32);
            pictureBox_lances.TabIndex = 32;
            pictureBox_lances.TabStop = false;
            // 
            // pictureBox_bows
            // 
            pictureBox_bows.Anchor = AnchorStyles.None;
            pictureBox_bows.Image = Properties.Resources.bow;
            pictureBox_bows.Location = new Point(18, 124);
            pictureBox_bows.Name = "pictureBox_bows";
            pictureBox_bows.Size = new Size(32, 32);
            pictureBox_bows.TabIndex = 33;
            pictureBox_bows.TabStop = false;
            // 
            // pictureBox_anima
            // 
            pictureBox_anima.Anchor = AnchorStyles.None;
            pictureBox_anima.Image = Properties.Resources.anima;
            pictureBox_anima.Location = new Point(156, 4);
            pictureBox_anima.Name = "pictureBox_anima";
            pictureBox_anima.Size = new Size(32, 32);
            pictureBox_anima.TabIndex = 34;
            pictureBox_anima.TabStop = false;
            // 
            // pictureBox_light
            // 
            pictureBox_light.Anchor = AnchorStyles.None;
            pictureBox_light.Image = Properties.Resources.light;
            pictureBox_light.Location = new Point(156, 44);
            pictureBox_light.Name = "pictureBox_light";
            pictureBox_light.Size = new Size(32, 32);
            pictureBox_light.TabIndex = 35;
            pictureBox_light.TabStop = false;
            // 
            // pictureBox_dark
            // 
            pictureBox_dark.Anchor = AnchorStyles.None;
            pictureBox_dark.Image = Properties.Resources.dark;
            pictureBox_dark.Location = new Point(156, 84);
            pictureBox_dark.Name = "pictureBox_dark";
            pictureBox_dark.Size = new Size(32, 32);
            pictureBox_dark.TabIndex = 36;
            pictureBox_dark.TabStop = false;
            // 
            // pictureBox_staves
            // 
            pictureBox_staves.Anchor = AnchorStyles.None;
            pictureBox_staves.Image = Properties.Resources.staff;
            pictureBox_staves.Location = new Point(156, 124);
            pictureBox_staves.Name = "pictureBox_staves";
            pictureBox_staves.Size = new Size(32, 32);
            pictureBox_staves.TabIndex = 37;
            pictureBox_staves.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(38, 42);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 25;
            label4.Text = "HP";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(35, 50);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 26;
            label8.Text = "S/M";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label13, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Location = new Point(38, 42);
            label13.Name = "label13";
            label13.Size = new Size(23, 15);
            label13.TabIndex = 25;
            label13.Text = "HP";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Location = new Point(35, 50);
            label14.Name = "label14";
            label14.Size = new Size(29, 15);
            label14.TabIndex = 26;
            label14.Text = "S/M";
            // 
            // CharacterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(tabControl1);
            Name = "CharacterForm";
            groupBox_characterDetails.ResumeLayout(false);
            groupBox_characterDetails.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox5.ResumeLayout(false);
            table_combatStats.ResumeLayout(false);
            table_combatStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberBox_exp).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_portrait).EndInit();
            groupBox2.ResumeLayout(false);
            table_stats.ResumeLayout(false);
            table_stats.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            table_weaponRanks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_swords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_axes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_lances).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_bows).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_anima).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_light).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_dark).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_staves).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_characterDetails;
        private PictureBox pictureBox_portrait;
        private GroupBox groupBox2;
        private GroupBox groupBox7;
        private ComboBox comboBox_class3;
        private ComboBox comboBox_class2;
        private GroupBox groupBox4;
        private ComboBox comboBox_class1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private NumericUpDown numberBox_exp;
        private Label label2;
        private GroupBox groupBox5;
        private Label label_hit;
        private Label label_crt;
        private Label label_as;
        private Label label_dmg;
        private Label label_avd;
        private Label label_movCombat;
        private Label label_hp;
        private TableLayoutPanel table_stats;
        private Label label_sm;
        private Label label_skl;
        private Label label_spd;
        private Label label_def;
        private Label label_res;
        private Label label_mov;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label13;
        private Label label14;
        private GroupBox groupBox6;
        private TableLayoutPanel table_weaponRanks;
        private PictureBox pictureBox_swords;
        private PictureBox pictureBox_axes;
        private PictureBox pictureBox_lances;
        private PictureBox pictureBox_bows;
        private PictureBox pictureBox_anima;
        private PictureBox pictureBox_light;
        private PictureBox pictureBox_dark;
        private PictureBox pictureBox_staves;
        private TableLayoutPanel table_combatStats;
        private Button button_levelUp;
        private GroupBox groupBox8;
        private TextBox textBox_selectedItemDesc;
        private Label label_defCombat;
        private Label label_resCombat;
        private TextBox textBox_features;
        private Button button_uploadPortrait;
        private Controls.InventorySlot invSlot1;
        private Controls.InventorySlot inventorySlot2;
        private Controls.InventorySlot inventorySlot1;
        private Controls.InventorySlot inventorySlot4;
        private Controls.InventorySlot invSlot4;
        private Controls.InventorySlot invSlot5;
        private Controls.InventorySlot invSlot3;
        private Controls.InventorySlot invSlot2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
