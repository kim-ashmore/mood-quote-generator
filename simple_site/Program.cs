using System;
using System.Collections.Generic;

namespace mood_emulator
{

    class MainClass
    {
        static public string mood_evaluator(string mood)
        {
            mood = mood.ToLower();
            int mood_val = 0;
            Dictionary<string, int> Mood_dict = new Dictionary<string, int>
            {
                {"happy", 1 },
                {"sad", 2},
                {"mad", 3 },
                {"excited", 4},
                {"nervous", 5},
            };

            // TODO: EMULATE MORE MOODS AND TAKE IN FROM COMMAND LINE IF NOT EXISTING IN SWITCH
            if (Mood_dict.ContainsKey(mood) == true)
            {
                mood_val = Mood_dict[mood];
            }

            else
            {
                Console.WriteLine("I've never heard of that before. could you tell me more about it?");
                Mood_dict.Add(Console.ReadLine(), 0);
            }

            switch (mood_val)
            {
                case 1:
                    Console.WriteLine("Fantastic! I have something for you.");
                    break;
                case 2:
                    Console.WriteLine("Oh, I'm Sorry to hear that. I know just the thing to cheer you up.");
                    break;
                default:
                    Console.WriteLine("Perfect! Jennny the Genie has some motivational words for you...");

                    break;
            }
            return mood;

        }

        static public string Mood_quotes(string mood)
        {
            string quote = "";
            string Author;

            return quote;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello!I'm Jennny the Genie. How are you feeling today? ");

            string mood = Console.ReadLine();

            // WORD CHECKING AND EVALUATION OF MOOD

            string mood_quote = mood_evaluator(mood);
            // TODO: ADD SYNONYMOUS BEHAVIOR. call an api with valuable quotes

            // EXIT WITH QUOTE

            Console.WriteLine($"Here is some great words by AUTHOR: {mood_quote}");

        }

    }
}




