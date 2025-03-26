namespace BattleEntities.Actions.Attacks;

public static class LightAttack
{
    public static string Name { get; } = "Ataque Leve";
    public static (int, int) PossibleDamageRange { get; } = (5, 10);
    public static int HitPercentage { get; } = 100;

    #region Actions
    public static int GetDamage() => AttackHelper.GetDamage(PossibleDamageRange);

    public static bool HitResult() => AttackHelper.HitResult(HitPercentage);

    public static int GetAttack() => AttackHelper.GetAttack(PossibleDamageRange, HitPercentage);
    #endregion
}