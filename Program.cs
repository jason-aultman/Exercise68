using System;
using System.Collections.Generic;

namespace Exercise68
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\jason\RiderProjects\Exercise68\dictionary.txt";
            Dictionary<string, string> translations = new Dictionary<string, string>();
            translations=FileHandler.getDictionary(translations,path);
            do
            {
                string englishWord = GetWordInEnglish();
                string spanishWord = GetWordInSpanish(englishWord, translations);
                if (spanishWord != null)
                {
                    Console.WriteLine($"{englishWord} in spanish is {spanishWord}");
                }else Console.WriteLine($"{englishWord} cannot be translated.");
            } while (DoAgain());
        }

        private static bool DoAgain()
        {
            Console.WriteLine("Would you like to go again? y/n");
            var answer = Console.ReadLine();
            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }

            return false;
        }

        public static string GetWordInEnglish()
        {
            Console.WriteLine("Enter a word in English: ");
            var englishWord = Console.ReadLine();
            return englishWord;
        }

        public static string GetWordInSpanish(string englishWord, Dictionary<string, string> translations)
        {
            return translations.GetValueOrDefault(englishWord, null);
        }
    }
}