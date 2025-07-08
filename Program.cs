// Arquivo: Program.cs

namespace PetVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.exibeATelaInicial();

            //Cria um pet
            Pet pet = new Pet(UI.escolhaOTipoDoPet(), UI.escolhaONomeDoPet());

            UI.exibePetInicial(pet);

            while (true)
            {
                int acao = UI.obtemProximaAcao();
                string acaoEscolhida = "";
                switch (acao)
                {
                    case 1:
                        pet.Alimentar();
                        acaoEscolhida = "Alimentar";
                        break;
                    case 2:
                        pet.Brincar();
                        acaoEscolhida = "Brincar";
                        break;
                    case 3:
                        pet.Dormir();
                        acaoEscolhida = "Dormir";
                        break;
                    case 4:
                        pet.DarBanho();
                        acaoEscolhida = "Dar banho";
                        break;
                    case 5:
                        pet.LevarAoVeterinario();
                        acaoEscolhida = "Levar ao Veterinário";
                        break;
                }

                pet.PassarOTempo();

                UI.ExibeEstadoAposAcao(acaoEscolhida, pet);

                if (!pet.EstaVivo)
                {
                    UI.ExibeTelaDeMorte(pet);
                    break;
                }

            }

            
        }
    }
}