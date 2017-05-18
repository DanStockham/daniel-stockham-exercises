using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {
        private int currentLevel;
        private int numberOfLevels;
        private bool doorIsOpen;

        public Elevator(int totalNumberOffloors)
        {
            numberOfLevels = totalNumberOffloors;
            currentLevel = 1;
            doorIsOpen = false;

        }


        //Properties
        public int CurrentLevel
        {
            get
            {
                return currentLevel;
            }
        }

        public int NumberOfLevels
        {
            get
            {
                return numberOfLevels;
            }
        }

        public bool DoorIsOpen
        {
            get
            {
                return doorIsOpen;
            }
        }

        //Methods
        public void OpenDoor()
        {
            if(doorIsOpen != true)
            {
                doorIsOpen = true;
            }
        }

        public void CloseDoor()
        {
            if(doorIsOpen != false)
            {
                doorIsOpen = false;
            }
        }

        public void GoUp(int desiredFloor)
        {
            if( desiredFloor > currentLevel && doorIsOpen == false )
            {
                if( desiredFloor <= numberOfLevels)
                {
                    currentLevel = desiredFloor;
                }
                else
                {
                    currentLevel = numberOfLevels;
                }
                
            }
        }

        public void GoDown(int desiredFloor)
        {
            if( desiredFloor < currentLevel && doorIsOpen == false)
            {
                if (desiredFloor >= 1)
                {
                    currentLevel = desiredFloor;
                }
                else
                {
                    currentLevel = 1;
                }
            }
        }
    }

}
