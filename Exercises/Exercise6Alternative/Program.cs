using System;

namespace Exercise6Alternative
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectPool<MyClass> objPool = new ObjectPool<MyClass>();
            MyClass obj1 = objPool.Get();
            MyClass obj2 = objPool.Get();
            MyClass obj3 = objPool.Get();
            objPool.Release(obj3);
            MyClass obj4 = objPool.Get();
            objPool.Release(obj1);
            objPool.Release(obj4);
            MyClass obj5 = objPool.Get();
            objPool.Release(obj5);
            objPool.Release(obj2);

            Console.Read();
        }
    }
}
