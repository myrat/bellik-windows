namespace bellik
{
    partial class bellikForm
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
            this.tContent = new System.Windows.Forms.TextBox();
            this.btNew = new System.Windows.Forms.Button();
            this.tTitle = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImprt = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btEdSave = new System.Windows.Forms.Button();
            this.bListNotes1 = new bellik.bListNotes();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tContent
            // 
            this.tContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tContent.Location = new System.Drawing.Point(191, 62);
            this.tContent.Margin = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.tContent.Multiline = true;
            this.tContent.Name = "tContent";
            this.tContent.ReadOnly = true;
            this.tContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tContent.Size = new System.Drawing.Size(705, 515);
            this.tContent.TabIndex = 1;
            this.tContent.TextChanged += new System.EventHandler(this.tContent_TextChanged);
            // 
            // btNew
            // 
            this.btNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNew.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btNew.FlatAppearance.BorderSize = 0;
            this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNew.Location = new System.Drawing.Point(716, 27);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(84, 23);
            this.btNew.TabIndex = 2;
            this.btNew.Text = "new note";
            this.btNew.UseVisualStyleBackColor = false;
            // 
            // tTitle
            // 
            this.tTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tTitle.Location = new System.Drawing.Point(191, 27);
            this.tTitle.Name = "tTitle";
            this.tTitle.Size = new System.Drawing.Size(519, 20);
            this.tTitle.TabIndex = 3;
            this.tTitle.TextChanged += new System.EventHandler(this.tTitle_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImprt});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuImprt
            // 
            this.mnuImprt.Name = "mnuImprt";
            this.mnuImprt.Size = new System.Drawing.Size(127, 22);
            this.mnuImprt.Text = "Import dir";
            this.mnuImprt.Click += new System.EventHandler(this.mnuImprt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btEdSave
            // 
            this.btEdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEdSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btEdSave.Enabled = false;
            this.btEdSave.FlatAppearance.BorderSize = 0;
            this.btEdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdSave.Location = new System.Drawing.Point(806, 27);
            this.btEdSave.Name = "btEdSave";
            this.btEdSave.Size = new System.Drawing.Size(84, 23);
            this.btEdSave.TabIndex = 2;
            this.btEdSave.Text = "Edit";
            this.btEdSave.UseVisualStyleBackColor = false;
            this.btEdSave.Click += new System.EventHandler(this.btEdSave_Click);
            // 
            // bListNotes1
            // 
            this.bListNotes1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bListNotes1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.bListNotes1.FormattingEnabled = true;
            this.bListNotes1.ItemHeight = 42;
            this.bListNotes1.Location = new System.Drawing.Point(2, 62);
            this.bListNotes1.Margin = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.bListNotes1.Name = "bListNotes1";
            this.bListNotes1.Size = new System.Drawing.Size(185, 515);
            this.bListNotes1.TabIndex = 0;
            this.bListNotes1.SelectedIndexChanged += new System.EventHandler(this.bListNotes1_SelectedIndexChanged);
            // 
            // bellikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 585);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tTitle);
            this.Controls.Add(this.btEdSave);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.tContent);
            this.Controls.Add(this.bListNotes1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "bellikForm";
            this.Text = "BellikForm";
            this.Load += new System.EventHandler(this.bellikForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bListNotes bListNotes1;
        private System.Windows.Forms.TextBox tContent;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.TextBox tTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuImprt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btEdSave;        
    }
}

