
namespace Anagrams.Console
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String str = "ABC";
            int n = str.Length;
            List<string> list = new List<string>();
            AnagramsSut _sut= new AnagramsSut();
            _sut.generate_anagram(str, 0, n - 1, list);
            foreach (var r in list)
                Console.WriteLine(r);
            Console.ReadKey();
        }


    }
}
