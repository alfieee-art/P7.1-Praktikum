using System;

public class ExplosiveBarrel : IDamageable
{
    public int Health { get; private set; } = 40;
    private bool _exploded = false;

    public void TakeDamage(int amount)
    {
        if (_exploded)
        {
            Console.WriteLine("Barel sudah meledak, tidak ada yang tersisa.");
            return;
        }

        Health -= amount;
        Console.WriteLine($"ExplosiveBarrel menerima {amount} damage. Sisa Health: {Math.Max(Health, 0)}");

        if (Health <= 0)
        {
            _exploded = true;
            Console.WriteLine("BOOM! ExplosiveBarrel meledak!");
        }
    }
}