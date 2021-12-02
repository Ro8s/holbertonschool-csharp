﻿using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var listakeys = myDict.Keys.ToList();
        listakeys.Sort();
        foreach (var item in listakeys)
        {
            Console.WriteLine("{0}: {1}", item, myDict[item]);
        }
        
    }
}
