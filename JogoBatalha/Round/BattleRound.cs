using BattleEntities.Actions;
using BattleEntities.Characters;
using BattleEntities.EnumActions;
using MessageLibrary.Message.GetMessage;

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
                    Console.WriteLine(GetPlayerMessage.GetPlayerFailureTakePotionHpMessage);
            }
            if (battleResultPlayer.IsAttack && battleResultEnemy.IsDefense)
            {
                var damage = battleResultPlayer.AttackDamage / 2;
                if (damage > 0)
                {
                    Console.WriteLine(GetEnemyMessage.GetEnemyUsingDefense);

                    if (battleResultPlayer.AttackType == EnumAction.LightAttack)
                        Console.WriteLine(GetPlayerMessage.GetPlayerEnemyDefenseLightAttackMessage(damage));

                    else if (battleResultPlayer.AttackType == EnumAction.MediumAttack)
                        Console.WriteLine(GetPlayerMessage.GetPlayerEnemyDefenseMediumAttackMessage(damage));

                    else if (battleResultPlayer.AttackType == EnumAction.HeavyAttack)
                        Console.WriteLine(GetPlayerMessage.GetPlayerEnemyDefenseHeavyAttackMessage(damage));

                    enemy.Hp -= damage;
                }
                else
                    Console.WriteLine(GetPlayerMessage.GetPlayerMissedButEnemyDefendedMessages);

                if (enemy.Hp <= 0)
                {
                    Console.WriteLine(GetPlayerMessage.GetPlayerVictoryMessages);
                    Console.WriteLine(GetPlayerMessage.GetPlayerVictoryTitleMessages);
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
                    Console.WriteLine(GetPlayerMessage.GetPlayerVictoryMessages);
                    Console.WriteLine(GetPlayerMessage.GetPlayerVictoryTitleMessages);
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