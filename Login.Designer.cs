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
            openFileDia_database_file = new OpenFileDialog();
            btn_select_database = new Button();
            btn_ceateNewVault = new Button();
            SuspendLayout();
            // 
            // btn_select_database
            // 
            btn_select_database.Location = new Point(286, 190);
            btn_select_database.Name = "btn_select_database";
            btn_select_database.Size = new Size(108, 23);
            btn_select_database.TabIndex = 2;
            btn_select_database.Text = "Select Keyvault";
            btn_select_database.UseVisualStyleBackColor = true;
            btn_select_database.Click += btn_select_database_Click;
            // 
            // btn_ceateNewVault
            // 
            btn_ceateNewVault.Location = new Point(286, 219);
            btn_ceateNewVault.Name = "btn_ceateNewVault";
            btn_ceateNewVault.Size = new Size(125, 23);
            btn_ceateNewVault.TabIndex = 4;
            btn_ceateNewVault.Text = "Create new Keyvault";
            btn_ceateNewVault.UseVisualStyleBackColor = true;
            btn_ceateNewVault.Click += btn_ceateNewVault_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ceateNewVault);
            Controls.Add(btn_select_database);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDia_database_file;
        private Button btn_select_database;
        private Button btn_ceateNewVault;
    }
}