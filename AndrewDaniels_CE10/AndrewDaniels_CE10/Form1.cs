using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.IO;

namespace AndrewDaniels_CE10
{
    public partial class Form1 : Form
    {
        /*Andrew Daniels
         * Visual Frameworks Section 01
         * Synthesis CE10
         */ 
        //Instantiate a new connection
        MySqlConnection conn = new MySqlConnection();
        //Instantiate a datatable
        DataTable theData = new DataTable();
        //instantiate a variable that will hold the row index number
        int row = 0;
        //create an event delegate for when a person is selected in the listview
        private EventHandler PersonSelected;
        //declare a userinput form
        UserInput usrInp;

        public Form1()
        {
            InitializeComponent();
            //call connect method, connect to database
            Connect();
            //call retrievedata method, retrieve data from the database
            RetrieveData();
        }

        //Create a custom eventarg
        public class ModifyObjectEventArgs : EventArgs
        {
            //create a person object
            Person ModifyObject;

            //create a property for the person object
            public Person ModifyObject1
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
            //create a method that makes the person object equal to the item passed in 
            //from the userinput form
            public ModifyObjectEventArgs(Person item)
            {
                ModifyObject = item;
            }
        }
        //Custom event arg handler for when modifying an object in the listview
        public void HandleModifyObject(object sender, ModifyObjectEventArgs e)
        {
            //update the database with the new data
                UpdateDatabase(e.ModifyObject1.UserId, e.ModifyObject1.FName, e.ModifyObject1.LName, e.ModifyObject1.OccupId, e.ModifyObject1.Gender);
            //update the listview with the new objects data
                personListView.SelectedItems[0].Tag = e.ModifyObject1;
                personListView.SelectedItems[0].Text = e.ModifyObject1.ToString();
                personListView.SelectedItems[0].ImageIndex = e.ModifyObject1.ImageIndex;
        }
        //create a method that updates the database with the new data
        public void UpdateDatabase(string uid, string fName, string lName, decimal occupId, string gender)
        {
            //try to input information into the database
            try
            {
                string sql = @"UPDATE users SET firstname = '" + fName + "', lastname = '" + lName + "', occupationId = '" + occupId + "', gender = '" + gender + "' WHERE userid = '" + uid + "'";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
            }
            //catch an error whenever the user types in an invalid occupation id
            catch (MySqlException)
            {
                MessageBox.Show("You entered an invalid occupation id, please select a different one instead!");
            }
        }
        //create a property for the selected item in the listview
        public Person SelectedItem
        {
            get
            {
                //return the person object from the selected item tag in the listview
                return personListView.SelectedItems[0].Tag as Person;
            }
        }
        //create a method that builds the connection string 
        private string BuildConnectionString()
        {
            //instantiate the serverip variable equal to null
            string serverIP = null;

            //try to read a file named connect.txt inside the VFW folder
            try
            {
                //open the text file using the stream reader
                using (StreamReader sr = new StreamReader("C:\\VFW\\connect.txt"))
                {
                    //read the whole file and make serverIP equal to what is read
                    serverIP = sr.ReadToEnd();
                }

            }
            //catch any errors, such as not being able to find the file
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            //return the buildconnectionstring
            return "server=" + serverIP + ";uid=dbsAdmin;pwd=password;database=exampleDatabase;port=8889";
        }
        //create a method that connects to the database
        private void Connect()
        {
            //Connect to database
            try
            {
                conn.ConnectionString = BuildConnectionString();
                conn.Open();
            }
            //catch any errors regarding trying to connect to the databse
            catch (MySqlException e)
            {
                // message string variable
                string msg;
                //check what exception was received

                switch (e.Number)
                {
                    case 0:
                        msg = e.ToString();
                        break;
                    case 1042:
                        msg = "Can't resolve host address.";
                        break;
                    case 1045:
                        msg = "Invalid username/password";
                        break;
                    default:
                        msg = e.ToString();
                        break;
                }
                //show the error message in a messagebox for the user
                MessageBox.Show(msg);
            }
        }
        //create a method that retrieves data from the database
        private void RetrieveData()
        {
            //create an SQL statement
            string sql = "SELECT userid, firstname, lastname, occupationId, gender FROM users LIMIT 15";
            MySqlDataAdapter adr = new MySqlDataAdapter(sql, conn);

            //set the adapters command type to text
            adr.SelectCommand.CommandType = CommandType.Text;

            // The fill method adds rows to match the data source
            // we're filling the datatable with the record set returned by the dataadapter
            if (theData.Select().Length == 0)
            {
                adr.Fill(theData);
            }
            //run while loop for each row inside thedata datatable
            while (row + 1 <= theData.Select().Length)
            {
                //declare a person variable
                Person newPerson; 
                //declare a listviewitem variable
                ListViewItem lvi = new ListViewItem();

                //try to input the user data from the database into the newPerson variable
                try
                {
                    newPerson = new Person(theData.Rows[row]["userid"].ToString(), theData.Rows[row]["firstname"].ToString(), theData.Rows[row]["lastname"].ToString(), Convert.ToDecimal(theData.Rows[row]["occupationId"]), theData.Rows[row]["gender"].ToString());
                    
                }
                //if the occupation id is null then use a 0 instead.
                catch (Exception)
                {
                    newPerson = new Person(theData.Rows[row]["userid"].ToString(), theData.Rows[row]["firstname"].ToString(), theData.Rows[row]["lastname"].ToString(), 0, theData.Rows[row]["gender"].ToString());
                    
                }

                //build the listviewitem with the newPerson's data 
                lvi.Text = newPerson.ToString();
                lvi.ImageIndex = newPerson.ImageIndex;
                lvi.Tag = newPerson;
                //add the listviewitem to the listview
                personListView.Items.Add(lvi);
                //autoincrement the row variable
                row++;
            }
            
        }
        //event handle for exit tool strip menu item click event
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit the application
            Application.Exit();
        }
        //event handler for the small tool strip menu item click event
        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check to see if the listview is in largeicon view before running
            if (personListView.View == View.LargeIcon)
            {
                //change the listview to smallicon and switch the checks on the menu items
                personListView.View = View.SmallIcon;
                smallToolStripMenuItem.Checked = true;
                largeToolStripMenuItem.Checked = false;
            }
        }
        //event handler for the large tool strip menu item click event
        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check to see if the listview is in smallicon view before running
            if (personListView.View == View.SmallIcon)
            {
                //change the listview to largeicon and switch the checks on the menu items
                personListView.View = View.LargeIcon;
                smallToolStripMenuItem.Checked = false;
                largeToolStripMenuItem.Checked = true;
            }
        }
        //event handler for the double click event
        private void personListView_DoubleClick(object sender, EventArgs e)
        {
            //check to make sure the usrInp form is either null or disposed before running
            if (usrInp == null || usrInp.IsDisposed == true)
            {
                //instantiate the userinput form
                usrInp = new UserInput();
                //subscribe all related events to the userinput form
                PersonSelected += usrInp.HandlePersonSelected;
                usrInp.ModifyObject += HandleModifyObject;
                //invoke the PersonSelected event
                if (PersonSelected != null)
                {
                    PersonSelected(this, new EventArgs());
                }
                //show the usrinp form modeless
                usrInp.Show(this);
            }
            
        }
    }
}
