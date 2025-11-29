using System.ComponentModel;

namespace FERD.Controls
{
    partial class InventorySlot
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox _dropdown;
        private Button _button;
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
            _button = new Button();
            _numberBox = new NumericUpDown();
            _label = new Label();
            ((ISupportInitialize)_numberBox).BeginInit();
            SuspendLayout();
            // 
            // _dropdown
            // 
            _dropdown.Location = new Point(56, 0);
            _dropdown.Name = "_dropdown";
            _dropdown.Size = new Size(145, 23);
            _dropdown.TabIndex = 0;
            // 
            // _button
            // 
            _button.Location = new Point(0, 0);
            _button.Name = "_button";
            _button.Size = new Size(50, 23);
            _button.TabIndex = 1;
            _button.Text = "Equip";
            // 
            // _numberBox
            // 
            _numberBox.Location = new Point(207, 0);
            _numberBox.Name = "_numberBox";
            _numberBox.Size = new Size(40, 23);
            _numberBox.TabIndex = 2;
            // 
            // _label
            // 
            _label.Location = new Point(251, 0);
            _label.Name = "_label";
            _label.Size = new Size(30, 23);
            _label.TabIndex = 3;
            _label.Text = "/ 00";
            _label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // InventorySlot
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(_dropdown);
            Controls.Add(_button);
            Controls.Add(_numberBox);
            Controls.Add(_label);
            Name = "InventorySlot";
            Size = new Size(284, 23);
            ((ISupportInitialize)_numberBox).EndInit();
            ResumeLayout(false);
        }
    }
}
