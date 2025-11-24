namespace FERD.Helpers
{
    public class ResourceHelper
    {
        public static string GetCsvContent(string csvResourceName)
        {
            string? csvContent = Properties.Resources.ResourceManager.GetString(csvResourceName, Properties.Resources.Culture);
            if (csvContent == null)
            {
                string message = $"Resource '{csvResourceName}.csv' not found.";
                Exception ex = new Exception(message);
                MessageBox.Show(message);
                throw ex;
            }

            return csvContent;
        }
    }
}
