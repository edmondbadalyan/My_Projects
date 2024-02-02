using System;
using System.Collections.Generic;
using Dictionary;
public class Program
{
    public static void Main(string[] args)
    {
        DictionaryTranslator translator = new DictionaryTranslator();

        while (true)
        {
            Console.WriteLine("Choose translation mode:");
            Console.WriteLine("1. English to Russian");
            Console.WriteLine("2. Russian to English");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            int modeChoice = int.Parse(Console.ReadLine());

            if (modeChoice == 0)
            {
                break;
            }

            bool isRussianToEnglish = modeChoice == 2;

            Console.Write("Enter the phrase to translate: ");
            string source = Console.ReadLine();

            string translation = translator.Translate(source, isRussianToEnglish);
            Console.WriteLine("Translation: " + translation);
            Console.WriteLine();
        }
    }
}