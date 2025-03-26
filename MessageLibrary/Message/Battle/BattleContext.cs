using MessageLibrary.Enum;

namespace MessageLibrary.Message.Battle
{
    public class BattleContext
    {
        private static Random random = new Random();

        public static EnumLanguage EnumLanguage { get; set; }

        //public static List<string> ListSuccesAttackDamageMessage { get; } = new List<string>() { }; // recebe por método

        public static string GetSuccessAttackDamageMessage(string playerName, int damage)
        {
            List<string> messages = new List<string>
            {
                $"{playerName} desferiu um golpe que causou {damage} de dano!",
                $"{playerName} atingiu o inimigo com força, causando {damage} de dano!",
                $"{playerName} golpeou com precisão, causando {damage} de dano!",
                $"{playerName} acertou o inimigo com {damage} de dano!",
                $"{playerName} infligiu {damage} de dano com um ataque certeiro!"
            };

            int index = random.Next(messages.Count);
            return messages[index];
        }

        public static string GetSuccesEnemyDefense()
        {

        }
    }
}
