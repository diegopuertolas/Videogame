namespace Videogane.Models;

public abstract class Character
{
    public string Name { get; set; }
    public int Life { get; set; }

    public Character(string name, int life)
    {
        Name = name;
        Life = life;
    }

    public abstract void GetDescription();
}