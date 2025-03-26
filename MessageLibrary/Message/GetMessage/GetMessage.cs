using MessageLibrary.Enum;
using MessageLibrary.Message.Player;

namespace MessageLibrary.Message.GetMessage;

public static class GetMessage
{
    #region Random
    private static Random random = new Random();
    #endregion

    public static EnumLanguage EnumLanguage { get; set; }

    public static string? PlayerName { get; set; }

    public static string GetPlayerSuccessTakePotionMessage()
    {
        if (EnumLanguage == EnumLanguage.Portuguese)
            return PlayerMessage.ListSuccessTakePotionMessagePortuguese[random.Next(5)];
        else if (EnumLanguage == EnumLanguage.English)
            return PlayerMessage.ListSuccessTakePotionMessageEnglish[random.Next(5)];
        else return PlayerMessage.ListSuccessTakePotionMessageTurkish[random.Next(5)];
    }
}