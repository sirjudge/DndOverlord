namespace DndOverlordHomePage.Models;


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