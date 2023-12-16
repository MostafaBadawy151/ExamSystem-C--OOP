using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exam
{
    class TFQuestion : Question
    {
        public TFQuestion(string header, string body, int mark, Answer correctAnswer) : base(header, body, mark, correctAnswer)
        {
        }
    }
}
