namespace BattleEntities.Actions.Attacks;

public static class HeavyAttack 
{
    public static string Name { get; } = "Ataque Pesado";
    public static (int, int) PossibleDamageRange { get; } = (20, 30);
    public static int HitPercentage { get; } = 50;

    #region Actions
    public static int GetDamage() => AttackHelper.GetDamage(PossibleDamageRange);

    public static bool HitResult() => AttackHelper.HitResult(HitPercentage);

    public static int GetAttack() => AttackHelper.GetAttack(PossibleDamageRange, HitPercentage);
    #endregion
}