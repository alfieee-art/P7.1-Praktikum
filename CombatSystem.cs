using System;

public class CombatSystem
{
    // Bergantung pada KONTRAK, bukan class konkret
    public void ApplyAreaDamage(List<IDamageable> targets, int dmg)
    {
        Console.WriteLine($"Ledakan area! {dmg} damage.");
        foreach (IDamageable t in targets)
            t.TakeDamage(dmg);
    }
}