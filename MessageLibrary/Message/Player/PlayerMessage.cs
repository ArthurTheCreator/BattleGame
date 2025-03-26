using MessageLibrary.Enum;
using System.Runtime.Intrinsics.X86;
using System;

namespace MessageLibrary.Message.Player;

public static class PlayerMessage
{
    private static Random random = new Random();

    public static EnumLanguage EnumLanguage { get; set; }
    public static List<string> ListSuccessTakePotionMessagePortuguese { get; } = new List<string>
    {
        "Você bebe a poção e sente uma energia revitalizante! +20 de vida.",
        "Você engole a poção dourada - um calor revigorante se espalha pelo corpo! +20 HP",
        "O líquido borbulhante cura suas feridas instantaneamente. Vida +20!",
        "*Glup glup* A poção restaura 20 pontos de vida!",
        "Você sente ossos se recompondo e músculos se regenerando ao beber o frasco.",
    };

    public static List<string> ListSuccessTakePotionMessageEnglish { get; } = new List<string>
    {
        "BrunaInglesinha",
        "BrunaInglesinha",
        "BrunaInglesinha",
        "BrunaInglesinha",
        "BrunaInglesinha"
    };

    public static List<string> ListSuccessTakePotionMessageTurkish { get; } = new List<string>
    {
        "BrunaTurkistinha",
        "BrunaTurkistinha",
        "BrunaTurkistinha",
        "BrunaTurkistinha",
        "BrunaTurkistinha"
    };

    public static List<string> ListFailureTakePotionStockMessagePortuguese { get; } = new List<string>
    {
        "Você revira a mochila... nenhuma poção encontrada!",
         "Você procura freneticamente, mas só encontra frascos vazios...",
        "Nenhuma poção restante! Melhor economizar nas próximas batalhas.",
        "*Sacode a mochila* Apenas um som de vidros vazios ecoa...",
    };

    public static List<string> ListFailureTakePotionHPMessagePortuguese { get; } = new List<string>
    {
        "Você examina a poção... Seus ferimentos são insignificantes para isso.",
        "Por que desperdiçar um bom frasco? Você está praticamente intacto!",
        "A poção parece supérflua - nem uma cicatriz para justificar seu uso.",
        "Você não sente necessidade - seus ferimentos são leves demais para usar agora."
    };
    public static List<string> ListFailureTakePotionStockAndHPMessagePortuguese { get; } = new List<string>
    {
        "Nem uma gota de poção... Mas também nem um arranhão para curar!",
        "Sua mochila está vazia e seu HP está brilhando - que sorte mista!",
        "Sem poções no estoque e você nem precisa - está com a saúde perfeita!",
    };


    public static string GetSuccessTakePotionMessage()
    {
        if (EnumLanguage == EnumLanguage.Portuguese)
            return ListSuccessTakePotionMessagePortuguese[random.Next(5)];
        else if (EnumLanguage == EnumLanguage.English)
            return ListSuccessTakePotionMessageEnglish[random.Next(5)];
        else return ListSuccessTakePotionMessageTurkish[random.Next(5)];
    }
}