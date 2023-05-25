using System.IO;

public class Journal
{
    public List<string> _entries = new List<string> { };

    public void DisplayJournal()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
            Console.WriteLine("");
        }
    }

    public void LoadJournal()
    {
        StreamReader sr = new StreamReader("File.txt");
        String line = sr.ReadLine();

        while (line != null)
        {
            line = sr.ReadLine();
        }
        sr.Close();

    }

    public void SaveJournal()
    {

        StreamWriter sw = new StreamWriter("File.txt");

        foreach (string entry in _entries)
        {
            sw.WriteLine(entry);
        }

        sw.Close();

    }

}