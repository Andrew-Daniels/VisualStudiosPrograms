using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewDaniels_CE04
{
    /*Andrew Daniels
        *Visual Frameworks Section 01
        *CE04: ListViews
        */
    public class Students
    {
        //Create member variables for the student class
        string name;
        string gender;
        bool over18;
        decimal classes;
        int imageIndex;

        //Override the tostring method to show the name and gender
        public override string ToString()
        {
            return name + ": " + gender;
        }
        //create a property for the name variable
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        //create a property for the gender variable
        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }
        //create a property for the over18 variable
        public bool Over18
        {
            get
            {
                return over18;
            }

            set
            {
                over18 = value;
            }
        }
        //create a property for the classes variable
        public decimal Classes
        {
            get
            {
                return classes;
            }

            set
            {
                classes = value;
            }
        }
        //create a property for the imageindex variable
        public int ImageIndex
        {
            get
            {
                return imageIndex;
            }

            set
            {
                imageIndex = value;
            }
        }
    }
}
