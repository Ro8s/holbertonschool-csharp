using System;
using System.Collections.Generic;
using System.Linq;
class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string last = null;
        foreach (KeyValuePair<string, int> item in myList.OrderBy(key => key.Value))
        {
            last = item.Key;
        }
        return(last);
    }
}

