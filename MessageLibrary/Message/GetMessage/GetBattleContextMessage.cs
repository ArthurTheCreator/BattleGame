using MessageLibrary.Enum;
using MessageLibrary.Message.Battle;

namespace MessageLibrary.Message.GetMessage
{
    public class GetBattleContextMessage
    {
        public static EnumLanguage Language { get; set; }

        public static string GetBattleContextWelcomeMessage 
        {
            get
            {
                var messages = BattleContext.WelcomeMessage[Language];
                return messages[GetNext(messages.Count)];
            }
        }

        public static string GetBattleContextPlayerChoose
        {
            get
            {
                var messages = BattleContext.PlayerChoose[Language];
                return messages[GetNext(messages.Count)];
            }
        }

        public static string GetBattleContextWrongAction
        {
            get
            {
                var messages = BattleContext.WrongAction[Language];
                return messages[GetNext(messages.Count)];
            }
        }

        public static string GetBattleContextMenuChoices
        {
            get
            {
                return BattleContext.MenuChoices[Language];
            }
        }

        private static int GetNext(int length)
        {
            Random random = new Random();
            return random.Next(length);
        }
    }
}
