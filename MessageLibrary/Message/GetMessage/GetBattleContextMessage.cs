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

        public static string GetBattleContextStartGameMessage
        {
            get
            {
                var messages = BattleContext.StartGameMessage[Language];
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

        public static string GetBattleContextMenuChoices(string playerName, int playerHp, int enemyHp)
        {
            var message = BattleContext.MenuChoices[Language];
            return message
                .Replace("{playerName}", playerName)
                .Replace("{playerHp}", playerHp.ToString())
                .Replace("{enemyHp}", enemyHp.ToString());
        }


        public static string GetBattleContextPressAnyKeyMessage
        {
            get
            {
                return BattleContext.PressAnyKeyMessage[Language];
            }
        }

        public static string GetBattleContextLoadingMessage
        {
            get
            {
                return BattleContext.LoadingMessage[Language];
            }
        }

        private static int GetNext(int length)
        {
            Random random = new Random();
            return random.Next(length);
        }
    }
}
