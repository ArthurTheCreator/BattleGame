using BattleEntities.Actions.Attacks;
using BattleEntities.Characters;
using BattleEntities.EnumActions;

namespace JogoBatalha.Round;

public static class Round
{
    public static void Battle(Player player, int number, Enemy enemy)
    {
        bool wrongAnswer = true;
        while (wrongAnswer)
        {
            switch (number)
            {
                case 1:
                    wrongAnswer = false;
                    Console.WriteLine(LightAttack.GetAttack());
                    break;
                case 2:
                    wrongAnswer = false;
                    Console.WriteLine(MediumAttack.GetAttack());
                    break;
                case 3:
                    wrongAnswer = false;
                    var damage = HeavyAttack.GetAttack();
                    Console.WriteLine(damage);
                    enemy.Hp = enemy.Hp - damage;
                    break;
                case 4:
                    wrongAnswer = false;
                    break;
                case 5:
                    wrongAnswer = false;
                    break;
                default:
                    Console.WriteLine("Por favor, digite corretamente!\n");
                    throw new Exception();
            }
        }
    }
}