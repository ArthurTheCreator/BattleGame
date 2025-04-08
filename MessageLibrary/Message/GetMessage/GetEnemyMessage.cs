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

    public static string GetEnemyUsingDefense
    {
        get
        {
            var messages = EnemyMessage.EnemyUsedDefenseMessages[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }

    private static int GetNext(int length)
    {
        return random.Next(length);
    }
}