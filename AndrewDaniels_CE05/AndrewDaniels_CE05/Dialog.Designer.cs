namespace AndrewDaniels_CE05
{
    partial class Dialog
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
            this.applyBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cruiseRadioBtn = new System.Windows.Forms.RadioButton();
            this.destroyerRadioBtn = new System.Windows.Forms.RadioButton();
            this.freighterRadioBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.activeDutyChkBx = new System.Windows.Forms.CheckBox();
            this.crewSize = new System.Windows.Forms.NumericUpDown();
            this.spaceShipName = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crewSize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.applyBtn);
            this.groupBox.Controls.Add(this.okBtn);
            this.groupBox.Controls.Add(this.cancelBtn);
            this.groupBox.Controls.Add(this.groupBox1);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.activeDutyChkBx);
            this.groupBox.Controls.Add(this.crewSize);
            this.groupBox.Controls.Add(this.spaceShipName);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(554, 593);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Create a Spaceship";
            // 
            // applyBtn
            // 
            this.applyBtn.BackColor = System.Drawing.Color.Lime;
            this.applyBtn.Location = new System.Drawing.Point(352, 508);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(93, 57);
            this.applyBtn.TabIndex = 11;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Visible = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(235, 508);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(92, 57);
            this.okBtn.TabIndex = 10;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Location = new System.Drawing.Point(95, 508);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(106, 57);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cruiseRadioBtn);
            this.groupBox1.Controls.Add(this.destroyerRadioBtn);
            this.groupBox1.Controls.Add(this.freighterRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(193, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 214);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick one";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type:";
            // 
            // cruiseRadioBtn
            // 
            this.cruiseRadioBtn.AutoSize = true;
            this.cruiseRadioBtn.Location = new System.Drawing.Point(42, 76);
            this.cruiseRadioBtn.Name = "cruiseRadioBtn";
            this.cruiseRadioBtn.Size = new System.Drawing.Size(112, 29);
            this.cruiseRadioBtn.TabIndex = 3;
            this.cruiseRadioBtn.TabStop = true;
            this.cruiseRadioBtn.Text = "Cruiser";
            this.cruiseRadioBtn.UseVisualStyleBackColor = true;
            // 
            // destroyerRadioBtn
            // 
            this.destroyerRadioBtn.AutoSize = true;
            this.destroyerRadioBtn.Location = new System.Drawing.Point(42, 123);
            this.destroyerRadioBtn.Name = "destroyerRadioBtn";
            this.destroyerRadioBtn.Size = new System.Drawing.Size(136, 29);
            this.destroyerRadioBtn.TabIndex = 4;
            this.destroyerRadioBtn.TabStop = true;
            this.destroyerRadioBtn.Text = "Destroyer";
            this.destroyerRadioBtn.UseVisualStyleBackColor = true;
            // 
            // freighterRadioBtn
            // 
            this.freighterRadioBtn.AutoSize = true;
            this.freighterRadioBtn.Location = new System.Drawing.Point(42, 173);
            this.freighterRadioBtn.Name = "freighterRadioBtn";
            this.freighterRadioBtn.Size = new System.Drawing.Size(129, 29);
            this.freighterRadioBtn.TabIndex = 5;
            this.freighterRadioBtn.TabStop = true;
            this.freighterRadioBtn.Text = "Freighter";
            this.freighterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Crew Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Spaceship Name:";
            // 
            // activeDutyChkBx
            // 
            this.activeDutyChkBx.AutoSize = true;
            this.activeDutyChkBx.Location = new System.Drawing.Point(193, 172);
            this.activeDutyChkBx.Name = "activeDutyChkBx";
            this.activeDutyChkBx.Size = new System.Drawing.Size(153, 29);
            this.activeDutyChkBx.TabIndex = 2;
            this.activeDutyChkBx.Text = "Active Duty";
            this.activeDutyChkBx.UseVisualStyleBackColor = true;
            // 
            // crewSize
            // 
            this.crewSize.Location = new System.Drawing.Point(193, 110);
            this.crewSize.Name = "crewSize";
            this.crewSize.Size = new System.Drawing.Size(120, 31);
            this.crewSize.TabIndex = 1;
            // 
            // spaceShipName
            // 
            this.spaceShipName.Location = new System.Drawing.Point(193, 57);
            this.spaceShipName.Name = "spaceShipName";
            this.spaceShipName.Size = new System.Drawing.Size(355, 31);
            this.spaceShipName.TabIndex = 0;
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 617);
            this.Controls.Add(this.groupBox);
            this.Name = "Dialog";
            this.Text = "Dialog";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crewSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cruiseRadioBtn;
        private System.Windows.Forms.RadioButton destroyerRadioBtn;
        private System.Windows.Forms.RadioButton freighterRadioBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox activeDutyChkBx;
        private System.Windows.Forms.NumericUpDown crewSize;
        private System.Windows.Forms.TextBox spaceShipName;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label3;
    }
}