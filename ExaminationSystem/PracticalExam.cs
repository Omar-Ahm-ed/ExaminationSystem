using System.Diagnostics;

namespace ExaminationSystem
{
    public class PracticalExam : Exam
    {
        public int Grade { get; set; }
        public override void DisplayExam()
        {
            int rightAnswer = 0;
            int Totalmark = 0;
            foreach (var question in Questions)
            {
                question.DisplayQuestion();
                Console.Write("-----------------------\nYour Answer :");
                try
                {
                    rightAnswer = int.Parse(Console.ReadLine());

                }
                catch
                {
                    try
                    {

                        Console.Write("-----------------------\nYour Answer as a number :");
                        rightAnswer = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }


                if (rightAnswer == question.RightAnswer.Id)
                {
                    Grade += question.Mark;
                }
                Console.WriteLine("************************************");

                Totalmark += question.Mark;

            }
            Console.Clear();
            Console.WriteLine("Your Answers:");
            for (int i = 0; i < NumberOfQuestions; i++)
            { 
           
                    Console.WriteLine($"Q{i + 1})\t{Questions[i].Body}: {Questions[i].RightAnswer.Text}");
            }
            Console.WriteLine($"Your Exam Grade is {Grade} from {Totalmark}");
        }
    }
}
