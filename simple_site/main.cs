using System;

namespace mood_emulator
{
    public class main
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello! I'm Jennny the Genie. How are you feeling today?\n ");

            string mood = Console.ReadLine(); // WORD CHECKING AND EVALUATION OF MOOD

            string mood_quote = MoodEmulatorClass.mood_evaluator(mood);
            // TODO: ADD SYNONYMOUS BEHAVIOR. call an api with valuable quotes
            Console.WriteLine($"\n {mood_quote}");
            System.Environment.Exit(1);
        }
    }
}
