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
}