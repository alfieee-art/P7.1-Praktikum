using System;

public class Npc : GameEntity
{
    public Npc(string name) : base(name, 50) { }
    public override string EntityType => "NPC";
    public override void Update()
    {
        Console.WriteLine($"{Name} berdiri menunggu dialog.");
    }
}