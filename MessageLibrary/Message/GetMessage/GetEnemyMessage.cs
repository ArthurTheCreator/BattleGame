using MessageLibrary.Enum;
using MessageLibrary.Message.Enemy;

namespace MessageLibrary.Message.GetMessage;

public static class GetEnemyMessage
{
    #region Random
    private static Random random = new Random();
    #endregion

    public static EnumLanguage EnumLanguage { get; set; }

    public static string GetEnemySuccessTakePotionMessage()
    {
        if (EnumLanguage == EnumLanguage.Portuguese)
            return EnemyMessage.ListSuccessTakePotionMessagePortuguese[random.Next(5)];
        else if (EnumLanguage == EnumLanguage.English)
            return EnemyMessage.ListSuccessTakePotionMessageEnglish[random.Next(5)];
        else return EnemyMessage.ListSuccessTakePotionMessageTurkish[random.Next(5)];
    }
}