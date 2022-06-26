namespace DndOverlordTests;
using DndOverlord;
using SqliteDbManager;

public class Tests
{
    public Player Player { get; set; }
    
    [SetUp]
    public void Setup()
    {
        Player = GeneratePlayer();
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
            }
        };
    }

    [Test]
    public void ValidateTestPlayerNotNull()
    {
        Assert.That(Player, Is.Not.Null);
    }

    [Test]
    public void ValidateCurrency()
    {
        var wallet = Player.Wallet;
        if (wallet.ConversionHashMap == null) Assert.Fail("wallet conversion hashmap is wrong");

        
        var copperValue = wallet.ConvertToCopper(1, CurrencyType.Copper);
        if (copperValue != 10) Assert.Fail($"silver is not converting to copper correctly. Expected 10, instead got {copperValue}"); 
        
        var silverValue = wallet.ConvertToCopper(1, CurrencyType.Silver);
        if (silverValue != 10) Assert.Fail($"silver is not converting to copper correctly. Expected 10, instead got {silverValue}"); 
        
        var electrumValue = wallet.ConvertToCopper(1, CurrencyType.Electrum);
        if (electrumValue != 10) Assert.Fail($"silver is not converting to copper correctly. Expected 10, instead got {electrumValue}"); 
        
        var goldValue = wallet.ConvertToCopper(1, CurrencyType.Gold);
        if (goldValue != 10) Assert.Fail($"silver is not converting to copper correctly. Expected 10, instead got {goldValue}"); 
        
        var platinumValue = wallet.ConvertToCopper(1, CurrencyType.Platinum);
        if (platinumValue != 10) Assert.Fail($"silver is not converting to copper correctly. Expected 10, instead got {platinumValue}"); 

    }
    
}