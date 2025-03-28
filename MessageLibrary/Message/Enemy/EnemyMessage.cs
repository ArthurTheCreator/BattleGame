namespace MessageLibrary.Message.Enemy;

public static class EnemyMessage
{
    #region PotionMEssage

    #region Portuguese
    public static List<string> ListSuccessTakePotionMessagePortuguese { get; } = new List<string>
    {
        "O inimigo sorri ao beber uma poção viscosa! +20 HP para ele.",
        "Seu oponente engole uma poção fumegante. Vida recuperada: +20",
        "*tilts frasco* O rival não desperdiça nem uma gota da poção. (+20 HP)",
        "glup glup - O rival esvazia o frasco de cura, e você vê seus cortes desaparecendo! (+20 HP)",
        "O inimigo sorri maliciosamente enquanto a poção restaura sua energia vital!"
    };
    #endregion

    #region English
    public static List<string> ListSuccessTakePotionMessageEnglish { get; } = new List<string>
    {
        "The enemy grins as they drink a slimy potion! +20 HP for them.",
        "Your opponent gulps down a steaming potion. Health restored: +20",
        "*tilts vial* The rival doesn't waste a single drop of the potion. (+20 HP)",
        "glug glug - The rival empties the healing vial, and you see their wounds fading! (+20 HP)",
        "The enemy smirks maliciously as the potion restores their vitality!"
    };
    #endregion

    #region Turkish
    public static List<string> ListSuccessTakePotionMessageTurkish { get; } = new List<string>
    {
        "Düşman, yapışkan bir iksiri içerken sırıtıyor! +20 HP kazandı.",
        "Rakibiniz buharlı bir iksiri yudumluyor. Can yenilendi: +20",
        "*şişeyi eğer* Rakip, iksirin tek bir damlasını bile ziyan etmiyor. (+20 HP)",
        "gulp gulp - Rakip, iyileşme iksirini bitiriyor ve yaralarının iyileştiğini görüyorsunuz! (+20 HP)",
        "Düşman, iksir canını yenilerken kötü bir gülümseme yapıyor!"
    };
    #endregion

    #endregion

}