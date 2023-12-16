using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exam
{
     class Answer
    {
        #region Properties
        public int AnswerID { get; set; }
        public string AnswerText{ get; set;}
        #endregion

        #region Constructor Function
        public Answer(int answerID, string answerText)
        {
            AnswerID = answerID;
            AnswerText = answerText;
        } 
        #endregion







    }
}
