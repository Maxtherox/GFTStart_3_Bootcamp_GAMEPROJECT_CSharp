namespace Game01.Entities
{
    public class Cristaos : Humanos
    {
        public Cristaos (string nome, string classeChar, string idade) : base(nome, classeChar, idade){

        }
        
        public override string Atacar()
        {
        Random dado = new Random();
        int DanoAtk = this.Nivel + dado.Next(1,100);
        this.LastHit = DanoAtk;

        return this.nome + " Atacou com sua espada e casou: " + DanoAtk + " de dano de corte";


        }

         public string Atacar(int bonus){
            Random dado = new Random();
            int danoAtk = this.Nivel +  dado.Next(1,100) + bonus;

            this.LastHit = danoAtk;

            return this.nome + " Atacou com sua espada ungida e causou: " + danoAtk + " de dano sagrado";
        }
    }
}