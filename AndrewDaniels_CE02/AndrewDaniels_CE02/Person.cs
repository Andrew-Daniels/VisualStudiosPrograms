using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewDaniels_CE02
{
    public class Person
    {
        //fields for the person object
        string name;
        string gender;
        bool over18;
        decimal classes;
        
        //override the tostring method to display name and gender in the listboxes
        public override string ToString()
        {
            return name + ": " + gender;
        }

        //create a new tostrings method that writes out all the data for the person object separated by comma's
        public string ToStrings()
        {
            return "," + name + "," + gender + "," + over18 + "," + classes;
        }

        //create a name property
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

        //create a gender property
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
        //create an over18 property
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
        //create a classes property
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
    }
}
