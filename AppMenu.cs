using Videogane.Models;

public abstract class AppMenu
{
    public static void DisplayMenu(List<Character> characters)
    {
        var option = -1;

        do
        {
            ShowMenu();
            option = ChooseOption();
            
            switch (option)
            {
                case 1:
                    Console.WriteLine();
                    GetAllCharacters(characters);
                    break;
                case 2:
                    Console.WriteLine();
                    GetArchers(characters);
                    break;
                case 3:
                    Console.WriteLine();
                    GetWarriors(characters);
                    break;
                case 4:
                    Console.WriteLine();
                    GetWizards(characters);
                    break;
                case 0:
                    Console.WriteLine("\nSaliendo del programa...");
                    break;
                default:
                    Console.WriteLine("\nOpción inválida. Eliga una opción entre el 0 y 1");
                    break;
            }
        } while (option != 0);
    }

    public static void ShowMenu()
    {
        Console.WriteLine("\n=== VIDEOJUEGO ===");
        Console.WriteLine("1. Mostrar personajes disponibles");
        Console.WriteLine("2. Mostrar arqueros disponibles");
        Console.WriteLine("3. Mostrar guerreros disponibles");
        Console.WriteLine("4. Mostrar magos disponibles");
        Console.WriteLine("0. Salir");
    }

    public static int ChooseOption()
    {
        Console.Write("\nElija una opción: ");
        var input = Console.ReadLine();

        if (!int.TryParse(input, out var decision))
        {
            return -1;
        }

        return decision;
    }

    public static void GetAllCharacters(List<Character> characters)
    {
        var found = false;

        foreach (var character in characters)
        {
            character.GetDescription();
            found = true;
        }

        if (!found)
        {
            Console.WriteLine("\nNo hay personajes disponibles.");
        }
    }

    public static void GetArchers(List<Character> characters)
    {
        var found = false;

        foreach (var character in characters)
        {
            if (character is Archer)
            {
                character.GetDescription();
                found = true;
            }  
        }

        if (!found)
        {
            Console.WriteLine("\nNo hay arqueros disponibles.");
        }
    }

    public static void GetWarriors(List<Character> characters)
    {
        var found = false;

        foreach (var character in characters)
        {
            if (character is Warrior)
            {
                character.GetDescription();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nNo hay guerreros disponibles.");
        }
    }

    public static void GetWizards(List<Character> characters)
    {
        var found = false;

        foreach (var character in characters)
        {
            if (character is Wizard)
            {
                character.GetDescription();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nNo hay magos disponibles.");
        }
    }
}