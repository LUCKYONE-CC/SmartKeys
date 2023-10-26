namespace SmartKeys
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            lab_passwd = new Label();
            openFileDia_database_file = new OpenFileDialog();
            btn_select_database = new Button();
            lab_keyvault = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(318, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 0;
            // 
            // lab_passwd
            // 
            lab_passwd.AutoSize = true;
            lab_passwd.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lab_passwd.Location = new Point(327, 179);
            lab_passwd.Name = "lab_passwd";
            lab_passwd.Size = new Size(161, 28);
            lab_passwd.TabIndex = 1;
            lab_passwd.Text = "Master-Password";
            // 
            // btn_select_database
            // 
            btn_select_database.Location = new Point(318, 249);
            btn_select_database.Name = "btn_select_database";
            btn_select_database.Size = new Size(108, 23);
            btn_select_database.TabIndex = 2;
            btn_select_database.Text = "Select Keyvault";
            btn_select_database.UseVisualStyleBackColor = true;
            btn_select_database.Click += btn_select_database_Click;
            // 
            // lab_keyvault
            // 
            lab_keyvault.AutoSize = true;
            lab_keyvault.Location = new Point(432, 253);
            lab_keyvault.Name = "lab_keyvault";
            lab_keyvault.Size = new Size(99, 15);
            lab_keyvault.TabIndex = 3;
            lab_keyvault.Text = "Selected Keyvault";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lab_keyvault);
            Controls.Add(btn_select_database);
            Controls.Add(lab_passwd);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lab_passwd;
        private OpenFileDialog openFileDia_database_file;
        private Button btn_select_database;
        private Label lab_keyvault;
    }
}