using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        var d = new Dictionary<string, int>();
        
        foreach (var item in myDict)
        {
            d.Add(item.Key, item.Value);
        }
        return (d);
    }
}
