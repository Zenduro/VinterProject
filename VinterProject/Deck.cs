using System;
using System.Collections.Generic;

public class Deck
{
    private List<Card> cards; /*En Privat lista för att lagra korten i kortleken*/

    public Deck()
    {
        cards = new List<Card>(); /*Skapar en ny lista för korten när en kortlek skapas*/
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" }; //Säger alla olika kort spalet ingår med, låter bättre på Engelska
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" }; //ALla nummer i spelet
                    /*Dessa nummer och Jack,Queen, King, Ace har ett nummer från Card klassen för att veta vad de är*/
        foreach (var suit in suits) /*Suits kommer ifrån Card.CS alltså andra klassen*/
        {
            foreach (var rank in ranks)  /*Rank kommer ifrån Card.CS för att göra det enklare*/
            {
                cards.Add(new Card(suit, rank));    /*Suit och Rank som sagt kommer ifrån andra klassen Card.CS*/
            }
        }
    }

    public void Shuffle()  /*Metod för att blanda kortleken och göra spelet slumpmässigt.*/
    {
        Random random = new Random(); 
        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            Card value = cards[k];
            cards[k] = cards[n];
            cards[n] = value;
        }
    }

    public Card Deal() /*Metod för att "deal" ett kort från kortleken, dvs ta de översta kortet det från kortleken*/
    {
        Card card = cards[0];
        cards.RemoveAt(0);
        return card; /*Returerar det "dealt" kortet*/
    }
}





