using System;

namespace mood_emulator
{

    class MainClass
    {
        static public string mood_evaluator(string mood)
        {
            string quote = "";
            string Author;
            return quote;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello!I'm Jennny the Genie. How are you feeling today? ");

            string mood = Console.ReadLine();
            Console.WriteLine("Perfect! Jennny the Genie has some motivational words for you...");

            // WORD CHECKING AND EVALUATION OF MOOD

            string mood_quote = mood_evaluator(mood);
            // TODO: ADD SYNONYMOUS BEHAVIOR. call an api with valuable quotes

            // EXIT WITH QUOTE

            Console.WriteLine($"Here is some great words by AUTHOR: {mood_quote}");

        }

    }

}


