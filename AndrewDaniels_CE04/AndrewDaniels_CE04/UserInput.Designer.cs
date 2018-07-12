namespace AndrewDaniels_CE04
{
    partial class UserInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInput));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.classesLabel = new System.Windows.Forms.Label();
            this.upDownClasses = new System.Windows.Forms.NumericUpDown();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.checkBox18OrOlder = new System.Windows.Forms.CheckBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAddToListBtn = new System.Windows.Forms.ToolStripButton();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownClasses)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.classesLabel);
            this.groupBox.Controls.Add(this.upDownClasses);
            this.groupBox.Controls.Add(this.genderLabel);
            this.groupBox.Controls.Add(this.nameLabel);
            this.groupBox.Controls.Add(this.textBoxName);
            this.groupBox.Controls.Add(this.comboBoxGender);
            this.groupBox.Controls.Add(this.checkBox18OrOlder);
            this.groupBox.Controls.Add(this.clearBtn);
            this.groupBox.Location = new System.Drawing.Point(12, 83);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(486, 549);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "User Input";
            // 
            // classesLabel
            // 
            this.classesLabel.AutoSize = true;
            this.classesLabel.Location = new System.Drawing.Point(52, 259);
            this.classesLabel.Name = "classesLabel";
            this.classesLabel.Size = new System.Drawing.Size(127, 25);
            this.classesLabel.TabIndex = 11;
            this.classesLabel.Text = "# of classes";
            // 
            // upDownClasses
            // 
            this.upDownClasses.Location = new System.Drawing.Point(185, 257);
            this.upDownClasses.Name = "upDownClasses";
            this.upDownClasses.Size = new System.Drawing.Size(120, 31);
            this.upDownClasses.TabIndex = 10;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(87, 118);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(83, 25);
            this.genderLabel.TabIndex = 9;
            this.genderLabel.Text = "Gender";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(87, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 25);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(184, 57);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(270, 31);
            this.textBoxName.TabIndex = 3;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(184, 115);
            this.comboBoxGender.MaxDropDownItems = 2;
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(121, 33);
            this.comboBoxGender.TabIndex = 2;
            // 
            // checkBox18OrOlder
            // 
            this.checkBox18OrOlder.AutoSize = true;
            this.checkBox18OrOlder.Location = new System.Drawing.Point(185, 185);
            this.checkBox18OrOlder.Name = "checkBox18OrOlder";
            this.checkBox18OrOlder.Size = new System.Drawing.Size(147, 29);
            this.checkBox18OrOlder.TabIndex = 1;
            this.checkBox18OrOlder.Text = "18 or older";
            this.checkBox18OrOlder.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.Location = new System.Drawing.Point(160, 359);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(145, 85);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddToListBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(512, 39);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripAddToListBtn
            // 
            this.toolStripAddToListBtn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAddToListBtn.Image")));
            this.toolStripAddToListBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAddToListBtn.Name = "toolStripAddToListBtn";
            this.toolStripAddToListBtn.Size = new System.Drawing.Size(165, 36);
            this.toolStripAddToListBtn.Text = "Add to List";
            this.toolStripAddToListBtn.Click += new System.EventHandler(this.toolStripAddToListBtn_Click);
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 648);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox);
            this.Name = "UserInput";
            this.Text = "UserInput";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserInput_FormClosed);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownClasses)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label classesLabel;
        private System.Windows.Forms.NumericUpDown upDownClasses;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.CheckBox checkBox18OrOlder;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripAddToListBtn;
    }
}