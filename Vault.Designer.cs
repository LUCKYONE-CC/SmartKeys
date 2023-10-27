namespace SmartKeys
{
    partial class Vault
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
            lB_entryListBox = new ListBox();
            btn_createEntry = new Button();
            btn_deleteEntry = new Button();
            pan_form = new Panel();
            SuspendLayout();
            // 
            // lB_entryListBox
            // 
            lB_entryListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lB_entryListBox.FormattingEnabled = true;
            lB_entryListBox.ItemHeight = 15;
            lB_entryListBox.Location = new Point(12, 42);
            lB_entryListBox.Name = "lB_entryListBox";
            lB_entryListBox.Size = new Size(156, 394);
            lB_entryListBox.TabIndex = 0;
            lB_entryListBox.SelectedIndexChanged += lB_entryListBox_SelectedIndexChanged;
            // 
            // btn_createEntry
            // 
            btn_createEntry.Location = new Point(12, 12);
            btn_createEntry.Name = "btn_createEntry";
            btn_createEntry.Size = new Size(75, 23);
            btn_createEntry.TabIndex = 1;
            btn_createEntry.Text = "Create new";
            btn_createEntry.UseVisualStyleBackColor = true;
            btn_createEntry.Click += btn_createEntry_Click;
            // 
            // btn_deleteEntry
            // 
            btn_deleteEntry.Location = new Point(93, 12);
            btn_deleteEntry.Name = "btn_deleteEntry";
            btn_deleteEntry.Size = new Size(75, 23);
            btn_deleteEntry.TabIndex = 2;
            btn_deleteEntry.Text = "Delete";
            btn_deleteEntry.UseVisualStyleBackColor = true;
            btn_deleteEntry.Click += btn_deleteEntry_Click;
            // 
            // pan_form
            // 
            pan_form.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pan_form.Location = new Point(174, 42);
            pan_form.Name = "pan_form";
            pan_form.Size = new Size(614, 394);
            pan_form.TabIndex = 3;
            // 
            // Vault
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pan_form);
            Controls.Add(btn_deleteEntry);
            Controls.Add(btn_createEntry);
            Controls.Add(lB_entryListBox);
            Name = "Vault";
            Text = "Vault";
            FormClosed += Vault_FormClosed;
            Load += Vault_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lB_entryListBox;
        private Button btn_createEntry;
        private Button btn_deleteEntry;
        private Panel pan_form;
    }
}