namespace BattleEntities.Actions.Attacks;

public static class HeavyAttack
{
    public static string Name { get; } = "Ataque Pesado";
    public static (int, int) PossibleDamageRange { get; } = (20, 30);
    public static int HitPercentage { get; } = 50;

    #region Random
    private static Random random = new Random();
    #endregion

    public static int GetDamage()
    {
        return random.Next(PossibleDamageRange.Item1, PossibleDamageRange.Item2 + 1);
    }

    public static bool HitResult()
    {
        return random.Next(1,11) <= (HitPercentage / 10) ? true : false;
    }

    public static int GetAttack()
    {
        return HitResult() == true ? GetDamage() : 0;
    }
}
