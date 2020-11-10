using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8
{
    public class QuestionManager : IQuestion
    {
        public IQuestion Question { get; set; }
        public string Catalog { get; private set; }

        public QuestionManager(string catalog)
        {
            Catalog = catalog;
        }

        public void Delete(string question)
        {
            Question.Delete(question);
        }

        public void Display()
        {
            Question.Display();
        }

        public virtual void DisplayAll()
        {
            Question.DisplayAll();
        }

        public void New(string question)
        {
            Question.New(question);
        }

        public void Next()
        {
            Question.Next();
        }

        public void Previous()
        {
            Question.Previous();
        }
    }
}
