using System;
using System.Collections.Generic;

namespace mood_emulator
{

    class MainClass
    {
        static public string mood_evaluator(string mood){

            mood = mood.ToLower();
            int mood_val = 0;
            string quote;

            Dictionary<string, int> Mood_dict = new Dictionary<string, int>{
                {"happy", 1 },
                {"sad", 2},
                {"mad", 3 },
                {"excited", 4},
                {"nervous", 5}};

            if (Mood_dict.ContainsKey(mood.ToLower()) == true){
                mood_val = Mood_dict[mood];
                //Console.WriteLine($"mood value: {mood_val}");
            }

            else{
                Console.WriteLine("I've never heard of that before. could you tell me more about it?");
                Mood_dict.Add(mood,0);
                string description = Console.ReadLine(); // ADD TO FUTURE DATABASE WHERE MOODS CAN BE EVALUATED BASED ON WORD DETECTION
            }

           
            return quote = Mood_quotes(mood, mood_val);

        }

        static public string Mood_quotes(string mood, int moodValue){

            string quote = "";
            string author = "";


            switch (moodValue){
                case 1:
                    Console.WriteLine("Fantastic! I have something for you...");
                    quote = "You are smart and confident within yourself. You've got this.";
                    author = "Kimbo Slice";
                    break;
                case 2:
                    Console.WriteLine("Oh, I'm Sorry to hear that. I know just the thing to cheer you up.");
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;

                default:
                    Console.WriteLine("Jennny the Genie is out of words for you today. come back tomorrow!");
                    quote = "";
                    author = "";

                    break;
            }
            string final_quote = $"\n\t{quote} \n\t\t\t - {author}";
            return final_quote;
        }

        public static void Main(string[] args){

            Console.WriteLine("Hello! I'm Jennny the Genie. How are you feeling today?\n ");

            string mood = Console.ReadLine(); // WORD CHECKING AND EVALUATION OF MOOD

            string mood_quote = mood_evaluator(mood);
            // TODO: ADD SYNONYMOUS BEHAVIOR. call an api with valuable quotes
            Console.WriteLine($"\n {mood_quote}");

        }

    }
}




