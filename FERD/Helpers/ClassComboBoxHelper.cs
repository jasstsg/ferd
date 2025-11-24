using FERD.Data;
using FERD.Models;

namespace FERD.Helpers
{
    public static class ClassComboBoxHelper
    {
        public static bool IsClassSetToNull(this ComboBox cb)
        {
            return (cb.SelectedValue as string)?.Equals(Classes.Null.Name) ?? true;
        }

        public static ClassType GetSelectedClass(this ComboBox cb)
        {
            return (cb.SelectedItem as ClassType) ?? Classes.Null;
        }

        public static List<ClassType> getSubclasses(this ComboBox cb)
        {
            return (cb?.SelectedItem as ClassType)?.getSubclassObjects() ?? Classes.None;
        }

        public static void enableIfSubClassIsNull(this ComboBox thisClass, ComboBox subClass)
        {
            thisClass.Enabled = subClass.IsClassSetToNull();
        }

        /// <summary>
        /// Initializes a ComboBox with character class options
        /// </summary>
        /// <param name="dropdown">The ComboBox to initialize</param>
        /// <param name="classOptions">The list of class options</param>
        /// <param name="enabled">Sets the enabled/disabled state of the dropdown by default</param>
        public static void initClassDropdown(this ComboBox dropdown, List<ClassType> classOptions, bool enabled = false)
        {
            dropdown.DisplayMember = "Name";
            dropdown.ValueMember = "Name";
            classOptions.Insert(0, Classes.Null);    // Sets the empty class option as the first option in the list
            dropdown.DataSource = classOptions;      // Binds the options to this list
            dropdown.SelectedIndex = 0;              // Selects the first option by default
            dropdown.Enabled = enabled;
        }

        /// <summary>
        /// Initializes all class dropdowns
        /// </summary>
        /// <param name="c">The character used to populate the dropdowns</param>
        /// <param name="tier1Dropdown">The character's tier 1 class options</param>
        /// <param name="tier2Dropdown">The character's tier 2 class options</param>
        /// <param name="tier3Dropdown">The character's tier 3 class options</param>
        public static void initClassDropdowns(this Character c, ComboBox tier1Dropdown, ComboBox tier2Dropdown, ComboBox tier3Dropdown)
        {
            // Give class1 box all options and set selected from character data
            tier1Dropdown.initClassDropdown(Classes.Tier1);
            tier1Dropdown.SelectedValue = c.Class1.Name;

            // Give class2 restricted options and set selected from character data
            tier2Dropdown.initClassDropdown(c.Class1.getSubclassObjects());
            tier2Dropdown.SelectedValue = c.Class2.Name;

            // Give class3 restricted options and set selected from character data
            tier3Dropdown.initClassDropdown(c.Class2.getSubclassObjects());
            tier3Dropdown.SelectedValue = c.Class3.Name;
        }

        public static void initInvDropdown(this ComboBox inv, string selectedItemName)
        {
            inv.DisplayMember = "Name";
            inv.ValueMember = "Name";
            inv.DataSource = Items.All;
            inv.SelectedValue = selectedItemName;
            inv.Enabled = true;
        }
        public static void initInvDropdown(this ComboBox inv)
        {
            inv.initInvDropdown(Items.Empty.Name);
        }

        public static Item GetSelectedItem(this ComboBox cb)
        {
            return (cb.SelectedItem as Item) ?? Items.Empty;
        }
    }
}
