using DemoLibrary.Flyweights;

namespace DemoLibrary.ContextClasses;

/// <summary>
/// The purpose of the Context class in the Flyweight design pattern is to:
/// 1. Combine unique(extrinsic) state with shared(intrinsic) state
/// 2. Maintain a reference to the Flyweight object
/// 3. Provide a way to use the Flyweight in conjunction with instance-specific data
/// </summary>
public class Character
{
    private char symbol;
    private CharacterStyle style;

    public Character(char symbol, CharacterStyle style)
    {
        this.symbol = symbol;
        this.style = style;
    }

    public void Display()
    {
        style.Display(symbol);
    }
}
