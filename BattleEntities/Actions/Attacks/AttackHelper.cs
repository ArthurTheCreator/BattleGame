namespace BattleEntities.Actions.Attacks;

public static class AttackHelper
{
    private static readonly Random random = new Random();

    public static int GetDamage((int, int) DamageRange)
    {
        return random.Next(DamageRange.Item1, DamageRange.Item2 + 1);
    }

    public static bool HitResult(int HitPossibilite)
    {
        return random.Next(11) <= HitPossibilite / 10;
    }

    public static int GetAttack((int, int) DamageRange, int HitPossibilite)
    {
        return HitResult(HitPossibilite) == true ? GetDamage(DamageRange) : 0;
    }
}