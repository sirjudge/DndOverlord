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
                Silver = 10,
                Electrum = 50,
                Gold = 1000,
                Platinum = 1000
            }
        };
    }

    [Test]
    public void ValidateTestPlayerNotNull()
    {
        Assert.That(Player, Is.Not.Null);
    }
    
}