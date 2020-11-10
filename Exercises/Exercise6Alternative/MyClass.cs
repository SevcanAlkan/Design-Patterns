using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6Alternative
{
    public class MyClass : IMyClass
    {
        public int num { get; private set; }

        public MyClass()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            this.num = random.Next(0, int.MaxValue);
            Console.WriteLine($"Instance {this.num} was created");
        }
    }

    public interface IMyClass
    {
        public int num { get; }
    }
}
