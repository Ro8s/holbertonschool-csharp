using System;
using System.Collections.Generic;


class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> uniq2 = new HashSet<int>(list2);
        HashSet<int> inter = new HashSet<int>(list1);
        inter.IntersectWith(uniq2);
        List<int> res = new List<int>();
        foreach (var item in inter)
        {
            res.Add(item);
        }
        return(res);

    }
}

