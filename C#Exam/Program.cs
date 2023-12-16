using System.Diagnostics;

namespace C_Exam
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Subject mathSubject = new Subject(1, "Mathematics");
            mathSubject.CreateExam();
            Console.Clear();
            Console.WriteLine("Do you want to start the exam: y | n");

            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch SW = new Stopwatch();
                SW.Start();
                mathSubject.ExamOfSubject.ShowExam();
                Console.WriteLine($"The Elapsed Time = ${SW.Elapsed}");
            }

            //finalExam.ShowExam();
        }
    }
}