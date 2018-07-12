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
using System.Collections;

namespace AndrewDaniels_CE02
{
    public partial class universityForm1 : Form
    {
        public universityForm1()
        {
            /* Andrew Daniels
               Visual Frameworks Section 01
               Passing Data and Multiple Forms CE02
             */
            InitializeComponent();
        }

        //create a property for a person object named Data.
        public Person Data
        {
            get
            {
                //instantiate a new person object
                Person p = new Person();
                //the new person object gets the values from the input controls
                p.Name = textBoxName.Text;
                p.Gender = comboBoxGender.Text;
                p.Over18 = checkBox18OrOlder.Checked;
                p.Classes = upDownClasses.Value;
                return p;

            }
            set
            {
                //setter for Data object
                //set each variable to the Person class's default constructor values.
                //these values get placed into the user input fields.
                textBoxName.Text = value.Name;
                comboBoxGender.Text = value.Gender;
                checkBox18OrOlder.Checked = value.Over18;
                upDownClasses.Value = value.Classes;
            }
        }

        //Event Handler for the exit button.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit the program
            Application.Exit();
        }

        //Event handler for the add student button.
        private void addStudent_Click(object sender, EventArgs e)
        {
            //Add the created Person object into the listBox for students.
            listBoxStudents.Items.Add(Data);

            //reset the user input fields to default values.
            Data = new Person();
        }

        //Event handler for add teacher button.
        private void addTeacher_Click(object sender, EventArgs e)
        {
            //Add the created Person object into the listBox for teachers.
            listBoxTeachers.Items.Add(Data);

            //reset the user input fields to default values.
            Data = new Person();
        }
        
        //event handler for move to teacher button
        private void moveToTeacher_Click(object sender, EventArgs e)
        {
            //Check to make sure a valid index is selected in the students listBox.
            if (listBoxStudents.SelectedIndex >= 0 && listBoxStudents.SelectedIndex <= listBoxStudents.Items.Count - 1)
            {
                //retrieve the selected person object from the student list as p.
                Person p = listBoxStudents.Items[listBoxStudents.SelectedIndex] as Person;

                //remove the person object from the students list
                listBoxStudents.Items.Remove(p);
                //add the person object to the teachers list.
                listBoxTeachers.Items.Add(p);
            }
            //disable the move to teacher button.
            moveToTeacherBtn.Enabled = false;
            //disable the remove button.
            removeBtn.Enabled = false;
        }
        //Event Handler for clear button
        private void clearButton_Click(object sender, EventArgs e)
        {
            //set the user input fields to their default values.
            Data = new Person();
        }

        //event handler for move to student button
        private void moveToStudent_Click(object sender, EventArgs e)
        {
            //check to make sure a valid index is selected in the listbox before running the following code.
            if (listBoxTeachers.SelectedIndex >= 0 && listBoxTeachers.SelectedIndex <= listBoxTeachers.Items.Count - 1)
            {
                //retrieve the selected person object from the teachers list as p.
                Person p = listBoxTeachers.Items[listBoxTeachers.SelectedIndex] as Person;
                //remove the person object from the teachers list
                listBoxTeachers.Items.Remove(p);
                //add the person object to the student list
                listBoxStudents.Items.Add(p);
            }
            //disable the move to students button
            moveToStudentBtn.Enabled = false;
            //disable the remove button
            removeBtn.Enabled = false;

        }
        //Event handler for the display tool strip menu item.
        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instantiate a details form
            DetailsForm form = new DetailsForm();

            //gather the count of students and teachers from their perspective lists on the main form
            //put the counts in their textbox's 
            form.NumStudentsTextBox = listBoxStudents.Items.Count.ToString();
            form.NumTeachersTextBox = listBoxTeachers.Items.Count.ToString();

