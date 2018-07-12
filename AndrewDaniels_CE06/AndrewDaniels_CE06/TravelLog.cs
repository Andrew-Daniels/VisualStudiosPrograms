using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewDaniels_CE06
{
        /*Andrew Daniels
         * Visual Frameworks Section 01
         * TreeView and TabControl CE06
         */
    public class TravelLog
    {
        //create member variables for the travellog class
        decimal m_miles;
        decimal m_hours;
        string m_direction;
        string m_mode;
        int m_imageIndex;

        //instantiate a new travellog list
        List<TravelLog> log = new List<TravelLog>();

        //property for miles
        public decimal Miles
        {
            get
            {
                return m_miles;
            }

            set
            {
                m_miles = value;
            }
        }
        //property for hours
        public decimal Hours
        {
            get
            {
                return m_hours;
            }

            set
            {
                m_hours = value;
            }
        }
        //property for mode
        public string Mode
        {
            get
            {
                return m_mode;
            }

            set
            {
                m_mode = value;
            }
        }
        //property for direction
        public string Direction
        {
            get
            {
                return m_direction;
            }

            set
            {
                m_direction = value;
            }
        }
        //property for list
        internal List<TravelLog> Log
        {
            get
            {
                return log;
            }

            set
            {
                log = value;
            }
        }
        //property for imageindex
        public int ImageIndex
        {
            get
            {
                //set the imageindex number depending on what direction is chosen
                if (m_direction == "North")
                {
                    m_imageIndex = 3;
                }
                else if (m_direction == "South")
                {
                    m_imageIndex = 0;
                }
                else if (m_direction == "West")
                {
                    m_imageIndex = 2;
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
    }
}
