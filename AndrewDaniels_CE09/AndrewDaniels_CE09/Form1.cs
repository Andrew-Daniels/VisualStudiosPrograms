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
using System.IO;

namespace AndrewDaniels_CE09
{
    public partial class Form1 : Form
    {
        /*Andrew Daniels
         * Visual Frameworks Section 01
         * Database Connectivity CE09
         */
        //Instantiate a new connection
        MySqlConnection conn = new MySqlConnection();
        //Instantiate a datatable
        DataTable theData = new DataTable();
        //instantiate a variable that will hold the row index number
        int row = 0;

        public Form1()
        {
            InitializeComponent();
            //call connect method, connect to database
            Connect();
            //call retrievedata method, retrieve data from the database
            RetrieveData();
            //call checkforbuttonvisibility method, this makes sure buttons that shouldn't be used aren't enabled
            CheckForButtonVisibility();
        }

        //event handle for exit tool strip menu item click event
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit the application
            Application.Exit();
        }
        //create a method that connects to the database
        private void Connect()
        {
            //Connect to database
            try
            {
                conn.ConnectionString = BuildConnectionString();
                conn.Open();
                //set the connection label text, to let user know they are connected
                connectionLbl.Text = "Connected to: exampleDatabase";
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
        //create a method that retrieves data from the database
        private void RetrieveData()
        {
            //create an SQL statement
            string sql = "SELECT firstname, lastname, occupationId, userStatusId FROM users LIMIT 15";
            MySqlDataAdapter adr = new MySqlDataAdapter(sql, conn);

            //set the adapters command type to text
            adr.SelectCommand.CommandType = CommandType.Text;

            // The fill method adds rows to match the data source
            // we're filling the datatable with the record set returned by the dataadapter
            if (theData.Select().Length == 0)
            {
                adr.Fill(theData);
            }

            // We can get a count of the number of rows within the DataTable using a method and sending no arg
            int numberOfRecords = theData.Select().Length;

            // let's put the first records data into the form
            firstNameTxtBx.Text = theData.Rows[row]["firstName"].ToString();
            lastNameTxtBx.Text = theData.Rows[row]["lastName"].ToString();
            try
            {
                //if the occupationId is null then catch the error
                occupBx.Value = Convert.ToDecimal(theData.Rows[row]["occupationId"]);
            }
            catch (Exception)
            {
                //make the occupBx 0 instead of null
                occupBx.Value = 0;
            }
            userStatusBx.Value = Convert.ToDecimal(theData.Rows[row]["userStatusId"]);
            //update the tool strip label text to show which record we're viewing
            toolStripStatusLabel1.Text = "Showing record: " + (row + 1).ToString() + " of " + theData.Select().Length.ToString();

        }
        //create a method that changes buttons visibility depending on the record selected
        private void CheckForButtonVisibility()
        {
            //if at the end of the record disable last and next buttons
            //enable previous and first buttons
            if (row + 1 == theData.Select().Length)
            {
                nextBtn.Enabled = false;
                lastBtn.Enabled = false;
                previousBtn.Enabled = true;
                firstBtn.Enabled = true;
            }
            //if there are still more records ahead
            //enable all buttons
            if (row + 1 < theData.Select().Length)
            {
                nextBtn.Enabled = true;
                lastBtn.Enabled = true;
                previousBtn.Enabled = true;
                firstBtn.Enabled = true;
            }
            //if at the first record
            //disable the first and previous buttons
            if (row == 0)
            {
                previousBtn.Enabled = false;
                firstBtn.Enabled = false;
            }
        }
        //event handler for next button click event
        private void nextBtn_Click(object sender, EventArgs e)
        {
            //autoincrement the row variable
            //cycle into the next row of data for the user input controls
            //enable/disable buttons depending on what index we're on 
                row++;
                RetrieveData();
                CheckForButtonVisibility();
            
        }
        //event handle for the previous button click event
        private void previousBtn_Click(object sender, EventArgs e)
        {
            //autodecrement the row variable
            //cycle to the previous row of data for the user input controls
            //enable/disable buttons depending on what index we're on 
            row--;
                RetrieveData();
                CheckForButtonVisibility();
        }
        //event handler for the first button click event
        private void firstBtn_Click(object sender, EventArgs e)
        {
            //row variable = 0
            //get the data from the first row
            //enable/disable buttons depending on what index we're on 
            row = 0;
            RetrieveData();
            CheckForButtonVisibility();
        }
        //event handler for the last button click event
        private void lastBtn_Click(object sender, EventArgs e)
        {
            //row variable equals theData's length minus 1
            //retrieve that last rows data
            //enable/disable buttons depending on what index we're on 
            row = theData.Select().Length - 1;
            RetrieveData();
            CheckForButtonVisibility();
        }
        //save tool strip button event handler
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set the savefiledialog's default extention to .txt
            saveFileDialog1.DefaultExt = "txt";

            //when user presses save run this code
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //write all the userinput control data into a text file
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(firstNameTxtBx.Text);
                    sw.WriteLine(lastNameTxtBx.Text);
                    sw.WriteLine(occupBx.Value);
                    sw.WriteLine(userStatusBx.Value);
                }
            }
            
        }
    }
}
