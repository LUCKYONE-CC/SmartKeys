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
        private readonly KeyVault vault = new KeyVault();
        public Vault(KeyVault vault, string filePath)
        {
            InitializeComponent();

            this.vault = vault;
            this.filePath = filePath;

            RefreshList(vault.Entrys);
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
                var newEntry = KVHandler.AddEntry(filePath, entry, "1234");
                vault.Entrys.Add(newEntry);
                RefreshList(vault.Entrys);
            }
        }

        private void btn_deleteEntry_Click(object sender, EventArgs e)
        {

        }

        private void Vault_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Vault_Load(object sender, EventArgs e)
        {
            CreateEditEntry createEditEntry = new CreateEditEntry();
            createEditEntry.TopLevel = false;
            pan_form.Controls.Add(createEditEntry);
            createEditEntry.FormBorderStyle = FormBorderStyle.None;
            createEditEntry.Dock = DockStyle.Fill;
            createEditEntry.Show();
        }

        private void lB_entryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pan_form.Controls.Clear();
            int selectedIndex = lB_entryListBox.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < vault.Entrys.Count)
            {
                DefaultEntry selectedEntry = vault.Entrys[selectedIndex];

                if(selectedEntry != null)
                {
                    CreateEditEntry createEditEntry = new CreateEditEntry(selectedEntry.Password, selectedEntry.Description, selectedEntry.Username, selectedEntry.Title);
                    createEditEntry.TopLevel = false;
                    pan_form.Controls.Add(createEditEntry);
                    createEditEntry.FormBorderStyle = FormBorderStyle.None;
                    createEditEntry.Dock = DockStyle.Fill;
                    createEditEntry.Show();
                }
            }
        }
        private void RefreshList(List<DefaultEntry> entries)
        {
            lB_entryListBox.Items.Clear();
            foreach (var entry in entries)
            {
                lB_entryListBox.Items.Add(entry.Title);
            }
        }
    }
}
