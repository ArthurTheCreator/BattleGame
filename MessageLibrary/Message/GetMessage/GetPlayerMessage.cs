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
    public static string GetPlayerSuccessTakePotionMessage
    {
        get
        {
            var messages = PlayerMessage.ListSuccessTakePotionMessage[EnumLanguage];
            return messages[GetNext(messages.Count)];
        }
    }

    //public static string GetPlayerFailureTakePotionStockMessage()
    //{
    //    if (EnumLanguage == EnumLanguage.Portuguese)
    //        return PlayerMessage.ListFailureTakePotionStockMessagePortuguese[GetNext()];
    //    else if (EnumLanguage == EnumLanguage.English)
    //        return PlayerMessage.ListFailureTakePotionStockMessageEnglish[GetNext()];
    //    else return PlayerMessage.ListFailureTakePotionStockMessageTurkish[GetNext()];
    //}

    //public static string GetPlayerFailureTakePotionHPMessage()
    //{
    //    if (EnumLanguage == EnumLanguage.Portuguese)
    //        return PlayerMessage.ListFailureTakePotionHPMessagePortuguese[GetNext()];
    //    else if (EnumLanguage == EnumLanguage.English)
    //        return PlayerMessage.ListFailureTakePotionHPMessageEnglish[GetNext()];
    //    else return PlayerMessage.ListFailureTakePotionHPMessageTurkish[GetNext()];
    //}

    //public static string GetFailureTakePotionStockAndHPMessage()
    //{
    //    if (EnumLanguage == EnumLanguage.Portuguese)
    //        return PlayerMessage.ListFailureTakePotionStockAndHPMessagePortuguese[GetNext()];
    //    else if (EnumLanguage == EnumLanguage.English)
    //        return PlayerMessage.ListFailureTakePotionStockAndHPMessageEnglish[GetNext()];
    //    else return PlayerMessage.ListFailureTakePotionStockAndHPMessageTurkish[GetNext()];
    //}
    #endregion

    private static int GetNext(int length)
    {
        Random random = new Random();
        return random.Next(length);
    }
}