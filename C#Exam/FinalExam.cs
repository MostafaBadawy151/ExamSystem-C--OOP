using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace C_Exam
{
    internal class FinalExam : Exam
    {
        QuestionBase[] Questions;
        Answer[] Answerarray;
        Answer[] ListOfAns;
       

        public FinalExam(decimal timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {

        }
       // public Answer Answerarray { get; set; }
        public  override void ReadQuestions()
        { 
             Questions = new QuestionBase[NumberOfQuestions];
            ListOfAns = new Answer[2];
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine($"Enter the type of Question No{i + 1} TF(1) OR MCQ(2)");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the body of question: ");
                string body = Console.ReadLine();
                Console.WriteLine("Enter the mark of question: ");
                int mark = int.Parse(Console.ReadLine());


                if (choice == 1)
                {
                   
                    Console.WriteLine("Enter the right choice for question 1 for True 2 for False");
                    int n = int.Parse(Console.ReadLine());
                    string AnswerText="False";

                    if (n == 1)
                    {
                         AnswerText = "True";
                    }
                    else if (n == 2)
                    {
                        AnswerText = "False";
                    }
                    else{
                        Console.WriteLine("you do not specify right answer");
                        AnswerText = "not found right answer";
                    }
                    Answer RightAnswer = new Answer(i + 1, AnswerText);
                    TFQuestion question = new TFQuestion($"Question{i + 1}", body, mark, RightAnswer);
                    ListOfAns[0] = new Answer(1,"True");
                    ListOfAns[1] = new Answer(2, "False");
                    Questions[i] = new QuestionBase($"T-F Question No {i + 1}", body, mark, ListOfAns, RightAnswer);

                }
                else if (choice == 2)
                {
                    Answerarray = new Answer[3];

                    //Answer[] Answerarray = new Answer[3]; 
                    for (int j = 0; j < 3; j++)
                    {   
                        Console.WriteLine($"Enter the choice number {j+1}");
                        Answerarray[j] = new Answer(j + 1, Console.ReadLine());
                        
                    }
                    Console.WriteLine("Please specify the right answer of question: ");
                    int right = int.Parse(Console.ReadLine());
                    Answer RightAnswer = new Answer(0, "Not found");
                    if (right == 1){ RightAnswer.AnswerID = 1; RightAnswer.AnswerText = Answerarray[0].AnswerText;}
                    else if(right == 2) { RightAnswer.AnswerID = 2; RightAnswer.AnswerText = Answerarray[1].AnswerText; }
                    else if (right == 3) { RightAnswer.AnswerID = 3; RightAnswer.AnswerText = Answerarray[2].AnswerText; }
                    else { Console.WriteLine("wrong choice"); }
                    //MCQOneChoice question = new MCQOneChoice($"Question{i + 1}", body, mark, Answerarray, RightAnswer);
                    Questions[i] = new QuestionBase($"MCQ Question No {i + 1}", body, mark, Answerarray, RightAnswer);

                }


            }
            // Implemntation of show exam function in final exam
            
        }   
        public override void ShowExam()
        {
            #region Implmentaion of ShowExam
            int Grade = 0;
            string[] UserAnswers = new string[NumberOfQuestions];

            for (int i = 0; i < Questions.Length; i++)
            {

                Console.WriteLine($"{Questions[i].Header}\t ({Questions[i].Mark} Marks)\n {Questions[i].Body}\n");
                //if (ListOfAns is not null)
                //{
                //    for (int k = 0; k < 2; k++)
                //    {
                //        Console.Write($"{Questions[i].AnswerList[k].AnswerID}. {Questions[i].AnswerList[k].AnswerText}\t");
                //    }
                //}
                if (Questions[i].AnswerList == Answerarray)
                {
                    for (int l = 0; l < Answerarray.Length; l ++)
                    {
                        
                        Console.Write($"{Questions[i].AnswerList[l].AnswerID}. {Questions[i].AnswerList[l].AnswerText}\t");
                    }
                }
                else if(Questions[i].AnswerList == ListOfAns)
                {
                    for (int l = 0; l < 2; l++)
                    {

                        Console.Write($"{Questions[i].AnswerList[l].AnswerID}. {Questions[i].AnswerList[l].AnswerText}\t");
                    }
                }

                Console.WriteLine("\n-------------------------------------------------");
                Console.WriteLine("Enter your choice number: ");
                int no = int.Parse(Console.ReadLine());
                UserAnswers[i] = Questions[i].AnswerList[no-1].AnswerText;
                if (no == Questions[i].CorrectAnswer.AnswerID)
                {
                    Grade += Questions[i].Mark;
                }
            }   
            int SumGrade = 0;
            for (int i = 0; i < Questions.Length; i++)
            {
                SumGrade += Questions[i].Mark;
                Console.WriteLine($"Your Answer of Q:{i + 1} is {UserAnswers[i]}");

            }

            Console.WriteLine($"Your Grade is {Grade} from {SumGrade}");
            #endregion
        }
    }
}
