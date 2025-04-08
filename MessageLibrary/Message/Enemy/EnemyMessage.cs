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
    #endregion

    #endregion

    public static Dictionary<EnumLanguage, List<string>> EnemyDefendedButPlayerDidNotAttackMessages = new()
    {
        { EnumLanguage.Portuguese, new()
            {
                "O inimigo assume postura defensiva… contra o nada. Você não atacou!",
                "Ele se protege, mas seu golpe nunca veio. Defesa desperdiçada!",
                "O adversário ergue a guarda por precaução — um ataque que nunca aconteceu.",
                "Com olhos atentos, o inimigo defende… o vazio.",
                "Ele se esconde atrás da defesa, mas você estava apenas observando."
            }
        },
        { EnumLanguage.English, new()
            {
                "The enemy braces for an attack… but you didn't strike!",
                "They shield themselves, but your blow never came. A wasted defense!",
                "The opponent raises their guard — for a threat that never arrived.",
                "Alert and defensive, the enemy prepares… for nothing.",
                "They hide behind their defense, but you were just watching."
            }
        },
        { EnumLanguage.Turkish, new()
            {
                "Düşman savunma pozisyonu alıyor… ama sen saldırmadın!",
                "Kendini koruyor ama saldırın hiç gelmedi. Boşa harcanan bir savunma!",
                "Rakip gardını kaldırıyor — ama tehdit hiç ortaya çıkmadı.",
                "Dikkatli ve savunmada… ama ortada saldırı yok.",
                "Savunmanın arkasına saklanıyor, ama sen sadece izliyordun."
            }
        }
    };

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


}