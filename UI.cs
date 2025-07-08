namespace PetVirtual
{
    public class UI
    {
        public static void exibeATelaInicial()
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("".PadRight(20, '━'));
            Console.WriteLine(" 🐾 PET VIRTUAL 🐾");
            Console.WriteLine("".PadRight(20, '━'));
            Console.WriteLine();
            Console.WriteLine("Seja muito bem-vindo ao universo dos Pets Virtuais!");
        }

        public static PetTipo escolhaOTipoDoPet()
        {
            Console.WriteLine("\nPara começar, escolha o tipo do seu pet:");
            Console.WriteLine("[1] 🐶 Cachorro \n[2] 🐱 Gato \n[3] 🐰 Coelho \n[4] 🐹 Hamster \n[5] 🐦 Pássaro \n[6] 🐠 Peixe \n[7] 🐢 Tartaruga");

            while (true)
            {
                Console.Write("Tipo de pet: ");

                if (int.TryParse(Console.ReadLine().Trim(), out int escolhaId) && Enum.IsDefined(typeof(PetTipo), escolhaId))
                {
                    return (PetTipo)escolhaId;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida. Por favor, digite um número entre 1 e 7.");
                    Console.ResetColor();
                }
            }
        }
        public static string escolhaONomeDoPet()
        {
            Console.WriteLine("\nÓtima escolha! Agora, diga como deseja chamá-lo:");
            Console.Write("→ Nome do pet: ");
            return Console.ReadLine().Trim();
        }


        public static string ObterArteDoPet(PetTipo tipo)
        {
            switch (tipo)
            {
                case PetTipo.Cachorro:
                    return @"
 /^ ^\
/ 0 0 \
V\ Y /V
 / - \
 |    \
 || (__)

";
                case PetTipo.Gato:
                    return @"
 /\_/\  
( o.o ) 
 > ^ < 
";
                case PetTipo.Coelho:
                    return @"
 (\_/)
 (•_•)
 / > \
";
                case PetTipo.Hamster:
                    return @"
(\__/) 
(•ㅅ•) 
 / 　 づ

";
                case PetTipo.Passaro:
                    return @"
  \
 (o>
 //\
 V_/_ 

";

                case PetTipo.Peixe:
                    return @"
><(((º> 
";

                case PetTipo.Tartaruga:
                    return @"
     _____     ____
   /      \  |  o | 
  |        |/ ___\| 
  |_________/     
  |_|_| |_|_|
";

                default:
                    return "Arte não encontrada.";
            }
        }

        public static void exibePetInicial(Pet pet)
        {
            Console.WriteLine("\n".PadRight(30, '━'));
            Console.WriteLine(" Conheça seu novo companheiro!");
            Console.WriteLine("".PadRight(30, '━'));
            Console.WriteLine(UI.ObterArteDoPet(pet.Tipo));
            Console.WriteLine();
            Console.WriteLine($"Este é {pet.Nome}, seu novo {pet.Tipo.ToString()} 🧡");
            Console.WriteLine($"[Fome {pet.Fome}] [Felicidade: {pet.Felicidade}] [Energia: {pet.Energia}] [Higiene: {pet.Higiene}] [Saúde: {pet.Saude}]");
            Console.WriteLine("Cuide bem dele e viva grandes aventuras!");
        }
        public static void Aguarda()
        {
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
        }

        public static int obtemProximaAcao()
        {
            Console.WriteLine();
            Console.WriteLine("".PadRight(30, '━'));
            Console.WriteLine(" O que você deseja fazer? ");
            Console.WriteLine("".PadRight(30, '━'));
            Console.WriteLine();
            Console.WriteLine("[1] 🍖 Alimentar \n[2] 🎾 Brincar \n[3] 💤 Dormir \n[4] 🛁 Dar banho \n[5] 🏥 Levar ao veterinário");
            Console.Write("Escolha uma opção: ");
            return int.Parse(Console.ReadLine().Trim());
        }

public static void ExibeMensagemDaAcao(string acao, Pet pet)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine();

    switch (acao.ToLower())
    {
        case "alimentar":
            Console.WriteLine($"🍽️ {pet.Nome} comeu com alegria e parece mais satisfeito!");
            break;
        case "brincar":
            Console.WriteLine($"🎉 {pet.Nome} se divertiu muito! Agora ele está mais feliz, mas um pouco cansado.");
            break;
        case "dormir":
            Console.WriteLine($"😴 {pet.Nome} teve um bom descanso e acordou renovado!");
            break;
        case "dar banho":
            Console.WriteLine($"🛁 {pet.Nome} está limpinho e cheirando bem, apesar de não ter gostado muito do banho.");
            break;
        case "levar ao veterinário":
            Console.WriteLine($"🏥 {pet.Nome} foi ao veterinário e está mais saudável, mesmo que tenha reclamado um pouco!");
            break;
        default:
            Console.WriteLine($"{pet.Nome} parece confuso... 🤔");
            break;
    }

    Console.ResetColor();
}

        public static void ExibeEstadoAposAcao(string acao, Pet pet)
        {
            Console.WriteLine();
            UI.Aguarda();
            Console.WriteLine();
            Console.WriteLine("".PadRight(30, '━'));
            Console.WriteLine($" 🐾 Você escolheu: {acao}! ");
            Console.WriteLine("".PadRight(30, '━'));
            Console.WriteLine(UI.ObterArteDoPet(pet.Tipo));
            ExibeMensagemDaAcao(acao, pet);
            Console.WriteLine();
            Console.WriteLine($"[Fome {pet.Fome}] [Felicidade: {pet.Felicidade}] [Energia: {pet.Energia}] [Higiene: {pet.Higiene}] [Saúde: {pet.Saude}]");

        }

        public static void ExibeTelaDeMorte(Pet pet)
        {
            Console.WriteLine("".PadRight(30, '━'));
            Console.WriteLine($" 💀 GAME OVER 💀 ");
            Console.WriteLine("".PadRight(30, '━'));
            Console.WriteLine();
            Console.WriteLine($"Infelizmente, a saúde de {pet.Nome} chegou a 0.");
            Console.WriteLine("Ele foi para o céu dos pets 🕊️");
            Console.WriteLine("Obrigado por jogar. Cuide bem do próximo! 💔");
        }

    }

}