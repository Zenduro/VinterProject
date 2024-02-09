using System;
using System.Collections.Generic;

public class Hand
{
    protected List<Card> cards; /*En skyddad lista som lagrar korten i handen*/

    public Hand()
    {
        cards = new List<Card>();  /*Skapar en ny lista för korten när en hand skapaaas */
    }

    public void AddCard(Card card)
    {
        cards.Add(card); /*Lägger till ett kort i handen*/
    }

    public void Clear()
    {
        cards.Clear(); /*Rensar alla kort från handen*/
    }

    public int CalculateScore() /*Kalkulerar poängen*/
    {
        int score = 0;  /*Lägger till värdet av varje kort i totalpoängen*/
        int numberOfAces = 0; /*Variabel för att räkna antalet ACE i handen*/

        foreach (var card in cards)
        {
            score += card.GetValue(); /*Får ett nummer antal vad man har*/
            if (card.Rank == "Ace")
            {
                numberOfAces++; /*Ökar med antalet ACE är om ett Ace hittas i Handenn*/
            }
        }

        while (score > 21 && numberOfAces > 0) /*Avgör ifall det är mindre 21 och avgör hur många av ACE det finns*/
        {
            score -= 10; /*Miskar poängen med 11 eller 1*/
            numberOfAces--;/*Nummer av ACE (11)*/
        }

        return score; /*Returerar poängen som är beräknad för handen*/
    }

    public void Display()
    {
        foreach (var card in cards)
        {
            Console.WriteLine($"{card.Rank} {card.Suit}"); /*Rank är ACE och Suits är Dimond eller spader elelr hjärta etc*/
        }
    }
}



