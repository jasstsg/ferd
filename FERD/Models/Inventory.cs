using FERD.Data;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace FERD.Models
{
    public class Inventory
    {
        public string Slot1 { get; set; } = Items.Empty.Name;
        public string Slot2 { get; set; } = Items.Empty.Name;
        public string Slot3 { get; set; } = Items.Empty.Name;
        public string Slot4 { get; set; } = Items.Empty.Name;
        public string Slot5 { get; set; } = Items.Empty.Name;
        public string Slot6 { get; set; } = Items.Empty.Name;
        public string Slot7 { get; set; } = Items.Empty.Name;
        public string Slot8 { get; set; } = Items.Empty.Name;
        public string Slot9 { get; set; } = Items.Empty.Name;
        public string Slot10 { get; set; } = Items.Empty.Name;

        [JsonIgnore]
        public string this[int slot]
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
                    case 6: return Slot6;
                    case 7: return Slot7;
                    case 8: return Slot8;
                    case 9: return Slot9;
                    case 10: return Slot10;
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
                    case 6: Slot6 = value; break;
                    case 7: Slot7 = value; break;
                    case 8: Slot8 = value; break;
                    case 9: Slot9 = value; break;
                    case 10: Slot10 = value; break;
                    default: throw new Exception($"Slot '{slot}' does not exist on the 'Inventory' object");
                }
            }
        } 
    }
}
