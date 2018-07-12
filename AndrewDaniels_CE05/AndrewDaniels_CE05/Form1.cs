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
    public partial class mainForm : Form
    {
        /*Andrew Daniels
         *Custom Event Arguments CE05
         * Visual Frameworks Section 01
         */
         //Declare a variable for the total amount of ships in the listview
        int totalShips;
        //Declare a dialog form
        Dialog createShip;
        //Create a delegate event for use when a spaceship is selected
        private EventHandler ShipSelected;
        //Create a property for the Dialog form named createShip
        public Dialog CreateShip
        {
            get
            {
                return createShip;
            }

            set
            {
                createShip = value;
            }
        }
        //Create a custom event argument class that derives from EventArgs
        public class ModifyObjectEventArgs : EventArgs
        {
            //Declare a spaceship object that will hold the updated objects data.
            Spaceship ModifyObject;

            //Create a property for the Spaceship object named ModifyObject
            public Spaceship ModifyObject1
            {
                get
                {
                    return ModifyObject;
                }

                set
                {
                    ModifyObject = value;
                }
            }
            //Function that makes the ModifyObject equal to the passed in spaceship item from the Dialog form.
            public ModifyObjectEventArgs(Spaceship item)
            {
                ModifyObject = item;
            }
        }

        //Create a getter for the ListViewItem selected on the spaceShipListView
        //Returns a spaceship type object
            public Spaceship ListViewItemSelected
        {
            get
            {
                return spaceshipListView.SelectedItems[0].Tag as Spaceship;
            }
        }
        
        public mainForm()
        {
            InitializeComponent();
        }
        //Exit the program when exit button is clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Event handler for when the new tool strip menu item is clicked
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create a new Dialog form
            //Subscribe all of the relevant event delegates to the form
            //Show the form modeless
            CreateShip = new Dialog();
            CreateShip.AddShipToListView += HandleAddShipToListView;
            CreateShip.ModifyObject += HandleModifyObject;
            CreateShip.CloseForm += HandleCloseForm;
            CreateShip.Show(this);
        }
        //Event handler for when the large tool strip menu item is clicked
        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check to make sure the large menu item isn't already checked before running the following code.
            if (largeToolStripMenuItem.Checked != true)
            {
                //Check the large menu item
                largeToolStripMenuItem.Checked = true;
                //Uncheck the small menu item
                smallToolStripMenuItem.Checked = false;
                //Change the listview's view to Largeicon.
                spaceshipListView.View = View.LargeIcon;
            }
        }
        //Event handler for when the small tool strip menu item is clicked
        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check to make sure the small menu item isn't already checked before running the following code.
            if (smallToolStripMenuItem.Checked != true)
            {
                //Uncheck the large menu item
                largeToolStripMenuItem.Checked = false;
                //Check the small menu item
                smallToolStripMenuItem.Checked = true;
                //Change the listview's view to Smallicon
                spaceshipListView.View = View.SmallIcon;
            }
        }
        //Event handler for when the clear tool strip menu item is clicked
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //remove all items from the spaceship listview
            spaceshipListView.Items.Clear();
            //update the total count of spaceships to zero.
            totalShips = 0;
            totalSpaceShipsLabel.Text = totalShips.ToString();
        }
        //Event handler for adding spaceships to the listview
        public void HandleAddShipToListView(object sender, EventArgs e)
        {
            //make the Dialog form equal to the Dialog form that is already opened
            Dialog thisDialog = sender as Dialog;
            //create a new spaceship object equal to the data the user input onto the Dialog form.
            Spaceship s = thisDialog.Data as Spaceship;
            //instantiate a listview item
            ListViewItem lvi = new ListViewItem();
            //make listview item properties equal to the spaceship object
            lvi.Text = s.ToString();
            lvi.ImageIndex = s.ImageIndex;
            lvi.Tag = s;
            //add the new listviewitem to the listview
            spaceshipListView.Items.Add(lvi);

            //if totalships is equal to zero add one to the variable before autoincrementing it
            if (totalShips == 0)
            {
                totalShips = 1;
                totalSpaceShipsLabel.Text = totalShips++.ToString();
            }
            //if totalships already has value above 0 then just autoincrement without adding 1 before.
            else
            {
                totalSpaceShipsLabel.Text = totalShips++.ToString();
            }
        }
        //Event handler for when the spaceship listview item is doubleclicked
        private void spaceshipListView_DoubleClick(object sender, EventArgs e)
        {
            //create a new dialog form
            Dialog ship = new Dialog();
            //subscribe all the relevant event delegates to the form
            ship.AddShipToListView += HandleAddShipToListView;
            ship.ModifyObject += HandleModifyObject;
            ship.CloseForm += HandleCloseForm;
            ShipSelected += ship.HandleShipSelected;
            //show the apply button
            ship.VisibleApplyBtn = true;
            //show the dialog form modeless
            ship.Show(this);
            //raise the shipselected event
            if (ShipSelected != null && spaceshipListView.SelectedItems.Count > 0)
            {
                ShipSelected(this, new EventArgs());
            }
        }
        //custom event handler for ModifyObject
        private void HandleModifyObject(object sender, ModifyObjectEventArgs e)
        {
            //make the selected listview item equal to the passed through updated object from the dialog form.
            spaceshipListView.SelectedItems[0].Text = e.ModifyObject1.ToString();
            spaceshipListView.SelectedItems[0].ImageIndex = e.ModifyObject1.ImageIndex;
            spaceshipListView.SelectedItems[0].Tag = e.ModifyObject1;
        }
        //custom event handler for CloseForm
        private void HandleCloseForm(object sender, EventArgs e)
        {
            //when the user clicks the cancel button on the dialog form, close the dialog form.
            Dialog openDialog = sender as Dialog;
            openDialog.Close();
        }
    }
}
