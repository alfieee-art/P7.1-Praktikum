using System;

public abstract class GameEntity
{
    public string Name { get; protected set; }
    public int Health { get; protected set; }
    // constructor pada abstract class
    protected GameEntity(string name, int health)
    {
        Name = name;
        Health = health;
    }

    // abstract method: WAJIB di-override tiap turunan
    public abstract void Update();

    // abstract property: wajib disediakan turunan
    public abstract string EntityType { get; }
    
    // method konkret: langsung siap pakai
    public void TakeDamage(int amount)
    {
        Health -= amount;
        Console.WriteLine($"{Name} kini {Health} HP.");
    }
}
