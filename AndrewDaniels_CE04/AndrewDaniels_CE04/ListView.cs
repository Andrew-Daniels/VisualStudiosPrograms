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
    public partial class ListView : Form
    {
        //create a delegate event for when the listview is closed
        public EventHandler ClosedListView;
        //create a delegate event for when the studentslistview is cleared
        public EventHandler ClearStudentListView;
        //create a delegate event for when the listviewobject is double clicked
        public EventHandler DoubleClickListViewObject;

        //create setter property for studentsListview to you can add an item to the listview
        public Students StudentsListView
        {
            set
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = value.ToString();
                lvi.ImageIndex = value.ImageIndex;
                lvi.Tag = value;

                studentsListView.Items.Add(lvi);
            }
        }
        //create a getter property for the selecteditem in the listview
        public Students SelectedStudent
        {
            get
            {
                return studentsListView.SelectedItems[0].Tag as Students;
            }
        }

        public ListView()
        {
            InitializeComponent();
        }
        
        //Event handler for when the listview form is closed.
        private void ListView_FormClosed(object sender, FormClosedEventArgs e)
        {
            //raise the closedlistview event
            if (ClosedListView != null)
            {
                ClosedListView(this, new EventArgs());
            }
        }
        //Event handler for when the clear tool strip button is clicked.
        private void clearToolStripBtn_Click(object sender, EventArgs e)
        {
            //raise the clearstudentlistview event
            if (ClearStudentListView != null)
            {
                ClearStudentListView(this, new EventArgs());
            }
            //remove all items from the listview
            studentsListView.Clear();
        }
        //handler for the clearstudentslist delegate event
        public void HandleClearStudentsList(object sender, EventArgs e)
        {
            //remove all items from the listview
            studentsListView.Clear(); 
        }
        //event handler for the double click event on a listview object
        private void studentsListView_DoubleClick(object sender, EventArgs e)
        {
            //raise the doubleclicklistviewobject event
            if (DoubleClickListViewObject != null)
            {
                DoubleClickListViewObject(this, new EventArgs());
            }
        }
    }
}
