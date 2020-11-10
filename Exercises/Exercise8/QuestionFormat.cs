using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8
{
    public class QuestionFormat : QuestionManager
    {
        public QuestionFormat(string catalog) : base(catalog)
        {

        }

        public override void DisplayAll()
        {
            Console.WriteLine("".PadRight(50, '-'));

            base.DisplayAll();

            Console.WriteLine("".PadRight(50, '-'));
        }
    }
}
