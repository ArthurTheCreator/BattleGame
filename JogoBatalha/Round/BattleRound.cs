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

            #region PlayerPotiom
            if (battleResultPlayer.IsCure)
            {
                if (player.Hp <= 80 && player.HealthPotionStock.Count > 0)
                {
                    player.Hp += battleResultPlayer.CureValue;
                    player.HealthPotionStock.RemoveAt(player.HealthPotionStock.Count - 1);
                    Console.WriteLine(GetPlayerMessage.GetPlayerSuccessTakePotionMessage);
                }

                else if (player.Hp > 80 && player.HealthPotionStock.Count == 0)
                {
                    Console.WriteLine(GetPlayerMessage.GetPlayerFailureTakePotionStockAndHpMessage);
                    return battleContinues;
                }

                else if (player.Hp > 80)
                {
                    Console.WriteLine(GetPlayerMessage.GetPlayerFailureTakePotionHpMessage);
                    return battleContinues;
                }

                else if (player.HealthPotionStock.Count == 0)
                {
                    Console.WriteLine(GetPlayerMessage.GetPlayerFailureTakePotionStockMessage);
                    return battleContinues;
                }
            }
            #endregion

            #region PlayerAttack
            if (battleResultPlayer.IsAttack)
            {
                var damage = battleResultPlayer.AttackDamage;
                if (damage > 0)
                {

                    if (battleResultEnemy.IsDefense)
                    {
                        damage = damage / 2;
                        Console.WriteLine(GetEnemyMessage.GetEnemyUsingDefense);

                        string defenseMessage = battleResultEnemy.AttackType == EnumAction.LightAttack ? GetPlayerMessage.GetPlayerEnemyDefenseLightAttackMessage(damage) : battleResultEnemy.AttackType == EnumAction.MediumAttack ? GetPlayerMessage.GetPlayerEnemyDefenseMediumAttackMessage(damage) : GetPlayerMessage.GetPlayerEnemyDefenseHeavyAttackMessage(damage);
                        Console.WriteLine(defenseMessage);

                    }

                    else
                    {
                        if (battleResultPlayer.AttackType == EnumAction.HeavyAttack)
                            Console.WriteLine(GetPlayerMessage.GetPlayerSuccessHeavyAttackMessage(damage));

                        else if (battleResultPlayer.AttackType == EnumAction.MediumAttack)
                            Console.WriteLine(GetPlayerMessage.GetPlayerSuccessMediumAttackMessage(damage));

                        else if (battleResultPlayer.AttackType == EnumAction.LightAttack)
                            Console.WriteLine(GetPlayerMessage.GetPlayerSuccessLightAttackMessage(damage));
                    }

                    enemy.Hp -= damage;
                }

                else if (battleResultEnemy.IsDefense)
                    Console.WriteLine(GetPlayerMessage.GetPlayerMissedButEnemyDefendedMessages);

                else
                {
                    string errorMensage = battleResultPlayer.AttackType == EnumAction.LightAttack ? GetPlayerMessage.GetPlayerFailLightAttackMessage : battleResultPlayer.AttackType == EnumAction.MediumAttack ? GetPlayerMessage.GetPlayerFailMediumAttackMessage : GetPlayerMessage.GetPlayerFailHeavyAttackMessage;
                    Console.WriteLine(errorMensage);
                }

                if (enemy.Hp <= 0)
                {
                    Console.WriteLine(GetPlayerMessage.GetPlayerVictoryMessages);
                    Console.WriteLine(GetPlayerMessage.GetPlayerVictoryTitleMessages);
                    battleContinues = false;
                }
            }
            #endregion

            #region EnemyAttack
            if (battleResultEnemy.IsAttack)
            {
                var damage = battleResultEnemy.AttackDamage;

                if (damage > 0)
                {
                    string attackMessage = battleResultEnemy.AttackType == EnumAction.HeavyAttack ? GetEnemyMessage.GetEnemySuccessHeavyAttackMessages(damage) : battleResultEnemy.AttackType == EnumAction.MediumAttack ? GetEnemyMessage.GetEnemySuccessMediumAttackMessages(damage) : GetEnemyMessage.GetEnemySuccessLightAttackMessages(damage);

                    if (battleResultPlayer.IsDefense)
                    {
                        damage = damage / 2;
                        Console.WriteLine(attackMessage);
                        Console.WriteLine(GetPlayerMessage.GetPlayerSuccessDefenseMessage(damage));
                    }

                    else
                    {
                        Console.WriteLine(attackMessage);
                    }

                    player.Hp -= damage;
                }

                else if (battleResultPlayer.IsDefense)
                    Console.WriteLine(GetEnemyMessage.GetEnemyMissedButPlayerDefendedMessages(player.Name));

                else
                    Console.WriteLine(GetEnemyMessage.GetEnemyMissedMessages);

                if (player.Hp <= 0)
                {
                    Console.WriteLine(GetPlayerMessage.GetPlayerDefeatMessages);
                    Console.WriteLine(GetPlayerMessage.GetPlayerDefeatTitleMessages);
                    battleContinues = false;
                }
            }
            #endregion

            #region Defense
            if (battleResultEnemy.IsDefense && battleResultPlayer.IsDefense)
                Console.WriteLine(GetEnemyMessage.GetBothUsingDefense);
            else if (battleResultEnemy.IsDefense && battleResultPlayer.IsCure)
                Console.WriteLine(GetEnemyMessage.EnemyUsedDefenseUselessly);
            else if (battleResultPlayer.IsDefense && battleResultEnemy.IsCure)
                Console.WriteLine(GetPlayerMessage.GetPlayerUselessDefense);
            #endregion

            #region EnemyPotion
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
            #endregion
        }
    }
}