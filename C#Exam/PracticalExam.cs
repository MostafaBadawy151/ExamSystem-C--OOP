using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exam
{
    internal class PracticalExam : Exam
    {

        QuestionBase[] Questions;
        Answer[] Answerarray;
        public PracticalExam(decimal timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {
        }
            
        public override void ReadQuestions()
        {
             Questions = new QuestionBase[NumberOfQuestions];
            

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Answerarray = new Answer[3];
                Console.WriteLine($"Enter the body of question {i+1}: ");
                string body = Console.ReadLine();
                Console.WriteLine("Enter the mark of question: ");
                int mark = int.Parse(Console.ReadLine());

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Enter the choice number {j + 1}");
                    Answerarray[j] = new Answer(j + 1, Console.ReadLine());
                }
                Console.WriteLine("Please specify the right answer of question: ");
                int right = int.Parse(Console.ReadLine());
                Answer RightAnswer = new Answer(0, "Not found");
                if (right == 1) { RightAnswer.AnswerID = 1; RightAnswer.AnswerText = Answerarray[0].AnswerText; }
                else if (right == 2) { RightAnswer.AnswerID = 2; RightAnswer.AnswerText = Answerarray[1].AnswerText; }
                else if (right == 3) { RightAnswer.AnswerID = 3; RightAnswer.AnswerText = Answerarray[2].AnswerText; }
                else { Console.WriteLine("wrong choice"); }
                //MCQOneChoice question = new MCQOneChoice($"Question{i + 1}", body, mark, Answerarray, RightAnswer);
                Questions[i] = new QuestionBase($"MCQ Question No {i + 1}", body, mark, Answerarray, RightAnswer);
            }



            // Implemntation of show exam function in practical exam

        }
        public override void ShowExam()
        {
            #region Implementaion of ShowExam
            //int Grade = 0;
            string[] UserAnswers = new string[NumberOfQuestions];

            for (int i = 0; i < Questions.Length; i++)
            {

                Console.WriteLine($"{Questions[i].Header}\t ({Questions[i].Mark} Marks)\n {Questions[i].Body}\n");
                
                if (Answerarray is not null)
                {
                    for (int k = 0; k < Answerarray.Length; k++)
                    {
                        Console.Write($"{Questions[i].AnswerList[k].AnswerID}. {Questions[i].AnswerList[k].AnswerText}\t");
                    }
                }

                Console.WriteLine("\n-------------------------------------------------");
                Console.WriteLine("Enter your choice number: ");
                int no = int.Parse(Console.ReadLine());
                UserAnswers[i] = Questions[i].CorrectAnswer.AnswerText;
                //if (no == Questions[i].CorrectAnswer.AnswerID)
                //{
                //    Grade += Questions[i].Mark;       
                //}
            }
            //int SumGrade = 0;
            for (int i = 0; i < Questions.Length; i++)
            {
               // SumGrade += Questions[i].Mark;
                Console.WriteLine($"Correct Answer of Q:{i + 1} is {UserAnswers[i]}");

            }


            //Console.WriteLine($"Your Grade is {Grade} from {SumGrade}");
            #endregion

        }
    }
   



}

