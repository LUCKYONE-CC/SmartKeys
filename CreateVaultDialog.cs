using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartKeys
{
    public partial class CreateVaultDialog : Form
    {
        public string Password { get { return tB_passwd.Text; } }
        public CreateVaultDialog()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tB_passwd.Text))
            {
                MessageBox.Show("Bitte geben Sie ein Passwort ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btn_generatePasswd_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string passwd = new string(Enumerable.Repeat(chars, 16).Select(s => s[random.Next(s.Length)]).ToArray());
            tB_passwd.Text = passwd;
            Clipboard.SetText(passwd);
            MessageBox.Show("Passwort wurde in die Zwischenablage kopiert.", "Passwort generiert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
