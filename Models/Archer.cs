namespace Videogane.Models;

public class Archer : Character
{
    public int NumberOfArrows { get; set; }

    public Archer(string name, int life, int numberOfArrows)
        : base(name, life)
    {
        NumberOfArrows = numberOfArrows;
    }

    public override void GetDescription()
    {
        Console.WriteLine($"Nombre: {Name} | Vida: {Life} | Número de flechas: {NumberOfArrows}");
    }
}