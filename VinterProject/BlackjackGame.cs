using System;

public class BlackjackGame
{
    private Deck deck;/*Referens till en kortlek (Deckklassen)*/
    private Player player;/*Referens till spelaren (Playerklassen)*/
    private Dealer dealer;/*Referars till dealern (Dealerklassen)*/

    public BlackjackGame()
    {
        deck = new Deck();/*Skapar en ny kortlek när spelet startar*/
        player = new Player("Spelare");/*Skapar en ny spelare med namnet Spelare*/
        dealer = new Dealer();/*Skapar en ny dealer (huset)*/
    }

    public void StartGame()
    {
        Console.WriteLine("Välkommen till Elias BlackJack! Kom ihåg att huset vinner alltid i slutet av dagen.");

        deck.Shuffle();/*Blandar kortleken */

        /*Delar ut två kort till spelaren och två kort till dealern (huset)*/
        player.AddCard(deck.Deal());
        dealer.AddCard(deck.Deal());
        player.AddCard(deck.Deal());
        dealer.AddCard(deck.Deal());

        DisplayHands();/*Visar händerna (korten) för spelaren och dealern*/

        PlayerTurn(); /*Spelarens tur att köra */
        DealerTurn(); /* Husets tur att köra */

        DetermineWinner();/*Avgör vinnaren och visar resultatet*/

    }

    private void PlayerTurn()
    {
        while (true)/*Loopar tills spelaren väljer att stanna*/
        {
            player.DisplayScore(); /*Visar spelarens aktuella poäng*/

            Console.Write("Ett kort till? (Slå) eller stanna (stanna)? ");
            string choice = Console.ReadLine().ToLower(); /*Läser in spelarens val och konverterar till gemener*/

            if (choice == "slå") /*Om spelaren väljer att ta ett till kort*/
            {
                player.AddCard(deck.Deal()); /*Spelaren får ett till kort*/
                DisplayHands(); /*Visar uppdaterade korten på handen */

                if (player.CalculateScore() > 21) /*Om spelaren går över 21 (Bust)*/
                {
                    Console.WriteLine("Bust! Du förlorar."); /*Meddelande om att spelaren förlorar */
                    return;
                }
            }
            else if (choice == "stanna") /*Om spelaren väljjer att stanna*/
            {
                Console.WriteLine("Spelare stannar."); /*Meddelande om att spelaren stannar*/
                break;
            }
        }
    }
    private void DisplayHands()
    {
        player.Display(); /*Visar spelarens kort på handen*/
        dealer.DisplayPartial(); /*Visar en del av dealerns (husets) kort*/
    }

    private void DealerTurn()
    {
        Console.WriteLine("\nHusets tur:");

        while (dealer.CalculateScore() < 17) /*Dealern (huset) fortsätter att ta kort tills poängen når minst 17*/
        {
            dealer.AddCard(deck.Deal());
            dealer.DisplayPartial(); /*Visar bara en del av dealerns (husets) kort*/
        }

        Console.WriteLine("Huset stannar.");  /*Meddelande om att dealern (huset) stannar*/
    }

    private void DetermineWinner()
    {
        Console.WriteLine("\nResultatet är klart! Se här nere.");

        DisplayHands(); /*Visar slutliga korten för spelaren och dealern */

        int playerScore = player.CalculateScore();/*Beräknar slutpoängen för spelaren*/
        int dealerScore = dealer.CalculateScore();/*Beräknar slutpoängen för dealern alltså huse*/

        if (playerScore > 21) /*Om spelaren har över 21 poäng (Bust) */
        {
            Console.WriteLine("Spelare bustar. Huset vinner.");
        }
        else if (dealerScore > 21) /*Om dealeare huset har över 21 poäng Bust*/
        {
            Console.WriteLine("Huset bustar. Spelare vinner.");
        }
        else if (playerScore > dealerScore) /* Om spelaren har högre poäng än dealern */
        {
            Console.WriteLine("Spelare vinner!");
        }
        else if (playerScore < dealerScore) /* Om dealern har högre poäng än spelaren */
        {
            Console.WriteLine("Huset vinner.");
        }
        else
        {
            Console.WriteLine("Det är lika!"); /*Om det blir oavgjort (båda har samma poäng)*/
        }
    }

    
}


