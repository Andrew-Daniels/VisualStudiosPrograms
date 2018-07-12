using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;

namespace AndrewDaniels_CE07
{
    public partial class Form1 : Form
    {
        /*Andrew Daniels
         * Visual Frameworks Section 01
         * JSON and Web Connectivity CE07
         */

            //instantiate a webclient class
        WebClient apiConnection = new WebClient();
        //create a string to hold the VFW website
        string vfw = "http://mdv-vfw.com/vfw.json";
        //create a string to hold the ASD website
        string asd = "http://mdv-vfw.com/asd.json";
        //create an array that will hold every piece of data that will fill the controls
        string[] data = new string[5];

        public Form1()
        {
            InitializeComponent();
        }
        //event handler for exit tool strip menu item 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit the program
            Application.Exit();
        }
        //event handler for save tool strip menu item click event
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //the Save command should allow the user to save the current data from the user input controls to a file of their choosing
            //run this conditional when the user selects ok
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //instantiate a Json Serializer
                JsonSerializer serializer = new JsonSerializer();
                //convert the data array into JSON data
                string output = JsonConvert.SerializeObject(data);
                //use a streamwriter
                //create a JSonwriter that uses the streamwriter
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    //create the identifier
                    //this identifier will let us know if we can open the saved file or not
                    sw.WriteLine("e16yha");
                    //write all the data in JSON format to the txt file.
                    serializer.Serialize(writer, data);
                }
            }
        }
        //event handler for the new menu strip item click event
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // reset all controls to their default values
            classNameBx.Text = null;
            courseCodeBx.Text = null;
            monthBx.Value = 0;
            hoursBx.Value = 0;
            descBx.Text = null;

        }
        //create a method that will retrieve the data from the websites.
        private void GetData()
        {
            //instantiate apiData string equal to null
            string apiData = null;
            //Try to connect to the websites,
            //if the website returns an error in anyway, catch it
            //then prompt a messagebox to the user
            try 
            {
                //check to see which radio button is selected to decide which website
                //data is pulled from
                if (vfwBtn.Checked == true)
                {
                    apiData = apiConnection.DownloadString(vfw);
                }
                else if (asdBtn.Checked == true)
                {
                    apiData = apiConnection.DownloadString(asd);
                }

                //parse the apiData retreived from the website into a JSON object
                JObject o = JObject.Parse(apiData);

                //pull the data from the JSON object and place it into the data array
                data[0] = o["class"]["course_name_clean"].ToString();
                data[1] = o["class"]["course_code_long"].ToString();
                data[2] = o["class"]["sequence"].ToString();
                data[3] = o["class"]["credit"].ToString();
                data[4] = o["class"]["course_description"].ToString();
            }
            //catch the exception whenever an error is handled in the try body
            catch(Exception)
            {
                //display an error messagebox to the user.
                MessageBox.Show("The website you tried to access is not available. Please come back later and try again. Sorry for any inconvenience.");
            }
        }
        //event handler for get info button click event
        private void getInfoBtn_Click(object sender, EventArgs e)
        {
            //call GetData method
            //this method will get the data from the selected website
            GetData();
            //call PlaceData method
            //this method will place the data from the website into its perspective controls
            PlaceData();
        }
        //event handler for load tool strip menu item click event
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //The Load command should allow the user to select a file to load data into the user input controls
            
            //run conditional when the user selects the OK button on dialog window
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //instantiate new streamreader that reads from the users selected file.
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    //check to make sure the file was created by this program before proceding further
                    if (sr.ReadLine() != "e16yha")
                    {
                        //display and error message when the user loads an invalid file
                        MessageBox.Show("The file opened doesn't contain proper data for this application. Please try selecting a file created by this program.");
                        return;
                    }
                    //read the whole file after the identifier and deserialize the JSON object into the data array
                    data = JsonConvert.DeserializeObject<string[]>(sr.ReadToEnd());
                }
                //place the newly acquired data into it's perspective control
                PlaceData();
            }
        
        }
        //this method will place the data from the data array into their 
        //perspective controls on the form.
        private void PlaceData()
        {
            classNameBx.Text = data[0];
            courseCodeBx.Text = data[1];
            monthBx.Value = Convert.ToDecimal(data[2]);
            hoursBx.Value = Convert.ToDecimal(data[3]);
            descBx.Text = data[4];
        }
    }
}
