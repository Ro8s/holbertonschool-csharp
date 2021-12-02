using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int pichu = 0;
        foreach (var item in myDict)
        {
            pichu++;
        }
        return (pichu);
    }
}

