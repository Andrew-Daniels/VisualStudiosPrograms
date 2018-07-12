using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewDaniels_CE10
{
    public class Person
    {
        /*Andrew Daniels
         * Visual Frameworks Section 01
         * Synthesis CE10
         */
        //create member variables for the person class
        string m_UserId;
        string m_FName;
        string m_LName;
        decimal m_OccupId;
        string m_Gender;
        int m_imageIndex;

        //create property for imageindex, this variable is set when called
        public int ImageIndex
        {
            get
            {
                if (Gender == "M")
                {
                    m_imageIndex = 0;
                }
                else
                {
                    m_imageIndex = 1;
                }
                return m_imageIndex;
            }

            set
            {
                m_imageIndex = value;
            }
        }
        //create property for m_FName variable
        public string FName
        {
            get
            {
                return m_FName;
            }

            set
            {
                m_FName = value;
            }
        }
        //create property for m_LName variable
        public string LName
        {
            get
            {
                return m_LName;
            }

            set
            {
                m_LName = value;
            }
        }
        //create property for m_OccupId variable
        public decimal OccupId
        {
            get
            {
                return m_OccupId;
            }

            set
            {
                m_OccupId = value;
            }
        }
        //create property for m_Gender variable
        public string Gender
        {
            get
            {
                return m_Gender;
            }

            set
            {
                m_Gender = value;
            }
        }
        //create property for m_UserId variable
        public string UserId
        {
            get
            {
                return m_UserId;
            }

            set
            {
                m_UserId = value;
            }
        }
        //override the tostring method to show the correct information in the listview
        public override string ToString()
        {
            return "First Name: " + FName + " Gender: " + Gender;
        }
        //constructor for person class
        public Person(string uid, string fName, string lName, decimal occupId, string gender)
        {
            UserId = uid;
            FName = fName;
            LName = lName;
            OccupId = occupId;
            Gender = gender;
        }

    }
}
