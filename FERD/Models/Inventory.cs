using FERD.Controls;
using FERD.Data;
using FERD.Helpers;
using System.Text.Json.Serialization;

namespace FERD.Models
{
    public class Inventory
    {
        [JsonInclude]
        public Slot Slot1 { get; set; } = new Slot();
        [JsonInclude]
        public Slot Slot2 { get; set; } = new Slot();
        [JsonInclude]
        public Slot Slot3 { get; set; } = new Slot();
        [JsonInclude]
        public Slot Slot4 { get; set; } = new Slot();
        [JsonInclude]
        public Slot Slot5 { get; set; } = new Slot();

        [JsonIgnore]
        public Slot this[int slot]
        {
            get
            {
                switch(slot)
                {
                    case 1: return Slot1;
                    case 2: return Slot2;
                    case 3: return Slot3;
                    case 4: return Slot4;
                    case 5: return Slot5;
                    default: throw new Exception($"Slot '{slot}' does not exist on the 'Inventory' object");
                }
            }

            set
            {
                switch(slot)
                {
                    case 1: Slot1 = value; break; 
                    case 2: Slot2 = value; break;
                    case 3: Slot3 = value; break;
                    case 4: Slot4 = value; break;
                    case 5: Slot5 = value; break;
                    default: throw new Exception($"Slot '{slot}' does not exist on the 'Inventory' object");
                }
            }
        } 
    }

    public class Slot
    {
        /// <summary>
        /// The name of the item in this slot
        /// </summary>
        [JsonInclude]
        public string Name { get; set; }
        /// <summary>
        /// The remaining durability of the item in this slot
        /// </summary>
        [JsonInclude]
        public int Uses { get; set; }

        public Slot()
        {
            Name = Items.Empty.Name;
            Uses = 0;
        }
    }

    public static class SlotHelper
    {
        public static void Set(this Slot slot, Item item)
        {
            slot.Name = item.Name;
            slot.Uses = item.Uses;
        }

        public static void Set(this Slot characterInvSlot, InventorySlot invSlotDropdown)
        {
            Item item = invSlotDropdown.GetSelectedItem();
            characterInvSlot.Set(item);
        }
    }
}
