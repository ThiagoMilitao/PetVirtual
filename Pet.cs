using System;

namespace PetVirtual
{
    public class Pet
    {
        public string Nome { get; private set; }
        public PetTipo Tipo { get; private set; }

        public int Fome { get; private set; }   
        public int Felicidade { get; private set; }
        public int Energia { get; private set; }      
        public int Higiene { get; private set; }
        public int Saude { get; private set; }      

        // verificar se o pet está vivo.
        public bool EstaVivo => this.Saude > 0;

        private const int MAX_VALOR = 100; // Valor máximo para os atributos
        private const int MIN_VALOR = 0;   // Valor mínimo para os atributos

        // CONSTRUTOR
        public Pet(PetTipo tipo, string nome)
        {
            this.Nome = nome;
            this.Tipo = tipo;
            this.Fome = 20;
            this.Felicidade = 80;
            this.Energia = 80;
            this.Higiene = 100;
            this.Saude = 100;
        }

        // AÇÕES DO JOGADOR

        public void Alimentar()
        {
            this.Fome -= 40;
            this.Felicidade += 5;
            this.Higiene -= 5;
            ClampValores();
        }

        public void Brincar()
        {
            this.Felicidade += 30;
            this.Energia -= 25;
            this.Fome += 20;
            this.Higiene -= 10;
            ClampValores();
        }

        public void Dormir()
        {
            this.Energia += 50;
            this.Fome += 25;
            this.Felicidade -= 5;
            ClampValores();
        }

        public void DarBanho()
        {
            this.Higiene += 60;
            this.Felicidade -= 20;
            ClampValores();
        }

        public void LevarAoVeterinario()
        {
            this.Saude += 50;
            this.Felicidade -= 30;
            ClampValores();
        }

        public void PassarOTempo()
        {
            this.Fome += 8;
            this.Energia -= 5;
            this.Felicidade -= 7;
            this.Higiene -= 4;

            if (this.Fome > 80) this.Saude -= 10;

            if (this.Higiene < 20) this.Saude -= 10;
            
            if (this.Felicidade < 20) this.Saude -= 5;

            if (this.Energia < 10) this.Saude -= 5;
            
            if (this.Fome < 20 && this.Felicidade > 80 && this.Energia > 80 && this.Higiene > 80)
            {
                this.Saude += 5;
            }

            ClampValores();
        }


        private void ClampValores()
        {
            this.Fome = Math.Max(MIN_VALOR, Math.Min(MAX_VALOR, this.Fome));
            this.Felicidade = Math.Max(MIN_VALOR, Math.Min(MAX_VALOR, this.Felicidade));
            this.Energia = Math.Max(MIN_VALOR, Math.Min(MAX_VALOR, this.Energia));
            this.Higiene = Math.Max(MIN_VALOR, Math.Min(MAX_VALOR, this.Higiene));
            this.Saude = Math.Max(MIN_VALOR, Math.Min(MAX_VALOR, this.Saude));
        }
    }
}