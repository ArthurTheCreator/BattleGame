using MessageLibrary.Enum;
using MessageLibrary.Message.Enemy;
using MessageLibrary.Message.Player;

namespace MessageLibrary.Message.GetMessage;

public static class GetEnemyMessage
{
    #region Random
    private static Random random = new Random();
    #endregion

    public static EnumLanguage EnumLanguage { get; set; }

    public static string GetEnemySuccesTakePotionMessage
    {
        get
        {
            var messages = EnemyMessage.SuccessTakePotionMessages[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }

    public static string GetEnemyFailureTakePotionStockMessage
    {
        get
        {
            var messages = EnemyMessage.EnemyFailureTakePotionStockMessage[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }

    public static string GetEnemySuccessLightAttackMessages(int damage)
    {
        var messages = EnemyMessage.EnemyLightAttackMessages[EnumLanguage];
        return messages[GetNext(messages.Count)].Replace("{damage}", damage.ToString());
    }

    public static string GetEnemySuccessMediumAttackMessages(int damage)
    {
        var messages = EnemyMessage.EnemyMediumAttackMessages[EnumLanguage];
        return messages[GetNext(messages.Count)].Replace("{damage}", damage.ToString());
    }

    public static string GetEnemySuccessHeavyAttackMessages(int damage)
    {
        var messages = EnemyMessage.EnemyHeavyAttackMessages[EnumLanguage];
        return messages[GetNext(messages.Count)].Replace("{damage}", damage.ToString());
    }

    public static string GetEnemyMissedButPlayerDefendedMessages(string playerName)
    {
        var messages = EnemyMessage.EnemyMissedButPlayerDefendedMessages[EnumLanguage];
        return messages[GetNext(messages.Count)].Replace("{playerName}", playerName);
    }

    public static string GetEnemyMissedMessages
    {
        get
        {
            var messages = EnemyMessage.EnemyMissedMessages[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }

    public static string GetEnemyUsingDefense
    {
        get
        {
            var messages = EnemyMessage.EnemyUsedDefenseMessages[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }

    public static string GetBothUsingDefense
    {
        get
        {
            var messages = EnemyMessage.BothDefendedMessages[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }

    public static string EnemyUsedDefenseUselessly
    {
        get
        {
            var messages = EnemyMessage.EnemyUsedDefenseUselesslyMessages[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }
    private static int GetNext(int length)
    {
        return random.Next(length);
    }
}