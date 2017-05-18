using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
       private bool isOn = false;
       private int currentChannel = 3;
       private int currentVolume = 2;


       public bool IsOn
        {
            get
            {
                return isOn;
            }
        }

        public int CurrentChannel
        {
            get
            {
                return currentChannel;
            }
        }

        public int CurrentVolume
        {
            get
            {
                return currentVolume;
            }
        }
       //Methods

        public void TurnOff()
        {
            isOn = false;
        }

        public void TurnOn()
        {
            isOn = true;
        }

        public void ChangeChannel(int newChannel)
        {
            if (isOn)
            {
                if (newChannel < 18)
                {
                    currentChannel = newChannel;
                }
                else
                {
                    currentChannel = 3;
                }
            }
        }

        public void ChannelUp()
        {
            if(isOn)
            {
                currentChannel += 1;
                if (currentChannel > 18)
                {
                    currentChannel = 3;
                }
                
            }
            
        }

        public void ChannelDown()
        {
            if (isOn == true)
            {

                currentChannel -= 1;

                if (CurrentChannel < 3)
                {
                    currentChannel = 18;
                }

            }
            
        }

        public void RaiseVolume()
        {
            if(isOn)
            {
                currentVolume += 1;
            }
            
        }

        public void LowerVolume()
        {
            if(isOn)
            {
                currentVolume -= 1;
                if (currentVolume < 0 )
                {
                    currentVolume = 0;
                }
                
            }
            
        }
    }
}
