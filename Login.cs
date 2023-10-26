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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lab_keyvault.Text = "Selected KeyVault: ";
        }

        private void btn_select_database_Click(object sender, EventArgs e)
        {
            openFileDia_database_file.Filter = "KeyVault Files (*.kv)|*.kv";
            var file = openFileDia_database_file.ShowDialog();

            if (file == DialogResult.OK)
            {
                lab_keyvault.Text = "Selected KeyVault: " + openFileDia_database_file.FileName;
            }
            else
            {
                MessageBox.Show("No file selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
