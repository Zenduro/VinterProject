class Program
{
    static void Main()
    {
        BlackjackGame game = new BlackjackGame();
        game.StartGame(); /*Program CS är vart jag börjar mina spel, alla andra koder är här från Blackjack game*/

        Console.WriteLine("\nKlicka på något för att stänga spelet."); /*Vart man skriver för att få spelaren att stänga fönstret*/
        Console.ReadKey(); 
    }
}






