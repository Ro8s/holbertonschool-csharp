using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (myLList.First == null)
        {
            return;
        }
        LinkedListNode<int> node = myLList.First;
        for (int i = 0; i < myLList.Count; i++)
        {
            if (i == index)
            {
                myLList.Remove(node);
                return;
            }
            else
            {
                node = node.Next;
            }
        }
        return;
    }
}
