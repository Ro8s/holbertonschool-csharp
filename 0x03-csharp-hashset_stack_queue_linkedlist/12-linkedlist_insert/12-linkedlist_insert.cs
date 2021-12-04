using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newnode = myLList.First;
        if (newnode.Value > n)
        {
            myLList.AddFirst(n);
            newnode = myLList.First;
            return(newnode);
        }
        foreach (var node in myLList)
        {
            if (n > newnode.Value)
            {
                if (newnode.Next == null)
                {
                    myLList.AddAfter(newnode, n);
                    newnode = newnode.Next;
                    break;
                }
                else if (n < newnode.Next.Value)
                {
                    myLList.AddAfter(newnode, n);
                    newnode = newnode.Next;
                    break;
                }
            }
            newnode = newnode.Next;
        }
        return(newnode);
    }
}

