using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exam
{
    
     class Question
    {
        
        #region Properties
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer CorrectAnswer { get; set; }
        #endregion

        #region Constructor Function
        public Question(string header, string body, int mark, Answer correctAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            CorrectAnswer = correctAnswer;
        }

        public override string ToString()
        {
            return $"{Header}\n {Body}\n {AnswerList[0]}\t{AnswerList[1]}\n{Mark}";
        }
        #endregion


    }
}
    