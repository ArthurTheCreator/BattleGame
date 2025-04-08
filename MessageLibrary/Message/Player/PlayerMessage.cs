using MessageLibrary.Enum;

namespace MessageLibrary.Message.Player;

public static class PlayerMessage
{
    #region PotionMessage

    public static Dictionary<EnumLanguage, List<string>> ListSuccessTakePotionMessage = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>{
            "Você bebe a poção e sente uma energia revitalizante! +20 de vida.",
            "Você engole a poção dourada - um calor revigorante se espalha pelo corpo! +20 HP",
            "O líquido borbulhante cura suas feridas instantaneamente. Vida +20!",
            "*Glup glup* A poção restaura 20 pontos de vida!",
            "Você sente ossos se recompondo e músculos se regenerando ao beber o frasco.",
        } },
        { EnumLanguage.English, new List<string>{
            "You drink the potion and feel revitalizing energy! +20 health.",
            "You swallow the golden potion - a revigorating warmth spreads through your body! +20 HP",
            "The bubbling liquid instantly heals your wounds. Health +20!",
            "*Gulp gulp* The potion restores 20 health points!",
            "You feel bones mending and muscles regenerating as you drink the flask."
        } },
        { EnumLanguage.Turkish, new List<string>{
            "İksiri içiyorsunuz ve canlandırıcı bir enerji hissediyorsunuz! +20 can.",
            "Altın iksiri yudumluyorsunuz - vücudunuzda canlandırıcı bir sıcaklık yayılıyor! +20 HP",
            "Fokurdayan sıvı yaralarınızı anında iyileştiriyor. Can +20!",
            "*Gulp gulp* İksir 20 can puanı iyileştiriyor!",
            "İksiri içerken kemiklerinizin kaynadığını ve kaslarınızın yenilendiğini hissediyorsunuz."
        } }
    };

    public static Dictionary<EnumLanguage, List<string>> ListFailureTakePotionStockMessage = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
        {
            "Você revira a mochila... nenhuma poção encontrada!",
            "Você procura freneticamente, mas só encontra frascos vazios...",
            "Nenhuma poção restante! Melhor economizar nas próximas batalhas.",
            "*Sacode a mochila* Apenas um som de vidros vazios ecoa...",
            "Você jurou ter guardado uma poção aqui... Onde foi parar?"
        } },
        { EnumLanguage.English, new List<string>
        {
            "You rummage through your backpack... no potions found!",
            "You search frantically but only find empty vials...",
            "No potions left! Better save up for the next battles.",
            "*Shakes backpack* Only the sound of empty glass echoes...",
            "You swore you stored a potion here... Where did it go?"
        } },
        { EnumLanguage.Turkish, new List<string>
        {
            "Sırt çantanızı karıştırıyorsunuz... hiç iksir bulunamadı!",
            "Çılgınca arıyorsunuz ama sadece boş şişeler buluyorsunuz...",
            "Hiç iksir kalmadı! Sonraki savaşlar için saklamak daha iyi.",
            "*Çantayı sallar* Sadece boş cam sesleri yankılanıyor...",
            "Buraya bir iksir sakladığınıza yemin edebilirdiniz... Nereye gitti?"
        } }
    };

    public static Dictionary<EnumLanguage, List<string>> ListFailureTakePotionHPMessage = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
        {
            "Você examina a poção... Seus ferimentos são insignificantes para isso.",
            "Por que desperdiçar um bom frasco? Você está praticamente intacto!",
            "A poção parece supérflua - nem uma cicatriz para justificar seu uso.",
            "Tomar poção agora seria como comprar guarda-chuva no deserto. Você está bem!",
            "Sangue? Apenas arranhões. Guarde a poção para quando o perigo for real."
        } },
        { EnumLanguage.English, new List<string>
        {
            "You examine the potion... Your wounds are too minor for this.",
            "Why waste a good flask? You're practically unscathed!",
            "The potion seems superfluous - not even a scar to justify its use.",
            "Drinking a potion now would be like buying an umbrella in the desert. You're fine!",
            "Blood? Just scratches. Save the potion for real danger."
        } },
        { EnumLanguage.Turkish, new List<string>
        {
            "İksiri inceliyorsunuz... Yaralarınız bunun için çok küçük.",
            "Neden iyi bir şişeyi boşa harcayasınız? Neredeyse hiç yara almamışsınız!",
            "İksir gereksiz görünüyor - kullanmak için bir yara bile yok.",
            "Şimdi iksir içmek, çölde şemsiye almak gibi olur. İyisiniz!",
            "Kan mı? Sadece sıyrıklar. İksiri gerçek tehlike için saklayın."
        } }
    };

    public static Dictionary<EnumLanguage, List<string>> ListFailureTakePotionStockAndHPMessage = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
        {
            "Nem uma gota de poção... Mas também nem um arranhão para curar!",
            "Sua mochila está vazia e seu HP está brilhando - que sorte mista!",
            "Sem poções no estoque e você nem precisa - está com a saúde perfeita!",
            "Sem poções na mochila e ferimentos leves. Você nem precisaria mesmo.",
            "Estoque zerado. Por sorte, seus ferimentos são superficiais."
        } },
        { EnumLanguage.English, new List<string>
        {
            "Not a drop of potion... But also not a scratch to heal!",
            "Your backpack is empty and your HP is shining - what mixed luck!",
            "No potions in stock and you don't even need them - in perfect health!",
            "No potions in your bag and only light wounds. You wouldn't need it anyway.",
            "Stock depleted. Luckily, your injuries are superficial."
        } },
        { EnumLanguage.Turkish, new List<string>
        {
            "Bir damla iksir yok... Ama iyileştirecek bir yara da yok!",
            "Çantanız boş ve HP'niz parlıyor - ne karışık bir şans!",
            "Stokta iksir yok ve zaten ihtiyacınız da yok - mükemmel sağlıktasınız!",
            "Çantanızda iksir yok ve sadece hafif yaralarınız var. Zaten gerek yoktu.",
            "Stok tükendi. Neyse ki yaralarınız yüzeysel."
        } }
    };

    #endregion

    #region AttackMessage

    public static Dictionary<EnumLanguage, List<string>> PlayerMissedButEnemyDefendedMessages = new()
    {
        { EnumLanguage.Portuguese, new()
            {
                "Você errou o ataque, mas o inimigo estava na defesa. Sorte que não era necessário acertar!",
                "O inimigo se defende de um ataque que nem chegou. Sorte sua, não foi exposto!",
                "Você não acerta o golpe, mas o inimigo estava ocupado se defendendo. Que sorte!",
                "Ataque errado, mas o inimigo desperdiçou a defesa. Melhor pra você!",
                "O inimigo bloqueou o vento — sorte sua, ficou tudo elas por elas!"
            }
        },
        { EnumLanguage.English, new()
            {
                "You missed the attack, but the enemy was guarding anyway. Lucky you!",
                "The enemy defends against nothing — your miss goes unnoticed. That's luck!",
                "Your attack fails, but the enemy was too busy defending. What luck!",
                "You didn’t land the blow, but the enemy wasted a defense. Fortune favors you!",
                "A failed strike, yet the enemy blocked the air. You got lucky this time!"
            }
        },
        { EnumLanguage.Turkish, new()
            {
                "Saldırın boşa gitti ama düşman zaten savunmadaydı. Şans senden yana!",
                "Düşman boşa savunma yaptı — senin saldırın isabet etmedi bile. Ne şans!",
                "Saldırı başarısız oldu ama düşman savunma yapıyordu. Şanslısın!",
                "Düşman boşluğu savundu. Senin için iyi oldu!",
                "Vuruş olmadı ama düşman gardını boşuna kaldırdı. Bu sefer şans seninleydi!"
            }
        }
    };


    #region LightAttack

    #region Success
    public static Dictionary<EnumLanguage, List<string>> ListSuccessLightAttackMessage = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
            {
                "Sua lâmina corta o ar e atinge o alvo de raspão. Dano leve causado: {damage}.",
                "*Swish!* Um ataque certeiro, mas contido. -{damage} de vida no oponente.",
                "Com um movimento quase imperceptível, você fere o inimigo levemente. Dano: {damage}.",
                "Você gira o corpo e ataca com leveza, mas eficiência. Dano: {damage}.",
                "Você finta para um lado e acerta do outro — golpe leve bem-sucedido. (-{damage})"
            } },
        { EnumLanguage.English, new List<string>
            {
                "Your blade slices through the air and grazes the target. Light damage dealt: {damage}.",
                "*Swish!* A precise but restrained strike. -{damage} HP to the opponent.",
                "With an almost imperceptible move, you lightly wound the enemy. Damage: {damage}.",
                "You spin and strike with lightness, yet efficiency. Damage: {damage}.",
                "You feint to one side and strike from the other — light hit successful. (-{damage})"
            } },
        { EnumLanguage.Turkish, new List<string>
            {
                "Kılıcın havayı yarar ve hedefi sıyırır. Hafif hasar verildi: {damage}.",
                "*Vızz!* Kesin ama hafif bir darbe. Rakip -{damage} HP kaybetti.",
                "Neredeyse fark edilmeyen bir hareketle düşmanı hafifçe yaraladın. Hasar: {damage}.",
                "Vücudunu döndürüp hafif ama etkili bir saldırı yaparsın. Hasar: {damage}.",
                "Bir yana yanıltıp diğer yandan vurursun — hafif saldırı başarılı. (-{damage})"
            } }
    };
    #endregion

    #region Failed
    public static Dictionary<EnumLanguage, List<string>> ListFailLightAttackMessage = new Dictionary<EnumLanguage, List<string>>
{
    { EnumLanguage.Portuguese, new List<string>
        {
            "Você erra o golpe — o inimigo se esquiva com facilidade!",
            "Seu ataque passa longe do alvo. Concentre-se!",
            "Seu golpe acerta o chão — ataque leve desperdiçado.",
            "O inimigo ri enquanto você erra o golpe leve.",
            "*Whoosh!* Só o vento foi atingido por esse ataque."
        } },
    { EnumLanguage.English, new List<string>
        {
            "You miss the strike — the enemy dodges with ease!",
            "Your attack goes wide. Focus!",
            "Your strike hits the ground — light attack wasted.",
            "The enemy laughs as you miss your light strike.",
            "*Whoosh!* Only the air felt that attack."
        } },
    { EnumLanguage.Turkish, new List<string>
        {
            "Saldırın boşa gider — düşman kolayca kaçar!",
            "Saldırın hedefi ıskaladı. Dikkatini topla!",
            "Darben yere çarpar — hafif saldırı boşa gitti.",
            "Düşman, hafif saldırını kaçırdığında güler.",
            "*Vızz!* Bu saldırıyı sadece hava hissetti."
        } }
};
    #endregion

    #region EnemyDefense
    public static Dictionary<EnumLanguage, List<string>> ListEnemyDefenseLightMessages = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
            {
                "O inimigo reage rapidamente e bloqueia parte do seu golpe leve. (-{damage})",
                "Sua lâmina toca o inimigo, mas ele consegue reduzir o impacto. Dano mitigado: {damage}.",
                "Você acerta, mas o inimigo defende a tempo — metade do golpe é absorvido. {damage}",
                "Seu ataque leve é parcialmente bloqueado. Só parte do dano passou. (-{damage})",
                "O inimigo se defende com agilidade e evita o pior. Dano reduzido: {damage}."
            }
        },
        { EnumLanguage.English, new List<string>
            {
                "The enemy reacts quickly and blocks part of your light strike. (-{damage})",
                "Your blade touches the enemy, but they manage to reduce the impact. Damage mitigated: {damage}.",
                "You hit, but the enemy defends in time — half the strike is absorbed. {damage}",
                "Your light attack is partially blocked. Only part of the damage goes through. (-{damage})",
                "The enemy defends swiftly and avoids the worst. Reduced damage: {damage}."
            }
        },
        { EnumLanguage.Turkish, new List<string>
            {
                "Düşman hızlıca tepki verir ve hafif saldırının bir kısmını engeller. (-{damage})",
                "Kılıcın düşmana dokunur ama darbenin etkisini azaltırlar. Azaltılan hasar: {damage}.",
                "Vurursun, ama düşman zamanında savunur — hasarın yarısı emilir.{damage}",
                "Hafif saldırın kısmen engellenir. Sadece bir kısmı geçer. (-{damage})",
                "Düşman çevik bir şekilde savunur ve en kötüsünden kaçar. Hasar azaltıldı: {damage}."
            }
        }
    };

    #endregion

    #endregion

    #region MediumAttack

    #region Success
    public static Dictionary<EnumLanguage, List<string>> ListSuccessMediumAttackMessage = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
            {
                "Você desfere um golpe firme e causa dano considerável! (-{damage})",
                "Sua arma crava no inimigo com força moderada. Dano médio: {damage}.",
                "Um ataque certeiro pega o inimigo desprevenido. Dano: {damage}.",
                "Com precisão e potência, você atinge o alvo. Dano causado: {damage}.",
                "Seu ataque médio acerta em cheio — o inimigo sente o impacto. (-{damage})"
            } },
        { EnumLanguage.English, new List<string>
            {
                "You land a solid blow and deal considerable damage! (-{damage})",
                "Your weapon hits the enemy with moderate force. Medium damage: {damage}.",
                "A well-placed strike catches the enemy off guard. Damage: {damage}.",
                "With precision and power, you strike your target. Damage dealt: {damage}.",
                "Your medium attack hits squarely — the enemy feels the impact. (-{damage})"
            } },
        { EnumLanguage.Turkish, new List<string>
            {
                "Sağlam bir darbe indirirsin ve ciddi hasar verirsin! (-{damage})",
                "Silahın, düşmana orta şiddetle çarpar. Orta seviye hasar: {damage}.",
                "İyi hedeflenmiş bir saldırı düşmanı hazırlıksız yakalar. Hasar: {damage}.",
                "Kesinlik ve güçle hedefini vurursun. Verilen hasar: {damage}.",
                "Orta saldırın tam isabet eder — düşman darbeyi hisseder. (-{damage})"
            } }
    };
    #endregion

    #region Failed
    public static Dictionary<EnumLanguage, List<string>> ListFailMediumAttackMessage = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
            {
                "Você erra o ataque médio — força sem precisão é inútil!",
                "Seu golpe potente passa direto pelo inimigo!",
                "Você tenta um ataque mais forte, mas o inimigo desvia no último segundo.",
                "O ataque foi com vontade, mas sem mira — falha total.",
                "Seu esforço é grande, mas o resultado... decepcionante. Nada de dano."
            } },
        { EnumLanguage.English, new List<string>
            {
                "You miss the medium attack — strength without aim is worthless!",
                "Your powerful strike goes right past the enemy!",
                "You go for a stronger hit, but the enemy dodges at the last second.",
                "The attack had force, but no direction — total miss.",
                "You put in the effort, but the result... disappointing. No damage done."
            } },
        { EnumLanguage.Turkish, new List<string>
            {
                "Orta saldırın ıskaladı — güç, hedef olmadan işe yaramaz!",
                "Güçlü saldırın düşmanın yanından geçip gider!",
                "Daha sert bir darbe denedin ama düşman son anda kaçtı.",
                "Saldırı güçlüydü ama yönsüzdü — tam bir fiyasko.",
                "Çaba vardı ama sonuç... hayal kırıklığı. Hasar yok."
            } }
    };
    #endregion

    #region EnemyDefense
    public static Dictionary<EnumLanguage, List<string>> ListEnemyDefenseMediumMessages = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
            {
                "O ataque médio atinge o inimigo, mas ele consegue bloquear parte do dano. (-{damage})",
                "Você acerta com força moderada, mas o inimigo reduz o impacto com a defesa. {damage}",
                "O inimigo levanta o escudo a tempo e mitiga parte do ataque médio. {damage}",
                "Seu golpe médio é parcialmente absorvido. Dano reduzido: {damage}.",
                "Você pressiona com força, mas o inimigo resiste. Só parte do golpe atinge. (-{damage})"
            }
        },
        { EnumLanguage.English, new List<string>
            {
                "Your medium attack lands, but the enemy blocks part of the damage. (-{damage})",
                "You strike with moderate force, but the enemy softens the blow. {damage}",
                "The enemy raises a shield just in time to absorb part of the medium attack. {damage}",
                "Your medium strike is partially absorbed. Damage reduced: {damage}.",
                "You push hard, but the enemy resists. Only part of the strike hits. (-{damage})"
            }
        },
        { EnumLanguage.Turkish, new List<string>
            {
                "Orta saldırın isabet eder ama düşman hasarın bir kısmını engeller. (-{damage})",
                "Orta kuvvette bir darbe indirirsin, ama düşman darbenin etkisini azaltır. {damage}",
                "Düşman zamanında kalkanını kaldırır ve saldırının bir kısmını emer. {damage}",
                "Orta saldırın kısmen emilir. Azaltılan hasar: {damage}.",
                "Güçlü itersin, ama düşman direnç gösterir. Saldırının sadece bir kısmı geçer. (-{damage})"
            }
        }
    };

    #endregion

    #endregion

    #region HeavyAttack

    #region Success
    public static Dictionary<EnumLanguage, List<string>> ListSuccessHeavyAttackMessage = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
            {
                "Você libera toda sua força em um golpe devastador! (-{damage})",
                "Seu ataque pesado atinge o inimigo com brutalidade. Dano massivo: {damage}.",
                "Com um grito de guerra, você desfere um golpe esmagador! Dano: {damage}.",
                "O chão treme com o impacto do seu ataque poderoso. (-{damage})",
                "Um ataque violento acerta em cheio — o inimigo cambaleia. Dano: {damage}."
            } },
        { EnumLanguage.English, new List<string>
            {
                "You unleash your full strength in a devastating blow! (-{damage})",
                "Your heavy attack strikes the enemy with brutal force. Massive damage: {damage}.",
                "With a war cry, you land a crushing hit! Damage: {damage}.",
                "The ground shakes as your powerful strike lands. (-{damage})",
                "A violent attack hits hard — the enemy staggers. Damage: {damage}."
            } },
        { EnumLanguage.Turkish, new List<string>
            {
                "Tüm gücünü serbest bırakırsın ve yıkıcı bir darbe indirirsin! (-{damage})",
                "Ağır saldırın düşmana acımasızca çarpar. Büyük hasar: {damage}.",
                "Savaş çığlığıyla ezici bir darbe indirirsin! Hasar: {damage}.",
                "Güçlü saldırının darbesiyle yer sarsılır. (-{damage})",
                "Şiddetli bir saldırı isabet eder — düşman sendelemeye başlar. Hasar: {damage}."
            } }
    };
    #endregion

    #region Failed
    public static Dictionary<EnumLanguage, List<string>> ListFailHeavyAttackMessage = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
            {
                "Você prepara um ataque poderoso, mas erra feio!",
                "O inimigo escapa por pouco — todo seu esforço foi em vão.",
                "Você perde o equilíbrio ao tentar um golpe pesado. Falha total.",
                "Seu ataque foi forte... pena que contra o vento.",
                "Você avança com tudo, mas o inimigo já não está mais lá."
            } },
        { EnumLanguage.English, new List<string>
            {
                "You prepare a powerful strike, but miss horribly!",
                "The enemy narrowly escapes — all your effort wasted.",
                "You lose balance trying a heavy blow. Total failure.",
                "The attack was strong... too bad it only hit the air.",
                "You charge with full force, but the enemy's already gone."
            } },
        { EnumLanguage.Turkish, new List<string>
            {
                "Güçlü bir darbe hazırlarsın ama fena halde ıskalarsın!",
                "Düşman kıl payı kurtulur — tüm çaban boşa gider.",
                "Ağır saldırıyı denerken dengen bozulur. Tam bir başarısızlık.",
                "Saldırı güçlüydü... ama sadece havayı biçtin.",
                "Tüm gücünle atılırsın ama düşman çoktan kaçmıştır."
            } }
    };
    #endregion

    #region EnemyDefense
    public static Dictionary<EnumLanguage, List<string>> ListEnemyDefenseHeavyMessages = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
            {
                "Mesmo sendo um ataque poderoso, o inimigo consegue defender parte do impacto. (-{damage})",
                "Seu ataque pesado colide com a defesa do inimigo, que reduz o dano. {damage}.",
                "O inimigo aguenta firme o golpe brutal e mitiga parte do estrago. {damage}.",
                "Você acerta com tudo, mas o inimigo bloqueia parte da força. Dano reduzido: {damage}.",
                "A defesa do inimigo segura parte do seu golpe devastador. (-{damage})"
            }
        },
        { EnumLanguage.English, new List<string>
            {
                "Even with a powerful attack, the enemy manages to block part of the blow. (-{damage})",
                "Your heavy strike hits, but the enemy reduces the damage with a solid defense. {damage}",
                "The enemy withstands the brute force and mitigates part of the damage. {damage}",
                "You hit with all your might, but part of it is blocked. Reduced damage: {damage}.",
                "The enemy’s defense holds against part of your devastating blow. (-{damage})"
            }
        },
        { EnumLanguage.Turkish, new List<string>
            {
                "Güçlü saldırına rağmen düşman darbenin bir kısmını engeller. (-{damage})",
                "Ağır darben isabet eder ama düşman sağlam bir savunmayla hasarı azaltır. {damage}",
                "Düşman tüm gücüne karşı koyar ve hasarın bir kısmını hafifletir. {damage}",
                "Tüm gücünle vurursun ama savunmayla bir kısmı durdurulur. Azaltılan hasar: {damage}.",
                "Düşmanın savunması yıkıcı darbenin bir kısmını engeller. (-{damage})"
            }
        }
    };

    #endregion

    #endregion

    #region Defense

    #region Success
    public static Dictionary<EnumLanguage, List<string>> ListSuccessDefenseMessage = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
            {
                "Você ergue sua guarda no momento certo e reduz o impacto do ataque! (-{reducedDamage})",
                "Seu escudo ou instinto bloqueia metade do golpe. Dano reduzido: {reducedDamage}.",
                "Com reflexos rápidos, você minimiza o impacto. Apenas {reducedDamage} de dano recebido.",
                "Você defende com precisão e sente apenas parte da dor. (-{reducedDamage})",
                "O ataque acerta, mas sua defesa foi eficaz. Dano parcial: {reducedDamage}."
            } },
        { EnumLanguage.English, new List<string>
            {
                "You raise your guard just in time and reduce the attack's impact! (-{reducedDamage})",
                "Your shield or instinct blocks half the strike. Damage reduced: {reducedDamage}.",
                "Quick reflexes minimize the hit. Only {reducedDamage} damage taken.",
                "You defend precisely and feel only part of the pain. (-{reducedDamage})",
                "The attack lands, but your defense was effective. Partial damage: {reducedDamage}."
            } },
        { EnumLanguage.Turkish, new List<string>
            {
                "Tam zamanında savunmaya geçersin ve saldırının etkisini azaltırsın! (-{reducedDamage})",
                "Kalkanın ya da içgüdülerin darbenin yarısını engeller. Hasar azaltıldı: {reducedDamage}.",
                "Hızlı reflekslerle darbeyi en aza indirirsin. Sadece {reducedDamage} hasar alındı.",
                "Savunman yerinde — acının yalnızca yarısını hissedersin. (-{reducedDamage})",
                "Saldırı isabet eder ama savunman etkiliydi. Kısmi hasar: {reducedDamage}."
            } }
    };
    #endregion

    #region Useless
    public static Dictionary<EnumLanguage, List<string>> ListUselessDefenseMessage = new Dictionary<EnumLanguage, List<string>>
    {
        { EnumLanguage.Portuguese, new List<string>
            {
                "Você se defende... de nada. O inimigo nem atacou.",
                "Você levanta a guarda, mas o golpe nunca veio.",
                "Sua defesa foi impecável... contra o vento.",
                "Você espera um ataque que nunca acontece.",
                "Você se protege instintivamente, mas foi um alarme falso."
            } },
        { EnumLanguage.English, new List<string>
            {
                "You defend... against nothing. The enemy didn't attack.",
                "You raise your guard, but the strike never comes.",
                "Your defense was flawless... against the wind.",
                "You brace for an attack that never arrives.",
                "You instinctively protect yourself, but it was a false alarm."
            } },
        { EnumLanguage.Turkish, new List<string>
            {
                "Savunmaya geçersin... ama saldırı yoktur. Düşman hamle yapmadı.",
                "Kendini korursun ama darbe hiç gelmez.",
                "Savunman kusursuzdu... ama rüzgara karşı.",
                "Hiç gerçekleşmeyen bir saldırıya hazırlanırsın.",
                "İçgüdüsel olarak korunursun, ama yanlış alarmdı."
            } }
    };
    #endregion

    #endregion

    public static Dictionary<EnumLanguage, List<string>> VictoryMessages = new()
    {
        { EnumLanguage.Portuguese, new()
            {
                "Você derrotou o inimigo!",
                "O inimigo caiu diante da sua força!",
                "Com um último golpe, o inimigo é vencido!",
                "Vitória! O inimigo não se levanta mais.",
                "O combate termina — o inimigo foi derrotado!"
            }
        },
        { EnumLanguage.English, new()
            {
                "You have defeated the enemy!",
                "The enemy falls before your strength!",
                "With a final strike, the enemy is vanquished!",
                "Victory! The enemy shall rise no more.",
                "The battle ends — the enemy is defeated!"
            }
        },
        { EnumLanguage.Turkish, new()
            {
                "Düşmanı yendin!",
                "Düşman gücünün karşısında yere serildi!",
                "Son darbenle düşman yok oldu!",
                "Zafer! Düşman bir daha kalkamayacak.",
                "Savaş bitti — düşman mağlup edildi!"
            }
        }
    };

    public static Dictionary<EnumLanguage, List<string>> VictoryTitleMessages = new()
    {
        { EnumLanguage.Portuguese, new()
            {
                "Vitória!",
                "Conquistado!",
                "Triunfo!",
                "Missão cumprida!",
                "Você venceu!"
            }
        },
        { EnumLanguage.English, new()
            {
                "Victory!",
                "You won!",
                "Triumph!",
                "Success!",
                "Mission complete!"
            }
        },
        { EnumLanguage.Turkish, new()
            {
                "Zafer!",
                "Kazandın!",
                "Başarı!",
                "Görev tamamlandı!",
                "Triumf!"
            }
        }
    };

    public static Dictionary<EnumLanguage, List<string>> DefeatMessages = new()
    {
        { EnumLanguage.Portuguese, new()
            {
                "O inimigo te derrotou!",
                "Você caiu em combate... o inimigo venceu.",
                "Derrotado! O inimigo prevaleceu desta vez.",
                "Você não resistiu — o inimigo saiu vitorioso.",
                "Fim de jogo. O inimigo foi mais forte."
            }
        },
        { EnumLanguage.English, new()
            {
                "The enemy has defeated you!",
                "You fell in battle... the enemy has won.",
                "Defeated! The enemy prevailed this time.",
                "You couldn’t hold on — the enemy is victorious.",
                "Game over. The enemy proved stronger."
            }
        },
        { EnumLanguage.Turkish, new()
            {
                "Düşman seni yendi!",
                "Savaşta yenildin... düşman galip geldi.",
                "Mağlubiyet! Bu sefer düşman kazandı.",
                "Dayanamadın — düşman zaferle çıktı.",
                "Oyun bitti. Düşman daha güçlüydü."
            }
        }
    };

    public static Dictionary<EnumLanguage, List<string>> DefeatTitleMessages = new()
    {
        { EnumLanguage.Portuguese, new()
            {
                "Derrota...",
                "Você perdeu.",
                "Fim...",
                "Fracasso!",
                "Tudo acabou..."
            }
        },
        { EnumLanguage.English, new()
            {
                "Defeat...",
                "You lost.",
                "The end...",
                "Failure!",
                "All is lost..."
            }
        },
        { EnumLanguage.Turkish, new()
            {
                "Mağlubiyet...",
                "Kaybettin.",
                "Son...",
                "Başarısızlık!",
                "Her şey bitti..."
            }
        }
    };



    #endregion
}