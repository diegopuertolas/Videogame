namespace Videogane.Models;

public class Wizard : Character
{
    public int Mana { get; set; }

    public Wizard(string name, int life, int mana)
        : base(name, life)
    {
        Mana = mana;
    }

    public override void GetDescription()
    {
        Console.WriteLine($"Nombre: {Name} | Vida: {Life} | Mana: {Mana}");
    }
}