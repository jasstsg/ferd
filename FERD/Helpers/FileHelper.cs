using FERD.Models;
using System.Text.Json;

namespace FERD.Helpers
{
    public static class FileHelper
    {
        private static string FileSaveDirectory = Properties.Settings.Default.CharacterDirectory ?? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static bool save(this Character c, bool showDialog = false)
        {
            string filepath;
            if (showDialog)
            {
                SaveFileDialog dialog = c.createSaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = dialog.FileName;
                }
                else
                {
                    MessageBox.Show("Something went wrong with the save dialog");
                    return false;
                }
            }
            else
            {
                filepath = Path.Combine(FileSaveDirectory, $"{c.Name}.json");
            }

            c.WriteToFile(filepath, showDialog);
            return true;
        }

        private static SaveFileDialog createSaveFileDialog(this Character c)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.FileName = c.Name;
            saveFileDialog.InitialDirectory = FileSaveDirectory;

            return saveFileDialog;
        }

        private static void WriteToFile(this Character c, string filepath, bool showDialog)
        {
            try
            {
                string contentToSave = JsonSerializer.Serialize<Character>(c);
                File.WriteAllText(filepath, contentToSave);

                if (showDialog)
                {
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
