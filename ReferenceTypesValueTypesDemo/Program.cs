using System;

namespace ReferenceTypesValueTypesDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b {1}", a, b));
        }
    }
}
