using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrewDaniels_CE02
{
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }
        //create a setter for the number of students text box
        public string NumStudentsTextBox
        {
            set
            {
                numStudentsTextBox.Text = value;
            }
        }
        //create a setter for the number of teacher text box
        public string NumTeachersTextBox
        {
            set
            {
                numTeachersTextBox.Text = value;
            }
        }

    }
}
