using System;

namespace CG2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Name");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter a Past-Tense Verb");
            string Verb = Console.ReadLine();

            Console.WriteLine("Enter a Noun");
            string Noun = Console.ReadLine();

            Console.WriteLine(Name + " be nimble " + Name + " be quick " + Name + " " + Verb + " over the " + Noun + ".");
            Console.ReadLine();
        }
    }
}
