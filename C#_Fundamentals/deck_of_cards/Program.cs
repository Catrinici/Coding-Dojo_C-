using System;

namespace BlackJack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's play some BlackJack!");
            Deck MyDeck = new Deck();
            MyDeck.Shuffle();
            Player Nelu = new Player("Nelu");
            
            Nelu.Draw(MyDeck);
            Nelu.Draw(MyDeck);
            Nelu.Draw(MyDeck);
            Nelu.Draw(MyDeck);
            Nelu.Draw(MyDeck);
            Console.WriteLine(Nelu.Hand);
            
            Nelu.Discard(3);

            System.Console.WriteLine(Nelu.Hand);
            

            
            
        }
    }
}
