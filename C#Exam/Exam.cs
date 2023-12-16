using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exam
{
    abstract class Exam
    {
        public decimal TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }

        public Subject AssociatedSubject { get; set; }

        public Exam(decimal timeOfExam, int numberOfQuestions )
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
            //AssociatedSubject = associatedSubject;  
        }

        public abstract void ReadQuestions();
        
           
        
        public abstract void ShowExam();
    }
}
