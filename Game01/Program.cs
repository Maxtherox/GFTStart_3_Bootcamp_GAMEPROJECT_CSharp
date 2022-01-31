using System;
using Game01.Entities;


namespace Game01
{
    class Program
    {
      

        static void Main(string[] args)
        {
              
         Cristaos Edmundo = new Cristaos ("Edmundo I ","Cristão",  "20");
         
         Vikings Ragnar = new Vikings ("Ragnar Lothbrok", "Vikinger", "21");

         System.Console.WriteLine("O Duelo de duas lendas se iniciara, de um lado temos: " + "\n"+  Edmundo + "\nDo outro lado nós temos: " + "\n" + Ragnar + "\nQue a luta dessas duas lendas comece!" );

        //System.Console.WriteLine(Ragnar);
       //System.Console.WriteLine(Aella);
       

        Console.WriteLine(Edmundo.Atacar());
        Console.WriteLine(Ragnar.Atacar());

        if( Ragnar.LastHit == Edmundo.LastHit){
          Console.WriteLine (" Empate, ambos os guerreiros deram o dano de: " + Ragnar.LastHit);
         } 
         else if ( Ragnar.LastHit > Edmundo.LastHit )
         {
         Edmundo.ReceberDano(Ragnar.LastHit - Edmundo.Health);
             Console.WriteLine(Ragnar.nome + " Venceu esse round");
        }
        else
        {
            Ragnar.ReceberDano(Edmundo.LastHit - Ragnar.Health);
            Console.WriteLine(Edmundo.nome + " Venceu esse round");
                      
        }
   
        System.Console.WriteLine("Fim do duelo.");
     

        }
    }
}