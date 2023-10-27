using SmartKeys.Helper;
using SmartKeys.Models;
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
    public partial class Vault : Form
    {
        private readonly string filePath = "";
        public Vault(KeyVault vault, string filePath)
        {
            InitializeComponent();

            this.filePath = filePath;

            foreach (var entry in vault.Entrys)
            {
                lB_entryListBox.Items.Add(entry.Title);
            }
        }

        private void btn_createEntry_Click(object sender, EventArgs e)
        {
            CreateEditEntry createEditEntry = new CreateEditEntry();

            DialogResult result = createEditEntry.ShowDialog();

            if (result == DialogResult.OK)
            {
                DefaultEntry entry = new DefaultEntry
                {
                    Title = createEditEntry.Title,
                    Username = createEditEntry.Username,
                    Password = createEditEntry.Password,
                    Description = createEditEntry.Description
                };

                createEditEntry.Close();
                createEditEntry.Dispose();
                KVHandler.AddEntry(filePath, entry, "1234");
            }
        }

        private void btn_deleteEntry_Click(object sender, EventArgs e)
        {

        }
    }
}
