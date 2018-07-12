using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrewDaniels_CE04
{
    /*Andrew Daniels
        *Visual Frameworks Section 01
        *CE04: ListViews
        */
    public partial class UserInput : Form
    {
        //Create delegate event for when students are added to the list
        public EventHandler StudentsAddedToList;
        //Create a delegate event for when students are added to the listview
        public EventHandler StudentsAddedToListView;
        //Create a delegate event for when the Userinput form is closed
        public EventHandler CloseInputWindow;

        public UserInput()
        {
            InitializeComponent();
        }
        //create a property for a student type object
        public Students Data
        {
            get
            {
                //create a new student that will take in the users input
                Students s = new Students();
                s.Name = textBoxName.Text;
                s.Gender = comboBoxGender.Text;
                s.Over18 = checkBox18OrOlder.Checked;
                s.Classes = upDownClasses.Value;
                s.ImageIndex = comboBoxGender.SelectedIndex;
                return s;

            }
            set
            {
                //this will allow for reseting the input fields back to default.
                textBoxName.Text = value.Name;
                comboBoxGender.Text = value.Gender;
                checkBox18OrOlder.Checked = value.Over18;
                upDownClasses.Value = value.Classes;
            }
        }
        //Event handler for when the user clicks the clear button
        private void clearBtn_Click(object sender, EventArgs e)
        {
            //set the input fields back to their default values.
            Data = new Students();
        }
        //Event handler for when the userInput form is closed
        private void UserInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            //raise the closeInputwindow event
            if (CloseInputWindow != null)
            {
                CloseInputWindow(this, new EventArgs());
            }
        }
        //event handler for toolstrip add to list button when it is clicked.
        private void toolStripAddToListBtn_Click(object sender, EventArgs e)
        {
            //raise the studentsaddedtolist event
            if (StudentsAddedToList != null)
            {
                StudentsAddedToList(this, new EventArgs());
            }
            //raise the studentsaddedtolistview event
            if (StudentsAddedToListView != null)
            {
                StudentsAddedToListView(this, new EventArgs());
            }
            //set the input fields to their default values.
            Data = new Students();
        }
    }
}
