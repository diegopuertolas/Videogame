namespace Videogane.Models;

public class Warrior : Character
{
    public int Strength { get; set; }

    public Warrior(string name, int life, int strength)
        : base(name, life)
    {
        Strength = strength;
    }

    public override void GetDescription()
    {
        Console.WriteLine($"Nombre: {Name} | Vida: {Life} | Fuerza: {Strength}");
    }
}