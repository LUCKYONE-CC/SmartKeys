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
    }
}
