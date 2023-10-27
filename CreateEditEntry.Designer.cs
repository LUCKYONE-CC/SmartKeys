namespace SmartKeys
{
    partial class CreateEditEntry
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
            tB_title = new TextBox();
            lab_title = new Label();
            lab_username = new Label();
            tB_username = new TextBox();
            lab_password = new Label();
            tB_password = new TextBox();
            rtB_description = new RichTextBox();
            lab_description = new Label();
            btn_save = new Button();
            SuspendLayout();
            // 
            // tB_title
            // 
            tB_title.Location = new Point(310, 125);
            tB_title.Name = "tB_title";
            tB_title.Size = new Size(156, 23);
            tB_title.TabIndex = 0;
            // 
            // lab_title
            // 
            lab_title.AutoSize = true;
            lab_title.Location = new Point(310, 107);
            lab_title.Name = "lab_title";
            lab_title.Size = new Size(29, 15);
            lab_title.TabIndex = 1;
            lab_title.Text = "Title";
            // 
            // lab_username
            // 
            lab_username.AutoSize = true;
            lab_username.Location = new Point(310, 163);
            lab_username.Name = "lab_username";
            lab_username.Size = new Size(60, 15);
            lab_username.TabIndex = 3;
            lab_username.Text = "Username";
            // 
            // tB_username
            // 
            tB_username.Location = new Point(310, 181);
            tB_username.Name = "tB_username";
            tB_username.Size = new Size(156, 23);
            tB_username.TabIndex = 2;
            // 
            // lab_password
            // 
            lab_password.AutoSize = true;
            lab_password.Location = new Point(310, 207);
            lab_password.Name = "lab_password";
            lab_password.Size = new Size(57, 15);
            lab_password.TabIndex = 5;
            lab_password.Text = "Password";
            // 
            // tB_password
            // 
            tB_password.Location = new Point(310, 225);
            tB_password.Name = "tB_password";
            tB_password.PasswordChar = '*';
            tB_password.Size = new Size(156, 23);
            tB_password.TabIndex = 4;
            tB_password.UseSystemPasswordChar = true;
            // 
            // rtB_description
            // 
            rtB_description.Location = new Point(310, 269);
            rtB_description.Name = "rtB_description";
            rtB_description.Size = new Size(156, 71);
            rtB_description.TabIndex = 6;
            rtB_description.Text = "";
            rtB_description.TextChanged += richTextBox1_TextChanged;
            // 
            // lab_description
            // 
            lab_description.AutoSize = true;
            lab_description.Location = new Point(310, 251);
            lab_description.Name = "lab_description";
            lab_description.Size = new Size(67, 15);
            lab_description.TabIndex = 7;
            lab_description.Text = "Description";
            // 
            // btn_save
            // 
            btn_save.Location = new Point(310, 375);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 8;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // CreateEditEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_save);
            Controls.Add(lab_description);
            Controls.Add(rtB_description);
            Controls.Add(lab_password);
            Controls.Add(tB_password);
            Controls.Add(lab_username);
            Controls.Add(tB_username);
            Controls.Add(lab_title);
            Controls.Add(tB_title);
            Name = "CreateEditEntry";
            Text = "CreateEditEntry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tB_title;
        private Label lab_title;
        private Label lab_username;
        private TextBox tB_username;
        private Label lab_password;
        private TextBox tB_password;
        private RichTextBox rtB_description;
        private Label lab_description;
        private Button btn_save;
    }
}