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
/// Objs class test
/// </summary>
public class Objs<T> : List<T>
{

}