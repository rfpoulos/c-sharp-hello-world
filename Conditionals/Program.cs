using System;

namespace Conditionals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");

            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");

            }
            else
            {
                Console.WriteLine("It's evening");
            }

            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotion");
                    break;
                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
        }
    }
}
