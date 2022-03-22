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
    void Interact();
}

/// <summary>
/// Ibreakable interface
/// </summary>
public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>
/// ICollectable interface
/// </summary>
public interface ICollectable
{
    bool isCollected { get; set; }
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
    void IInteractive.Interact()
    {

    }

    void IBreakable.Break()
    {

    }
    void ICollectable.Collect()
    {

    }
    /// <summary>
    /// isCollected bool property
    /// </summary>
    public bool isCollected { get; set; }

}