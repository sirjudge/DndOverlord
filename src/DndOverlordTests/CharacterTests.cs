using DndOverlordHomePage.Models;
using DndOverlordHomePage.Repositories;
using NUnit.Framework.Internal;

namespace DndOverlordTests;

public class CharacterTest
{
    private Character TestCharacter { get; set; }
    private Weapon TestWeapon { get; set; }
    private CharacterRepository CharacterRepository { get; set; }

    #region set up
    [SetUp]
    public void Setup()
    {
        TestCharacter = GenerateCharacter();
        TestWeapon = GenerateWeapon();
        CharacterRepository = new CharacterRepository();
    }
    
    public CharacterTest(Character testCharacter, Weapon testWeapon)
    {
        TestCharacter = testCharacter;
        TestWeapon = testWeapon;
    }

    private static Weapon GenerateWeapon()
    {
        return new Weapon()
        {
            Name = "Test weapon of doom",
            Description = "Test description",
            Value = 1000,
            ValueCurrency = CurrencyType.Gold,
            DamageDie = 8, 
            NumDamageDie = 3,
        };
    }
    
    private static Character GenerateCharacter()
    {
        return new Character()
        {
            Name = "Ol Swampy",
            ItemList = new List<Item>()
            {
                new Item("test name", "test description",1000)
            },
            Wallet = new Wallet()
            {
                Copper = 1,
                Silver = 1,
                Electrum = 1,
                Gold = 1,
                Platinum = 1
            },
            CurrentHealth = 10,
            TotalHealth = 20,
        };
    }
    #endregion

    [Test]
    public void ValidateTestPlayerNotNull()
    {
        Assert.That(TestCharacter, Is.Not.Null);
    }

    [Test]
    public void InsertNewCharacter()
    {
        var character = TestCharacter;
        CharacterRepository.Insert(character);
    }
}