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
/// <returns>float</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// CurrentHPargs class
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// CurrentHp private property
    /// </summary>
    public float currentHp { get; private set; }

    /// <summary>
    /// CurrentHpargs constructor
    /// </summary>
    /// <param name="newHp">newHp</param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}

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
    /// Status of player
    /// </summary>
    private string status { get; set; }

    /// <summary>
    /// EventHandler HpCheck
    /// </summary>
    public EventHandler<CurrentHPArgs> HPCheck;


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
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;

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
            ValidateHP(-damage + this.hp);
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
            ValidateHP(this.hp + heal);
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
        OnCheckStatus(new CurrentHPArgs(hp));
    }

    /// <summary>
    /// ApplyModifier method
    /// </summary>
    /// <param name="baseValue">float baseValue</param>
    /// <param name="modifier">Modifier modifier</param>
    /// <returns>float number</returns>
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

    /// <summary>
    /// Checkstatus method
    /// </summary>
    /// <param name="sender">sender</param>
    /// <param name="e">e</param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
        {
            this.status = $"{this.name} is in perfect health!";
            Console.WriteLine($"{this.name} is in perfect health!");
        }
        else if (e.currentHp >= (this.maxHp / 2) && e.currentHp < this.maxHp)
        {
            this.status = $"{this.name} is doing well!";
            Console.WriteLine($"{this.name} is doing well!");
        }
        else if (e.currentHp >= (this.maxHp / 4) && e.currentHp < (this.maxHp / 2))
        {
            this.status = $"{this.name} isn't doing too great...";
            Console.WriteLine($"{this.name} isn't doing too great...");
        }
        else if (e.currentHp > 0 && e.currentHp < (this.maxHp / 4))
        {
            this.status = $"{this.name} needs help!";
            Console.WriteLine($"{this.name} needs help!");
        }
        else
        {
            this.status = $"{this.name} is knocked out!";
            Console.WriteLine($"{this.name} is knocked out!");
        }
    }

    /// <summary>
    /// HpvalueWarning
    /// </summary>
    /// <param name="sender">sender</param>
    /// <param name="e">e</param>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {

            Console.WriteLine("Health has reached zero!");

        }
        else if (e.currentHp >= (this.maxHp / 4) && e.currentHp < (this.maxHp / 2))
        {
            Console.WriteLine("Health is low!");
        }

    }

    /// <summary>
    /// Oncheckstatus
    /// </summary>
    /// <param name="e">e</param>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < (this.maxHp / 4))
        {
            HPValueWarning(e.currentHp, new CurrentHPArgs(e.currentHp));
        }
        HPCheck(this, e);
    }
}