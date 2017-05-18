using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {

        private int totalMarks;
        private int possibleMarks;
        private string submitterName;

        public HomeworkAssignment(int possibleMarks)
        {
            this.possibleMarks = possibleMarks;

        }

        public int TotalMarks
        {
            get
            {
                return totalMarks;
            }
            set
            {
                totalMarks = value;
            }
        }

        public int PossibleMarks
        {
            get
            {
                return possibleMarks;
            }
           
        }

        public string SubmitterName
        {
            get
            {
                return submitterName;
            }
            set
            {
                submitterName = value;
            }
        }

        public string LetterGrade
        {
            get
            {
                double gradeScore = (double) totalMarks / possibleMarks;

                if ( gradeScore >= .90)
                {
                    return "A";
                } 
                else if(gradeScore >= .80)
                {
                    return "B";
                }
                else if(gradeScore >= .70)
                {
                    return "C";
                } 
                else if(gradeScore >= .60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
        }


    }
}
