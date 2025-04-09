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
                if (player.Hp <= 80 && player.HealthPotionStock.Count > 0)
                {
                    player.Hp += battleResultPlayer.CureValue;
                    player.HealthPotionStock.RemoveAt(player.HealthPotionStock.Count - 1);
                    Console.WriteLine(GetPlayerMessage.GetPlayerSuccessTakePotionMessage);
                }
                else if (player.Hp > 80 && player.HealthPotionStock.Count == 0)
                    Console.WriteLine(GetPlayerMessage.GetPlayerFailureTakePotionStockAndHpMessage);

                else if (player.Hp > 80)
                    Console.WriteLine(GetPlayerMessage.GetPlayerFailureTakePotionHpMessage);

                else if (player.HealthPotionStock.Count == 0)
                    Console.WriteLine(GetPlayerMessage.GetPlayerFailureTakePotionStockMessage);
            }
            else if (battleResultPlayer.IsAttack && battleResultEnemy.IsDefense)
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
            else if (battleResultEnemy.IsAttack && battleResultPlayer.IsDefense)
            {
                var damage = battleResultEnemy.AttackDamage / 2;
                if (damage > 0)
                {
                    Console.WriteLine(GetPlayerMessage.GetPlayerSuccessDefenseMessage(damage));

                    player.Hp -= damage;
                }
                else
                    Console.WriteLine(GetEnemyMessage.GetEnemyMissedButPlayerDefendedMessages(player.Name));

                if (player.Hp <= 0)
                {
                    Console.WriteLine(GetPlayerMessage.GetPlayerDefeatMessages);
                    Console.WriteLine(GetPlayerMessage.GetPlayerDefeatTitleMessages);
                    battleContinues = false;
                }
            }
            else if (battleResultPlayer.IsAttack && !battleResultEnemy.IsDefense)
            {
                var damage = battleResultPlayer.AttackDamage;
                if (damage > 0)
                {
                    if (battleResultPlayer.AttackType == EnumAction.HeavyAttack)
                        Console.WriteLine(GetPlayerMessage.GetPlayerSuccessHeavyAttackMessage(damage));

                    else if (battleResultPlayer.AttackType == EnumAction.MediumAttack)
                        Console.WriteLine(GetPlayerMessage.GetPlayerSuccessMediumAttackMessage(damage));

                    else if (battleResultPlayer.AttackType == EnumAction.LightAttack)
                        Console.WriteLine(GetPlayerMessage.GetPlayerSuccessLightAttackMessage(damage));

                    enemy.Hp -= damage;
                }
                else
                    Console.WriteLine(GetPlayerMessage.GetPlayerMissedAttackMessages);

                if (enemy.Hp <= 0)
                {
                    Console.WriteLine(GetPlayerMessage.GetPlayerVictoryMessages);
                    Console.WriteLine(GetPlayerMessage.GetPlayerVictoryTitleMessages);
                    battleContinues = false;
                }
            }
            else if (battleResultEnemy.IsAttack && !battleResultPlayer.IsDefense)
            {
                var damage = battleResultPlayer.AttackDamage;
                if (damage > 0)
                {
                    if (battleResultEnemy.AttackType == EnumAction.HeavyAttack)
                        Console.WriteLine(GetEnemyMessage.GetEnemySuccessHeavyAttackMessages(damage));

                    else if (battleResultEnemy.AttackType == EnumAction.MediumAttack)
                        Console.WriteLine(GetEnemyMessage.GetEnemySuccessMediumAttackMessages(damage));

                    else if (battleResultEnemy.AttackType == EnumAction.LightAttack)
                        Console.WriteLine(GetEnemyMessage.GetEnemySuccessLightAttackMessages(damage));

                    player.Hp -= damage;
                }
                else
                    Console.WriteLine(GetEnemyMessage.GetEnemyMissedMessages);

                if (player.Hp <= 0)
                {
                    Console.WriteLine(GetPlayerMessage.GetPlayerDefeatMessages);
                    Console.WriteLine(GetPlayerMessage.GetPlayerDefeatTitleMessages);
                    battleContinues = false;
                }
            }
            else if (battleResultEnemy.IsDefense && battleResultPlayer.IsDefense)
            {
                Console.WriteLine(GetEnemyMessage.GetBothUsingDefense);
            }
            if (battleResultEnemy.IsCure)
            {
                if (enemy.HealthPotionStock.Count > 0)
                {
                    enemy.Hp += battleResultEnemy.CureValue;
                    enemy.HealthPotionStock.RemoveAt(enemy.HealthPotionStock.Count - 1);
                    Console.WriteLine(GetEnemyMessage.GetEnemySuccesTakePotionMessage);
                }

                else if (enemy.HealthPotionStock.Count == 0)
                    Console.WriteLine(GetEnemyMessage.GetEnemyFailureTakePotionStockMessage);
            }
            return battleContinues;
        }
    }
}