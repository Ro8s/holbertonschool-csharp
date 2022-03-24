using System;
    
/// <summary>
/// CalculateHealth delegate
/// </summary>
/// <param name="num">float number</param>
public delegate void CalculateHealth(float num);

/// <summary>
/// Modifier enum
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Weak modifier
    /// </summary>
    Weak,
    /// <summary>
    /// Base modifier
    /// </summary>
    Base,
    /// <summary>
    /// Strong modifier
    /// </summary>
    Strong
}

/// <summary>
/// CalculateModifier delegate
/// </summary>
/// <param name="baseValue">float baseValue</param>
/// <param name="modifier">Modifier modifier</param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Player class
/// </summary>
public class Player
{
    /// <summary>
    /// name of the player
    /// </summary>
    private string name { get; set; }
    
    /// <summary>
    /// Max hp of the player
    /// </summary>
    private float maxHp { get; set; }

    /// <summary>
    /// current hp of the player
    /// </summary>
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
            ValidateHP(-damage + this.hp);
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
            ValidateHP(this.hp + heal);
            Console.WriteLine($"{this.name} heals {heal} HP!");
        }
    }

    /// <summary>
    /// ValidateHp method
    /// </summary>
    /// <param name="newHp"> new hp</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if (newHp > this.maxHp)
        {
            this.hp = this.maxHp;
        }
        else
        {
            this.hp = newHp;
        }
    }

    /// <summary>
    /// ApplyModifier method
    /// </summary>
    /// <param name="baseValue">float baseValue</param>
    /// <param name="modifier">Modifier modifier</param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return (baseValue / 2);
        }
        else if (modifier == Modifier.Base)
        {
            return (baseValue);
        }
        else
        {
            return (baseValue * 1.5f);
        }
    }
}