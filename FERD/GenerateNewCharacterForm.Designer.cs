namespace FERD
{
    partial class GenerateNewCharacterForm
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
            textBox_Name = new TextBox();
            comboBox_class1 = new ComboBox();
            comboBox_class2 = new ComboBox();
            comboBox_class3 = new ComboBox();
            table_stats = new TableLayoutPanel();
            label2 = new Label();
            label_statsTotal = new Label();
            numberBox_res = new NumericUpDown();
            numberBox_def = new NumericUpDown();
            numberBox_spd = new NumericUpDown();
            numberBox_skl = new NumericUpDown();
            numberBox_sm = new NumericUpDown();
            label_sm = new Label();
            label_skl = new Label();
            label_spd = new Label();
            label_def = new Label();
            label_res = new Label();
            numberBox_hp = new NumericUpDown();
            label_hp = new Label();
            button_useStatsAndGenerate = new Button();
            button_randomStatsAndGenerate = new Button();
            label1 = new Label();
            numberBox_level = new NumericUpDown();
            table_stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberBox_res).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_def).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_spd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_skl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_sm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_hp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_level).BeginInit();
            SuspendLayout();
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(12, 12);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.PlaceholderText = "Character Name";
            textBox_Name.Size = new Size(137, 23);
            textBox_Name.TabIndex = 1;
            textBox_Name.Text = "Mark";
            // 
            // comboBox_class1
            // 
            comboBox_class1.FormattingEnabled = true;
            comboBox_class1.Location = new Point(12, 41);
            comboBox_class1.Name = "comboBox_class1";
            comboBox_class1.Size = new Size(137, 23);
            comboBox_class1.TabIndex = 2;
            comboBox_class1.SelectedIndexChanged += comboBox_class1_SelectedIndexChanged;
            // 
            // comboBox_class2
            // 
            comboBox_class2.FormattingEnabled = true;
            comboBox_class2.Location = new Point(12, 70);
            comboBox_class2.Name = "comboBox_class2";
            comboBox_class2.Size = new Size(137, 23);
            comboBox_class2.TabIndex = 3;
            comboBox_class2.SelectedIndexChanged += comboBox_class2_SelectedIndexChanged;
            // 
            // comboBox_class3
            // 
            comboBox_class3.FormattingEnabled = true;
            comboBox_class3.Location = new Point(12, 99);
            comboBox_class3.Name = "comboBox_class3";
            comboBox_class3.Size = new Size(137, 23);
            comboBox_class3.TabIndex = 4;
            comboBox_class3.SelectedIndexChanged += comboBox_class3_SelectedIndexChanged;
            // 
            // table_stats
            // 
            table_stats.ColumnCount = 2;
            table_stats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_stats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_stats.Controls.Add(label2, 0, 6);
            table_stats.Controls.Add(label_statsTotal, 0, 6);
            table_stats.Controls.Add(numberBox_res, 1, 5);
            table_stats.Controls.Add(numberBox_def, 1, 4);
            table_stats.Controls.Add(numberBox_spd, 1, 3);
            table_stats.Controls.Add(numberBox_skl, 1, 2);
            table_stats.Controls.Add(numberBox_sm, 1, 1);
            table_stats.Controls.Add(label_sm, 0, 1);
            table_stats.Controls.Add(label_skl, 0, 2);
            table_stats.Controls.Add(label_spd, 0, 3);
            table_stats.Controls.Add(label_def, 0, 4);
            table_stats.Controls.Add(label_res, 0, 5);
            table_stats.Controls.Add(numberBox_hp, 1, 0);
            table_stats.Controls.Add(label_hp, 0, 0);
            table_stats.Location = new Point(155, 41);
            table_stats.Name = "table_stats";
            table_stats.RowCount = 7;
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_stats.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_stats.Size = new Size(137, 213);
            table_stats.TabIndex = 31;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(14, 189);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 38;
            label2.Text = "TOTAL";
            // 
            // label_statsTotal
            // 
            label_statsTotal.Anchor = AnchorStyles.None;
            label_statsTotal.AutoSize = true;
            label_statsTotal.Location = new Point(81, 189);
            label_statsTotal.Name = "label_statsTotal";
            label_statsTotal.Size = new Size(42, 15);
            label_statsTotal.TabIndex = 37;
            label_statsTotal.Text = "15 / 50";
            // 
            // numberBox_res
            // 
            numberBox_res.Location = new Point(71, 153);
            numberBox_res.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numberBox_res.Name = "numberBox_res";
            numberBox_res.Size = new Size(63, 23);
            numberBox_res.TabIndex = 36;
            // 
            // numberBox_def
            // 
            numberBox_def.Location = new Point(71, 123);
            numberBox_def.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numberBox_def.Name = "numberBox_def";
            numberBox_def.Size = new Size(63, 23);
            numberBox_def.TabIndex = 35;
            // 
            // numberBox_spd
            // 
            numberBox_spd.Location = new Point(71, 93);
            numberBox_spd.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numberBox_spd.Name = "numberBox_spd";
            numberBox_spd.Size = new Size(63, 23);
            numberBox_spd.TabIndex = 34;
            // 
            // numberBox_skl
            // 
            numberBox_skl.Location = new Point(71, 63);
            numberBox_skl.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numberBox_skl.Name = "numberBox_skl";
            numberBox_skl.Size = new Size(63, 23);
            numberBox_skl.TabIndex = 33;
            // 
            // numberBox_sm
            // 
            numberBox_sm.Location = new Point(71, 33);
            numberBox_sm.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numberBox_sm.Name = "numberBox_sm";
            numberBox_sm.Size = new Size(63, 23);
            numberBox_sm.TabIndex = 32;
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
            // numberBox_hp
            // 
            numberBox_hp.Location = new Point(71, 3);
            numberBox_hp.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            numberBox_hp.Name = "numberBox_hp";
            numberBox_hp.Size = new Size(63, 23);
            numberBox_hp.TabIndex = 31;
            numberBox_hp.Value = new decimal(new int[] { 15, 0, 0, 0 });
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
            // button_useStatsAndGenerate
            // 
            button_useStatsAndGenerate.Location = new Point(12, 129);
            button_useStatsAndGenerate.Name = "button_useStatsAndGenerate";
            button_useStatsAndGenerate.Size = new Size(137, 60);
            button_useStatsAndGenerate.TabIndex = 32;
            button_useStatsAndGenerate.Text = "Current stats and generate";
            button_useStatsAndGenerate.UseVisualStyleBackColor = true;
            button_useStatsAndGenerate.Click += button_useStatsAndGenerate_Click;
            // 
            // button_randomStatsAndGenerate
            // 
            button_randomStatsAndGenerate.Location = new Point(12, 194);
            button_randomStatsAndGenerate.Name = "button_randomStatsAndGenerate";
            button_randomStatsAndGenerate.Size = new Size(137, 60);
            button_randomStatsAndGenerate.TabIndex = 33;
            button_randomStatsAndGenerate.Text = "Randomize stats and generate";
            button_randomStatsAndGenerate.UseVisualStyleBackColor = true;
            button_randomStatsAndGenerate.Click += button_randomStatsAndGenerate_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(174, 15);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 34;
            label1.Text = "LEVEL";
            // 
            // numberBox_level
            // 
            numberBox_level.Location = new Point(226, 12);
            numberBox_level.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            numberBox_level.Name = "numberBox_level";
            numberBox_level.Size = new Size(63, 23);
            numberBox_level.TabIndex = 35;
            // 
            // GenerateNewCharacterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 265);
            Controls.Add(numberBox_level);
            Controls.Add(label1);
            Controls.Add(button_randomStatsAndGenerate);
            Controls.Add(button_useStatsAndGenerate);
            Controls.Add(table_stats);
            Controls.Add(comboBox_class3);
            Controls.Add(comboBox_class2);
            Controls.Add(comboBox_class1);
            Controls.Add(textBox_Name);
            Name = "GenerateNewCharacterForm";
            Text = "Auto generate a character";
            table_stats.ResumeLayout(false);
            table_stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberBox_res).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_def).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_spd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_skl).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_sm).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_hp).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_level).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Name;
        private ComboBox comboBox_class1;
        private ComboBox comboBox_class2;
        private ComboBox comboBox_class3;
        private TableLayoutPanel table_stats;
        private Label label2;
        private Label label_statsTotal;
        private NumericUpDown numberBox_res;
        private NumericUpDown numberBox_def;
        private NumericUpDown numberBox_spd;
        private NumericUpDown numberBox_skl;
        private NumericUpDown numberBox_sm;
        private Label label_sm;
        private Label label_skl;
        private Label label_spd;
        private Label label_def;
        private Label label_res;
        private NumericUpDown numberBox_hp;
        private Label label_hp;
        private Button button_useStatsAndGenerate;
        private Button button_randomStatsAndGenerate;
        private Label label1;
        private NumericUpDown numberBox_level;
    }
}