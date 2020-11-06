using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            CDBuilder builder = new CDBuilder();
            CDType cdType = builder.BuildSonyCDType();
            cdType.ShowItems();

            CDType cdType2 = builder.BuildSamsungCDType();
            cdType2.ShowItems();

            Console.ReadKey();
        }
    }
}
