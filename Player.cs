using System;

public class Player : GameEntity, IDamageable, IMovable
{
    public Player(string name) : base(name, 100) { }
    public override string EntityType => "Pemain";
    public override void Update()
    {
        Console.WriteLine($"{Name} menunggu input pemain.");
    }

    public void Move(float x, float y)
    => Console.WriteLine($"{Name} bergerak ke ({x}, {y}).");
}