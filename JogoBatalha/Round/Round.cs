using BattleEntities.Actions;
using BattleEntities.Actions.Attacks;
using BattleEntities.Characters;
using BattleEntities.EnumActions;

namespace JogoBatalha.Round;

public static class Round
{
    public static ReturnAction Battle(Player player, int number, Enemy enemy)
    {
        ReturnAction returnAction = new ReturnAction();
        int resultOfAction;
        bool wrongAnswer = true;
        while (wrongAnswer)
        {
            switch (number)
            {
                case 1:
                    wrongAnswer = false;
                    resultOfAction = LightAttack.GetAttack();
                    returnAction.Attack(resultOfAction, EnumAction.LightAttack);
                    return returnAction;
                case 2:
                    wrongAnswer = false;
                    resultOfAction = MediumAttack.GetAttack();
                    returnAction.Attack(resultOfAction, EnumAction.MediumAttack);
                    return returnAction;
                case 3:
                    wrongAnswer = false;
                    resultOfAction = HeavyAttack.GetAttack();
                    returnAction.Attack(resultOfAction, EnumAction.HeavyAttack);
                    return returnAction;
                case 4:
                    wrongAnswer = false;
                    returnAction.Defense();
                    return returnAction;
                case 5:
                    wrongAnswer = false;
                    resultOfAction = 20;
                    returnAction.Cure();
                    return returnAction;
                default:
                    Console.WriteLine("Por favor, digite corretamente!\n");
                    throw new Exception();
            }
        }
        return returnAction;
    }
}