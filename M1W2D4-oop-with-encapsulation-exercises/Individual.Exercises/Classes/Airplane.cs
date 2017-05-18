using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane { 

        private string planeNumber;
        private int totalFirstClassSeats;
        private int totalCoachSeats;
        private int bookedCoachSeats;
        private int bookedFirstClassSeats;
        private int availableFirstClassSeats;
        private int availableCoachSeats;

       //Constructor
       public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.planeNumber = planeNumber;
            this.totalFirstClassSeats = totalFirstClassSeats;
            this.totalCoachSeats = totalCoachSeats;
            bookedCoachSeats = 0;
            bookedFirstClassSeats = 0;
            availableFirstClassSeats = totalFirstClassSeats;
            availableCoachSeats = totalCoachSeats;
        }

        //Properties
        public string PlaneNumber
        {
            get
            {
                return planeNumber;
            }
        }

        public int TotalFirstClassSeats
        {
            get
            {
                return totalFirstClassSeats;
            }
        }

        public int TotalCoachSeats
        {
            get
            {
                return totalCoachSeats;
            }
        }

        public int BookedFirstClassSeats
        {
            get
            {
                return bookedFirstClassSeats;
            }
        }

        public int BookedCoachSeats
        {
            get
            {
                return bookedCoachSeats;
            }
        }
        public int AvailableFirstClassSeats 
        {
            get
            {
                availableFirstClassSeats = totalFirstClassSeats - bookedFirstClassSeats;
                return availableFirstClassSeats;
            }
        }
        public int AvailableCoachSeats
        {
            get
            {
                availableCoachSeats = totalCoachSeats - bookedCoachSeats;
                return availableCoachSeats;
            }
        }

        //Methods
        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            bool openSeats = false;

            if( forFirstClass == true)
            {
                if(totalNumberOfSeats <= availableFirstClassSeats)
                {
                    bookedFirstClassSeats += totalNumberOfSeats;
                    openSeats = true;
                }

            }
            else
            {
                if(totalNumberOfSeats <= availableCoachSeats)
                {
                    bookedCoachSeats += totalNumberOfSeats;
                    openSeats = true;
                }
            }

            return openSeats;

        }

    }
}
