public class Dealer : Player
{
    public Dealer() : base("Huset")
    { 

    }

    public void DisplayPartial() /*Visar husets händer och ett okänt kort*/
    {
        Console.WriteLine($"{Name}'s hand: {cards[0].Rank} {cards[0].Suit} Och ett okänt kort"); /* kort är okänt för spelare för att det ingår i Blackjack och säger att spelare inte får veta för ens spelaren har stannat elelr slåt.*/
    }
}

