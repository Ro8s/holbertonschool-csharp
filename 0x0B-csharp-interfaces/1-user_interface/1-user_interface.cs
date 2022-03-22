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
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{ 
    /// <summary>
    /// durability int property
    /// </summary>
    public int durability { get; set; }
    /// <summary>
    /// Interact method from IInteractive interface
    /// </summary>
    void IInteractive.Interact()
    {

    }
    
    /// <summary>
    /// Break method from IBreakable interface
    /// </summary>
    void IBreakable.Break()
    {

    }

    /// <summary>
    /// Collect method from ICollectable interface
    /// </summary>
    void ICollectable.Collect()
    {

    }

    /// <summary>
    /// isCollected bool property
    /// </summary>
    public bool isCollected { get; set; }

}