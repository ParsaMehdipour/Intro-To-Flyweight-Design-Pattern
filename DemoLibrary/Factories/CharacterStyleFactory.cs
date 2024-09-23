using DemoLibrary.Flyweights;

namespace DemoLibrary.Factories;

/// <summary> 
/// The Flyweight Factory creates and manages the Flyweight objects. It
/// ensures that flyweights are shared correctly. When the client requests a
/// flyweight, the factory either returns an existing instance or creates a
/// new one, if it doesn't exist yet.
/// </summary>
public class CharacterStyleFactory
{
    private Dictionary<string, CharacterStyle> styles = new Dictionary<string, CharacterStyle>();

    public CharacterStyle GetStyle(string font, int size, ConsoleColor color)
    {
        string key = $"{font}_{size}_{color}";

        if (!styles.ContainsKey(key))
        {
            styles[key] = new CharacterStyle(font, size, color);
        }

        return styles[key];
    }

    public int StyleCount => styles.Count;
}