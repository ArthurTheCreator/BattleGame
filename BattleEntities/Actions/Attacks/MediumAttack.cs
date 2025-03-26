namespace BattleEntities.Actions.Attacks;

public static class MediumAttack
{
    public static string Name { get; } = "Ataque Médio";
    public static (int, int) PossibleDamageRange { get; } = (10, 20);
    public static int HitPercentage { get; } = 80;

    #region Actions
    public static int GetDamage() => AttackHelper.GetDamage(PossibleDamageRange);

    public static bool HitResult() => AttackHelper.HitResult(HitPercentage);

    public static int GetAttack() => AttackHelper.GetAttack(PossibleDamageRange, HitPercentage);
    #endregion
}