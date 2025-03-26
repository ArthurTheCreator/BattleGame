using BattleEntities.Actions;
using BattleEntities.Actions.Attacks;
using BattleEntities.Characters;
using BattleEntities.EnumActions;

namespace JogoBatalha.Round;

public static class EnemyMoveset
{
    private static Random random = new Random();

    public static ReturnAction EnemyAction(Enemy enemy)
    {
        var returnAction = new ReturnAction();
        switch (enemy)
        {
            case Enemy e when e.Hp > 80:
                returnAction = ChooseAction1();
                break;
            case Enemy e when e.Hp <= 80 && e.Hp > 40 && e.HealthPotionStock.Count() > 0:
                returnAction = ChooseAction2();
                break;
            case Enemy e when e.Hp <= 80 && e.Hp > 40 && e.HealthPotionStock.Count() == 0:
                returnAction = ChooseAction1();
                break;
            case Enemy e when e.Hp <= 40 && e.Hp > 10 && e.HealthPotionStock.Count() > 0:
                returnAction = ChooseAction3();
                break;
            case Enemy e when e.Hp <= 40 && e.Hp > 10 && e.HealthPotionStock.Count() == 0:
                returnAction = ChooseAction4();
                break;
            default:
                returnAction.Attack(HeavyAttack.GetAttack(), EnumAction.HeavyAttack);
                break;
        }
        return returnAction;
    }

    public static EnumAction ChooseAttack()
    {
        return (EnumAction)random.Next(3);
    }
    public static ReturnAction ChooseAction1()
    {
        var returnAction = new ReturnAction();
        switch (random.Next(2))
        {
            case 0:
                switch (ChooseAttack())
                {
                    case EnumAction.LightAttack:
                        var attack = LightAttack.GetAttack();
                        Console.WriteLine(attack);
                        returnAction.Attack(attack, EnumAction.LightAttack);
                        break;
                    case EnumAction.MediumAttack:
                        var attack1 = MediumAttack.GetAttack();
                        Console.WriteLine(attack1);
                        returnAction.Attack(attack1, EnumAction.MediumAttack);
                        break;
                    default:
                        var attack2 = HeavyAttack.GetAttack();
                        Console.WriteLine(attack2);
                        returnAction.Attack(attack2, EnumAction.HeavyAttack);
                        break;
                }
                break;
            default:
                returnAction.Defense();
                break;
        }
        return returnAction;
    }

    public static ReturnAction ChooseAction2()
    {
        var returnAction = new ReturnAction();
        switch (random.Next(1, 11))
        {
            case <= 4:
                switch (ChooseAttack())
                {
                    case EnumAction.LightAttack:
                        var attack = LightAttack.GetAttack();
                        Console.WriteLine(attack);
                        returnAction.Attack(attack, EnumAction.LightAttack);
                        break;
                    case EnumAction.MediumAttack:
                        var attack1 = MediumAttack.GetAttack();
                        Console.WriteLine(attack1);
                        returnAction.Attack(attack1, EnumAction.MediumAttack);
                        break;
                    default:
                        var attack2 = HeavyAttack.GetAttack();
                        Console.WriteLine(attack2);
                        returnAction.Attack(attack2, EnumAction.HeavyAttack);
                        break;
                }
                break;
            case <= 8:
                returnAction.Defense();
                break;
            default:
                returnAction.Cure();
                break;
        }
        return returnAction;
    }

    public static ReturnAction ChooseAction3()
    {
        var returnAction = new ReturnAction();
        switch (random.Next(1, 11))
        {
            case <= 2:
                switch (ChooseAttack())
                {
                    case EnumAction.LightAttack:
                        var attack = LightAttack.GetAttack();
                        Console.WriteLine(attack);
                        returnAction.Attack(attack, EnumAction.LightAttack);
                        break;
                    case EnumAction.MediumAttack:
                        var attack1 = MediumAttack.GetAttack();
                        Console.WriteLine(attack1);
                        returnAction.Attack(attack1, EnumAction.MediumAttack);
                        break;
                    default:
                        var attack2 = HeavyAttack.GetAttack();
                        Console.WriteLine(attack2);
                        returnAction.Attack(attack2, EnumAction.HeavyAttack);
                        break;
                }
                break;
            case <= 4:
                returnAction.Defense();
                break;
            default:
                returnAction.Cure();
                break;
        }
        return returnAction;
    }

    public static ReturnAction ChooseAction4()
    {
        var returnAction = new ReturnAction();
        switch (random.Next(1, 11))
        {
            case <= 4:
                switch (ChooseAttack())
                {
                    case EnumAction.LightAttack:
                        var attack = LightAttack.GetAttack();
                        Console.WriteLine(attack);
                        returnAction.Attack(attack, EnumAction.LightAttack);
                        break;
                    case EnumAction.MediumAttack:
                        var attack1 = MediumAttack.GetAttack();
                        Console.WriteLine(attack1);
                        returnAction.Attack(attack1, EnumAction.MediumAttack);
                        break;
                    default:
                        var attack2 = HeavyAttack.GetAttack();
                        Console.WriteLine(attack2);
                        returnAction.Attack(attack2, EnumAction.HeavyAttack);
                        break;
                }
                break;
            default:
                returnAction.Defense();
                break;
        }
        return returnAction;
    }
}