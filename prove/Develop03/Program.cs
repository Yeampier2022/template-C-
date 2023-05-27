using System;

class Programw4
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        Words words = new Words();


        Console.WriteLine("Welcome to Scripture Study");
        Console.WriteLine();
        Console.WriteLine("Please select a scripture favorite (1-5): ");

        reference.DisplayAllReferences();
        string choiceScripture = Console.ReadLine();
        int i = Int32.Parse(choiceScripture);

        Console.Clear();
        Console.WriteLine(reference.DisplaySelectedReference(i));
        words.HideWords(scripture.ScriptureArray(i), i);

        Console.WriteLine();
        Console.WriteLine("Thanks for Studying! Goodbye!");
    }
}