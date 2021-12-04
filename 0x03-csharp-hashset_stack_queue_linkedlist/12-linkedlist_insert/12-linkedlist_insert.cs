using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newnode = myLList.First;
        if (newnode.Value > n)
        {
            if (newnode.Next == null)
            {
                newnode = myLList.AddFirst(n);
                return(newnode);
            }
        }
        foreach (var node in myLList)
        {
            if (n > newnode.Value && n < newnode.Next.Value)
            {
                myLList.AddAfter(newnode, n);
                break;
            }
            else
            {
                newnode = newnode.Next;
            }
            
        }
        return(newnode);

    }
}

