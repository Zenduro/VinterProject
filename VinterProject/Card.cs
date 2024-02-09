public class Card /*Koden för alla Korten alltså, här är koden för att kort Blackjack spel ska veta vad för nummer de är.*/ 
{
    public string Suit { get; set; } /*Representerar suit för ett kort t.ex Hearts, dimonds etc*/
    public string Rank { get; set; } /*Representerar Rank för ett kort t.ex ACE eller king*/

    public Card(string suit, string rank)
    {
        Suit = suit; /*Tilldelar kortet för dess Suit symbol det är, som Dimonds eller Hearth. vilket är Diamant elelr spader osv*/
        Rank = rank; /*Tilldelar kortet för dess Rank det är som ACE eller King*/
    }

    public int GetValue()
    {
        if (Rank == "Ace")  /*Om kortet är ACE*/
            return 11; /*Returnerar värdet 11, eftersom ACE kan vara värdte 11 eller 1*/ 
        if (Rank == "King" || Rank == "Queen" || Rank == "Jack") /*Koden för att säga att King, Queen, Jack är för nummer, låter bättre på Engelska*/
            return 10; /*Koden för att säga vad de är alltså 10*/
        return int.Parse(Rank); /*Returnerar värdet för övriga kort genom att konvertera Rank till en siffra*/
    }
}










