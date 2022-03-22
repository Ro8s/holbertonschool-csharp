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
/// TestObject class that inherts Base and all interfaces crated
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