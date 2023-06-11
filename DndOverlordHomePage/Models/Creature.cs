namespace DndOverlord;

public class Creature
{
    public int CR { get; set; }
    public int Level { get; set; }
    private long ExperiencePoints { get; set; }
    public int TotalHealth { get; set; }
    public int CurrentHealth { get; set; }
    public int TemporaryHealth { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
    public int ProficiencyBonus { get; set; }
    public string Name { get; set; }
    public Wallet Wallet { get; set; }
    public List<Feat> FeatList { get; set; }
    public List<Item> ItemList { get; set; }
    public List<Weapon> Weapons { get; set; }

    public void AddExperience(long experiencePointsToAdd) => ExperiencePoints += experiencePointsToAdd;
    public void SubtractExperience(long experiencePointsToRemove) => ExperiencePoints -= experiencePointsToRemove;

    public void FullHeal() => CurrentHealth = TotalHealth;
    public void DamageCreature(int damage)
    {
        if (TemporaryHealth > 0)
        {
            if (TemporaryHealth > damage) TemporaryHealth -= damage;
            else CurrentHealth -= (damage - TemporaryHealth);
        }
        else
        {
            CurrentHealth -= damage;
            //TODO: calculate if damage < 0, start death save?
            if (CurrentHealth < 0) CurrentHealth = 0;
        }
    }

    public void HealCreature(int healing)
    {
        CurrentHealth += healing;
        if (CurrentHealth > TotalHealth) CurrentHealth = TotalHealth;
    }
}

public class SpellSlot
{
    public int Level { get; set; }
    public long NumberOfSpells { get; set; }
}

public class Currency
{
    public CurrencyType CurrencyType { get; set; }
    public long ValueInCopper { get; set; }
}

public enum CurrencyType {
    Copper, 
    Silver,
    Electrum,
    Gold,
    Platinum
}

public class Wallet
{
    public Wallet(){ }

    public Dictionary<CurrencyType, long> ConversionHashMap = new Dictionary<CurrencyType, long>()
    {
        { CurrencyType.Copper, 1 },
        { CurrencyType.Silver, 10 },
        { CurrencyType.Electrum, 50 },
        { CurrencyType.Gold, 100 },
        { CurrencyType.Platinum, 1000 }
    };
    public long Gold { get; set; }
    public long Silver { get; set; }
    public long Copper { get; set; }
    public long Electrum { get; set; }
    public long Platinum { get; set; }
    
    
    public void SetWallet(long gold, long silver, long copper, long electrum,long platiunum)
    {
        Gold = gold;
        Silver = silver;
        Copper = copper;
        Electrum = electrum;
        Platinum = platiunum;
    }

    public long ConvertToCopper(long currencyValue, CurrencyType currencyType)
    {
        return currencyValue *  ConversionHashMap[currencyType];
    }
}