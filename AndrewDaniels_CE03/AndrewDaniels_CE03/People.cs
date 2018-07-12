using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewDaniels_CE03
{
    public class People
    {
        //create fields for People class
        string name;
        string gender;
        bool olderThan18;
        decimal classes;

        //override tostring method to show name and gender of the object
        public override string ToString()
        {
            return name + ": " + gender;
        }

        //property for name
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

        //property for gender
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

        //property for olderthan18
        public bool OlderThan18
        {
            get
            {
                return olderThan18;
            }

            set
            {
                olderThan18 = value;
            }
        }

        //property for classes
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
