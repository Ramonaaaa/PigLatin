using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Test will be transformed in: \"{LatinPig.TransformWord("Test")}\".");
            Console.WriteLine($"Examen will be transformed in: \"{LatinPig.TransformWord("Examen")}\".");
            Console.WriteLine($"Empty string will be transformed in: \"{LatinPig.TransformWord(string.Empty)}\".");

        }
    }
}
