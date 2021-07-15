using System;
using System.Collections.Generic;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input letter or string: ");
            string letter = Console.ReadLine();

            int counter = 0;
            List<string> list = new List<string>();

            string[] words =
            {
                "home", "programming", "victory", "C#", "football", "sport",
                "book", "learn", "dream", "fun"
            };

            for(int i = 0;i < words.Length; i++){
                if (words[i].Contains(letter)) { 
                    counter++;
                    list.Add(words[i]);
                }                
            }

            if (counter!=0)
            {                
                foreach (var e in list)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("No match");                
            }
        }
    }
}
