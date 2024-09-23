using DemoLibrary.ContextClasses;
using DemoLibrary.Factories;
using DemoLibrary.Flyweights;

namespace ConsoleUI;

/// <summary>
/// Client
/// </summary>
public class TextEditor
{
    private List<Character> characters = new List<Character>();
    private CharacterStyleFactory styleFactory = new CharacterStyleFactory();

    public void AddCharacter(char symbol, string font, int size, ConsoleColor color)
    {
        CharacterStyle style = styleFactory.GetStyle(font, size, color);
        characters.Add(new Character(symbol, style));
    }

    public void Display()
    {
        foreach (var character in characters)
        {
            character.Display();
        }
        Console.WriteLine();
        Console.WriteLine($"Total characters: {characters.Count}");
        Console.WriteLine($"Total character styles: {styleFactory.StyleCount}");
    }
}

