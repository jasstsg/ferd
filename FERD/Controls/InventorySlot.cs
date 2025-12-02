using System.ComponentModel;
namespace FERD.Controls
{
    public partial class InventorySlot : UserControl
    {
        public ComboBox Dropdown => _dropdown;
        public Button ButtonEquip => _buttonEquip;
        public Button ButtonUp => _buttonUp;
        public Button ButtonDown => _buttonDown;
        public NumericUpDown NumberBox => _numberBox;
        public Label Label => _label;

        public InventorySlot()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelText
        {
            get => Label.Text;
            set => Label.Text = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public decimal NumericValue
        {
            get => NumberBox.Value;
            set => NumberBox.Value = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ComboBox.ObjectCollection Items => Dropdown.Items;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string SelectedItem
        {
            get => Dropdown.SelectedItem?.ToString();
            set => Dropdown.SelectedItem = value;
        }

        // ----- Events -----

        [Category("Action")]
        [Description("Occurs when the equip button is clicked.")]
        public event EventHandler ButtonEquipClick
        {
            add => ButtonEquip.Click += value;
            remove => ButtonEquip.Click -= value;
        }

        [Category("Action")]
        [Description("Occurs when the up button is clicked.")]
        public event EventHandler ButtonUpClick
        {
            add => ButtonUp.Click += value;
            remove => ButtonUp.Click -= value;
        }

        [Category("Action")]
        [Description("Occurs when the down button is clicked.")]
        public event EventHandler ButtonDownClick
        {
            add => ButtonDown.Click += value;
            remove => ButtonDown.Click -= value;
        }

        [Category("Action")]
        [Description("Occurs when the Value is changed")]
        public event EventHandler ValueChanged
        {
            add => NumberBox.ValueChanged += value;
            remove => NumberBox.ValueChanged -= value;
        }

        [Category("Behavior")]
        [Description("Occurs when the dropdown index is changed")]
        public event EventHandler SelectedIndexChanged
        {
            add => Dropdown.SelectedIndexChanged += value;
            remove => Dropdown.SelectedIndexChanged -= value;
        }
    }
}
