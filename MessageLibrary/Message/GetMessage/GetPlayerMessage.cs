using MessageLibrary.Enum;
using MessageLibrary.Message.Player;

namespace MessageLibrary.Message.GetMessage;

public static class GetPlayerMessage
{
    #region Random
    private static Random random = new Random();
    #endregion

    public static EnumLanguage EnumLanguage { get; set; }

    public static string? PlayerName { get; set; }

    #region Potion

    #region Success
    public static string GetPlayerSuccessTakePotionMessage
    {
        get
        {
            var messages = PlayerMessage.ListSuccessTakePotionMessage[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }
    #endregion

    #region FailureStock
    public static string GetPlayerFailureTakePotionStockMessage
    {
        get
        {
            var messages = PlayerMessage.ListFailureTakePotionStockMessage[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }
    #endregion

    #region FailureHP
    public static string GetPlayerFailureTakePotionHpMessage
    {
        get
        {
            var messages = PlayerMessage.ListFailureTakePotionHPMessage[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }
    #endregion

    #region FailureStockAndHP
    public static string GetPlayerFailureTakePotionStockAndHpMessage
    {
        get
        {
            var messages = PlayerMessage.ListFailureTakePotionStockAndHPMessage[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }
    #endregion

    #endregion

    #region Attack

    #region Light

    #region Success
    public static string GetPlayerSuccessLightAttackMessage
    {
        get
        {
            var messages = PlayerMessage.ListSuccessLightAttackMessage[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }
    #endregion

    #region Failed
    public static string GetPlayerFailLightAttackMessage
    {
        get
        {
            var messages = PlayerMessage.ListFailLightAttackMessage[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }
    #endregion

    #region EnemyDefense
    public static string GetPlayerEnemyDefenseLightAttackMessage
    {
        get
        {
            var messages = PlayerMessage.ListEnemyDefenseLightMessages[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }
    #endregion

    #endregion

    #region Medium
    #region Success
    public static string GetPlayerSuccessMediumAttackMessage
    {
        get
        {
            var messages = PlayerMessage.ListSuccessMediumAttackMessage[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }
    #endregion

    #region Failed
    public static string GetPlayerFailMediumAttackMessage
    {
        get
        {
            var messages = PlayerMessage.ListFailLightAttackMessage[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }
    #endregion

    #region EnemyDefense
    public static string GetPlayerEnemyDefenseMediumAttackMessage
    {
        get
        {
            var messages = PlayerMessage.ListEnemyDefenseMediumMessages[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }
    #endregion
    #endregion

    #region Heavy
    #region Success
    public static string GetPlayerSuccessHeavyAttackMessage
    {
        get
        {
            var messages = PlayerMessage.ListSuccessHeavyAttackMessage[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }
    #endregion

    #region Failed
    public static string GetPlayerFailHeavyAttackMessage
    {
        get
        {
            var messages = PlayerMessage.ListFailHeavyAttackMessage[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }
    #endregion

    #region EnemyDefense
    public static string GetPlayerEnemyDefenseHeavyAttackMessage
    {
        get
        {
            var messages = PlayerMessage.ListEnemyDefenseHeavyMessages[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }
    #endregion
    #endregion

    #endregion

    #region Defense

    #region Success
    public static string GetPlayerSuccessDefenseMessage
    {
        get
        {
            var messages = PlayerMessage.ListSuccessDefenseMessage[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }
    #endregion

    #region Useless
    public static string GetPlayerUselessDefense
    {
        get
        {
            var messages = PlayerMessage.ListUselessDefenseMessage[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }
    #endregion

    #endregion

    private static int GetNext(int length)
    {
        Random random = new Random();
        return random.Next(length);
    }
}