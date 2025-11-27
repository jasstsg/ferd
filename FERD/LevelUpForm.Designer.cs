namespace FERD
{
    partial class LevelUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_levelUpText = new Label();
            table_stats = new TableLayoutPanel();
            label_sm = new Label();
            label_skl = new Label();
            label_spd = new Label();
            label_def = new Label();
            label_res = new Label();
            label_hp = new Label();
            label_hpValue = new Label();
            label_smValue = new Label();
            label_sklValue = new Label();
            label_spdValue = new Label();
            label_defValue = new Label();
            label_resValue = new Label();
            groupBox4 = new GroupBox();
            comboBox_class3 = new ComboBox();
            comboBox_class2 = new ComboBox();
            comboBox_class1 = new ComboBox();
            button_startLevelUp = new Button();
            button_finishLevelUp = new Button();
            textBox_classDescription = new TextBox();
            table_stats.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label_levelUpText
            // 
            label_levelUpText.AutoSize = true;
            label_levelUpText.Location = new Point(6, 9);
            label_levelUpText.Name = "label_levelUpText";
            label_levelUpText.Size = new Size(174, 15);
            label_levelUpText.TabIndex = 0;
            label_levelUpText.Text = "Mark is leveling up from 0 --> 1";
            // 
            // table_stats
            // 
            table_stats.ColumnCount = 2;
            table_stats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_stats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_stats.Controls.Add(label_sm, 0, 1);
            table_stats.Controls.Add(label_skl, 0, 2);
            table_stats.Controls.Add(label_spd, 0, 3);
            table_stats.Controls.Add(label_def, 0, 4);
            table_stats.Controls.Add(label_res, 0, 5);
            table_stats.Controls.Add(label_hp, 0, 0);
            table_stats.Controls.Add(label_hpValue, 1, 0);
            table_stats.Controls.Add(label_smValue, 1, 1);
            table_stats.Controls.Add(label_sklValue, 1, 2);
            table_stats.Controls.Add(label_spdValue, 1, 3);
            table_stats.Controls.Add(label_defValue, 1, 4);
            table_stats.Controls.Add(label_resValue, 1, 5);
            table_stats.Location = new Point(201, 6);
            table_stats.Name = "table_stats";
            table_stats.RowCount = 6;
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            table_stats.Size = new Size(100, 150);
            table_stats.TabIndex = 31;
            // 
            // label_sm
            // 
            label_sm.Anchor = AnchorStyles.None;
            label_sm.AutoSize = true;
            label_sm.Location = new Point(10, 30);
            label_sm.Name = "label_sm";
            label_sm.Size = new Size(29, 15);
            label_sm.TabIndex = 26;
            label_sm.Text = "S/M";
            // 
            // label_skl
            // 
            label_skl.Anchor = AnchorStyles.None;
            label_skl.AutoSize = true;
            label_skl.Location = new Point(12, 55);
            label_skl.Name = "label_skl";
            label_skl.Size = new Size(26, 15);
            label_skl.TabIndex = 27;
            label_skl.Text = "SKL";
            // 
            // label_spd
            // 
            label_spd.Anchor = AnchorStyles.None;
            label_spd.AutoSize = true;
            label_spd.Location = new Point(11, 80);
            label_spd.Name = "label_spd";
            label_spd.Size = new Size(28, 15);
            label_spd.TabIndex = 28;
            label_spd.Text = "SPD";
            // 
            // label_def
            // 
            label_def.Anchor = AnchorStyles.None;
            label_def.AutoSize = true;
            label_def.Location = new Point(11, 105);
            label_def.Name = "label_def";
            label_def.Size = new Size(27, 15);
            label_def.TabIndex = 29;
            label_def.Text = "DEF";
            // 
            // label_res
            // 
            label_res.Anchor = AnchorStyles.None;
            label_res.AutoSize = true;
            label_res.Location = new Point(12, 130);
            label_res.Name = "label_res";
            label_res.Size = new Size(26, 15);
            label_res.TabIndex = 30;
            label_res.Text = "RES";
            // 
            // label_hp
            // 
            label_hp.Anchor = AnchorStyles.None;
            label_hp.AutoSize = true;
            label_hp.Location = new Point(13, 5);
            label_hp.Name = "label_hp";
            label_hp.Size = new Size(23, 15);
            label_hp.TabIndex = 25;
            label_hp.Text = "HP";
            // 
            // label_hpValue
            // 
            label_hpValue.Anchor = AnchorStyles.None;
            label_hpValue.AutoSize = true;
            label_hpValue.Location = new Point(68, 5);
            label_hpValue.Name = "label_hpValue";
            label_hpValue.Size = new Size(13, 15);
            label_hpValue.TabIndex = 31;
            label_hpValue.Text = "0";
            // 
            // label_smValue
            // 
            label_smValue.Anchor = AnchorStyles.None;
            label_smValue.AutoSize = true;
            label_smValue.Location = new Point(68, 30);
            label_smValue.Name = "label_smValue";
            label_smValue.Size = new Size(13, 15);
            label_smValue.TabIndex = 38;
            label_smValue.Text = "0";
            // 
            // label_sklValue
            // 
            label_sklValue.Anchor = AnchorStyles.None;
            label_sklValue.AutoSize = true;
            label_sklValue.Location = new Point(68, 55);
            label_sklValue.Name = "label_sklValue";
            label_sklValue.Size = new Size(13, 15);
            label_sklValue.TabIndex = 39;
            label_sklValue.Text = "0";
            // 
            // label_spdValue
            // 
            label_spdValue.Anchor = AnchorStyles.None;
            label_spdValue.AutoSize = true;
            label_spdValue.Location = new Point(68, 80);
            label_spdValue.Name = "label_spdValue";
            label_spdValue.Size = new Size(13, 15);
            label_spdValue.TabIndex = 40;
            label_spdValue.Text = "0";
            // 
            // label_defValue
            // 
            label_defValue.Anchor = AnchorStyles.None;
            label_defValue.AutoSize = true;
            label_defValue.Location = new Point(68, 105);
            label_defValue.Name = "label_defValue";
            label_defValue.Size = new Size(13, 15);
            label_defValue.TabIndex = 41;
            label_defValue.Text = "0";
            // 
            // label_resValue
            // 
            label_resValue.Anchor = AnchorStyles.None;
            label_resValue.AutoSize = true;
            label_resValue.Location = new Point(68, 130);
            label_resValue.Name = "label_resValue";
            label_resValue.Size = new Size(13, 15);
            label_resValue.TabIndex = 42;
            label_resValue.Text = "0";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox_class3);
            groupBox4.Controls.Add(comboBox_class2);
            groupBox4.Controls.Add(comboBox_class1);
            groupBox4.Location = new Point(6, 40);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(189, 111);
            groupBox4.TabIndex = 32;
            groupBox4.TabStop = false;
            groupBox4.Text = "Class";
            // 
            // comboBox_class3
            // 
            comboBox_class3.Enabled = false;
            comboBox_class3.ForeColor = SystemColors.WindowFrame;
            comboBox_class3.FormattingEnabled = true;
            comboBox_class3.Location = new Point(6, 76);
            comboBox_class3.Name = "comboBox_class3";
            comboBox_class3.Size = new Size(177, 23);
            comboBox_class3.TabIndex = 0;
            comboBox_class3.SelectedIndexChanged += comboBox_class3_SelectedIndexChanged;
            // 
            // comboBox_class2
            // 
            comboBox_class2.Enabled = false;
            comboBox_class2.ForeColor = SystemColors.WindowFrame;
            comboBox_class2.FormattingEnabled = true;
            comboBox_class2.Location = new Point(6, 47);
            comboBox_class2.Name = "comboBox_class2";
            comboBox_class2.Size = new Size(177, 23);
            comboBox_class2.TabIndex = 0;
            comboBox_class2.SelectedIndexChanged += comboBox_class2_SelectedIndexChanged;
            // 
            // comboBox_class1
            // 
            comboBox_class1.Enabled = false;
            comboBox_class1.ForeColor = SystemColors.WindowFrame;
            comboBox_class1.FormattingEnabled = true;
            comboBox_class1.Location = new Point(6, 18);
            comboBox_class1.Name = "comboBox_class1";
            comboBox_class1.Size = new Size(177, 23);
            comboBox_class1.TabIndex = 0;
            // 
            // button_startLevelUp
            // 
            button_startLevelUp.Location = new Point(201, 162);
            button_startLevelUp.Name = "button_startLevelUp";
            button_startLevelUp.Size = new Size(100, 35);
            button_startLevelUp.TabIndex = 33;
            button_startLevelUp.Text = "Start level up";
            button_startLevelUp.UseVisualStyleBackColor = true;
            button_startLevelUp.Click += button_startLevelUp_Click;
            // 
            // button_finishLevelUp
            // 
            button_finishLevelUp.Enabled = false;
            button_finishLevelUp.ForeColor = SystemColors.ControlDark;
            button_finishLevelUp.Location = new Point(201, 203);
            button_finishLevelUp.Name = "button_finishLevelUp";
            button_finishLevelUp.Size = new Size(100, 35);
            button_finishLevelUp.TabIndex = 34;
            button_finishLevelUp.Text = "Finish level up";
            button_finishLevelUp.UseVisualStyleBackColor = true;
            button_finishLevelUp.Click += button_finishLevelUp_Click;
            // 
            // textBox_classDescription
            // 
            textBox_classDescription.Location = new Point(6, 158);
            textBox_classDescription.Multiline = true;
            textBox_classDescription.Name = "textBox_classDescription";
            textBox_classDescription.ReadOnly = true;
            textBox_classDescription.Size = new Size(189, 80);
            textBox_classDescription.TabIndex = 35;
            textBox_classDescription.Text = "Selected class descrption";
            // 
            // LevelUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 241);
            Controls.Add(textBox_classDescription);
            Controls.Add(button_finishLevelUp);
            Controls.Add(button_startLevelUp);
            Controls.Add(groupBox4);
            Controls.Add(table_stats);
            Controls.Add(label_levelUpText);
            Name = "LevelUpForm";
            Text = "Mark is leveling up!";
            table_stats.ResumeLayout(false);
            table_stats.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_levelUpText;
        private TableLayoutPanel table_stats;
        private Label label_sm;
        private Label label_skl;
        private Label label_spd;
        private Label label_def;
        private Label label_res;
        private Label label_hp;
        private Label label_hpValue;
        private Label label_smValue;
        private Label label_sklValue;
        private Label label_spdValue;
        private Label label_defValue;
        private Label label_resValue;
        private GroupBox groupBox4;
        private ComboBox comboBox_class3;
        private ComboBox comboBox_class2;
        private ComboBox comboBox_class1;
        private Button button_startLevelUp;
        private Button button_finishLevelUp;
        private TextBox textBox_classDescription;
    }
}