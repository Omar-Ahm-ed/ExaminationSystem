namespace ExaminationSystem
{
    public class TrueOrFalse: Question
    {
        public TrueOrFalse()
        {
            Answers = new Answer[2];
        }
        public override void DisplayQuestion()
        {
            Header = "True | False Question";
            Console.WriteLine($"{Header}\tMark({Mark}):\n{Body}\n");
            for (int i = 0; i < Answers.Length; i++) 
            {
                Console.Write(Answers[i] +"\t\t\t\t");
            }
        }
    }
}
