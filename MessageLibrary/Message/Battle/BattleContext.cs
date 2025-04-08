using MessageLibrary.Enum;

namespace MessageLibrary.Message.Battle
{
    public class BattleContext
    {
        public static Dictionary<EnumLanguage, List<string>> WelcomeMessage = new Dictionary<EnumLanguage, List<string>>
        {
            { EnumLanguage.Portuguese, new List<string>{
                "Bem-vindo, aventureiro! Qual é o seu nome?",
                "Você desperta em uma terra mágica... diga-nos, como devemos chamá-lo?",
                "A jornada começa agora. Mas antes, qual é o seu nome, bravo herói?",
                "Seja bem-vindo ao reino encantado! Diga seu nome para que todos saibam quem é você.",
                "Uma nova lenda está prestes a nascer. Qual é o nome que ecoará pelas eras?"
            } } ,
            { EnumLanguage.English, new List<string>{
                "Welcome, adventurer! What is your name?",
                "You awaken in a magical land... tell us, what should we call you?",
                "The journey begins now. But first, brave hero, what is your name?",
                "Welcome to the enchanted realm! Speak your name so all may know you.",
                "A new legend is about to begin. What name shall echo through the ages?"
            } },
            { EnumLanguage.Turkish, new List<string>{
                "Hoş geldin, maceraperest! Adın ne?",
                "Büyülü bir diyarda uyanıyorsun... Söyle bakalım, sana nasıl hitap edelim?",
                "Yolculuk şimdi başlıyor. Ama önce, cesur kahraman, adın nedir?",
                "Büyülü krallığa hoş geldin! Herkes seni tanısın diye adını söyle.",
                "Yeni bir efsane doğmak üzere. Hangi isimle anılacaksın?"
            } }
        };

        public static Dictionary<EnumLanguage, List<string>> StartGameMessage = new Dictionary<EnumLanguage, List<string>>
        {
            {
                EnumLanguage.Portuguese, new List<string>
                {
                    "Belo nome, jogadô! Vamos começar?\n",
                    "Nome digno de um herói! Preparado para o desafio?\n",
                    "Hehe... gostei do nome. Bora pra batalha?\n",
                    "Nome poderoso! Que comecem os combates!\n",
                    "Pronto para escrever sua lenda, jogadô?\n"
                }
            },
            {
                EnumLanguage.English, new List<string>
                {
                    "Nice name, adventurer! Shall we begin?\n",
                    "A name worthy of a hero! Ready for the challenge?\n",
                    "Heh... I like your name. Let’s head to battle!\n",
                    "Powerful name! Let the fight begin!\n",
                    "Are you ready to write your legend, adventurer?\n"
                }
            },
            {
                EnumLanguage.Turkish, new List<string>
                {
                    "Güzel isim, maceraperest! Başlayalım mı?\n",
                    "Kahramana yakışır bir isim! Mücadeleye hazır mısın?\n",
                    "Hehe... ismi beğendim. Savaşa gidelim mi?\n",
                    "Güçlü bir isim! Savaş başlasın!\n",
                    "Efsaneni yazmaya hazır mısın, maceraperest?\n"
                }
            }
        };


