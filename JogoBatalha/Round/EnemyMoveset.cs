using BattleEntities.Actions.Attacks;
using BattleEntities.Characters;
using BattleEntities.EnumActions;
using System.Runtime.InteropServices;

namespace JogoBatalha.Round;

public static class EnemyMoveset
{
    private static Random random = new Random();

    public static (Enemy, int) EnemyAction(Enemy enemy)
    {
        switch (enemy)
        {
            case Enemy e when e.Hp > 80:
                break;
            case Enemy e when e.Hp <= 80 && e.HealthPotionStock.Count() > 0:
                break;

        } 
    }

    public static EnumAction ChooseAttack()
    {
        return (EnumAction)random.Next(3);
    }
    public static EnumAction ChooseAction1()
    {
        switch (random.Next(1))
        {
            case 0:
                switch (ChooseAttack())
                {
                    case EnumAction.LightAttack:
                        var attack = LightAttack.GetAttack();
                        Console.WriteLine(attack);

                }

                
                    ;
        }
    }
}
