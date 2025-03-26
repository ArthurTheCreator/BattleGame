using BattleEntities.Actions;
using BattleEntities.Characters;
using BattleEntities.EnumActions;

namespace JogoBatalha.Round
{
    public class BattleRound
    {
        public static bool RoundFight(Player player, Enemy enemy, ReturnAction battleResultPlayer, ReturnAction battleResultEnemy)
        {
            bool battleContinues = true;

            if (battleResultPlayer.IsCure)
            {
                if (player.Hp <= 80)
                {
                    player.Hp += battleResultPlayer.CureValue;
                    Console.WriteLine("");
                }
                else
                    Console.WriteLine("Você não pode se curar ainda, sua vida precisa estar abaixo de 80!");
            }
            if (battleResultPlayer.IsAttack && battleResultEnemy.IsDefense)
            {
                var damage = battleResultPlayer.AttackDamage / 2;
                if (damage > 0)
                {
                    Console.WriteLine("O inimigo utilizou defesa!");
                    Console.WriteLine($"{player.Name} causou {damage} de dano!");
                    enemy.Hp -= damage;
                }
                else
                    Console.WriteLine("Você errou o ataque, porém seu inimigo defendeu, que sorte!");

                if (enemy.Hp <= 0)
                {
                    Console.WriteLine("Você derrotou o seu inimigo!");
                    Console.WriteLine("Vitória!");
                    battleContinues = false;
                }
            }
            if (battleResultEnemy.IsAttack && battleResultPlayer.IsDefense)
            {
                var damage = battleResultEnemy.AttackDamage / 2;
                if (damage > 0)
                {
                    Console.WriteLine($"{player.Name} utilizou defesa!");
                    Console.WriteLine($"O inimigo causou {damage} de dano!");
                    player.Hp -= damage;
                }
                else
                    Console.WriteLine($"O inimigo errou o ataque, porém {player.Name} defendeu, que azar...");

                if (player.Hp <= 0)
                {
                    Console.WriteLine("Seu inimigo te derrotou!");
                    Console.WriteLine("Derrota...");
                    battleContinues = false;
                }
            }
            if (battleResultPlayer.IsAttack && !battleResultEnemy.IsDefense)
            {
                var damage = battleResultPlayer.AttackDamage;
                if (damage > 0)
                {
                    if (battleResultPlayer.AttackType == EnumAction.HeavyAttack)
                        Console.WriteLine($"{player.Name} causou {damage} de dano no inimigo, um ataque devastador!");
                    else
                        Console.WriteLine($"{player.Name} causou {damage} de dano no inimigo!");

                    enemy.Hp -= damage;
                }
                else
                    Console.WriteLine("Você errou o ataque, que pena...");

                if (enemy.Hp <= 0)
                {
                    Console.WriteLine("Você derrotou o seu inimigo!");
                    Console.WriteLine("Vitória!");
                    battleContinues = false;
                }
            }
            if (battleResultEnemy.IsAttack && !battleResultPlayer.IsDefense)
            {
                var damage = battleResultPlayer.AttackDamage;
                if (damage > 0)
                {
                    if (battleResultPlayer.AttackType == EnumAction.HeavyAttack)
                        Console.WriteLine($"O inimigo causou {damage} de dano no(a) {player.Name}, um ataque devastador!");
                    else
                        Console.WriteLine($"O inimigo causou {damage} de dano no(a) {player.Name}!");

                    player.Hp -= damage;
                }
                else
                    Console.WriteLine("O inimigo errou o ataque, que sorte...");

                if (player.Hp <= 0)
                {
                    Console.WriteLine("Seu inimigo te derrotou!");
                    Console.WriteLine("Derrota...");
                    battleContinues = false;
                }
            }
            return battleContinues;
        }
    }
}