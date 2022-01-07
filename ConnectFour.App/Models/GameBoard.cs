namespace ConnectFour.App.Models;

public class GameBoard
{
    public bool?[][] State { get; private set; } = new bool?[6][];

    public GameBoard()
    {
        for (var index = 0; index < State.Length; index++)
        {
            State[index] = new bool?[7];
        }
    }
}