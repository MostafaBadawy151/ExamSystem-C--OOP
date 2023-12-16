using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exam
{
    class MCQOneChoice : Question
    {
        public MCQOneChoice(string header, string body, int mark, Answer[] answerList, Answer correctAnswer) : base(header, body, mark, correctAnswer)
        {
            AnswerList = answerList;
        }
    }
}
