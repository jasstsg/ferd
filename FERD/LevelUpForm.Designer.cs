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
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label15 = new Label();
            label_hp = new Label();
            label_sm = new Label();
            label_skl = new Label();
            label_spd = new Label();
            label_def = new Label();
            label_res = new Label();
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
            table_stats.Controls.Add(label18, 0, 1);
            table_stats.Controls.Add(label19, 0, 2);
            table_stats.Controls.Add(label20, 0, 3);
            table_stats.Controls.Add(label21, 0, 4);
            table_stats.Controls.Add(label22, 0, 5);
            table_stats.Controls.Add(label15, 0, 0);
            table_stats.Controls.Add(label_hp, 1, 0);
            table_stats.Controls.Add(label_sm, 1, 1);
            table_stats.Controls.Add(label_skl, 1, 2);
            table_stats.Controls.Add(label_spd, 1, 3);
            table_stats.Controls.Add(label_def, 1, 4);
            table_stats.Controls.Add(label_res, 1, 5);
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
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.AutoSize = true;
            label18.Location = new Point(10, 30);
            label18.Name = "label18";
            label18.Size = new Size(29, 15);
            label18.TabIndex = 26;
            label18.Text = "S/M";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.AutoSize = true;
            label19.Location = new Point(12, 55);
            label19.Name = "label19";
            label19.Size = new Size(26, 15);
            label19.TabIndex = 27;
            label19.Text = "SKL";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.None;
            label20.AutoSize = true;
            label20.Location = new Point(11, 80);
            label20.Name = "label20";
            label20.Size = new Size(28, 15);
            label20.TabIndex = 28;
            label20.Text = "SPD";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.None;
            label21.AutoSize = true;
            label21.Location = new Point(11, 105);
            label21.Name = "label21";
            label21.Size = new Size(27, 15);
            label21.TabIndex = 29;
            label21.Text = "DEF";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.None;
            label22.AutoSize = true;
            label22.Location = new Point(12, 130);
            label22.Name = "label22";
            label22.Size = new Size(26, 15);
            label22.TabIndex = 30;
            label22.Text = "RES";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Location = new Point(13, 5);
            label15.Name = "label15";
            label15.Size = new Size(23, 15);
            label15.TabIndex = 25;
            label15.Text = "HP";
            // 
            // label_hp
            // 
            label_hp.Anchor = AnchorStyles.None;
            label_hp.AutoSize = true;
            label_hp.Location = new Point(68, 5);
            label_hp.Name = "label_hp";
            label_hp.Size = new Size(13, 15);
            label_hp.TabIndex = 31;
            label_hp.Text = "0";
            // 
            // label_sm
            // 
            label_sm.Anchor = AnchorStyles.None;
            label_sm.AutoSize = true;
            label_sm.Location = new Point(68, 30);
            label_sm.Name = "label_sm";
            label_sm.Size = new Size(13, 15);
            label_sm.TabIndex = 38;
            label_sm.Text = "0";
            // 
            // label_skl
            // 
            label_skl.Anchor = AnchorStyles.None;
            label_skl.AutoSize = true;
            label_skl.Location = new Point(68, 55);
            label_skl.Name = "label_skl";
            label_skl.Size = new Size(13, 15);
            label_skl.TabIndex = 39;
            label_skl.Text = "0";
            // 
            // label_spd
            // 
            label_spd.Anchor = AnchorStyles.None;
            label_spd.AutoSize = true;
            label_spd.Location = new Point(68, 80);
            label_spd.Name = "label_spd";
            label_spd.Size = new Size(13, 15);
            label_spd.TabIndex = 40;
            label_spd.Text = "0";
            // 
            // label_def
            // 
            label_def.Anchor = AnchorStyles.None;
            label_def.AutoSize = true;
            label_def.Location = new Point(68, 105);
            label_def.Name = "label_def";
            label_def.Size = new Size(13, 15);
            label_def.TabIndex = 41;
            label_def.Text = "0";
            // 
            // label_res
            // 
            label_res.Anchor = AnchorStyles.None;
            label_res.AutoSize = true;
            label_res.Location = new Point(68, 130);
            label_res.Name = "label_res";
            label_res.Size = new Size(13, 15);
            label_res.TabIndex = 42;
            label_res.Text = "0";
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
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label15;
        private Label label_hp;
        private Label label_sm;
        private Label label_skl;
        private Label label_spd;
        private Label label_def;
        private Label label_res;
        private GroupBox groupBox4;
        private ComboBox comboBox_class3;
        private ComboBox comboBox_class2;
        private ComboBox comboBox_class1;
        private Button button_startLevelUp;
        private Button button_finishLevelUp;
        private TextBox textBox_classDescription;
    }
}