using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrewDaniels_CE06
{
    public partial class TravelPlanner : Form
    {
        /*Andrew Daniels
         * Visual Frameworks Section 01
         * TreeView and TabControl CE06
         */
        //create member variables
        decimal m_TotalMiles;
        decimal m_TotalHours;
        int m_TotalLegs;

        public TravelPlanner()
        {
            InitializeComponent();
        }

        //create a property for the TravelLog class
        public TravelLog log
        {
            get
            {
                //instantiate new travellog object
                TravelLog l = new TravelLog();
                //fill in objects properties with user input
                l.Direction = directionBox.Text;
                l.Miles = milesUpDown.Value;
                l.Hours = hoursUpDown.Value;
                l.Mode = modeTxtbx.Text;
                //return created object
                return l;
            }
            set
            {
                //reset all user input fields to default values
                directionBox.SelectedIndex = 0;
                milesUpDown.Value = value.Miles;
                hoursUpDown.Value = value.Hours;
                modeTxtbx.Text = value.Mode;
            }
        }
        //create addtotreeview method
        private void AddToTreeView()
        {
            //Add users input to TreeView
            TreeNode node = new TreeNode();
            //create initial node that shows the direction
            node.Text = log.Direction;
            node.ImageIndex = log.ImageIndex;
            node.SelectedImageIndex = 5;

            //create a nested node for the first node
            TreeNode nestedNode1 = new TreeNode();
            nestedNode1.Text = ("Miles: " + log.Miles.ToString());
            nestedNode1.ImageIndex = 4;
            nestedNode1.SelectedImageIndex = 5;
            //add the nested node to the first node.
            node.Nodes.Add(nestedNode1);

            //create another nested node for the hours
            TreeNode nestedNode2 = new TreeNode();
            nestedNode2.Text = ("Hours: " + log.Hours.ToString());
            nestedNode2.ImageIndex = 6;
            nestedNode2.SelectedImageIndex = 5;
            //add the nested node to the first node
            node.Nodes.Add(nestedNode2);

            //create another nested node for the mode
            TreeNode nestedNode3 = new TreeNode();
            nestedNode3.Text = ("Mode: " + log.Mode);
            nestedNode3.ImageIndex = 7;
            nestedNode3.SelectedImageIndex = 5;
            //add the nested node to the first node
            node.Nodes.Add(nestedNode3);
            //add the initial node to the treeview with all the nested nodes inside it.
            treeView1.Nodes.Add(node);
        }
        //Event handler for when the form is activated
        private void TravelPlanner_Activated(object sender, EventArgs e)
        {
            //set the selected index to 0 on the direction box
            directionBox.SelectedIndex = 0;
        }
        //Event handler for exit tool strip item
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit the program
            Application.Exit();
        }
        //Event handler for add button click event
        private void addBtn_Click(object sender, EventArgs e)
        {
            //as long as the direction box text isn't equal to Nowhere, then run the conditional
            if (directionBox.Text != "Nowhere")
            {
                //Call AddToTreeView method
                AddToTreeView();
                //Append users input to total data.
                FindTotalOfData();
            }
        }
        //method for finding the total amount of data 
        private void FindTotalOfData()
        {
            //member variables add the values to their value to get the total value
            m_TotalMiles += milesUpDown.Value;
            m_TotalHours += hoursUpDown.Value;
            m_TotalLegs += 1;

            //make the textboxes reflect these changes.
            totalMiles.Text = m_TotalMiles.ToString();
            totalHours.Text = m_TotalHours.ToString();
            totalLegs.Text = m_TotalLegs.ToString();
        }
        //event handler for new tool strip menu item
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a new travel log
            TravelLog tl = new TravelLog();
            //clear all the nodes from the treeview
            treeView1.Nodes.Clear();

            //reset the user input fields to their default values
            log = tl;
            //call clear totals method that clears the totals for every variable
            ClearTotals();
        }
        //method that handles clearing the totals for the data on the totals page
        private void ClearTotals()
        {
            //set the member variables back to 0
            m_TotalMiles = 0;
            m_TotalHours = 0;
            m_TotalLegs = 0;
            //set the text boxes text value to null
            totalMiles.Text = null;
            totalHours.Text = null;
            totalLegs.Text = null;
        }
    }
}
