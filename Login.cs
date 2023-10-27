using SmartKeys.Exceptions;
using SmartKeys.Helper;
using SmartKeys.Models;

namespace SmartKeys
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_select_database_Click(object sender, EventArgs e)
        {
            openFileDia_database_file.Filter = "KeyVault Files (*.kv)|*.kv";
            var file = openFileDia_database_file.ShowDialog();

            if (file == DialogResult.OK)
            {
                string selectedFilePath = openFileDia_database_file.FileName;

                string enteredPassword = Microsoft.VisualBasic.Interaction.InputBox("Bitte geben Sie das Passwort ein:", "Passwort eingeben", "");

                if (!string.IsNullOrWhiteSpace(enteredPassword))
                {
                    try
                    {
                        KeyVault vault = KVHandler.ReadKV(selectedFilePath, enteredPassword);

                        MessageBox.Show("Datenbank erfolgreich geladen!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Vault dashboard = new Vault(vault);
                        this.Hide();
                        dashboard.Show();
                    }
                    catch (InvalidPasswordException)
                    {
                        MessageBox.Show("Ungültiges Passwort", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Kein Passwort eingegeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No file selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_ceateNewVault_Click(object sender, EventArgs e)
        {
            CreateVaultDialog passwordDialog = new CreateVaultDialog();

            DialogResult result = passwordDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string enteredPassword = passwordDialog.Password;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Konfigurationsdatei|*.kv";
                saveFileDialog.Title = "Neue Konfigurationsdatei erstellen";
                saveFileDialog.DefaultExt = "kv";
                saveFileDialog.FileName = "newvault.kv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    KVHandler.GenerateKV(saveFileDialog.FileName, enteredPassword, saveFileDialog.FileName);
                }
            }
        }
    }
}
