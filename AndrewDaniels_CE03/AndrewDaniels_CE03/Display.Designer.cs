namespace AndrewDaniels_CE03
{
    partial class Display
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripClearBtn = new System.Windows.Forms.ToolStripButton();
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripClearBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(646, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripClearBtn
            // 
            this.toolStripClearBtn.AccessibleDescription = "Clear";
            this.toolStripClearBtn.AccessibleName = "Clear";
            this.toolStripClearBtn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripClearBtn.Image")));
            this.toolStripClearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripClearBtn.Name = "toolStripClearBtn";
            this.toolStripClearBtn.Size = new System.Drawing.Size(105, 36);
            this.toolStripClearBtn.Tag = "Clear";
            this.toolStripClearBtn.Text = "Clear";
            this.toolStripClearBtn.Click += new System.EventHandler(this.toolStripClearBtn_Click);
            // 
            // studentsListBox
            // 
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.ItemHeight = 25;
            this.studentsListBox.Location = new System.Drawing.Point(12, 75);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(622, 304);
            this.studentsListBox.TabIndex = 1;
            this.studentsListBox.SelectedIndexChanged += new System.EventHandler(this.studentsListBox_SelectedIndexChanged);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 405);
            this.Controls.Add(this.studentsListBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Display";
            this.Text = "Display";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Display_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripClearBtn;
        private System.Windows.Forms.ListBox studentsListBox;
    }
}