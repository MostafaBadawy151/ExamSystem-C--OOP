using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace C_Exam
{
     class Subject
    {

        #region Properties
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam ExamOfSubject { get; set; } 
        #endregion

        #region Constructor Function
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }
        #endregion

            
        #region Methods
        public void CreateExam()
        {
            Console.Write("Enter the type of exam you want to create 1 for practical and 2 for final: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time of exam in minutes: ");
            decimal time = decimal.Parse(Console.ReadLine()) ;
            Console.WriteLine("Enter the number of questions: ");
            int NoQ = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                ExamOfSubject = new PracticalExam(time, NoQ);
                ExamOfSubject.ReadQuestions();
            }
                
                
            else if (number == 2) 
            {
                ExamOfSubject = new FinalExam(time, NoQ);
                ExamOfSubject.ReadQuestions();
            }
            else
                Console.WriteLine("Wrong choice");
            //ExamOfSubject = exam;
        } 
        #endregion




    }
}
