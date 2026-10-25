using Videogane.Models;

var gladiator = new Warrior("Gladiador", 100, 1000);
var harryPotter = new Wizard("Harry Potter", 70, 500);
var legolas = new Archer("Legolas", 50, 100);

var characters = new List<Character>
{
    gladiator,
    harryPotter,
    legolas
};

AppMenu.DisplayMenu(characters);