using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8
{
    public interface IQuestion
    {
        void Next();
        void Previous();
        void New(string question);
        void Delete(string question);
        void Display();
        void DisplayAll();
    }
}
