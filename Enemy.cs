using System;

public class Enemy : GameEntity, IDamageable
{
    public Enemy(string name) : base(name, 80) { }
    public override string EntityType => "Musuh";
    public override void Update()
    {
        Console.WriteLine($"{Name} mengejar pemain.");
    }
}