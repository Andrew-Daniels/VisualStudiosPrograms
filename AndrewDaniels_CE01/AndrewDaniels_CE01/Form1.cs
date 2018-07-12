using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AndrewDaniels_CE01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            /*Andrew Daniels
              Visual Frameworks Section 01
              Introduction to Windows Forms
             */

            InitializeComponent();
        }

        //Event handler for exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit program when exit button is pressed.
            Application.Exit();
        }

        //event handler for reset button
        private void resetButton_Click(object sender, EventArgs e)
        {
            //when reset button is clicked set all input controls to default values.
            nameTextBox.Text = null;
            isStudentCheckBox.Checked = false;
            ageUpDown.Value = 0;
        }

        //event handler for load tool strip menu item
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //When user presses the open button.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Load saved file into program.
                var path = openFileDialog.FileName;
                StreamReader rdr = new StreamReader(path);
                //Each line in the saved file gets read and filled into its perspective input control.
                nameTextBox.Text = rdr.ReadLine();
                isStudentCheckBox.Checked = Convert.ToBoolean(rdr.ReadLine());
                ageUpDown.Value = Convert.ToDecimal(rdr.ReadLine());
                
            }
        }

        //Event handler for when the save tool strip menu button is pressed.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //When the user presses the save button run the following code.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Save the file as the name the user typed into the save file field.
                var path = saveFileDialog1.FileName;
                StreamWriter writer = new StreamWriter(path);
                //Write each input control's contents into the newly created save file.
                writer.WriteLine(nameTextBox.Text);
                writer.WriteLine(isStudentCheckBox.Checked);
                writer.WriteLine(ageUpDown.Value);
                writer.Close();
            }
        }
    }
}
