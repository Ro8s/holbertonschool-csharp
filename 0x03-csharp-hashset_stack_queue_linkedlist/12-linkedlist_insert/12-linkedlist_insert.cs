using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newnode = myLList.First;
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

