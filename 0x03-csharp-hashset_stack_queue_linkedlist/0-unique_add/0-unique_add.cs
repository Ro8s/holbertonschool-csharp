using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {

        var uniq = myList.Distinct();
        int sum = 0;
        foreach (int i in uniq)
        {
            sum += i;
        }
        return(sum);
    }
}

