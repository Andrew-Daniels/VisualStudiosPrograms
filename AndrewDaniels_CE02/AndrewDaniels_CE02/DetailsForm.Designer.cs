namespace AndrewDaniels_CE02
{
    partial class DetailsForm
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
            this.numStudentsTextBox = new System.Windows.Forms.TextBox();
            this.numTeachersTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numStudentsTextBox
            // 
            this.numStudentsTextBox.Location = new System.Drawing.Point(163, 62);
            this.numStudentsTextBox.Name = "numStudentsTextBox";
            this.numStudentsTextBox.ReadOnly = true;
            this.numStudentsTextBox.Size = new System.Drawing.Size(174, 31);
            this.numStudentsTextBox.TabIndex = 0;
            this.numStudentsTextBox.Text = "0";
            // 
            // numTeachersTextBox
            // 
            this.numTeachersTextBox.Location = new System.Drawing.Point(163, 134);
            this.numTeachersTextBox.Name = "numTeachersTextBox";
            this.numTeachersTextBox.ReadOnly = true;
            this.numTeachersTextBox.Size = new System.Drawing.Size(174, 31);
            this.numTeachersTextBox.TabIndex = 1;
            this.numTeachersTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "# of Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "# of Teachers";
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 229);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTeachersTextBox);
            this.Controls.Add(this.numStudentsTextBox);
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numStudentsTextBox;
        private System.Windows.Forms.TextBox numTeachersTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}