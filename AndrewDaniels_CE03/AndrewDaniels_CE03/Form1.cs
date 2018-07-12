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
    public partial class Form1 : Form
    {
        public Display displayForm;

        public Form1()
        {
            /* Andrew Daniels
               Visual Frameworks Section 01
               Custom Events CE03
             */ 
            InitializeComponent();
            
        }
        //Create the event delegate.
        private EventHandler StudentAdded;
        
        //create a people property called Data
        public People Data
        {
            get
            {
                //instantiate a new people object
                People p = new People();
                //set the values of the people object equal to the user input control fields
                p.Name = textBoxName.Text;
                p.Gender = comboBoxGender.Text;
                p.OlderThan18 = checkBox18OrOlder.Checked;
                p.Classes = upDownClasses.Value;
                return p;
            }

            set
            {
                //set the user input controls to their default People class constructor values.
                textBoxName.Text = value.Name;
                comboBoxGender.Text = value.Gender;
                checkBox18OrOlder.Checked = value.OlderThan18;
                upDownClasses.Value = value.Classes;
            }
        }
        //Property for the Students list
        public List<People> Students
        {
            get
            {
                return students;
            }

            set
            {
                students = value;
            }
        }
        //property for the display ToolTipChecked method
        public bool ToolTipChecked
        {
            set
            {
                displayToolStripMenuItem.Checked = value;
            }
        }

        //instantiate the students list
        List<People> students = new List<People>();

        //Event handler for the add students button
        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            //Add to the students list the People object created by the Data getter.
            //get data from the user input controls
            Students.Add(Data);
            //set the user input fields to their default values.
            Data = new People();

            //check to make sure that studentadded is not equal to null before raising the event
            if(StudentAdded != null)
            {
                //raise the StudentAdded event
                StudentAdded(this, new EventArgs());
            }
        }

        //Event handler for clear button clicked
        private void clearBtn_Click(object sender, EventArgs e)
        {
            //instantiate a new People object with default values
            People p = new People();
            //set input controls equal to the people's default values
            Data = p;
        }

        //event handler for exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close the application
            Application.Exit();
        }

        //event handler for display menu button
        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check to make sure display form isn't already running before opening a new one.
            if (displayForm == null || displayForm.IsDisposed == true)
            {
                //create a new display form with this main form passed in as an argument for the constructor
                displayForm = new Display(this);
                //Subscribe to the event
                StudentAdded += displayForm.HandleStudentAdded;
                //displayForm.StudentsRemoved += HandleStudentsRemoved;

                //add every student inside the students list to the StudentsListBox in the displayform
                foreach (People p in Students)
                {
                    displayForm.StudentsListBox = p;
                }
                //show the displayform modalless
                displayForm.Show();

                //add a check mark besides the display menu item
                displayToolStripMenuItem.Checked = true;
            }
            
        }
        
        //Event handler for clear menu item
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instantiate totalstudents variable equal to number of students in the list
            int totalStudents = Students.Count;

            //remove each item from the listBox until there aren't any left.
            while (--totalStudents >= 0)
            {
                displayForm.StudentsRemove = totalStudents;
            }

            //clear the list<>
            Students.Clear();
        }

        /*public void HandleStudentsRemoved(object sender, EventArgs e)
        {
            students.Clear();
        }*/


    }
}
