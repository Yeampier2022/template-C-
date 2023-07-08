using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>{};

        Video cats = new Video("Dog", "charles dickens", 30);
        cats.AddComment("Yeampier", "why does his face look like that?");
        cats.AddComment("Marcelo", "I miss my dog, she ran away");
        cats.AddComment("Gustavo", "Click this link for free bitcoin bit.ly/56987");
        _videos.Add(cats);

        Video puppies = new Video("puppies", "leroy jenkins", 60);
        puppies.AddComment("Paola", "Stop feeding him dog food, he deserves steaks");
        puppies.AddComment("Maria", "What a cute doggy");
        puppies.AddComment("Gerardo", "Your dog will be the first in space. Check your dms");
        _videos.Add(puppies);

        Video conspiracy = new Video("Birds are government spies", "anonymous man", 100000);
        conspiracy.AddComment("Leonardo", "very insightful, I will be hiding from birds now");
        conspiracy.AddComment("Alejandro", "I am an egg");
        conspiracy.AddComment("Fabricio", "We are watching your house");
        _videos.Add(conspiracy);

        foreach (Video v in _videos)
        {
            Console.WriteLine();
            v.Display();
            Console.WriteLine();
        }
    }
}