using System;
using System.Collections.Generic;

public class AnagramsSut
{
    
    public void generate_anagram(String str, int l, int r, List<string> list)
    {
        if (l == r)
        {
            list.Add(str);
        }
        else
        {
            for (int i = l; i <= r; i++)
            {
                str = swap(str, l, i);
                generate_anagram(str, l + 1, r, list);
                str = swap(str, l, i);
            }
        }
    }

    public static String swap(String a,
                              int i, int j)
    {
        char temp;
        char[] charArray = a.ToCharArray();
        temp = charArray[i];
        charArray[i] = charArray[j];
        charArray[j] = temp;
        string s = new string(charArray);
        return s;
    }


}