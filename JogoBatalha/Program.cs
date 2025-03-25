using BattleEntities.Actions.Attacks;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(LightAttack.GetDamage());
    Console.WriteLine(MediumAttack.GetDamage());
    Console.WriteLine(HeavyAttack.GetDamage());
}