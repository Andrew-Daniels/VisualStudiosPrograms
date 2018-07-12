namespace AndrewDaniels_CE10
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
            this.occupBx = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTxtBx = new System.Windows.Forms.TextBox();
            this.firstNameTxtBx = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.genderBx = new System.Windows.Forms.ComboBox();
            this.userIdTxtBx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.occupBx)).BeginInit();
            this.SuspendLayout();
            // 
            // occupBx
            // 
            this.occupBx.Location = new System.Drawing.Point(180, 183);
            this.occupBx.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.occupBx.Name = "occupBx";
            this.occupBx.Size = new System.Drawing.Size(141, 26);
            this.occupBx.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Occupation ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name:";
            // 
            // lastNameTxtBx
            // 
            this.lastNameTxtBx.Location = new System.Drawing.Point(180, 151);
            this.lastNameTxtBx.Name = "lastNameTxtBx";
            this.lastNameTxtBx.Size = new System.Drawing.Size(229, 26);
            this.lastNameTxtBx.TabIndex = 10;
            // 
            // firstNameTxtBx
            // 
            this.firstNameTxtBx.Location = new System.Drawing.Point(180, 119);
            this.firstNameTxtBx.Name = "firstNameTxtBx";
            this.firstNameTxtBx.Size = new System.Drawing.Size(229, 26);
            this.firstNameTxtBx.TabIndex = 9;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Lime;
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateBtn.Location = new System.Drawing.Point(180, 271);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(141, 57);
            this.updateBtn.TabIndex = 17;
            this.updateBtn.Text = "Save";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // genderBx
            // 
            this.genderBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderBx.FormattingEnabled = true;
            this.genderBx.Items.AddRange(new object[] {
            "M",
            "F"});
            this.genderBx.Location = new System.Drawing.Point(180, 215);
            this.genderBx.Name = "genderBx";
            this.genderBx.Size = new System.Drawing.Size(88, 28);
            this.genderBx.TabIndex = 18;
            // 
            // userIdTxtBx
            // 
            this.userIdTxtBx.Location = new System.Drawing.Point(373, 215);
            this.userIdTxtBx.Name = "userIdTxtBx";
            this.userIdTxtBx.ReadOnly = true;
            this.userIdTxtBx.Size = new System.Drawing.Size(100, 26);
            this.userIdTxtBx.TabIndex = 19;
            this.userIdTxtBx.Visible = false;
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 421);
            this.Controls.Add(this.userIdTxtBx);
            this.Controls.Add(this.genderBx);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.occupBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameTxtBx);
            this.Controls.Add(this.firstNameTxtBx);
            this.Name = "UserInput";
            this.Text = "UserInput";
            ((System.ComponentModel.ISupportInitialize)(this.occupBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown occupBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameTxtBx;
        private System.Windows.Forms.TextBox firstNameTxtBx;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ComboBox genderBx;
        private System.Windows.Forms.TextBox userIdTxtBx;
    }
}