namespace FERD
{
    partial class NewCharacterForm
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
            comboBox_class = new ComboBox();
            table_stats = new TableLayoutPanel();
            label2 = new Label();
            label_statsTotal = new Label();
            numberBox_res = new NumericUpDown();
            numberBox_def = new NumericUpDown();
            numberBox_spd = new NumericUpDown();
            numberBox_skl = new NumericUpDown();
            numberBox_sm = new NumericUpDown();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            numberBox_hp = new NumericUpDown();
            label15 = new Label();
            button_createCharacter = new Button();
            textBox_classDescription = new TextBox();
            table_stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberBox_res).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_def).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_spd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_skl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_sm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_hp).BeginInit();
            SuspendLayout();
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(16, 17);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.PlaceholderText = "Character Name";
            textBox_Name.Size = new Size(137, 23);
            textBox_Name.TabIndex = 0;
            textBox_Name.Text = "Mark";
            // 
            // comboBox_class
            // 
            comboBox_class.FormattingEnabled = true;
            comboBox_class.Location = new Point(16, 46);
            comboBox_class.Name = "comboBox_class";
            comboBox_class.Size = new Size(137, 23);
            comboBox_class.TabIndex = 1;
            comboBox_class.SelectedIndexChanged += comboBox_class_SelectedIndexChanged;
            comboBox_class.MouseHover += comboBox_class_MouseHover;
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
            table_stats.Controls.Add(label18, 0, 1);
            table_stats.Controls.Add(label19, 0, 2);
            table_stats.Controls.Add(label20, 0, 3);
            table_stats.Controls.Add(label21, 0, 4);
            table_stats.Controls.Add(label22, 0, 5);
            table_stats.Controls.Add(numberBox_hp, 1, 0);
            table_stats.Controls.Add(label15, 0, 0);
            table_stats.Location = new Point(159, 17);
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
            table_stats.TabIndex = 30;
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
            numberBox_res.ValueChanged += numberBox_res_changed;
            // 
            // numberBox_def
            // 
            numberBox_def.Location = new Point(71, 123);
            numberBox_def.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numberBox_def.Name = "numberBox_def";
            numberBox_def.Size = new Size(63, 23);
            numberBox_def.TabIndex = 35;
            numberBox_def.ValueChanged += numberBox_def_changed;
            // 
            // numberBox_spd
            // 
            numberBox_spd.Location = new Point(71, 93);
            numberBox_spd.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numberBox_spd.Name = "numberBox_spd";
            numberBox_spd.Size = new Size(63, 23);
            numberBox_spd.TabIndex = 34;
            numberBox_spd.ValueChanged += numberBox_spd_changed;
            // 
            // numberBox_skl
            // 
            numberBox_skl.Location = new Point(71, 63);
            numberBox_skl.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numberBox_skl.Name = "numberBox_skl";
            numberBox_skl.Size = new Size(63, 23);
            numberBox_skl.TabIndex = 33;
            numberBox_skl.ValueChanged += numberBox_skl_changed;
            // 
            // numberBox_sm
            // 
            numberBox_sm.Location = new Point(71, 33);
            numberBox_sm.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numberBox_sm.Name = "numberBox_sm";
            numberBox_sm.Size = new Size(63, 23);
            numberBox_sm.TabIndex = 32;
            numberBox_sm.ValueChanged += numberBox_sm_changed;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.AutoSize = true;
            label18.Location = new Point(19, 37);
            label18.Name = "label18";
            label18.Size = new Size(29, 15);
            label18.TabIndex = 26;
            label18.Text = "S/M";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.AutoSize = true;
            label19.Location = new Point(21, 67);
            label19.Name = "label19";
            label19.Size = new Size(26, 15);
            label19.TabIndex = 27;
            label19.Text = "SKL";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.None;
            label20.AutoSize = true;
            label20.Location = new Point(20, 97);
            label20.Name = "label20";
            label20.Size = new Size(28, 15);
            label20.TabIndex = 28;
            label20.Text = "SPD";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.None;
            label21.AutoSize = true;
            label21.Location = new Point(20, 127);
            label21.Name = "label21";
            label21.Size = new Size(27, 15);
            label21.TabIndex = 29;
            label21.Text = "DEF";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.None;
            label22.AutoSize = true;
            label22.Location = new Point(21, 157);
            label22.Name = "label22";
            label22.Size = new Size(26, 15);
            label22.TabIndex = 30;
            label22.Text = "RES";
            // 
            // numberBox_hp
            // 
            numberBox_hp.Location = new Point(71, 3);
            numberBox_hp.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            numberBox_hp.Name = "numberBox_hp";
            numberBox_hp.Size = new Size(63, 23);
            numberBox_hp.TabIndex = 31;
            numberBox_hp.Value = new decimal(new int[] { 15, 0, 0, 0 });
            numberBox_hp.ValueChanged += numberBox_hp_changed;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Location = new Point(22, 7);
            label15.Name = "label15";
            label15.Size = new Size(23, 15);
            label15.TabIndex = 25;
            label15.Text = "HP";
            // 
            // button_createCharacter
            // 
            button_createCharacter.Location = new Point(16, 198);
            button_createCharacter.Name = "button_createCharacter";
            button_createCharacter.Size = new Size(137, 30);
            button_createCharacter.TabIndex = 31;
            button_createCharacter.Text = "Create Character";
            button_createCharacter.UseVisualStyleBackColor = true;
            button_createCharacter.Click += button_createCharacter_Click;
            // 
            // textBox_classDescription
            // 
            textBox_classDescription.Location = new Point(16, 75);
            textBox_classDescription.Multiline = true;
            textBox_classDescription.Name = "textBox_classDescription";
            textBox_classDescription.ReadOnly = true;
            textBox_classDescription.Size = new Size(137, 117);
            textBox_classDescription.TabIndex = 32;
            textBox_classDescription.Text = "Selected class description";
            // 
            // NewCharacterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 238);
            Controls.Add(textBox_classDescription);
            Controls.Add(button_createCharacter);
            Controls.Add(table_stats);
            Controls.Add(comboBox_class);
            Controls.Add(textBox_Name);
            Name = "NewCharacterForm";
            Text = "New Character";
            table_stats.ResumeLayout(false);
            table_stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberBox_res).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_def).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_spd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_skl).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_sm).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberBox_hp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Name;
        private ComboBox comboBox_class;
        private TableLayoutPanel table_stats;
        private Label label2;
        private Label label_statsTotal;
        private NumericUpDown numberBox_res;
        private NumericUpDown numberBox_def;
        private NumericUpDown numberBox_spd;
        private NumericUpDown numberBox_skl;
        private NumericUpDown numberBox_sm;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label15;
        private NumericUpDown numberBox_hp;
        private Button button_createCharacter;
        private TextBox textBox_classDescription;
    }
}