namespace DndOverlordHomePage.Models;

public class Spell : Weapon
{
    public bool Concentration { get; set; }
    public SchoolOfMagic MagicSchool { get; set; }
}

public enum SchoolOfMagic
{
    Conjuration, 
    Necromancy, 
    Evocation, 
    Abjuration, 
    Transmutation, 
    Divination, 
    Enchantment, 
    Illusion
}

