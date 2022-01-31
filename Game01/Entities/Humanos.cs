 using System;

namespace Game01.Entities
{
    public class Humanos
    {
        public Humanos (string nome, string classeChar, string idade){
            this.nome = nome;
            this.classeChar = classeChar;
            this.Nivel = 1;
            this.Health = 500;
            this.Mana = 10;
            this.idade = idade;

        }
        
        //propriedades

        
        public string nome { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public string idade { get; set; }
        public string classeChar { get; set; }

        public int Nivel { get; set; }

        public int LastHit { get; set; }

        public override string ToString()
        {
            return "Meu nome é: " + this.nome + "\n"
                    + "Meu nivel é: " + this.Nivel + "\n"
                    + "Minha vida atual é: " + this.Health + "\n"
                    + "Minha mana atual é: " + this.Mana + "\n"
                    + "Minha classe é: " + this.classeChar + "\n"
                    + "Minha idade é: " + this.idade;
        }

    public virtual string Atacar(){
        Random dado = new Random();
        int DanoAtk = this.Nivel + dado.Next(1,30);
        this.LastHit = DanoAtk;

        return this.nome + " Atacou com um soco e causou: " + DanoAtk + " de dano";
    }

    public void ReceberDano(int danoRecebido){
        this.Health = this.Health - danoRecebido;
        

    }

    }
}