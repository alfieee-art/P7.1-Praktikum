var combat = new CombatSystem();
var targets = new List<IDamageable>

{
new Player("Aldric"),
new Enemy("Goblin"),
new WoodenCrate()
};

combat.ApplyAreaDamage(targets, 25);