        public static Dictionary<EnumLanguage, List<string>> PlayerChoose = new Dictionary<EnumLanguage, List<string>>
        {
            { EnumLanguage.Portuguese, new List<string>{
                "Prepare-se! Um oponente do seu nível está à sua espera!\nVocê pode se defender, se curar ou atacar (leve, médio ou pesado). Uma ação por turno!",
                "Um inimigo à altura se aproxima...\nNo seu turno, escolha entre defesa, cura ou um ataque (leve, médio ou pesado).",
                "Você sente a presença de um adversário igualmente forte!\nDefenda-se, recupere vida ou ataque com intensidade. Apenas uma ação por vez!",
                "O campo de batalha está pronto. Um rival digno aguarda!\nVocê pode usar um ataque leve, médio, pesado, curar-se ou se defender — escolha sabiamente.",
                "Seu desafio começa agora contra um inimigo do seu nível!\nEm cada turno, você tem direito a apenas uma ação: defender, curar ou atacar."
            } } ,
            { EnumLanguage.English, new List<string>{
                "Get ready! An opponent of equal strength awaits you!\nYou may defend, heal, or attack (light, medium, or heavy) — one action per turn!",
                "A worthy enemy approaches...\nOn your turn, choose to defend, heal, or launch an attack (light, medium, or heavy).",
                "You sense the presence of a foe as strong as you!\nDefend, recover, or strike back — one move per round!",
                "The battlefield is set. A rival on your level stands before you!\nChoose carefully: light, medium or heavy attack, heal, or defend.",
                "Your challenge begins now against a matching opponent!\nEach turn, you may perform one action only: defend, heal, or attack."
            } },
            { EnumLanguage.Turkish, new List<string>{
                "Hazır ol! Gücüne denk bir rakip seni bekliyor!\nSavun, iyileş veya saldır (hafif, orta, ağır) — her turda sadece bir hamle yapabilirsin!",
                "Sana denk bir düşman yaklaşıyor...\nSıra sende: savunma, iyileşme ya da saldırı (hafif, orta, ağır) seçeneklerinden birini seç.",
                "Senin kadar güçlü bir rakibin varlığını hissediyorsun!\nKendini savun, iyileştir ya da saldır. Ama her turda yalnızca bir eylem hakkın var!",
                "Savaş alanı hazır. Sana denk bir rakip karşında!\nHer turda yalnızca bir hamle yapabilirsin: savun, iyileş ya da hafif, orta veya ağır saldır.",
                "Meydan okuma başlıyor! Rakibin gücünle eşdeğer!\nTur başına sadece bir aksiyon seçebilirsin: savun, iyileş ya da saldır."
            } }
        };

        public static Dictionary<EnumLanguage, List<string>> WrongAction = new Dictionary<EnumLanguage, List<string>>
        {
            { EnumLanguage.Portuguese, new List<string>{
                "Ei, tente digitar corretamente, por favor!",
                "Hmm... essa entrada não parece válida. Tente de novo!",
                "Digitado incorretamente, vou falar pro Minardi diminuir sua nota!",
                "Não entendi isso... tente escrever corretamente!",
                "Por favor, digite uma opção válida!"
            } } ,
            { EnumLanguage.English, new List<string>{
                "Hey, please type it correctly!",
                "Hmm... that doesn't seem valid. Try again!",
                "Oops! Something’s off. Can you try once more?",
                "Didn’t quite catch that. Please enter it properly.",
                "Please enter a valid option!"
            } },
            { EnumLanguage.Turkish, new List<string>{
                "Hey, lütfen doğru yaz!",
                "Hmm... bu geçerli görünmüyor. Tekrar dene!",
                "Hata! Bir şeyler yanlış. Bir kez daha dener misin?",
                "Bunu anlayamadım. Lütfen doğru bir giriş yap!",
                "Geçerli bir seçenek gir lütfen!"
            } }
        };

        public static Dictionary<EnumLanguage, string> PressAnyKeyMessage = new Dictionary<EnumLanguage, string>
        {
            { EnumLanguage.Portuguese, "Aperte qualquer tecla para continuar." },
            { EnumLanguage.English, "Press any key to continue." },
            { EnumLanguage.Turkish, "Devam etmek için herhangi bir tuşa bas." }
        };

        public static Dictionary<EnumLanguage, string> LoadingMessage = new Dictionary<EnumLanguage, string>
        {
            { EnumLanguage.Portuguese, "Carregando" },
            { EnumLanguage.English, "Loading" },
            { EnumLanguage.Turkish, "Yükleniyor" }
        };


        public static Dictionary<EnumLanguage, string> MenuChoices = new Dictionary<EnumLanguage, string>
        {
            { EnumLanguage.Portuguese,
                @"Qual será sua escolha?

                1-	 Ataque leve
                2-	 Ataque Médio
                3-	 Ataque Pesado
                4-	 Usar Defesa
                5-	 Usar poção de Cura" },

            { EnumLanguage.English,
                @"What will be your choice?

                1-	 Light Attack
                2-	 Medium Attack
                3-	 Heavy Attack
                4-	 Use Defense
                5-	 Use Healing Potion" },

            { EnumLanguage.Turkish,
                @"Seçimin ne olacak?

                1-	 Hafif Saldırı
                2-	 Orta Seviye Saldırı
                3-	 Ağır Saldırı
                4-	 Savunma Kullan
                5-	 İyileştirme İksiri Kullan" }
        };

        public static Dictionary<EnumLanguage, string> ArenaTitle = new Dictionary<EnumLanguage, string>
        {
            { EnumLanguage.Portuguese, "Arena Mortal" },
            { EnumLanguage.English, "Mortal Arena" },
            { EnumLanguage.Turkish, "Ölüm Arenası" }
        };
    }
}