            //launch the new details form as modal.
            form.ShowDialog();
        }

        //event handler for when a student object is selected in the listBox
        private void studentIndexSelected(object sender, EventArgs e)
        {
            //check to make sure a valid index is selected in the listbox
            if (listBoxStudents.SelectedIndex >= 0 && listBoxStudents.SelectedIndex < listBoxStudents.Items.Count)
            {
                //disable the move to student button
                moveToStudentBtn.Enabled = false;
                //enable the move to teacher button
                moveToTeacherBtn.Enabled = true;
                //enable the remove button
                removeBtn.Enabled = true;

                //retrieve the person object from the students list
                Person p = listBoxStudents.Items[listBoxStudents.SelectedIndex] as Person;

                //fill the user input controls with the contents of the selected person object
                Data = p;
                //clear the selected teacher object if one is selected.
                listBoxTeachers.ClearSelected();
            }
            
        }

        //event handler for when a teacher object is selected in the listBox
        private void teachersIndexSelected(object sender, EventArgs e)
        {
            //check to make sure a valid index is selected in the listbox
            if (listBoxTeachers.SelectedIndex >= 0 && listBoxTeachers.SelectedIndex < listBoxTeachers.Items.Count)
            {
                //enable the move to student button
                moveToStudentBtn.Enabled = true;
                //disable the move to teacher button
                moveToTeacherBtn.Enabled = false;
                //enable the remove button
                removeBtn.Enabled = true;

                //retrieve the person object from the teachers list
                Person p = listBoxTeachers.Items[listBoxTeachers.SelectedIndex] as Person;

                //fill the user input controls with the contents of the selected person object
                Data = p;

                //clear the selected student object if one is selected.
                listBoxStudents.ClearSelected();
            }
            
        }

        //Event Handler for the save tool strip menu item
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Run the following code when the user presses the save button
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //create new streamwriter that saves to the file created
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);

                //create a variable that holds the current index number value
                int indexNumber = 0;

                //save each student object to the file until there aren't any left to save.
                while (listBoxStudents.Items.Count > 0 && indexNumber <= listBoxStudents.Items.Count - 1)
                {
                    //retrieve the person object from the students list
                    Person p = listBoxStudents.Items[indexNumber] as Person;
                    
                    //append the student keyword to the student's values.
                    //write out the students values to the saved file
                    sw.WriteLine("student" + p.ToStrings());
                    //increment the indexNumber value to get to the next person object in the listbox.
                    indexNumber++;
                }
                //reset the indexNumber variable back to 0 for the teachers list.
                indexNumber = 0;

                //save each teacher object to the file until there aren't any left to save.
                while (listBoxTeachers.Items.Count > 0 && indexNumber <= listBoxTeachers.Items.Count - 1)
                {
                    //retrieve the person object from the teachers list
                    Person p = listBoxTeachers.Items[indexNumber] as Person;

                    //append the teacher keyword to the student's values.
                    //write out the teachers values to the saved file
                    sw.WriteLine("teacher" + p.ToStrings());
                    //increment the indexNumber value to get to the next person object in the listbox.
                    indexNumber++;
                }
                //close the streamwriter.
                sw.Close();
            }
            
        }

        //Event Handler for load tool strip menu item
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //When user presses the open button run the following code.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //instantiate streamreader that reads from the file selected.
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                //read from the file until there is no more lines left in the file.
                while (sr.Peek() >= 0)
                {
                    //split the lines where there is a comma, add each string to an index inside the person array.
                    string[] personArray = sr.ReadLine().Split(',');

                    //if the first index string is equal to teacher then run this if statement
                    if (personArray[0] == "teacher")
                    {
                        //fill the user input fields with their perspective values for the person object
                        textBoxName.Text = personArray[1];
                        comboBoxGender.Text = personArray[2];
                        checkBox18OrOlder.Checked = Convert.ToBoolean(personArray[3]);
                        upDownClasses.Value = Convert.ToDecimal(personArray[4]);
                        //once the input fields are filled, input that user into the teacher listBox
                        listBoxTeachers.Items.Add(Data);
                        //reset the user input fields to their default values.
                        Data = new Person();
                    }
                    //if the first index string is equal to student then run this if statement
                    if (personArray[0] == "student")
                    {
                        //fill the user input fields with their perspective values for the person object
                        textBoxName.Text = personArray[1];
                        comboBoxGender.Text = personArray[2];
                        checkBox18OrOlder.Checked = Convert.ToBoolean(personArray[3]);
                        upDownClasses.Value = Convert.ToDecimal(personArray[4]);
                        //once the input fields are filled, input that user into the student listBox
                        listBoxStudents.Items.Add(Data);
                        //reset the user input fields to their default values.
                        Data = new Person();
                    }
                }
                //close the streamreader
                sr.Close();
            }
        }

        //event handler for the remove button
        private void removeButton_Click(object sender, EventArgs e)
        {
            //make sure a valid student index is selected before running this if statement
            if (listBoxStudents.SelectedIndex >= 0 && listBoxStudents.SelectedIndex <= listBoxStudents.Items.Count - 1)
            {
                //remove the selected person object from the students list box
                listBoxStudents.Items.RemoveAt(listBoxStudents.SelectedIndex);
            }
            //make sure a valid teacher index is selected before running this if statement.
            if (listBoxTeachers.SelectedIndex >= 0 && listBoxTeachers.SelectedIndex <= listBoxTeachers.Items.Count - 1)
            {
                //remove the selected person object from the students list box
                listBoxTeachers.Items.RemoveAt(listBoxTeachers.SelectedIndex);
            }
        }
        //event handler for when the form1 is clicked upon
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //disable the move to students button
            moveToStudentBtn.Enabled = false;
            //disable the move to teachers button
            moveToTeacherBtn.Enabled = false;
            //disable the remove button
            removeBtn.Enabled = false;
            //clear selections from the listboxes
            listBoxStudents.ClearSelected();
            listBoxTeachers.ClearSelected();
        }
    }
}
