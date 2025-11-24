using FERD.Data;
using FERD.Models;
using System.Text.Json;

namespace FERD
{
    public partial class MainForm : Form
    {
        private string _characterDir
        {
            get 
            {
                string dir = Properties.Settings.Default.CharacterDirectory;
                return !string.IsNullOrEmpty(dir) ? dir : Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
            set
            {
                Properties.Settings.Default.CharacterDirectory = value;
            }
        }

        private Dictionary<string, string> _characterFilePaths = new Dictionary<string, string>();

        public MainForm()
        {
            InitializeComponent();
            loadData();
            loadCharacters();
            textBox_characterFolder.Text = _characterDir;
        }

        private void loadData()
        {
            // Call static class map just to populate the data in memory
            _ = Classes.ClassMap;
        }

        private void loadCharacters()
        {
            listBox_characters.Items.Clear();
            string[] filepaths = Directory.GetFiles(_characterDir, "*.json");
            string filename = "";
            _characterFilePaths.Clear();
            foreach (string filepath in filepaths)
            {
                filename = Path.GetFileNameWithoutExtension(filepath);
                listBox_characters.Items.Add(filename);
                _characterFilePaths.Add(filename, filepath);
            }
            if (listBox_characters.Items.Count > 0)
            {
                listBox_characters.SelectedIndex = 0;
            }
        }

        private void button_setCharacterFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox_characterFolder.Text = fbd.SelectedPath;
                Properties.Settings.Default.CharacterDirectory = fbd.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            NewCharacterForm ncf = new NewCharacterForm();
            ncf.Show();
        }

        private void button_openCharacter_Click(object sender, EventArgs e)
        {
            string filepath = _characterFilePaths[(string)listBox_characters.SelectedItem];
            string fileContent = File.ReadAllText(filepath);
            Character c = JsonSerializer.Deserialize<Character>(fileContent);
            CharacterForm cf = new CharacterForm(c);
            cf.Show();
        }

        private void button_OpenPromotionTree_Click(object sender, EventArgs e)
        {
            PromotionTreeForm f = new PromotionTreeForm();
            f.Show();
        }
    }
}
