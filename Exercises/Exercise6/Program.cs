using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectPoolDemo op = new ObjectPoolDemo();
            op.setup();
            op.tearDown();
            op.testOjectPool();

            Console.ReadKey();
        }
    }
}
