using MessageLibrary.Enum;

namespace MessageLibrary.Message.GetMessage;

public static class GetEnemyMessage
{
    #region Random
    private static Random random = new Random();
    #endregion

    public static EnumLanguage EnumLanguage { get; set; }



    private static int GetNext(this List<string> listMessage)
    {
        return random.Next(listMessage.Count);
    }
}