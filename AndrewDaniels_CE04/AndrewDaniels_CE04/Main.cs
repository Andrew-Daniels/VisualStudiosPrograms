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
    public partial class Main : Form
    {
        /*Andrew Daniels
         *Visual Frameworks Section 01
         *CE04: ListViews
         */
         //declare a listview form
        ListView lsv;
        //declare a userinput form
        UserInput usrInp;
        //instantiate a List to hold all students created.
        List<Students> studentList = new List<Students>();
        //declare a variable to store the amount of input windows that are open.
        int openInputWins;

        //create a delegate event for when students are cleared from the list<>.
        private EventHandler ClearStudentsList;

        public Main()
        {
            InitializeComponent();
        }

        //Created a setter for checking the display tool strip menu item
        public bool DisplayChecked
        {
            set
            {
                displayToolStripMenuItem.Checked = value;
            }
        }
        //create a property for the list<>
        public List<Students> StudentList
        {
            get
            {
                return studentList;
            }

            set
            {
                studentList = value;
            }
        }
        //create a property for the userinput form
        public UserInput UsrInp
        {
            get
            {
                return usrInp;
            }

            set
            {
                usrInp = value;
            }
        }
        //create a property for the listview form
        public ListView Lsv
        {
            get
            {
                return lsv;
            }

            set
            {
                lsv = value;
            }
        }
        //Event handler for the new input window button on the click event
        private void newInputWinBtn_Click(object sender, EventArgs e)
        {
            //instantiate the userinput form
            //subscribe all the relevent events to the form
            UsrInp = new UserInput();
            UsrInp.StudentsAddedToList += HandleStudentsAddedToList;
            UsrInp.StudentsAddedToListView += HandleStudentsAddedToListView;
            UsrInp.CloseInputWindow += HandleCloseInputWindow;
            //show the form modeless
            UsrInp.Show(this);
            //auto increment the openinput windows variable
            openInputWins++;
            //change the text of the textbox to however many input windows are open.
            inpWinsOpen.Text = openInputWins.ToString();
        }
        //Event handler for the display tool strip menu item on the event click
        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check to make sure the listview form is either null or disposed of.
            //that way there aren't ever 2 listview forms open at one time
            if (Lsv == null || Lsv.IsDisposed)
            {
                //create a listview form
                //subscribe all the revelent events to the form
                Lsv = new ListView();
                Lsv.ClosedListView += HandleClosedListView;
                Lsv.ClearStudentListView += HandleClearStudentsListView;
                ClearStudentsList += Lsv.HandleClearStudentsList;
                Lsv.DoubleClickListViewObject += HandleDoubleClickListViewObject;
                //add every item in the list on the mainForm to the listview on the listview form.
                foreach (Students s in studentList)
                {
                    Lsv.StudentsListView = s;
                }
                //show the listview form modeless
                Lsv.Show(this);
                //check the display tool strip menu item
                displayToolStripMenuItem.Checked = true;
            }
            
        }
        //custom event handler for studentsaddedtolist
        public void HandleStudentsAddedToList(object sender, EventArgs e)
        {
            //get access to the already active userInput form
            UserInput openUsrInp = sender as UserInput;
            //add the users input data to the list<> on the main form
            studentList.Add(openUsrInp.Data);
            //autoincrement the amount of students that are stored in the list's variable
            numStudentsTextBox.Text = studentList.Count.ToString();
        }
        //custom event handler for studentsaddedtolistview
        public void HandleStudentsAddedToListView(object sender, EventArgs e)
        {
            //check to make sure there is an active listview form before running the following code
            if (Lsv != null)
            {
                //get access to the already active userInput form
                UserInput openUsrInp = sender as UserInput;
                //add to the listview the users input data from the userinput form.
                Students s = new Students();
                s = openUsrInp.Data;
                Lsv.StudentsListView = s;
            }
        }
        //custom event handler for when the input form is closed.
        public void HandleCloseInputWindow(object sender, EventArgs e)
        {
            //decrement the amount of input windows that are open for the variable that stores the amount
            openInputWins--;
            inpWinsOpen.Text = openInputWins.ToString();
        }
        //custom event handler for when the listview is closed
        public void HandleClosedListView(object sender, EventArgs e)
        {
            //uncheck the display tool strip menu item
            displayToolStripMenuItem.Checked = false;
        }
        //custom event handler for clearing the students list view
        public void HandleClearStudentsListView(object sender, EventArgs e)
        {
            //remove all items from the list<>
            studentList.Clear();
            //change the textbox's text to the amount of items in the list<>
            numStudentsTextBox.Text = studentList.Count.ToString();
        }
        //event handler for when the clear tool strip menu item is clicked
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clear all items from the list<>
            studentList.Clear();
            //change the textbox's text to the amount of items in the list<>
            numStudentsTextBox.Text = studentList.Count.ToString();
            //raise the clearstudentslist event
            if (ClearStudentsList != null)
            {
                ClearStudentsList(this, new EventArgs());
            }
        }
        //event handler for exit tool strip button on click event
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit the program
            Application.Exit();
        }
        //custom event handler for doubleclicklistviewobject
        public void HandleDoubleClickListViewObject(object sender, EventArgs e)
        {
            //call the newinputwinbtn method
            //create a new input form
            newInputWinBtn_Click(sender, e);
            //get access to the already active listview form
            ListView openLsv = sender as ListView;
            //fill in the input fields on the userinput form with the selected students information.
            UsrInp.Data = openLsv.SelectedStudent;
        }
    }
}
