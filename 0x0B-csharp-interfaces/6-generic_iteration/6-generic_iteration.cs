using System;
using System.Linq;
using System.Collections.Generic;


///<summary>Base Class</summary>
abstract class Base
{
    ///<summary>Property name</summary>
    public string name { set; get; }

    ///<summary>Returns the string representation of a Base object</summary>
    public override string ToString()
    {
        return $"{this.name} is a {this.GetType().Name}";
    }
}

///<summary>IInteractive Interface</summary>
interface IInteractive
{
    ///<summary>Delcaration of method Interact</summary>

    void Interact();
}

///<summary>IBreakable Interface</summary>
interface IBreakable
{
    ///<summary>property durability</summary>
    int durability { set; get; }

    ///<summary>method Break</summary>
    void Break();
}

///<summary>ICollectable Interface</summary>
interface ICollectable
{
    ///<summary>property isCollected</summary>
    bool isCollected { set; get; }

    ///<summary>method Collect</summary>
    void Collect();
}



///<summary>Door Class that inherts base and IInteractive</summary>
class Door : Base, IInteractive
{
    ///<summary>Base Constructor</summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }
    ///<summary>Method Interact</summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}

/// <summary>
/// Decoration base
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// bool variable isQuestItem
    /// </summary>
    public bool isQuestItem;

    /// <summary>
    /// durability property
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Decoration Constructor
    /// </summary>
    /// <param name="name">name</param>
    /// <param name="durability">durability</param>
    /// <param name="isQuestItem">isquestitem</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interect method
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {this.name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        }
        else if (isQuestItem == false)
        {
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Break method
    /// </summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
        {
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        }
        if (durability == 0)
        {
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        }
        if (durability < 0)
        {
            Console.WriteLine($"The {this.name} is already broken.");
        }
    }
}

/// <summary>
///  Key class that inherts Base and ICollectable
/// </summary>
class Key : Base, ICollectable
{
    /// <summary>
    /// isCollected property
    /// </summary>
    public bool isCollected { set; get; }

    /// <summary>
    /// Key constructor class
    /// </summary>
    /// <param name="name">name</param>
    /// <param name="isCollected">isCollected</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Collect method
    /// </summary>
    public void Collect()
    {
        if (this.isCollected == false)
        {
            this.isCollected = true;
            Console.WriteLine($"You pick up the {this.name}.");
        }
        else if (this.isCollected == true)
        {
            Console.WriteLine($"You have already picked up the {this.name}.");
        }
    }
}


/// <summary>
/// Objs class
/// </summary>
/// <typeparam name="T">Type</typeparam>
public class Objs<T> : IEnumerable<T>
{
    /// <summary>
    /// private list
    /// </summary>
    private T[] tlist = new T[] { };


    /// <summary>
    /// MyEnumerator variable
    /// </summary>
    private MyEnumerator<T> _myEnum;


    /// <summary>
    /// Objs Constructor
    /// </summary>
    public Objs()
    {
        _myEnum = new MyEnumerator<T>(tlist);
    }

    /// <summary>
    /// MyEnumerator class
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    class MyEnumerator<T> : IEnumerator<T>
    {
        /// <summary>
        /// tlist 
        /// </summary>
        private T[] tlist;
        
        /// <summary>
        /// position
        /// </summary>
        private int position = -1;

        /// <summary>
        /// Myenumerator constructor
        /// </summary>
        /// <param name="list">list</param>
        public MyEnumerator(T[] list)
        {
            UpdateArray(list);
        }
        /// <summary>
        /// Update array 
        /// </summary>
        /// <param name="list">list</param>
        public void UpdateArray(T[] list) => tlist = list;

        /// <summary>
        /// MoveNext
        /// </summary>
        /// <returns>bool</returns>
        public bool MoveNext()
        {
            position++;
            return position < tlist.Length;
        }

        /// <summary>
        /// Reset
        /// </summary>
        public void Reset()
        {
            position = -1;
        }

        /// <summary>
        /// Current
        /// </summary>
        public T Current
        {
            get
            {
                try
                {
                    return tlist[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException("Estas haciendo cualquiera pastrana");
                }
            }
        }
        /// <summary>
        /// Ienumerator
        /// </summary>
        object IEnumerator.Current => Current;

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {

        }
    }
    /// <summary>
    /// Add method
    /// </summary>
    /// <param name="item">item</param>
    public void Add(T item)
    {
        List<T> copy = new List<T>();
        copy.AddRange(tlist);
        copy.Add(item);

        tlist = copy.ToArray();
        _myEnum.UpdateArray(tlist);
    }

    /// <summary>
    /// public
    /// </summary>
    /// <returns>Enumerator T</returns>
    public IEnumerator<T> GetEnumerator()
    {
        return (IEnumerator<T>)_myEnum;
    }

    /// <summary>
    /// IEnumerator
    /// </summary>
    /// <returns>Ienumerable</returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
