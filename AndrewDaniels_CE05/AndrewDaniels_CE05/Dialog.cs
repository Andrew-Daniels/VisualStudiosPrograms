using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrewDaniels_CE05
{
    public partial class Dialog : Form
    {
        /*Andrew Daniels
         *Custom Event Arguments CE05
         * Visual Frameworks Section 01
         */

        public Dialog()
        {
            InitializeComponent();
        }

        //Create an Event delegate with args for use when needing to modify and object
        public EventHandler<mainForm.ModifyObjectEventArgs> ModifyObject;
        //Create an Event delegate for use when needing to add a spaceship to the listview
        public EventHandler AddShipToListView;
        //create an event delegate for use when closing the dialog form
        public EventHandler CloseForm;

        //create a Property for the Spaceship class
        public Spaceship Data
        {
            get
            {
                //Create a new spaceship with the fields taken from the user
                Spaceship s = new Spaceship();
                s.Name = spaceShipName.Text;
                s.CrewSize = crewSize.Value;
                s.ActiveDuty = activeDutyChkBx.Checked;
                s.Cruiser = cruiseRadioBtn.Checked;
                s.Destroyer = destroyerRadioBtn.Checked;
                s.Freighter = freighterRadioBtn.Checked;
                return s;
            }

            set
            {
                //Use this setter when needing to reset the user input fields back to default
                spaceShipName.Text = value.Name;
                crewSize.Value = value.CrewSize;
                activeDutyChkBx.Checked = value.ActiveDuty;
                cruiseRadioBtn.Checked = value.Cruiser;
                destroyerRadioBtn.Checked = value.Destroyer;
                freighterRadioBtn.Checked = value.Freighter;
            }
        }
        
        //Create a property for the Applybutton's visibility
        public bool VisibleApplyBtn
        {
            set
            {
                applyBtn.Visible = value;
            }
        }
        //Event handler for the Ok button click event
        private void okBtn_Click(object sender, EventArgs e)
        {
            //raise the AddShipToListView event
            if (AddShipToListView != null)
            {
                AddShipToListView(this, new EventArgs());
            }
            //set the user input fields back to default
            Data = new Spaceship();
        }
        //Event handler for Apply button click event
        private void applyBtn_Click(object sender, EventArgs e)
        {
            //raise the modifyobject event
            if (ModifyObject != null)
            {
                //pass in the users updated input data
                ModifyObject(this, new mainForm.ModifyObjectEventArgs(Data));
            }
        }
        //Event handler for cancel button click event
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //raise the CloseForm event
            if (CloseForm != null)
            {
                CloseForm(this, new EventArgs());
            }
        }
        //Custom event handler for ShipSelected
        public void HandleShipSelected(object sender, EventArgs e)
        {
            //get access to the mainForm through the sender object
            mainForm main = sender as mainForm;
            //fill the user input fields with the data from the object selected in the listview on mainform.
            Data = main.ListViewItemSelected as Spaceship;
        }
    }
}
