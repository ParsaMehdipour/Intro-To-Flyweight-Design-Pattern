namespace DemoLibrary.Flyweights;
/// <summary>
/// The Flyweight stores a common portion of the state (also called intrinsic
/// state) that belongs to multiple real business entities. The Flyweight
/// accepts the rest of the state (extrinsic state, unique for each entity)
/// via its method parameters.
/// </summary>
public class CharacterStyle
{
    public string Font { get; private set; }
    public int Size { get; private set; }
    public ConsoleColor Color { get; private set; }

    public CharacterStyle(string font, int size, ConsoleColor color)
    {
        Font = font;
        Size = size;
        Color = color;
    }

    /// <summary>
    /// Here the symbol is an example of extrinsic state data
    /// </summary>
    /// <param name="symbol"></param>
    public void Display(char symbol)
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"{symbol} ({Font}, {Size})");
        Console.ResetColor();
    }
}