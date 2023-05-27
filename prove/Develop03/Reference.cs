using System;

//Keeps track of the book, chapter, and verse information.
public class Reference
{
    private string[] _referenceList = {
        "1- 2 Nephi Chapter 31:20",
        "2- James 1:5-6",
        "3- Mosiah Chapter 2:17",
        "4- Alma Chapter 32:20",
        "5- Moroni Chapter 10:4-5"
       
    };
    private string _reference;

    public void DisplayAllReferences()
    {
        foreach (string reference in _referenceList)
        {
            Console.WriteLine(reference);
        }
    }

    public string DisplaySelectedReference(int i)
    {
        _reference = _referenceList[i - 1];
        return _reference;
    }
}