using MessageLibrary.Enum;

namespace MessageLibrary.Message.Player;

public static class PlayerMessage
{
    #region PotionMessage

    #region Portuguese
    public static List<string> ListSuccessTakePotionMessagePortuguese { get; } = new List<string>
    {
        "Você bebe a poção e sente uma energia revitalizante! +20 de vida.",
        "Você engole a poção dourada - um calor revigorante se espalha pelo corpo! +20 HP",
        "O líquido borbulhante cura suas feridas instantaneamente. Vida +20!",
        "*Glup glup* A poção restaura 20 pontos de vida!",
        "Você sente ossos se recompondo e músculos se regenerando ao beber o frasco.",
    };

    public static List<string> ListFailureTakePotionStockMessagePortuguese { get; } = new List<string>
    {
        "Você revira a mochila... nenhuma poção encontrada!",
         "Você procura freneticamente, mas só encontra frascos vazios...",
        "Nenhuma poção restante! Melhor economizar nas próximas batalhas.",
        "*Sacode a mochila* Apenas um som de vidros vazios ecoa...",
        "Você jurou ter guardado uma poção aqui... Onde foi parar?"
    };

    public static List<string> ListFailureTakePotionHPMessagePortuguese { get; } = new List<string>
    {
        "Você examina a poção... Seus ferimentos são insignificantes para isso.",
        "Por que desperdiçar um bom frasco? Você está praticamente intacto!",
        "A poção parece supérflua - nem uma cicatriz para justificar seu uso.",
        "Tomar poção agora seria como comprar guarda-chuva no deserto. Você está bem!",
        "Sangue? Apenas arranhões. Guarde a poção para quando o perigo for real."
    };
    public static List<string> ListFailureTakePotionStockAndHPMessagePortuguese { get; } = new List<string>
    {
        "Nem uma gota de poção... Mas também nem um arranhão para curar!",
        "Sua mochila está vazia e seu HP está brilhando - que sorte mista!",
        "Sem poções no estoque e você nem precisa - está com a saúde perfeita!",
        "Sem poções na mochila e ferimentos leves. Você nem precisaria mesmo.",
        "Estoque zerado. Por sorte, seus ferimentos são superficiais."
    };
    #endregion

    #region English
    public static List<string> ListSuccessTakePotionMessageEnglish { get; } = new List<string>
    {
    "You drink the potion and feel revitalizing energy! +20 health.",
    "You swallow the golden potion - a revigorating warmth spreads through your body! +20 HP",
    "The bubbling liquid instantly heals your wounds. Health +20!",
    "*Gulp gulp* The potion restores 20 health points!",
    "You feel bones mending and muscles regenerating as you drink the flask."
    };

    public static List<string> ListFailureTakePotionStockMessageEnglish { get; } = new List<string>
    {
    "You rummage through your backpack... no potions found!",
    "You search frantically but only find empty vials...",
    "No potions left! Better save up for the next battles.",
    "*Shakes backpack* Only the sound of empty glass echoes...",
    "You swore you stored a potion here... Where did it go?"
    };

    public static List<string> ListFailureTakePotionHPMessageEnglish { get; } = new List<string>
    {
    "You examine the potion... Your wounds are too minor for this.",
    "Why waste a good flask? You're practically unscathed!",
    "The potion seems superfluous - not even a scar to justify its use.",
    "Drinking a potion now would be like buying an umbrella in the desert. You're fine!",
    "Blood? Just scratches. Save the potion for real danger."
    };

    public static List<string> ListFailureTakePotionStockAndHPMessageEnglish { get; } = new List<string>
    {
    "Not a drop of potion... But also not a scratch to heal!",
    "Your backpack is empty and your HP is shining - what mixed luck!",
    "No potions in stock and you don't even need them - in perfect health!",
    "No potions in your bag and only light wounds. You wouldn't need it anyway.",
    "Stock depleted. Luckily, your injuries are superficial."
    };
    #endregion

    #region Turkish
    public static List<string> ListSuccessTakePotionMessageTurkish { get; } = new List<string>
    {
    "İksiri içiyorsunuz ve canlandırıcı bir enerji hissediyorsunuz! +20 can.",
    "Altın iksiri yudumluyorsunuz - vücudunuzda canlandırıcı bir sıcaklık yayılıyor! +20 HP",
    "Fokurdayan sıvı yaralarınızı anında iyileştiriyor. Can +20!",
    "*Gulp gulp* İksir 20 can puanı iyileştiriyor!",
    "İksiri içerken kemiklerinizin kaynadığını ve kaslarınızın yenilendiğini hissediyorsunuz."
    };

    public static List<string> ListFailureTakePotionStockMessageTurkish { get; } = new List<string>
    {
    "Sırt çantanızı karıştırıyorsunuz... hiç iksir bulunamadı!",
    "Çılgınca arıyorsunuz ama sadece boş şişeler buluyorsunuz...",
    "Hiç iksir kalmadı! Sonraki savaşlar için saklamak daha iyi.",
    "*Çantayı sallar* Sadece boş cam sesleri yankılanıyor...",
    "Buraya bir iksir sakladığınıza yemin edebilirdiniz... Nereye gitti?"
    };

    public static List<string> ListFailureTakePotionHPMessageTurkish { get; } = new List<string>
    {
    "İksiri inceliyorsunuz... Yaralarınız bunun için çok küçük.",
    "Neden iyi bir şişeyi boşa harcayasınız? Neredeyse hiç yara almamışsınız!",
    "İksir gereksiz görünüyor - kullanmak için bir yara bile yok.",
    "Şimdi iksir içmek, çölde şemsiye almak gibi olur. İyisiniz!",
    "Kan mı? Sadece sıyrıklar. İksiri gerçek tehlike için saklayın."
    };

    public static List<string> ListFailureTakePotionStockAndHPMessageTurkish { get; } = new List<string>
    {
    "Bir damla iksir yok... Ama iyileştirecek bir yara da yok!",
    "Çantanız boş ve HP'niz parlıyor - ne karışık bir şans!",
    "Stokta iksir yok ve zaten ihtiyacınız da yok - mükemmel sağlıktasınız!",
    "Çantanızda iksir yok ve sadece hafif yaralarınız var. Zaten gerek yoktu.",
    "Stok tükendi. Neyse ki yaralarınız yüzeysel."
    };
    #endregion

    #endregion
}