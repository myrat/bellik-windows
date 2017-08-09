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
            this.button1 = new System.Windows.Forms.Button();
            this.tTitle = new System.Windows.Forms.TextBox();
            this.bListNotes1 = new bellik.bListNotes();
            this.SuspendLayout();
            // 
            // tContent
            // 
            this.tContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tContent.Location = new System.Drawing.Point(191, 68);
            this.tContent.Margin = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.tContent.Multiline = true;
            this.tContent.Name = "tContent";
            this.tContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tContent.Size = new System.Drawing.Size(705, 509);
            this.tContent.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(812, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "new note";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tTitle
            // 
            this.tTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tTitle.Location = new System.Drawing.Point(191, 40);
            this.tTitle.Name = "tTitle";
            this.tTitle.Size = new System.Drawing.Size(614, 20);
            this.tTitle.TabIndex = 3;
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
            this.Controls.Add(this.tTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tContent);
            this.Controls.Add(this.bListNotes1);
            this.Name = "bellikForm";
            this.Text = "BellikForm";
            this.Load += new System.EventHandler(this.bellikForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.bellikForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bListNotes bListNotes1;
        private System.Windows.Forms.TextBox tContent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tTitle;        
    }
}

