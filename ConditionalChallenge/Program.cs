using System;

namespace ConditionalChallenge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = getUserInput();

        }

        public static int getUserInput()
        {
            try
            {
                Console.WriteLine("Enter integer between 1 - 10");
                var input = int.Parse(Console.ReadLine());

                if (input <= 10 && input >= 0)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    throw new Exception();
                }
                return input;
            }
            catch (Exception)
            {
                Console.WriteLine("Not valid");
                return getUserInput();
            }
        }
    }
}
