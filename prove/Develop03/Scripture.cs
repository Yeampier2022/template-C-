using System;

public class Scripture
{
    private string[] _scriptureList = {
        $"\nWherefore, ye must press forward with a asteadfastness in Christ, having \na perfect brightness of bhope, and a clove of God and of all men.\nWherefore, if ye shall press forward, feasting upon the word of Christ, \nand dendure to the end, behold, thus saith the Father: Ye shall have eeternal life.",
        $"\nIf any of you lack wisdom, let him ask of God, that giveth to all men \nliberally, and upbraideth not; and it shall be given him. But let him ask in \nfaith, nothing wavering. For he that wavereth is like a wave of the sea driven \nwith the wind and tossed.",
        $"\nTrust in the Lord with all thine heart; and lean not unto thine own \nunderstanding. In all thy ways acknowledge him, and he shall direct thy paths.",
        $"\nAnd now, he imparteth his word by angels unto men, yea, anot only men but women also. \nNow this is not all; little bchildren do have words given unto them many times, \nwhich cconfound the wise and the learned.",
        $"\nAnd when ye shall receive these things, I would exhort you that ye would aask God, \nthe Eternal Father, in the name of Christ, if these things are not true, \nand if ye shall ask with a csincere heart, with dreal intent, \nefaith in Christ, he will fmanifest the gtruth of it unto you, \nby the power of the Holy Ghost."
        
    };
    private string _scripture;
    private string _reference;


    public string RandomScripture()
    {
        Console.Clear();
        var randomNumber = new Random();
        int i = randomNumber.Next(_scriptureList.Length);
        _scripture = _scriptureList[i];

        Reference reference = new Reference();
        _reference = reference.DisplaySelectedReference(i);

        _scripture = _reference + "\n" + _scripture;

        return _scripture;
    }

    public string SpecificScripture(int i)
    {
        string _scripture = _scriptureList[i - 1];
        return _scripture;
    }

    public string[] ScriptureArray(int i)
    {
        _scripture = _scriptureList[i - 1];
        var scriptureArrayList = _scripture.Split(" ");

        return scriptureArrayList;
    }
}