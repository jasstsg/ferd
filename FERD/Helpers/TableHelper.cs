
namespace FERD.Helpers
{
    public static class TableHelper
    {
        public static void AddText(this TableLayoutPanel table, string text, int colIndex, int rowIndex)
        {
            table.GetControlFromPosition(colIndex, rowIndex)?.Dispose();
            table.Controls.Add(new Label() { Anchor = AnchorStyles.None, Text = text }, colIndex, rowIndex);
        }

        public static void AddText(this TableLayoutPanel table, int num, int colIndex, int rowIndex)
        {
            table.AddText(num.ToString(), colIndex, rowIndex);
        }
    }
}
