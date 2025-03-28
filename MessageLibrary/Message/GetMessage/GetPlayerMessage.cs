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
    public static string GetPlayerSuccessTakePotionMessage()
    {
        if (EnumLanguage == EnumLanguage.Portuguese)
            return PlayerMessage.ListSuccessTakePotionMessagePortuguese[random.Next(5)];
        else if (EnumLanguage == EnumLanguage.English)
            return PlayerMessage.ListSuccessTakePotionMessageEnglish[random.Next(5)];
        else return PlayerMessage.ListSuccessTakePotionMessageTurkish[random.Next(5)];
    }    

    public static string GetPlayerFailureTakePotionStockMessage()
    {
        if (EnumLanguage == EnumLanguage.Portuguese)
            return PlayerMessage.ListFailureTakePotionStockMessagePortuguese[random.Next(5)];
        else if (EnumLanguage == EnumLanguage.English)
            return PlayerMessage.ListFailureTakePotionStockMessageEnglish[random.Next(5)];
        else return PlayerMessage.ListFailureTakePotionStockMessageTurkish[random.Next(5)];
    }

    public static string GetPlayerFailureTakePotionHPMessage()
    {
        if (EnumLanguage == EnumLanguage.Portuguese)
            return PlayerMessage.ListFailureTakePotionHPMessagePortuguese[random.Next(5)];
        else if (EnumLanguage == EnumLanguage.English)
            return PlayerMessage.ListFailureTakePotionHPMessageEnglish[random.Next(5)];
        else return PlayerMessage.ListFailureTakePotionHPMessageTurkish[random.Next(5)];
    }

    public static string GetFailureTakePotionStockAndHPMessage()
    {
        if (EnumLanguage == EnumLanguage.Portuguese)
            return PlayerMessage.ListFailureTakePotionStockAndHPMessagePortuguese[random.Next(5)];
        else if (EnumLanguage == EnumLanguage.English)
            return PlayerMessage.ListFailureTakePotionStockAndHPMessageEnglish[random.Next(5)];
        else return PlayerMessage.ListFailureTakePotionStockAndHPMessageTurkish[random.Next(5)];
    }
    #endregion
}