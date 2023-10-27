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
    public partial class CreateEditEntry : Form
    {
        public string Password { get { return tB_password.Text; } }
        public string Title { get { return tB_title.Text; } }
        public string Username { get { return tB_username.Text; } }
        public string Description { get { return rtB_description.Text; } }
        public CreateEditEntry()
        {
            InitializeComponent();
        }
        public CreateEditEntry(string password, string description, string username, string title)
        {
            InitializeComponent();
            tB_password.Text = password;
            tB_username.Text = username;
            tB_title.Text = title;
            rtB_description.Text = description;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
