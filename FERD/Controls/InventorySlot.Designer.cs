using System.ComponentModel;

namespace FERD.Controls
{
    partial class InventorySlot
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox _dropdown;
        private Button _buttonEquip;
        private Button _buttonUp;
        private Button _buttonDown;
        private NumericUpDown _numberBox;
        private Label _label;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            _dropdown = new ComboBox();
            _buttonEquip = new Button();
            _numberBox = new NumericUpDown();
            _label = new Label();
            _buttonUp = new Button();
            _buttonDown = new Button();
            ((ISupportInitialize)_numberBox).BeginInit();
            SuspendLayout();
            // 
            // _dropdown
            // 
            _dropdown.Location = new Point(45, 0);
            _dropdown.Name = "_dropdown";
            _dropdown.Size = new Size(120, 23);
            _dropdown.TabIndex = 0;
            // 
            // _buttonEquip
            // 
            _buttonEquip.Location = new Point(0, 0);
            _buttonEquip.Name = "_buttonEquip";
            _buttonEquip.Size = new Size(45, 23);
            _buttonEquip.TabIndex = 1;
            _buttonEquip.Text = "Equip";
            // 
            // _numberBox
            // 
            _numberBox.Location = new Point(171, 0);
            _numberBox.Name = "_numberBox";
            _numberBox.Size = new Size(35, 23);
            _numberBox.TabIndex = 2;
            // 
            // _label
            // 
            _label.Location = new Point(212, 0);
            _label.Name = "_label";
            _label.Size = new Size(30, 23);
            _label.TabIndex = 3;
            _label.Text = "/ 00";
            _label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _buttonUp
            // 
            _buttonUp.Location = new Point(248, 0);
            _buttonUp.Name = "_buttonUp";
            _buttonUp.Size = new Size(20, 23);
            _buttonUp.TabIndex = 4;
            _buttonUp.Text = "↑";
            _buttonUp.UseVisualStyleBackColor = true;
            // 
            // _buttonDown
            // 
            _buttonDown.Location = new Point(264, 0);
            _buttonDown.Name = "_buttonDown";
            _buttonDown.Size = new Size(20, 23);
            _buttonDown.TabIndex = 5;
            _buttonDown.Text = "↓";
            _buttonDown.UseVisualStyleBackColor = true;
            // 
            // InventorySlot
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(_buttonDown);
            Controls.Add(_buttonUp);
            Controls.Add(_dropdown);
            Controls.Add(_buttonEquip);
            Controls.Add(_numberBox);
            Controls.Add(_label);
            Name = "InventorySlot";
            Size = new Size(284, 23);
            ((ISupportInitialize)_numberBox).EndInit();
            ResumeLayout(false);
        }
    }
}
