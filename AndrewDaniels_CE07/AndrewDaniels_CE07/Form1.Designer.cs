namespace AndrewDaniels_CE07
{
    partial class Form1
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
            this.vfwBtn = new System.Windows.Forms.RadioButton();
            this.asdBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.classNameBx = new System.Windows.Forms.TextBox();
            this.hoursBx = new System.Windows.Forms.NumericUpDown();
            this.monthBx = new System.Windows.Forms.NumericUpDown();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseCodeBx = new System.Windows.Forms.TextBox();
            this.getInfoBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthBx)).BeginInit();
            this.SuspendLayout();
            // 
            // vfwBtn
            // 
            this.vfwBtn.AutoSize = true;
            this.vfwBtn.Location = new System.Drawing.Point(23, 58);
            this.vfwBtn.Name = "vfwBtn";
            this.vfwBtn.Size = new System.Drawing.Size(90, 29);
            this.vfwBtn.TabIndex = 0;
            this.vfwBtn.TabStop = true;
            this.vfwBtn.Text = "VFW";
            this.vfwBtn.UseVisualStyleBackColor = true;
            // 
            // asdBtn
            // 
            this.asdBtn.AutoSize = true;
            this.asdBtn.Location = new System.Drawing.Point(155, 58);
            this.asdBtn.Name = "asdBtn";
            this.asdBtn.Size = new System.Drawing.Size(86, 29);
            this.asdBtn.TabIndex = 1;
            this.asdBtn.TabStop = true;
            this.asdBtn.Text = "ASD";
            this.asdBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vfwBtn);
            this.groupBox1.Controls.Add(this.asdBtn);
            this.groupBox1.Location = new System.Drawing.Point(37, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Selection";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // descBx
            // 
            this.descBx.Location = new System.Drawing.Point(36, 46);
            this.descBx.Multiline = true;
            this.descBx.Name = "descBx";
            this.descBx.ReadOnly = true;
            this.descBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descBx.Size = new System.Drawing.Size(1046, 229);
            this.descBx.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Class Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Course Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Month:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.descBx);
            this.groupBox2.Location = new System.Drawing.Point(37, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1122, 298);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Credit Hours:";
            // 
            // classNameBx
            // 
            this.classNameBx.Location = new System.Drawing.Point(357, 114);
            this.classNameBx.Name = "classNameBx";
            this.classNameBx.ReadOnly = true;
            this.classNameBx.Size = new System.Drawing.Size(416, 31);
            this.classNameBx.TabIndex = 10;
            // 
            // hoursBx
            // 
            this.hoursBx.Location = new System.Drawing.Point(469, 321);
            this.hoursBx.Name = "hoursBx";
            this.hoursBx.ReadOnly = true;
            this.hoursBx.Size = new System.Drawing.Size(168, 31);
            this.hoursBx.TabIndex = 12;
            // 
            // monthBx
            // 
            this.monthBx.Location = new System.Drawing.Point(605, 207);
            this.monthBx.Name = "monthBx";
            this.monthBx.ReadOnly = true;
            this.monthBx.Size = new System.Drawing.Size(168, 31);
            this.monthBx.TabIndex = 13;
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(268, 38);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // courseCodeBx
            // 
            this.courseCodeBx.Location = new System.Drawing.Point(357, 207);
            this.courseCodeBx.Name = "courseCodeBx";
            this.courseCodeBx.ReadOnly = true;
            this.courseCodeBx.Size = new System.Drawing.Size(168, 31);
            this.courseCodeBx.TabIndex = 14;
            // 
            // getInfoBtn
            // 
            this.getInfoBtn.BackColor = System.Drawing.Color.Lime;
            this.getInfoBtn.Location = new System.Drawing.Point(37, 259);
            this.getInfoBtn.Name = "getInfoBtn";
            this.getInfoBtn.Size = new System.Drawing.Size(280, 103);
            this.getInfoBtn.TabIndex = 15;
            this.getInfoBtn.Text = "Get Class Information";
            this.getInfoBtn.UseVisualStyleBackColor = false;
            this.getInfoBtn.Click += new System.EventHandler(this.getInfoBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 769);
            this.Controls.Add(this.getInfoBtn);
            this.Controls.Add(this.courseCodeBx);
            this.Controls.Add(this.monthBx);
            this.Controls.Add(this.hoursBx);
            this.Controls.Add(this.classNameBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton vfwBtn;
        private System.Windows.Forms.RadioButton asdBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox descBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.TextBox classNameBx;
        private System.Windows.Forms.NumericUpDown hoursBx;
        private System.Windows.Forms.NumericUpDown monthBx;
        private System.Windows.Forms.TextBox courseCodeBx;
        private System.Windows.Forms.Button getInfoBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

