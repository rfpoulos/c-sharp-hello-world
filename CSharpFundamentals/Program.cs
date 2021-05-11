using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var john = new Person
            {
                FirstName = "John",
                LastName = "Smith"
            };
            john.Introduce();
            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
