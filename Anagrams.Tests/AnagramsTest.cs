using System.Collections.Generic;
using NUnit.Framework;

public class AnagramsTest
{
    AnagramsSut _sut;
    [SetUp]
    public void Initialise()
    {
        _sut = new AnagramsSut();
    }
    [Test]
    public void Anagram2Characters()
    {
        List<string> temp = new List<string>{"ABC", "ACB", "BAC","BCA", "CBA", "CAB"};
        List<string> output= new List<string>();
        var str = "ABC";
        _sut.generate_anagram(str,0, str.Length-1,output);
        Assert.AreEqual(temp, output);
    }
}