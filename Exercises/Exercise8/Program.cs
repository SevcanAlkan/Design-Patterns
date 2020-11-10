using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionFormat questions = new QuestionFormat("C# Programming Language, not the Java!");

            questions.Question = new CSharpQuestions();

            questions.Next();
            questions.Display();
            questions.Delete("What is class?");

            questions.New("What is inheritance?");
            questions.New("How many types of inheritance are there in C#?");

            questions.DisplayAll();

            Console.ReadKey();
        }
    }
}
