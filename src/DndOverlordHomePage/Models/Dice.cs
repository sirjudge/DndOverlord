namespace DndOverlordHomePage.Models;


public class Dice {

    public int numSides { get; set; }

    public static int RollDice(int numSides)
    {
        var random = new Random();
        return random.Next(1, numSides);
    }

    public static int RollDie(int numSides, int numRolls)
    {
        var output = 0;
        for (var i = 0; i < numRolls; i++)
            output += RollDice(numSides);
        
        return output;
    }
}