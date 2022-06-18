namespace DndOverlord;

public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long Value { get; set; }
}

public class Weapon : Item
{
    public int DamageDie { get; set; }
    public int NumDamageDie { get; set; }
    public long Damgae => Dice.RollDie(DamageDie, NumDamageDie);
}