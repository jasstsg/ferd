using FERD.Controls;
using FERD.Data;
using FERD.Models;

namespace FERD.Helpers
{
    public static class InventorySlotHelper
    {
        public static void SetSelectedItem(this InventorySlot slot, string selectedItemName, int selectedItemUses)
        {
            // Set dropdown
            slot.Dropdown.DisplayMember = "Name";
            slot.Dropdown.ValueMember = "Name";
            slot.Dropdown.DataSource = Items.All;
            slot.Dropdown.SelectedValue = selectedItemName;
            slot.Dropdown.Enabled = true;

            // Set numberbox to remaining uses value
            slot.NumberBox.Value = selectedItemUses;

            // Set label to max uses value
            Item item = slot.Dropdown.GetSelectedItem();
            slot.Label.Text = $"/ {item.Uses}";
        }

        public static void OnSelectedItemChanged(this InventorySlot slot)
        {
            Item item = slot.Dropdown.GetSelectedItem();
            slot.NumberBox.Value = item.Uses;
            slot.Label.Text = $"/ {item.Uses}";
        }

        public static Item GetSelectedItem(this InventorySlot slot)
        {
            return (slot.Dropdown.SelectedItem as Item) ?? Items.Empty;
        }

        public static void SetDisplay(this InventorySlot slot, Character c)
        {
            Item slotItem = slot.GetSelectedItem();
            if (slotItem.Type == "Items")
            {
                slot.DisplayReset();
            }
            else
            {
                slot.DisplayAllowed(c.IsWeaponAllowed(slotItem));
            }
        }

        public static void DisplayReset(this InventorySlot slot)
        {
            slot.BackColor = SystemColors.Window;
        }

        public static void DisplayAllowed(this InventorySlot slot, bool allowed)
        {
            slot.BackColor = allowed ? Color.LightBlue : Color.DarkGray;
        }

        public static void DisplaySelected(this InventorySlot slot)
        {
            slot.BackColor = Color.LightGreen;
        }
    }
}
