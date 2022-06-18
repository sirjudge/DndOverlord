namespace DndOverlord;

public class Dice {
    public int numSides { get; set; }

    public static int RollDice(int numSides)
    {
        var random = new Random();
        return random.Next(1, numSides);
    }

    public List<int> RollDie(int numSides, int numRolls)
    {
        var outputList = new List<int>();
        for (var i = 0; i < numRolls; i ++)
            outputList.Add(RollDice(numSides));
        return outputList;
    }
}