using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> uniq1 = new HashSet<int>(list1);
        HashSet<int> uniq2 = new HashSet<int>(list2);
        HashSet<int> exp = new HashSet<int>(list1);
        exp.ExceptWith(uniq2);
        uniq2.ExceptWith(uniq1);
        List<int> res = new List<int>();
        foreach (var item in exp)
        {
            res.Add(item);
        }
        foreach (var item in uniq2)
        {
            res.Add(item);
        }
        res.Sort();
        return(res);
    }
}

