namespace DemoLibrary.Flyweights;

/// <summary>
/// The Flyweight stores a common portion of the state (also called intrinsic
/// state) that belongs to multiple real business entities. The Flyweight
/// accepts the rest of the state (extrinsic state, unique for each entity)
/// via its method parameters.
/// </summary>
public class CharacterStyle
{
    private string font;
    private int size;
    private ConsoleColor color;

    public CharacterStyle(string font, int size, ConsoleColor color)
    {
        this.font = font;
        this.size = size;
        this.color = color;
    }

    /// <summary>
    /// Here the symbol is an example of extrinsic state data
    /// </summary>
    /// <param name="symbol"></param>
    public void Display(char symbol)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"{symbol} ({font}, {size})");
        Console.ResetColor();
    }
}