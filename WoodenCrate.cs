using System;

public class WoodenCrate : IDamageable
{
    public int Health { get; private set; } = 30;
    public void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health <= 0)
            Console.WriteLine("Peti hancur berkeping-keping!");
        else
            Console.WriteLine($"Peti retak, sisa {Health} daya tahan.");
    }
}