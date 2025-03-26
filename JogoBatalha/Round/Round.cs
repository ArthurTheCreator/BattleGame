using BattleEntities.Actions;
using BattleEntities.Actions.Attacks;
using BattleEntities.Characters;
using BattleEntities.EnumActions;

namespace JogoBatalha.Round;

public static class Round
{
    public static (int, bool) Battle(Player player, int number, Enemy enemy)
    {
        int resultOfAction = 0;
        bool isDefense = false;
        bool wrongAnswer = true;
        while (wrongAnswer)
        {
            switch (number)
            {
                case 1:
                    wrongAnswer = false;
                    resultOfAction = LightAttack.GetAttack();
                    return (resultOfAction, isDefense);
                case 2:
                    wrongAnswer = false;
                    resultOfAction = MediumAttack.GetAttack();
                    return (resultOfAction, isDefense);
                case 3:
                    wrongAnswer = false;
                    resultOfAction = HeavyAttack.GetAttack();
                    return (resultOfAction, isDefense);
                case 4:
                    wrongAnswer = false;
                    isDefense = true;
                    return (resultOfAction, isDefense);
                case 5:
                    wrongAnswer = false;
                    resultOfAction = 20;
                    if(player.ListHealthPotion.Count > 0)
                    return (resultOfAction, isDefense);
                default:
                    Console.WriteLine("Por favor, digite corretamente!\n");
                    throw new Exception();
            }
        }
        return resultOfAction;
    }
}