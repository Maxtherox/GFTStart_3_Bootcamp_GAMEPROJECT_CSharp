namespace Game01.Entities
{
    public class Vikings : Humanos
    {
        public Vikings(string nome, string classeChar, string idade) : base(nome, classeChar, idade)
        {
        }
         public override string Atacar()
        {
        Random dado = new Random();
        int DanoAtk = this.Nivel + dado.Next(1,100);
        this.LastHit = DanoAtk;

        return this.nome + " Atacou com seu machado e causou: " + DanoAtk + " de dano bruto";

        }

        public string Atacar(int bonus){
            Random dado = new Random();
            int danoAtk = this.Nivel +  dado.Next(1,100) + bonus;

            this.LastHit = danoAtk;

            return this.nome + " Desferiu um golpe crítico com seu machado e causou " + danoAtk + " de dano critico";
        }

    }
}