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
        private string password;
        private string title;
        private string username;
        private string description;
        public CreateEditEntry()
        {
            InitializeComponent();
        }
        public CreateEditEntry(string password, string description, string username, string title)
        {
            InitializeComponent();
            this.password = password;
            this.username = username;
            this.title = title;
            this.description = description;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CreateEditEntry_Load(object sender, EventArgs e)
        {
            tB_password.Text = password;
            tB_title.Text = title;
            tB_username.Text = username;
            rtB_description.Text = description;
        }

        private void cb_showHidePasswd_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showHidePasswd.Checked)
            {
                cb_showHidePasswd.Text = "Hide";
                tB_password.UseSystemPasswordChar = false;
                tB_password.Text = password;
            }
            else
            {
                cb_showHidePasswd.Text = "Show";
                tB_password.UseSystemPasswordChar = true;
            }
        }
    }
}
