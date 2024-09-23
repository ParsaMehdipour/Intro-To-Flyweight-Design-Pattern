using ConsoleUI;

TextEditor editor = new TextEditor();

// Adding characters with various styles
editor.AddCharacter('H', "Arial", 12, ConsoleColor.Red);
editor.AddCharacter('e', "Arial", 12, ConsoleColor.Red);
editor.AddCharacter('l', "Arial", 12, ConsoleColor.Red);
editor.AddCharacter('l', "Arial", 12, ConsoleColor.Red);
editor.AddCharacter('o', "Arial", 12, ConsoleColor.Red);
editor.AddCharacter('f', "Arial", 12, ConsoleColor.White);
editor.AddCharacter('W', "Times New Roman", 14, ConsoleColor.Blue);
editor.AddCharacter('o', "Times New Roman", 14, ConsoleColor.Blue);
editor.AddCharacter('r', "Times New Roman", 14, ConsoleColor.Blue);
editor.AddCharacter('l', "Times New Roman", 14, ConsoleColor.Blue);
editor.AddCharacter('d', "Times New Roman", 14, ConsoleColor.Blue);
editor.AddCharacter('!', "Arial", 12, ConsoleColor.Yellow);

// Display the text
editor.Display();