using System;

/// <summary>
/// Player class
/// </summary>
public class Player
{
	private string name {get; set;}
	private float maxHp { get; set;}
	private float hp { get; set; }

	/// <summary>
    /// Player constructor
    /// </summary>
    /// <param name="name">name</param>
    /// <param name="maxHp">maxhp</param>
	public Player(string name = "Player", float maxHp = 100f)
    {
		this.name = name;
		if (maxHp <= 0)
        {
			this.maxHp = 100f;
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
			this.maxHp = maxHp;
        }
		this.hp = this.maxHp;
    }
	/// <summary>
    /// PrintHealth method
    /// </summary>
	public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}
