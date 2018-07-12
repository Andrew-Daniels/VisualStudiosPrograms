namespace AndrewDaniels_CE02
{
    partial class universityForm1
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.classesLabel = new System.Windows.Forms.Label();
            this.upDownClasses = new System.Windows.Forms.NumericUpDown();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addTeacherBtn = new System.Windows.Forms.Button();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.checkBox18OrOlder = new System.Windows.Forms.CheckBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.studentLabel = new System.Windows.Forms.Label();
            this.moveToStudentBtn = new System.Windows.Forms.Button();
            this.moveToTeacherBtn = new System.Windows.Forms.Button();
            this.listBoxTeachers = new System.Windows.Forms.ListBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.removeBtn = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownClasses)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.classesLabel);
            this.groupBox.Controls.Add(this.upDownClasses);
            this.groupBox.Controls.Add(this.genderLabel);
            this.groupBox.Controls.Add(this.nameLabel);
            this.groupBox.Controls.Add(this.addTeacherBtn);
            this.groupBox.Controls.Add(this.addStudentBtn);
            this.groupBox.Controls.Add(this.textBoxName);
            this.groupBox.Controls.Add(this.comboBoxGender);
            this.groupBox.Controls.Add(this.checkBox18OrOlder);
            this.groupBox.Controls.Add(this.clearBtn);
            this.groupBox.Location = new System.Drawing.Point(12, 66);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(366, 529);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "User Input";
            // 
            // classesLabel
            // 
            this.classesLabel.AutoSize = true;
            this.classesLabel.Location = new System.Drawing.Point(6, 259);
            this.classesLabel.Name = "classesLabel";
            this.classesLabel.Size = new System.Drawing.Size(127, 25);
            this.classesLabel.TabIndex = 11;
            this.classesLabel.Text = "# of classes";
            // 
            // upDownClasses
            // 
            this.upDownClasses.Location = new System.Drawing.Point(139, 257);
            this.upDownClasses.Name = "upDownClasses";
            this.upDownClasses.Size = new System.Drawing.Size(120, 31);
            this.upDownClasses.TabIndex = 10;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(41, 118);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(83, 25);
            this.genderLabel.TabIndex = 9;
            this.genderLabel.Text = "Gender";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(41, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 25);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            // 
            // addTeacherBtn
            // 
            this.addTeacherBtn.Location = new System.Drawing.Point(191, 336);
            this.addTeacherBtn.Name = "addTeacherBtn";
            this.addTeacherBtn.Size = new System.Drawing.Size(154, 44);
            this.addTeacherBtn.TabIndex = 7;
            this.addTeacherBtn.Text = "Add Teacher";
            this.addTeacherBtn.UseVisualStyleBackColor = true;
            this.addTeacherBtn.Click += new System.EventHandler(this.addTeacher_Click);
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(11, 336);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(154, 44);
            this.addStudentBtn.TabIndex = 6;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(138, 57);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 31);
            this.textBoxName.TabIndex = 3;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(138, 115);
            this.comboBoxGender.MaxDropDownItems = 2;
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(121, 33);
            this.comboBoxGender.TabIndex = 2;
            // 
            // checkBox18OrOlder
            // 
            this.checkBox18OrOlder.AutoSize = true;
            this.checkBox18OrOlder.Location = new System.Drawing.Point(139, 185);
            this.checkBox18OrOlder.Name = "checkBox18OrOlder";
            this.checkBox18OrOlder.Size = new System.Drawing.Size(147, 29);
            this.checkBox18OrOlder.TabIndex = 1;
            this.checkBox18OrOlder.Text = "18 or older";
            this.checkBox18OrOlder.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.Location = new System.Drawing.Point(114, 413);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(145, 85);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.Location = new System.Drawing.Point(1034, 86);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(102, 25);
            this.teacherLabel.TabIndex = 15;
            this.teacherLabel.Text = "Teachers";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(555, 86);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(97, 25);
            this.studentLabel.TabIndex = 14;
            this.studentLabel.Text = "Students";
            // 
            // moveToStudentBtn
            // 
            this.moveToStudentBtn.Enabled = false;
            this.moveToStudentBtn.Location = new System.Drawing.Point(789, 296);
            this.moveToStudentBtn.Name = "moveToStudentBtn";
            this.moveToStudentBtn.Size = new System.Drawing.Size(130, 45);
            this.moveToStudentBtn.TabIndex = 13;
            this.moveToStudentBtn.Text = "<";
            this.moveToStudentBtn.UseVisualStyleBackColor = true;
            this.moveToStudentBtn.Click += new System.EventHandler(this.moveToStudent_Click);
            // 
            // moveToTeacherBtn
            // 
            this.moveToTeacherBtn.Enabled = false;
            this.moveToTeacherBtn.Location = new System.Drawing.Point(789, 373);
            this.moveToTeacherBtn.Name = "moveToTeacherBtn";
            this.moveToTeacherBtn.Size = new System.Drawing.Size(130, 45);
            this.moveToTeacherBtn.TabIndex = 12;
            this.moveToTeacherBtn.Text = ">";
            this.moveToTeacherBtn.UseVisualStyleBackColor = true;
            this.moveToTeacherBtn.Click += new System.EventHandler(this.moveToTeacher_Click);
            // 
            // listBoxTeachers
            // 
            this.listBoxTeachers.FormattingEnabled = true;
            this.listBoxTeachers.ItemHeight = 25;
            this.listBoxTeachers.Location = new System.Drawing.Point(962, 126);
            this.listBoxTeachers.Name = "listBoxTeachers";
            this.listBoxTeachers.Size = new System.Drawing.Size(256, 454);
            this.listBoxTeachers.TabIndex = 5;
            this.listBoxTeachers.SelectedIndexChanged += new System.EventHandler(this.teachersIndexSelected);
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 25;
            this.listBoxStudents.Location = new System.Drawing.Point(482, 126);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(256, 454);
            this.listBoxStudents.TabIndex = 4;
            this.listBoxStudents.SelectedIndexChanged += new System.EventHandler(this.studentIndexSelected);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.detailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1326, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(165, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(165, 38);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem});
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.detailToolStripMenuItem.Text = "Stats";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.displayToolStripMenuItem.Text = "Display";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Red;
            this.removeBtn.Enabled = false;
            this.removeBtn.Location = new System.Drawing.Point(744, 519);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(212, 61);
            this.removeBtn.TabIndex = 16;
            this.removeBtn.Text = "Remove from List";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // universityForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 610);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.teacherLabel);
            this.Controls.Add(this.moveToTeacherBtn);
            this.Controls.Add(this.moveToStudentBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBoxTeachers);
            this.Controls.Add(this.listBoxStudents);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "universityForm1";
            this.Text = "Full Sail University";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownClasses)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label classesLabel;
        private System.Windows.Forms.NumericUpDown upDownClasses;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addTeacherBtn;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.ListBox listBoxTeachers;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.CheckBox checkBox18OrOlder;
        private System.Windows.Forms.Button moveToStudentBtn;
        private System.Windows.Forms.Button moveToTeacherBtn;
        public System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button removeBtn;
    }
}

