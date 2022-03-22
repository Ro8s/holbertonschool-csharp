using System;

/// <summary>
/// Abstarct Base class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// name string property
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Override ToString Method toreturn an specific output
    /// </summary>
    /// <returns>[name] is a [type of class]</returns>
    public override string ToString()
    {
        return this.name + " is a " + this.GetType(); 
    }
}

/// <summary>
/// IInteractive interface
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Function Interact
    /// </summary>
    void Interact();
}

/// <summary>
/// Ibreakable interface
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// durability int property
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Break function
    /// </summary>
    void Break();
}

/// <summary>
/// ICollectable interface
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// isCollected bool property
    /// </summary>
    bool isCollected { get; set; }
    
    /// <summary>
    /// Collect function
    /// </summary>
    void Collect();
}

/// <summary>
/// Door class that inherts Base and IInteractive
/// </summary>
class Door : Base, IInteractive
{

    /// <summary>
    /// Interact method from IInteractive interface
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }

    /// <summary>
    /// Constructor for Door class
    /// </summary>
    /// <param name="n">name to the door</param>
    public Door(string n = "Door") => name = n;

}


/// <summary>
/// Decoration class that inherts Base, IInteractive and IBreakable
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// durability int property
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// isQuestItem bool
    /// </summary>
    public bool isQuestItem;

    /// <summary>
    /// Decoration constructor
    /// </summary>
    /// <param name="n">argument name</param>
    /// <param name="d">argument durabilirty</param>
    /// <param name="isq">argument isQuestItem</param>
    public Decoration(string n = "Decoration", int d = 1, bool isq = false)
    {
        if (d <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        name = n;
        durability = d;
        isQuestItem = isq;
    }

    /// <summary>
    /// Interact void
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {this.name} has been broken.");
        }
        else if (isQuestItem == true)
        {
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        }
        else if (isQuestItem == false)
        {
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Break void
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
            Console.WriteLine($"You smash the {this.name} What a mess.");
        }
        if (durability < 0)
        {
            Console.WriteLine($"The {this.name} is already broken.");
        }
    }
}