using BattleEntities.Actions;
using BattleEntities.Actions.Attacks;
using BattleEntities.Characters;
using BattleEntities.EnumActions;

namespace JogoBatalha.Round;

public static class EnemyMoveset
{
    private static Random random = new Random();

    #region ChoiceOfActionBasedOnCurrentLife
    public static ReturnAction EnemyAction(Enemy enemy)
    {
        var returnAction = new ReturnAction();
        switch (enemy)
        {
            case Enemy e when e.Hp > 80:
                returnAction = Moveset1();
                break;
            case Enemy e when e.Hp <= 80 && e.Hp > 40 && e.HealthPotionStock.Count() > 0:
                returnAction = Moveset2();
                break;
            case Enemy e when e.Hp <= 80 && e.Hp > 40 && e.HealthPotionStock.Count() == 0:
                returnAction = Moveset1();
                break;
            case Enemy e when e.Hp <= 40 && e.Hp > 10 && e.HealthPotionStock.Count() > 0:
                returnAction = Moveset3();
                break;
            case Enemy e when e.Hp <= 40 && e.Hp > 10 && e.HealthPotionStock.Count() == 0:
                returnAction = Moveset4();
                break;
            default:
                returnAction.Attack(HeavyAttack.GetAttack(), EnumAction.HeavyAttack);
                break;
        }
        return returnAction;
    }
    #endregion

    #region Movesets
    #region RandomAttack
    public static EnumAction ChooseAttack()
    {
        return (EnumAction)random.Next(3);
    }
    #endregion

    #region Moveset1
    public static ReturnAction Moveset1()
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
    #endregion

    #region Moveset2
    public static ReturnAction Moveset2()
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
    #endregion

    #region Moveset3
    public static ReturnAction Moveset3()
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
    #endregion

    #region Moveset4
    public static ReturnAction Moveset4()
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
    #endregion

    #endregion
}