using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrewDaniels_CE10
{
    public partial class UserInput : Form
    {
        /*Andrew Daniels
         * Visual Frameworks Section 01
         * Synthesis CE10
         */
        //create custom event with args for when an object is modified
        public EventHandler<Form1.ModifyObjectEventArgs> ModifyObject;
        
        public UserInput()
        {
            InitializeComponent();
        }

        //create a property for the person class called data
        public Person Data
        {
            get
            {
                //create a person object with the data from the userinput controls
                Person p = new Person(userIdTxtBx.Text, firstNameTxtBx.Text, lastNameTxtBx.Text, occupBx.Value, genderBx.Text);
                //return the person object
                return p;
            }
        }
        //create a custom event handler for when a person is selected
        public void HandlePersonSelected(object sender, EventArgs e)
        {
            //instantiate new form1 from the original running mainform
            Form1 mainForm = sender as Form1;
            //instantiate a new person object equal to the selected item on the listview on the mainform
            Person newPerson = mainForm.SelectedItem;

            //fill in the userinput controls with the data from the newPerson
            firstNameTxtBx.Text = newPerson.FName;
            lastNameTxtBx.Text = newPerson.LName;
            occupBx.Value = newPerson.OccupId;
            genderBx.Text = newPerson.Gender;
            userIdTxtBx.Text = newPerson.UserId;
        }
        //create an event handler for the update button click event
        private void updateBtn_Click(object sender, EventArgs e)
        {
            //invoke the modifyobject custom event with args
            if (ModifyObject != null)
            {
                //pass the data from the userinput controls as an argument for the mainform
                ModifyObject(this, new Form1.ModifyObjectEventArgs(Data));
            }
        }
    }
}
