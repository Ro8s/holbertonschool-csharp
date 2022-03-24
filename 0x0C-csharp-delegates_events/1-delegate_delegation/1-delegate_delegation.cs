using System;


/// <summary>
/// CalculateHealth delegate
/// </summary>
/// <param name="num">num</param>
public delegate void CalculateHealth(float num);

/// <summary>
/// Player class
/// </summary>
public class Player
{

    private string name { get; set; }
    private float maxHp { get; set; }
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


    /// <summary>
    /// TakeDamage Method
    /// </summary>
    /// <param name="damage">damage</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine($"{this.name} takes 0 damage!");
        }
        else
        {

            Console.WriteLine($"{this.name} takes {damage} damage!");
        }
    }

    /// <summary>
    /// Method HealDamage
    /// </summary>
    /// <param name="heal">heal</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine($"{this.name} heals 0 HP!");
        }
        else
        {
            Console.WriteLine($"{this.name} heals {heal} HP!");
        }
    }

}

