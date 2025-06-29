namespace ExaminationSystem
{
    public abstract class Exam
    {
        public DateTime Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        public abstract void DisplayExam();
    }
}
