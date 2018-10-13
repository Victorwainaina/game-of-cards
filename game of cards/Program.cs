using System;
using System.Collections.Generic;

namespace game_of_cards
{
    internal static class Program
    {
        private static void Main()
        {
            var x = new List<string>()
            {
                "KS","KH","KD","KF",
                "JS","JH","JD","JF",
                "QS","QH","QD","QF", 
                "2S","2H","2D","2F",
                "3S","3H","3D","3F",
                "4S","4H","4D","4F",
                "5S","5H","5D","5F",
                "6S","6H","6D","6F",
                "7S","7H","7D","7F",
                "8S","8H","8D","8F",
                "9S","9H","9D","9F",
                "10S","10H","10D","10F",
                "AS","AH","AD","AF",

            };
            var rand = new Random();
            for (int i = 0; i <= x.Count; i++)
            {
                //x.Add(rand.ToString());
                var rand1 = rand.Next(x.Count);
                var rand2 = rand.Next(x.Count);
                var rand3 = rand.Next(x.Count);
                var rand4 = rand.Next(x.Count);
                Console.WriteLine(rand1);
                Console.WriteLine(rand2);
                Console.WriteLine(rand3);
                Console.WriteLine(rand4);
                break;
            }
            var v= new List<string>(){};
            Console.ReadKey();
        }
    }
}
