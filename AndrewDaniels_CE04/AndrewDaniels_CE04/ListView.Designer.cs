namespace AndrewDaniels_CE04
{
    partial class ListView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListView));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.studentsListView = new System.Windows.Forms.ListView();
            this.clearToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Male.png");
            this.imageList1.Images.SetKeyName(1, "Female.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(838, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // studentsListView
            // 
            this.studentsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsListView.LargeImageList = this.imageList1;
            this.studentsListView.Location = new System.Drawing.Point(0, 39);
            this.studentsListView.MultiSelect = false;
            this.studentsListView.Name = "studentsListView";
            this.studentsListView.Size = new System.Drawing.Size(838, 513);
            this.studentsListView.TabIndex = 1;
            this.studentsListView.UseCompatibleStateImageBehavior = false;
            this.studentsListView.DoubleClick += new System.EventHandler(this.studentsListView_DoubleClick);
            // 
            // clearToolStripBtn
            // 
            this.clearToolStripBtn.AccessibleDescription = "Clear";
            this.clearToolStripBtn.AccessibleName = "Clear";
            this.clearToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripBtn.Image")));
            this.clearToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearToolStripBtn.Name = "clearToolStripBtn";
            this.clearToolStripBtn.Size = new System.Drawing.Size(105, 36);
            this.clearToolStripBtn.Tag = "Clear";
            this.clearToolStripBtn.Text = "Clear";
            this.clearToolStripBtn.Click += new System.EventHandler(this.clearToolStripBtn_Click);
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 552);
            this.Controls.Add(this.studentsListView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ListView";
            this.Text = "ListView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListView_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListView studentsListView;
        private System.Windows.Forms.ToolStripButton clearToolStripBtn;
    }
}