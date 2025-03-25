﻿namespace BattleEntities.Actions.Attacks;

public static class MediumAttack
{
    public static string Name { get; } = "Ataque Médio";
    public static (int, int) PossibleDamageRange { get; } = (10, 20);
    public static int HitPercentage { get; } = 80;

    #region Random
    private static Random random = new Random();
    #endregion

    public static int GetDamage()
    {
        return random.Next(PossibleDamageRange.Item1, PossibleDamageRange.Item2 + 1);
    }
}
