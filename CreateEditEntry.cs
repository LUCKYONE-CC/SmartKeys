namespace SmartKeys
{
    public partial class CreateEditEntry : Form
    {
        public string Password { get { return tB_password.Text; } }
        public string Title { get { return tB_title.Text; } }
        public string Username { get { return tB_username.Text; } }
        public string Description { get { return rtB_description.Text; } }
        private Guid _id;
        private string _password;
        private string _title;
        private string _username;
        private string _description;

        public CreateEditEntry()
        {
            InitializeComponent();
        }
        public CreateEditEntry(Guid id, string password, string description, string username, string title)
        {
            InitializeComponent();
            _id = id;
            _password = password;
            _username = username;
            _title = title;
            _description = description;
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
            tB_password.Text = _password;
            tB_title.Text = _title;
            tB_username.Text = _username;
            rtB_description.Text = _description;
            Console.WriteLine(_id);
        }

        private void cb_showHidePasswd_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showHidePasswd.Checked)
            {
                cb_showHidePasswd.Text = "Hide";
                tB_password.UseSystemPasswordChar = false;
                tB_password.Text = _password;
            }
            else
            {
                cb_showHidePasswd.Text = "Show";
                tB_password.UseSystemPasswordChar = true;
            }
        }
    }
}
