using MessageLibrary.Enum;

namespace MessageLibrary.Message.Enemy;

public static class EnemyMessage
{
    #region PotionMessage

    public static Dictionary<EnumLanguage, List<string>> SuccessTakePotionMessages = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
            {
                "O inimigo sorri ao beber uma poção viscosa! +20 HP para ele.",
                "Seu oponente engole uma poção fumegante. Vida recuperada: +20",
                "*tilts frasco* O rival não desperdiça nem uma gota da poção. (+20 HP)",
                "glup glup - O rival esvazia o frasco de cura, e você vê seus cortes desaparecendo! (+20 HP)",
                "O inimigo sorri maliciosamente enquanto a poção restaura sua energia vital!"
            }
        },
        { EnumLanguage.English, new List<string>
            {
                "The enemy grins as they drink a slimy potion! +20 HP for them.",
                "Your opponent gulps down a steaming potion. Health restored: +20",
                "*tilts vial* The rival doesn't waste a single drop of the potion. (+20 HP)",
                "glug glug - The rival empties the healing vial, and you see their wounds fading! (+20 HP)",
                "The enemy smirks maliciously as the potion restores their vitality!"
            }
        },
        { EnumLanguage.Turkish, new List<string>
            {
                "Düşman, yapışkan bir iksiri içerken sırıtıyor! +20 HP kazandı.",
                "Rakibiniz buharlı bir iksiri yudumluyor. Can yenilendi: +20",
                "*şişeyi eğer* Rakip, iksirin tek bir damlasını bile ziyan etmiyor. (+20 HP)",
                "gulp gulp - Rakip, iyileşme iksirini bitiriyor ve yaralarının iyileştiğini görüyorsunuz! (+20 HP)",
                "Düşman, iksir canını yenilerken kötü bir gülümseme yapıyor!"
            }
        }
    };

    public static Dictionary<EnumLanguage, List<string>> EnemyFailureTakePotionStockMessage = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
        {
            "O inimigo revira a mochila... nenhuma poção encontrada!",
            "O inimigo procura freneticamente, mas só encontra frascos vazios...",
            "Sem poções restantes! Parece que o inimigo está ficando sem recursos.",
            "*Sacode a mochila* Apenas o som de vidros vazios vindo do inimigo...",
            "O inimigo jurou ter guardado uma poção... Mas onde foi parar?"
        } },
        { EnumLanguage.English, new List<string>
        {
            "The enemy rummages through the backpack... no potions found!",
            "The enemy searches frantically but only finds empty vials...",
            "No potions left! Looks like the enemy is running low on supplies.",
            "*Shakes backpack* Only the sound of empty glass from the enemy...",
            "The enemy swore a potion was stored... But where did it go?"
        } },
        { EnumLanguage.Turkish, new List<string>
        {
            "Düşman sırt çantasını karıştırıyor... hiç iksir bulunamadı!",
            "Düşman çılgınca arıyor ama sadece boş şişeler buluyor...",
            "Hiç iksir kalmadı! Görünüşe göre düşmanın kaynakları tükeniyor.",
            "*Çanta sallanıyor* Düşmandan sadece boş cam sesleri geliyor...",
            "Düşman burada bir iksir sakladığına yemin edebilirdi... Ama nereye gitti?"
        } }
    };

    #endregion

    #region Attack

    #region Light
    public static Dictionary<EnumLanguage, List<string>> EnemyLightAttackMessages = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
            {
                "O inimigo te acerta com um golpe leve. Você perde {damage} de vida.",
                "Você sente uma dor leve — o ataque inimigo te atingiu. (-{damage} HP)",
                "Um corte superficial do inimigo te acerta. Dano: {damage}.",
                "Você é surpreendido por um ataque sutil. Dano recebido: {damage}.",
                "O ataque inimigo quase não te toca, mas ainda causa {damage} de dano."
            }
        },
        { EnumLanguage.English, new List<string>
            {
                "The enemy hits you with a light strike. You lose {damage} HP.",
                "A mild pain spreads — the enemy's attack landed. (-{damage} HP)",
                "A shallow cut from the enemy hits you. Damage: {damage}.",
                "You’re caught off guard by a subtle strike. Received damage: {damage}.",
                "The enemy’s attack barely touches you, but still deals {damage} damage."
            }
        },
        { EnumLanguage.Turkish, new List<string>
            {
                "Düşman seni hafif bir saldırıyla vurur. {damage} can kaybettin.",
                "Hafif bir acı hissediyorsun — düşmanın saldırısı isabet etti. (-{damage} HP)",
                "Düşmandan yüzeysel bir kesik alırsın. Hasar: {damage}.",
                "Beklenmedik bir hafif saldırıya yakalandın. Alınan hasar: {damage}.",
                "Düşmanın saldırısı seni zar zor yakalasa da {damage} hasar veriyor."
            }
        }
    };
    #endregion

    #region Medium
    public static Dictionary<EnumLanguage, List<string>> EnemyMediumAttackMessages = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
            {
                "Você é atingido por um golpe firme! Dano sofrido: {damage}.",
                "O ataque inimigo te acerta com força média. (-{damage} HP)",
                "Você cambaleia com o impacto do golpe. Dano: {damage}.",
                "O inimigo te ataca com determinação — você sofre {damage} de dano.",
                "Um ataque preciso e direto te pega em cheio. (-{damage} vida)"
            }
        },
        { EnumLanguage.English, new List<string>
            {
                "You are struck by a solid blow! Damage taken: {damage}.",
                "The enemy hits you with medium force. (-{damage} HP)",
                "You stagger from the impact. Damage: {damage}.",
                "The enemy attacks with intent — you suffer {damage} damage.",
                "A precise and direct strike hits you hard. (-{damage} HP)"
            }
        },
        { EnumLanguage.Turkish, new List<string>
            {
                "Sağlam bir darbe alırsın! Alınan hasar: {damage}.",
                "Düşman seni orta şiddette bir saldırıyla vurur. (-{damage} HP)",
                "Darbe seni sarsar. Hasar: {damage}.",
                "Düşman kararlı bir şekilde saldırır — {damage} hasar alırsın.",
                "Kesin ve doğrudan bir darbe seni fena vurur. (-{damage} HP)"
            }
        }
    };

    #endregion

    #region Heavy
    public static Dictionary<EnumLanguage, List<string>> EnemyHeavyAttackMessages = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
            {
                "Você é atingido com brutalidade! Dano massivo: {damage}.",
                "Um golpe devastador do inimigo te atinge em cheio! (-{damage} HP)",
                "O impacto é tão forte que quase te derruba. Dano recebido: {damage}.",
                "O inimigo libera um ataque poderoso — você sente cada parte dos {damage} de dano.",
                "Você tenta bloquear, mas a força do golpe te atravessa. (-{damage})"
            }
        },
        { EnumLanguage.English, new List<string>
            {
                "You're struck with brutal force! Massive damage: {damage}.",
                "A devastating blow from the enemy hits you hard! (-{damage} HP)",
                "The impact is so strong it nearly knocks you down. Damage taken: {damage}.",
                "The enemy unleashes a powerful strike — you feel every bit of the {damage} damage.",
                "You try to block, but the sheer force pushes through. (-{damage})"
            }
        },
        { EnumLanguage.Turkish, new List<string>
            {
                "Brutal bir darbeyle vurulursun! Büyük hasar: {damage}.",
                "Düşmanın yıkıcı saldırısı seni tam isabetle vurur! (-{damage} HP)",
                "Darbe o kadar şiddetlidir ki neredeyse yere düşersin. Alınan hasar: {damage}.",
                "Düşman güçlü bir saldırı gerçekleştirir — {damage} hasarın her anını hissedersin.",
                "Engellemeye çalışırsın ama darbenin gücü seni aşar. (-{damage})"
            }
        }
    };

    public static Dictionary<EnumLanguage, List<string>> EnemyMissedButPlayerDefendedMessages = new()
    {
        { EnumLanguage.Portuguese, new()
            {
                "O inimigo errou o ataque, porém {playerName} defendeu, que azar...",
                "Mesmo se defendendo, {playerName} nem precisou — o inimigo errou feio!",
                "{playerName} estava em guarda, mas o ataque do inimigo foi inútil.",
                "O inimigo falhou e {playerName} ainda estava preparado. Azar total!",
                "O ataque do inimigo foi tão desastroso que {playerName} nem precisaria se defender..."
            }
        },
        { EnumLanguage.English, new()
            {
                "The enemy missed the attack, but {playerName} defended anyway — what bad luck...",
                "{playerName} was ready, but the enemy still missed completely!",
                "Even with {playerName} guarding, the enemy’s attack failed miserably.",
                "The enemy struck and failed — and {playerName} didn’t even need to block.",
                "What a disaster for the enemy! {playerName} was defending, but it wasn’t needed."
            }
        },
        { EnumLanguage.Turkish, new()
            {
                "Düşman saldırıyı ıskaladı ama {playerName} yine de savunmadaydı — ne talihsizlik...",
                "{playerName} hazırdı ama düşman tamamen ıskaladı!",
                "{playerName} gardını almıştı ama düşmanın saldırısı boşa gitti.",
                "Düşman saldırdı ama {playerName} sadece izledi. Tam bir başarısızlık!",
                "{playerName} savunmadaydı ama düşmanın saldırısı zaten işe yaramadı."
            }
        }
    };


    public static Dictionary<EnumLanguage, List<string>> EnemyMissedMessages = new()
    {
        { EnumLanguage.Portuguese, new()
            {
                "O inimigo errou o ataque, que sorte...",
                "Você escapa por pouco — o inimigo erra o golpe!",
                "O inimigo ataca, mas você se livra ileso. Que sorte!",
                "Por um triz! O inimigo falha no ataque.",
                "O inimigo errou feio. A sorte sorriu pra você!"
            }
        },
        { EnumLanguage.English, new()
            {
                "The enemy missed the attack — how lucky...",
                "You barely dodge — the enemy's strike fails!",
                "The enemy attacks, but you come out unharmed. Lucky!",
                "So close! The enemy misses their attack.",
                "The enemy missed badly. Luck was on your side!"
            }
        },
        { EnumLanguage.Turkish, new()
            {
                "Düşman saldırıyı ıskaladı, ne şans...",
                "Kıl payı kurtuldun — düşmanın saldırısı boşa gitti!",
                "Düşman saldırdı ama sana zarar veremedi. Şanslısın!",
                "Ucu ucuna! Düşman hedefi ıskaladı.",
                "Düşman büyük hata yaptı. Şans senden yanaydı!"
            }
        }
    };


    #endregion

    #endregion

    #region Defense

    public static Dictionary<EnumLanguage, List<string>> BothDefendedMessages = new()
    {
        { EnumLanguage.Portuguese, new()
            {
                "Você e o inimigo se encaram em silêncio, ambos na defensiva.",
                "Dois guerreiros cautelosos, nenhum se arrisca a atacar.",
                "O campo de batalha fica em suspense — ninguém ousa atacar.",
                "Você levanta sua guarda, assim como o inimigo. Esperando…",
                "Ambos protegem suas posições. Um impasse silencioso."
            }
        },
        { EnumLanguage.English, new()
            {
                "You and the enemy stare each other down, both on the defense.",
                "Two cautious warriors — neither dares to strike.",
                "The battlefield is quiet, tense. No one moves to attack.",
                "You raise your guard, and so does the enemy. Waiting...",
                "Both of you defend, holding your ground. A silent standoff."
            }
        },
        { EnumLanguage.Turkish, new()
            {
                "Sen ve düşman birbirinize bakıyorsunuz, ikiniz de savunmada.",
                "İki temkinli savaşçı — hiçbiri saldırmaya cesaret edemiyor.",
                "Savaş alanı sessiz ve gergin. Kimse saldırmıyor.",
                "Sen gardını kaldırıyorsun, düşman da öyle. Bekleyiş başlıyor...",
                "İkiniz de pozisyonunuzu koruyorsunuz. Sessiz bir çıkmaz."
            }
        }
    };

    public static Dictionary<EnumLanguage, List<string>> EnemyUsedDefenseMessages = new()
    {
        { EnumLanguage.Portuguese, new()
            {
                "O inimigo utilizou defesa!",
                "O inimigo ergue a guarda para se proteger!",
                "Com movimentos ágeis, o inimigo entra em posição defensiva.",
                "O inimigo recua levemente e se prepara para defender.",
                "O inimigo se protege, antecipando o próximo golpe!"
            }
        },
        { EnumLanguage.English, new()
            {
                "The enemy used defense!",
                "The enemy raises the guard to protect!",
                "With swift movement, the enemy assumes a defensive stance.",
                "The enemy steps back slightly and prepares to defend.",
                "The enemy braces for the next strike, shielding up!"
            }
        },
        { EnumLanguage.Turkish, new()
            {
                "Düşman savunma yaptı!",
                "Düşman kendini korumak için gardını kaldırıyor!",
                "Hızlı bir hareketle düşman savunma pozisyonuna geçiyor.",
                "Düşman hafifçe geri çekiliyor ve savunmaya hazırlanıyor.",
                "Düşman bir sonraki saldırıya karşı savunmaya geçiyor!"
            }
        }
    };

    #endregion
}