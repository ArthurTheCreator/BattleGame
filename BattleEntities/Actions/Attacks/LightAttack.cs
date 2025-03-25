namespace BattleEntities.Actions.Attacks;

public static class LightAttack
{
    public static string Name { get; } = "Ataque Leve";
    public static (int, int) PossibleDamageRange { get; } = (5, 10);
    public static int HitPercentage { get; } = 100;

    #region Random
    private static Random random = new Random();
    #endregion

    public static int GetDamage()
    {
        return random.Next(PossibleDamageRange.Item1, PossibleDamageRange.Item2 + 1);
    }

    public static bool HitResult()
    {
        return random.Next(1, 101) <= (HitPercentage) ? true : false;
    }

    public static int GetAttack()
    {
        return HitResult() == true ? GetDamage() : 0;
    }
}