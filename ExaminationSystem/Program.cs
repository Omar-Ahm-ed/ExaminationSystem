using ExaminationSystem;
using System.Diagnostics;

public class Program
{
    static void Main(string[] args)
    {
        Subject subject1 = new Subject();
        subject1.CreateExam();
        Console.Clear();
        Console.WriteLine("Do You Want To Start The Exame (y | n): ");
        if(char.Parse(Console.ReadLine()) == 'y')
        {
            Console.Clear();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            subject1.SubjectExam.DisplayExam();
            Console.WriteLine($"The Elapsed Time = {stopwatch.Elapsed}");
        }
    }
}
