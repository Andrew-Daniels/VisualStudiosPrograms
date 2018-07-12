using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace AndrewDaniels_CE08
{
    public partial class Form1 : Form
    {
        /*Andrew Daniels
         * Visual Frameworks Section 01
         * XML CE08
         */
        //instantiate a webclient class
        WebClient apiConnection = new WebClient();
        //create strings to hold the website links
        string vfwJSON = "http://mdv-vfw.com/vfw.json";
        string asdJSON = "http://mdv-vfw.com/asd.json";
        string vfwXML = "http://mdv-vfw.com/vfw.xml";
        string asdXML = "http://mdv-vfw.com/asd.xml";
        //create an array that will hold every piece of data that will fill the controls
        string[] data = new string[5];

        public Form1()
        {
            InitializeComponent();
        }
        //This method will retrieve the JSON data from the json website
        private void GetJSONData()
        {
            //instantiate apiData string equal to null
            string apiData = null;
            //Try to connect to the websites,
            //if the website return an error in anyway, catch it
            //then prompt a messagebox to the user
            try
            {
                // check to see which radio button is selected to decide which website
                //data is pulled from
                if (vfwBtn.Checked == true)
                {
                    apiData = apiConnection.DownloadString(vfwJSON);
                }
                else if (asdBtn.Checked == true)
                {
                    apiData = apiConnection.DownloadString(asdJSON);
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
            catch (Exception)
            {
                //display an error messagebox to the user.
                MessageBox.Show("The website you tried to access is not available. Please come back later and try again. Sorry for any inconvenience.");
            }
        }
        //event handler for get info button click event
        private void getInfoBtn_Click(object sender, EventArgs e)
        {
            //call GetData method depending on which radio button is checked
            //this method will get the data from the selected website
            if (rdoXML.Checked)
            {
                GetXMLData();
            }
            else
            {
                GetJSONData();
            }
            //call PlaceData method
            //this method will place the data from the website into its perspective controls
            PlaceData();


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
        //create a method that will retrieve the data from the XML websites.
        private void GetXMLData()
        {
            //instantiate apiData string equal to null
            string apiEndPoint = null;
            //check to see which radio button is selected to decide which website
            //data is pulled from
            if (vfwBtn.Checked)
            {
                apiEndPoint = vfwXML;
            }
            else
            {
                apiEndPoint = asdXML;
            }
            //Try to connect to the websites,
            //if the website returns an error in anyway, catch it
            //then prompt a messagebox to the user
            try
            {
                //instantiate an XmlTextReader that will read the XML data on the website
                XmlTextReader apiData = new XmlTextReader(apiEndPoint);

                //while there is still data to read

                //continue reading the website's data
                while (apiData.Read())
                {
                    //if the key is equal then fill the value into the data array
                    if (apiData.Name == "course_name_clean")
                    {
                        data[0] = apiData.ReadString();
                    }
                    //if the key is equal then fill the value into the data array
                    if (apiData.Name == "course_code_long")
                    {
                        data[1] = apiData.ReadString();
                    }
                    //if the key is equal then fill the value into the data array
                    if (apiData.Name == "sequence")
                    {
                        data[2] = apiData.ReadString();
                    }
                    //if the key is equal then fill the value into the data array
                    if (apiData.Name == "credit")
                    {
                        data[3] = apiData.ReadString();
                    }
                    //if the key is equal then fill the value into the data array
                    if (apiData.Name == "course_description")
                    {
                        data[4] = apiData.ReadString();
                    }
                }
            }
            //catch the exception whenever an error is handled in the try body
            catch (Exception)
            {
                //display an error messagebox to the user.
                MessageBox.Show("The website you tried to access is not available. Please come back later and try again. Sorry for any inconvenience.");
            }

        }
        //event handler for save tool strip menu item click event
        private void saveToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            //check to see which radio button is selected to decide the file type 
            //that the file will be saved as
            if (rdoXML.Checked)
            {
                //default extention is .xml for XML
                saveFileDialog1.DefaultExt = "xml";
            }
            else
            {
                //default extention is .txt for JSON
                saveFileDialog1.DefaultExt = "txt";
            }

            //run this conditional when the user selects ok
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //if radio button XML is checked then save the file in XML format
                if (rdoXML.Checked)
                {
                    //instantiate XMLWriterSettings
                    XmlWriterSettings settings = new XmlWriterSettings();
                    //set the conformance level to document
                    settings.ConformanceLevel = ConformanceLevel.Document;
                    //add indents to the file when saving
                    settings.Indent = true;

                    //use an xmlwriter to write to the user created file
                    using (XmlWriter w = XmlWriter.Create(saveFileDialog1.FileName, settings))
                    {
                        //start the XML element
                        w.WriteStartElement("ClassInformation");
                        //create the rest of the elements in the XML file with the data in the controls
                        w.WriteElementString("ClassName", classNameBx.Text);
                        w.WriteElementString("CourseCode", courseCodeBx.Text);
                        w.WriteElementString("Month", monthBx.Value.ToString());
                        w.WriteElementString("CreditHours", hoursBx.Value.ToString());
                        w.WriteElementString("Description", descBx.Text);
                        //end the start element
                        w.WriteEndElement();

                    }
                }
                //run this code block if the user selected JSON instead of XML
                else
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
        }
        //event handler for the new menu strip item click event
        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // reset all controls to their default values
            classNameBx.Text = null;
            courseCodeBx.Text = null;
            monthBx.Value = 0;
            hoursBx.Value = 0;
            descBx.Text = null;
        }
        //load tool strip menu event handler for click event
        private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //run this conditional when the user selects ok
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName.Contains(".xml"))
                {
                    //Load XML data
                    // first, we'll get the settings for the reader
                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.ConformanceLevel = ConformanceLevel.Document;

                    //We want to make sure our reader gets only the XML
                    settings.IgnoreComments = true;
                    settings.IgnoreWhitespace = true;

                    // create the XmlReader
                    using (XmlReader rdr = XmlReader.Create(openFileDialog1.FileName, settings))
                    {
                        // skip the metadata and move to the content
                        rdr.MoveToContent();

                        // we'll verify that this XML is what we want
                        if (rdr.Name != "ClassInformation")
                        {
                            // we can show a messagebox to user then return
                            MessageBox.Show("This is not correct Class Information data!");
                            return;
                        }

                        //if confirmed as class information data, we can read the rest of the XML file
                        while (rdr.Read())
                        {
                            if (rdr.Name == "ClassName" && rdr.IsStartElement())
                            {
                                Console.WriteLine(rdr.Name);
                                //we'll read the string into the array
                                data[0] = rdr.ReadString();
                            }
                            if (rdr.Name == "CourseCode" && rdr.IsStartElement())
                            {
                                //we'll read the string into the array
                                data[1] = rdr.ReadString();
                            }
                            if (rdr.Name == "Month" && rdr.IsStartElement())
                            {
                                //we'll read the string into the array
                                data[2] = rdr.ReadString();
                            }
                            if (rdr.Name == "CreditHours" && rdr.IsStartElement())
                            {
                                //we'll read the string into the array
                                data[3] = rdr.ReadString();
                            }
                            if (rdr.Name == "Description" && rdr.IsStartElement())
                            {
                                //we'll read the string into the array
                                data[4] = rdr.ReadString();
                            }
                        }
                        //call PlaceData method
                        //this method will place the data from the website into its perspective controls
                        PlaceData();
                    }
                }

                //run this conditional if a text file was selected
                else if (openFileDialog1.FileName.Contains(".txt"))
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
        }
        //event handler for exit tool strip menu item click event
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //exit the application
            Application.Exit();
        }
    }
}
