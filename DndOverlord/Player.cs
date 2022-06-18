namespace DndOverlord;

public class Player : Creature
{
    public Wallet Wallet { get; set; }
}

public class Wallet
{
    public long Gold { get; set; }
    public long Silver { get; set; }
    public long Copper { get; set; }
    public long Electrum { get; set; }
}