String userOk = "N";
String[] nuhUhWords = { "Funk", "Shot", "Drat", "Flip", "Poo", "Damn", "Leah", "Sheila", "Ball"};

// Name generator
String generateName()
{
    String[] firstNames = { "Logan", "David", "James", "Jacob", "Alistair", "Issa", "Leah", "James", "Jashandeep", "Ethan"};
    String[] lastNames = { "Heath", "Day", "Theophilou", "Harrod", "Howles", "Abdu", "Ball", "Baker", "Singh", "Conolly"};

    Random dice = new Random();

    String temp = firstNames[dice.Next(0, firstNames.Length)] + "" + lastNames[dice.Next(0, lastNames.Length)];
    return temp;
}

String Multiverse()
{
    String userName = generateName();
    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Your Username is: " + userName);
    return userName;
}

void Megaverse()
{
    String userName = Multiverse();
    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("Are you happy with your name (Y/N): "); userOk = Console.ReadLine().ToUpper();

    if (userOk.Equals("Y"))
    {
        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Welcome to the game " + userName);
    }
    else if (userOk.Equals("N"))
    {
        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Generating new name...");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Incorrect Input, Keeping Name!");
        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Welcome to the game " + userName);
    }
}

Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("Welcome to the Kahurt Name Generator");
Console.Write("Please enter your Username: "); String userName = Console.ReadLine();

if (nuhUhWords.Any(word => userName.Contains(word)))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("NUH UH, YOU CAN'T SAY THAT. BANISHED!");
    while (userOk.Equals("N"))
    {
        Megaverse();
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Welcome to the game: " + userName);
}
Console.ForegroundColor = ConsoleColor.White;