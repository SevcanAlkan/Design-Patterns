using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8
{
    public class CSharpQuestions : IQuestion
    {
        private List<string> questions = new List<string>();
        private int current = 0;

        public CSharpQuestions()
        {
            questions.Add("What is class?");
            questions.Add("What is interface?");
            questions.Add("What is abstraction?");
            questions.Add("How multiple polymorphism is achived in C#?");
            questions.Add("How many types of exception handling are there in C#?");
            questions.Add("What is abstract class?");
            questions.Add("What is multi threading?");
        }

        public void Delete(string question)
        {
            questions.Remove(question);
        }

        public void Display()
        {
             Console.WriteLine(questions[current]);
        }

        public void DisplayAll()
        {
            foreach (var item in questions)
            {
                Console.WriteLine(item);
            }
        }

        public void New(string question)
        {
            questions.Add(question);
        }

        public void Next()
        {
            if (current <= questions.Count - 1)
                current++;
        }

        public void Previous()
        {
            if (current > 0)
                current--;
        }
    }
}
