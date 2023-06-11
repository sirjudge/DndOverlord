using System.Runtime.InteropServices;

namespace DndOverlordTests;
using DndOverlord;

public class Tests
{
    private Player TestPlayer { get; set; }
    private Weapon TestWeapon { get; set; }
    
    [SetUp]
    public void Setup()
    {
        TestPlayer = GeneratePlayer();
        TestWeapon = GenerateWeapon();
    }

    private Weapon GenerateWeapon()
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

    private Player GeneratePlayer()
    {
        return new Player()
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

    [Test]
    public void ValidateTestPlayerNotNull()
    {
        Assert.That(TestPlayer, Is.Not.Null);
    }

    [Test]
    public void ValidateCurrency()
    {
        var wallet = TestPlayer.Wallet;
        if (wallet.ConversionHashMap == null) Assert.Fail("wallet conversion hashmap is wrong");

        
        var copperValue = wallet.ConvertToCopper(1, CurrencyType.Copper);
        if (copperValue != 1) Assert.Fail($"Copper is not converting to copper correctly. Expected 1, instead got {copperValue}"); 
        
        var silverValue = wallet.ConvertToCopper(1, CurrencyType.Silver);
        if (silverValue != 10) Assert.Fail($"silver is not converting to copper correctly. Expected 10, instead got {silverValue}"); 
        
        var electrumValue = wallet.ConvertToCopper(1, CurrencyType.Electrum);
        if (electrumValue != 50) Assert.Fail($"Electrum is not converting to copper correctly. Expected 50, instead got {electrumValue}"); 
        
        var goldValue = wallet.ConvertToCopper(1, CurrencyType.Gold);
        if (goldValue != 100) Assert.Fail($"Gold is not converting to copper correctly. Expected 100, instead got {goldValue}"); 
        
        var platinumValue = wallet.ConvertToCopper(1, CurrencyType.Platinum);
        if (platinumValue != 1000) Assert.Fail($"platinum is not converting to copper correctly. Expected 1000, instead got {platinumValue}");
    }

    [Test]
    public void TestItemDamage()
    {
        for (var i = 0; i < 5; i++)
        {
            var damageRoll = TestWeapon.RollDamage();
            if (damageRoll is < 3 or > 24)
                Assert.Fail( $"Expected damage roll to be > 3 and < 24, instead got {damageRoll}");
        }
    }

    [Test]
    public void TestDamage()
    {
        TestPlayer.DamageCreature(5);
        Assert.That(TestPlayer.CurrentHealth is 5, 
            $"TestPlayer.CurrentHealth expected 5, instead is {TestPlayer.CurrentHealth}");
    }

    [Test]
    public void TestHealing()
    {
        TestPlayer.HealCreature(5);
        Assert.That(TestPlayer.CurrentHealth is 15,
            $"TestPlayer.CurrentHealth expected is 15, instead it {TestPlayer.CurrentHealth}");
    }
}