namespace DndOverlordHomePage.Models;

public class Item
{
    public Item(){}
    public Item(string name, string description, long value)
    {
        Name = name;
        Description = description;
        Value = value;
    }
    public string Name { get; set; }
    public string Description { get; set; }
    public long Value { get; set; }
    public CurrencyType ValueCurrency { get; set; }
}

public class Weapon : Item
{
    public int DamageDie { get; set; }
    public int NumDamageDie { get; set; }
    public long RollDamage() => Dice.RollDie(DamageDie, NumDamageDie);
}