using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewDaniels_CE05
{
    public class Spaceship
    {
        /*Andrew Daniels
         *Custom Event Arguments CE05
         * Visual Frameworks Section 01
         */
         //Create member variables for the spaceship class
        string name;
        decimal crewSize;
        bool activeDuty;
        bool cruiser;
        bool destroyer;
        bool freighter;
        int imageIndex;

        //override to the tostring method to show the name and status of active duty
        public override string ToString()
        {
            return "Name: " + name + " Active: " + activeDuty;
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
        //create a property for the crewsize variable
        public decimal CrewSize
        {
            get
            {
                return crewSize;
            }

            set
            {
                crewSize = value;
            }
        }
        //create a property for the active duty variable
        public bool ActiveDuty
        {
            get
            {
                return activeDuty;
            }

            set
            {
                activeDuty = value;
            }
        }
        //create a property for the cruiser variable
        public bool Cruiser
        {
            get
            {
                return cruiser;
            }

            set
            {
                cruiser = value;
            }
        }
        //create a property for the destroyer variable
        public bool Destroyer
        {
            get
            {
                return destroyer;
            }

            set
            {
                destroyer = value;
            }
        }
        //create a property for the freighter variable
        public bool Freighter
        {
            get
            {
                return freighter;
            }

            set
            {
                freighter = value;
            }
        }
        //create a property for the imageindex variable
        public int ImageIndex
        {
            //when the imageindex property is called it will figure out what the indexNumber is for the image
            get
            {
                if (cruiser == true)
                {
                    imageIndex = 0;
                }
                if (destroyer == true)
                {
                    imageIndex = 1;
                }
                if (freighter == true)
                {
                    imageIndex = 2;
                }

                return imageIndex;
            }

            set
            {
                imageIndex = value;
            }
        }
    }
}
