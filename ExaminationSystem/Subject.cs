namespace ExaminationSystem
{   //4:49
    //6:8

    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam SubjectExam { get; set; }
        public void CreateExam()
        {
            Console.Write("Please Enter Type Of Exam You want To Create ( 1 for Practical and 2 for Final):");
            var Type = int.Parse(Console.ReadLine());
            var time = 0;
            switch (Type)
            {
                case 1:
                    SubjectExam = new PracticalExam();
                    Console.Write("Please Enter The Time Of Exam in Minutes: ");
                    try
                    {
                        time = int.Parse(Console.ReadLine());

                    }
                    catch
                    {
                        try
                        {
                            Console.Write("Please Enter The Time Of Exam in Minutes as a number: ");
                            time = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }

                    SubjectExam.Time.AddMinutes(time);
                    Console.WriteLine("Please Enter The Number Of Question You Wanted To Create: ");
                    try
                    {
                        SubjectExam.NumberOfQuestions = int.Parse(Console.ReadLine());

                    }
                    catch 
                    {
                        try
                        {

                            Console.WriteLine("Please Enter The Number Of Question You Wanted To Create: ");
                            SubjectExam.NumberOfQuestions = int.Parse(Console.ReadLine());
                        }
                        catch(Exception ex)
                        {
                            throw ex;
                        }
                    }
                    SubjectExam.Questions = new Question[SubjectExam.NumberOfQuestions];
                    for (int i = 0; i < SubjectExam.NumberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.Write($"Please Choose The Type Of Question Number({i + 1}) (1 for True | False || 2 for MCQ) : ");
                        try
                        {
                            Type = int.Parse(Console.ReadLine());

                        }
                        catch
                        {
                            try
                            {
                                Console.Write($"Please Choose The Type Of Question Number({i + 1}) (1 for True OR False || 2 for MCQ) as a number : ");
                                Type = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                        }

                        Console.Clear();
                        switch (Type)
                        {
                            case 1:
                                SubjectExam.Questions[i] = new TrueOrFalse();
                                Console.WriteLine("True | False Question\nPlease Enter The Bady of Question:");
                                SubjectExam.Questions[i].Body = Console.ReadLine();
                                Console.Write("Please Enter The Marks of Question:");
                                try
                                {
                                    SubjectExam.Questions[i].Mark = int.Parse(Console.ReadLine());

                                }
                                catch
                                {
                                    try
                                    {
                                        Console.Write("Please Enter The Marks of Question as a number:");
                                        SubjectExam.Questions[i].Mark = int.Parse(Console.ReadLine());
                                    }
                                    catch (Exception ex)
                                    {
                                        throw ex;
                                    }
                                }
                                Console.WriteLine("Please Enter The Right Answer of Question (1 for True and 2 for False):");
                                SubjectExam.Questions[i].Answers = new Answer[2]
                                {
                                    new Answer { Id = 1, Text = "True"},
                                    new Answer {  Id= 2, Text = "False"}
                                };
                                SubjectExam.Questions[i].RightAnswer = new Answer();

                                try
                                {
                                    SubjectExam.Questions[i].RightAnswer.Id = int.Parse(Console.ReadLine());

                                }
                                catch
                                {
                                    try
                                    {
                                        Console.WriteLine("Please Enter The Right Answer of Question (1 for True and 2 for False) as a number:");
                                        SubjectExam.Questions[i].RightAnswer.Id = int.Parse(Console.ReadLine());
                                    }
                                    catch (Exception ex)
                                    {
                                        throw ex;
                                    }
                                }
                                SubjectExam.Questions[i].RightAnswer.Id = SubjectExam.Questions[i].RightAnswer.Id;
                                for (int j = 0; j < SubjectExam.Questions[i].Answers.Length; j++)
                                {
                                    if (SubjectExam.Questions[i].RightAnswer.Id == SubjectExam.Questions[i].Answers[j].Id)
                                        SubjectExam.Questions[i].RightAnswer.Text = SubjectExam.Questions[i].Answers[j].Text;

                                }

                                break;
                            case 2:
                                SubjectExam.Questions[i] = new MCQQuestion();
                                Console.WriteLine("MCQ Question\nPlease Enter The Bady of Question:");
                                SubjectExam.Questions[i].Body = Console.ReadLine();
                                Console.Write("Please Enter The Marks of Question:");
                                try
                                {
                                    SubjectExam.Questions[i].Mark = int.Parse(Console.ReadLine());

                                }
                                catch
                                {
                                    try
                                    {

                                        Console.WriteLine("MCQ Question\nPlease Enter The Bady of Question as a number:");
                                        SubjectExam.Questions[i].Mark = int.Parse(Console.ReadLine());
                                    }
                                    catch (Exception ex)
                                    {
                                        throw ex;
                                    }
                                }


                                Console.WriteLine("The Choices Of Question:");
                                for (int j = 0; j < 3; j++)
                                {
                                    Console.Write($"Please Enter The Choice Number {j + 1}:");
                                    var choice = Console.ReadLine();
                                    SubjectExam.Questions[i].Answers[j] = new Answer();
                                    SubjectExam.Questions[i].Answers[j].Id = j + 1;
                                    SubjectExam.Questions[i].Answers[j].Text = choice;
                                }
                                SubjectExam.Questions[i].RightAnswer = new Answer();
                                Console.WriteLine("Please Specify The Right Choice of Question:");
                                var id = 0;
                                try
                                {
                                     id = int.Parse(Console.ReadLine());

                                }
                                catch
                                {
                                    try
                                    {
                                        Console.WriteLine("Please Specify The Right Choice of Question as a number:");
                                        id = int.Parse(Console.ReadLine());
                                    }
                                    catch (Exception ex)
                                    {
                                        throw ex;
                                    }
                                }


                                SubjectExam.Questions[i].RightAnswer.Id = id;
                                for (int j = 0; j < SubjectExam.Questions[i].Answers.Length; j++)
                                {
                                    if (id == SubjectExam.Questions[i].Answers[j].Id)
                                        SubjectExam.Questions[i].RightAnswer.Text = SubjectExam.Questions[i].Answers[j].Text;

                                }
                                break;
                            default:
                                Console.WriteLine("Wrong choice. Come back later.");
                                break;
                        }
                    }
                    break;
                case 2:
                    SubjectExam = new FinalExam();
                    Console.Write("Please Enter The Time Of Exam in Minutes: ");
                    try
                    {
                        time = int.Parse(Console.ReadLine());

                    }
                    catch
                    {
                        try
                        {
                            Console.Write("Please Enter The Time Of Exam in Minutes as a number: ");
                            time = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }

                    SubjectExam.Time.AddMinutes(time);
                    Console.WriteLine("Please Enter The Number Of Question You Wanted To Create: ");
                    try
                    {
                        SubjectExam.NumberOfQuestions = int.Parse(Console.ReadLine());

                    }
                    catch
                    {
                        try
                        {

                            Console.WriteLine("Please Enter The Number Of Question You Wanted To Create: ");
                            SubjectExam.NumberOfQuestions = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                    SubjectExam.Questions = new Question[SubjectExam.NumberOfQuestions];
                    for (int i = 0; i < SubjectExam.NumberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.Write($"Please Choose The Type Of Question Number({i + 1}) (1 for True | False || 2 for MCQ) : ");
                        try
                        {
                            Type = int.Parse(Console.ReadLine());

                        }
                        catch
                        {
                            try
                            {
                                Console.Write($"Please Choose The Type Of Question Number({i + 1}) (1 for True OR False || 2 for MCQ) as a number : ");
                                Type = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                        }

                        Console.Clear();
                        switch (Type)
                        {
                            case 1:
                                SubjectExam.Questions[i] = new TrueOrFalse();
                                Console.WriteLine("True | False Question\nPlease Enter The Bady of Question:");
                                SubjectExam.Questions[i].Body = Console.ReadLine();
                                Console.Write("Please Enter The Marks of Question:");

                                try
                                {
                                    SubjectExam.Questions[i].Mark = int.Parse(Console.ReadLine());

                                }
                                catch
                                {
                                    try
                                    {
                                        Console.Write("Please Enter The Marks of Question as a number:");
                                        SubjectExam.Questions[i].Mark = int.Parse(Console.ReadLine());
                                    }
                                    catch (Exception ex)
                                    {
                                        throw ex;
                                    }
                                }
                                Console.WriteLine("Please Enter The Right Answer of Question (1 for True and 2 for False):");
                                SubjectExam.Questions[i].Answers = new Answer[2]
                                {
                                    new Answer { Id = 1, Text = "True"},
                                    new Answer {  Id= 2, Text = "False"}
                                };
                                SubjectExam.Questions[i].RightAnswer = new Answer();

                                try
                                {
                                    SubjectExam.Questions[i].RightAnswer.Id = int.Parse(Console.ReadLine());

                                }
                                catch
                                {
                                    try
                                    {
                                        Console.WriteLine("Please Enter The Right Answer of Question (1 for True and 2 for False) as a number:");
                                        SubjectExam.Questions[i].RightAnswer.Id = int.Parse(Console.ReadLine());
                                    }
                                    catch (Exception ex)
                                    {
                                        throw ex;
                                    }
                                }
                                for (int j = 0; j < SubjectExam.Questions[i].Answers.Length; j++)
                                {
                                    if (SubjectExam.Questions[i].RightAnswer.Id == SubjectExam.Questions[i].Answers[j].Id)
                                        SubjectExam.Questions[i].RightAnswer.Text = SubjectExam.Questions[i].Answers[j].Text;

                                }

                                break;
                            case 2:
                                SubjectExam.Questions[i] = new MCQQuestion();
                                Console.WriteLine("MCQ Question\nPlease Enter The Bady of Question:");
                                SubjectExam.Questions[i].Body = Console.ReadLine();
                                Console.Write("Please Enter The Marks of Question:");
                                try
                                {
                                    SubjectExam.Questions[i].Mark = int.Parse(Console.ReadLine());

                                }
                                catch
                                {
                                    try
                                    {

                                        Console.WriteLine("MCQ Question\nPlease Enter The Bady of Question as a number:");
                                        SubjectExam.Questions[i].Mark = int.Parse(Console.ReadLine());
                                    }
                                    catch (Exception ex)
                                    {
                                        throw ex;
                                    }
                                }


                                Console.WriteLine("The Choices Of Question:");
                                for (int j = 0; j < 3; j++)
                                {
                                    Console.Write($"Please Enter The Choice Number {j + 1}:");
                                    var choice = Console.ReadLine();
                                    SubjectExam.Questions[i].Answers[j] = new Answer();
                                    SubjectExam.Questions[i].Answers[j].Id = j + 1;
                                    SubjectExam.Questions[i].Answers[j].Text = choice;
                                }
                                SubjectExam.Questions[i].RightAnswer = new Answer();
                                Console.WriteLine("Please Specify The Right Choice of Question:");
                                var id = 0;
                                try
                                {
                                    id = int.Parse(Console.ReadLine());

                                }
                                catch
                                {
                                    try
                                    {
                                        Console.WriteLine("Please Specify The Right Choice of Question as a number:");
                                        id = int.Parse(Console.ReadLine());
                                    }
                                    catch (Exception ex)
                                    {
                                        throw ex;
                                    }
                                }


                                SubjectExam.Questions[i].RightAnswer.Id = id;
                                for (int j = 0; j < SubjectExam.Questions[i].Answers.Length; j++) 
                                {
                                    if (id == SubjectExam.Questions[i].Answers[j].Id)
                                        SubjectExam.Questions[i].RightAnswer.Text = SubjectExam.Questions[i].Answers[j].Text;

                                }
                                break;
                            default:
                                Console.WriteLine("Wrong choice. Come back later.");
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Wrong choice. Come back later.");
                    break;
            }
        }
        
    }
}
