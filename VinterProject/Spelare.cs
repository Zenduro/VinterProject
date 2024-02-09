public class Player : Hand 
{
    public string Name { get; set; } /*Namnet på spelaren. Get Set Go används för att få och sätta värdet av egenskaper*/

    public Player(string name)
    {
        Name = name;  /*Tilldelar spelarej dess namn vid skapandet av spelaren*/
    }

    public void DisplayScore() /*Visar Poänegn alltså score*/
    {
        Console.WriteLine($"{Name} kort: {CalculateScore()}"); /*Visar spelarens namn och poäng (score) på konsolen*/
    }
}
