namespace SmartKeys
{
    partial class CreateVaultDialog
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
            btn_OK = new Button();
            btn_generatePasswd = new Button();
            tB_passwd = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_OK
            // 
            btn_OK.Anchor = AnchorStyles.Top;
            btn_OK.Location = new Point(218, 130);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(97, 29);
            btn_OK.TabIndex = 0;
            btn_OK.Text = "Ok";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // btn_generatePasswd
            // 
            btn_generatePasswd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_generatePasswd.Location = new Point(421, 206);
            btn_generatePasswd.Name = "btn_generatePasswd";
            btn_generatePasswd.Size = new Size(79, 29);
            btn_generatePasswd.TabIndex = 1;
            btn_generatePasswd.Text = "Generate";
            btn_generatePasswd.UseVisualStyleBackColor = true;
            btn_generatePasswd.Click += btn_generatePasswd_Click;
            // 
            // tB_passwd
            // 
            tB_passwd.Anchor = AnchorStyles.Top;
            tB_passwd.Location = new Point(178, 101);
            tB_passwd.Name = "tB_passwd";
            tB_passwd.Size = new Size(173, 23);
            tB_passwd.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(198, 73);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 3;
            label1.Text = "Vault-Password";
            // 
            // CreateVaultDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 247);
            Controls.Add(label1);
            Controls.Add(tB_passwd);
            Controls.Add(btn_generatePasswd);
            Controls.Add(btn_OK);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CreateVaultDialog";
            Text = "CreateVaultDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_OK;
        private Button btn_generatePasswd;
        private TextBox tB_passwd;
        private Label label1;
    }
}