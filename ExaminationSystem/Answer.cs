namespace ExaminationSystem
{
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Text}\t\t\t";
        }

    }
}
