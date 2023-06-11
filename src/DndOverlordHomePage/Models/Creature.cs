namespace DndOverlordHomePage.Models;

public class StatBlock
{
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
    public int ProficiencyBonus { get; set; }
}

public class Experience
{
    public int Level { get; private set; }
    private long ExperiencePoints { get; set; }
    public void AddExperience(long experiencePointsToAdd) => ExperiencePoints += experiencePointsToAdd;
    public void SubtractExperience(long experiencePointsToRemove) => ExperiencePoints -= experiencePointsToRemove;
}

public class Creature
{
    public int CR { get; set; }
    public Experience Experience { get; set; }
    public int TotalHealth { get; set; }
    public int CurrentHealth { get; set; }
    public int TemporaryHealth { get; set; }
    public string Name { get; set; }
    public Wallet Wallet { get; set; }
    public List<Item> ItemList { get; set; }

    
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