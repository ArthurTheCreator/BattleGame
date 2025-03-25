using BattleEntities.Actions.Attacks;
using BattleEntities.Characters;
using BattleEntities.EnumActions;

namespace JogoBatalha.Round;

public static class Round
{
    public static void Battle(Player player, EnumAction enumAction, Enemy enemy)
    {
        var a = EnemyMoveset.EnemyAction(enemy);
        switch (enumAction)
        {
            case EnumAction.LightAttack:
                Console.WriteLine(LightAttack.GetAttack());
                break;
            case EnumAction.MediumAttack:
                Console.WriteLine(MediumAttack.GetAttack());
                break;
            case EnumAction.HeavyAttack:
                var damage = HeavyAttack.GetAttack();
                Console.WriteLine(damage);
                enemy.Hp = enemy.Hp - damage;
                break;
            case EnumAction.Defense:
                break;
            case EnumAction.HealthPotion:
                break;
            default: break;
        }
    }
}