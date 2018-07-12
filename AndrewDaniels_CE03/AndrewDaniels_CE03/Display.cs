using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrewDaniels_CE03
{
    public partial class Display : Form
    {
        //declare a new Form1
        public Form1 mainForm;

        //add constructor argument that takes in form1 
        public Display(Form1 form1)
        {
            InitializeComponent();
            //make mainForm equal to the form1 passed into the constructor
            this.mainForm = form1;
        }


        //public EventHandler StudentsRemoved;

        //Create setter for StudentsListBox, enable ability to add items to the listbox
        public People StudentsListBox
        {
            set
            {
                studentsListBox.Items.Add(value);
            }
        }
        //Create setter for studentsListBox, enable ability to remove items from the listbox
        public int StudentsRemove
        {
            set
            {
                studentsListBox.Items.RemoveAt(value);
            }
        }
        
        //Event Handler for when a student is added to the list
        public void HandleStudentAdded(object sender, EventArgs e)
        {
            //Form1 is passed in as the Sender object
            //turn sender object into mainForm as a Form1
            Form1 mainForm = sender as Form1;

            //add each list<> item from the mainForm into the studentsListBox on displayform.
            foreach (People p in mainForm.Students)
            {
                //if the listBox doesn't contain the Person object already then add it.
                if (!studentsListBox.Items.Contains(p))
                {
                    studentsListBox.Items.Add(p);
                }
                
            }
        }

        //Event handler for clear button
        private void toolStripClearBtn_Click(object sender, EventArgs e)
        {
            //clear the items for the List<> and the ListBox.
            studentsListBox.Items.Clear();
            mainForm.Students.Clear();

            /*if (StudentsRemoved != null)
            {
                StudentsRemoved(this, new EventArgs());
            }
            */

        }

        //Event Handler for selected index changed in the student list box
        private void studentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check to make sure a valid selection is made before running if statement
            if (studentsListBox.SelectedIndex >= 0 && studentsListBox.SelectedIndex <= studentsListBox.Items.Count - 1)
            {
                //set the input user control data equal to the person selected's data.
                mainForm.Data = (People)studentsListBox.Items[studentsListBox.SelectedIndex] as People;
            }
        }
        //Event handler for when the display form is closed
        private void Display_FormClosed(object sender, FormClosedEventArgs e)
        {
            //uncheck the display menu tool tip item.
            mainForm.ToolTipChecked = false;
        }

        
    }
}
