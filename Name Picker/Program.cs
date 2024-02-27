// Name generater
String generateName()
{
    String[] firstNames = { "Logan", "David", "James", "Jacob", "Alistair", "Issa" };
    String[] lastNames = { "Heath", "Day", "Theophilou", "Harrod", "Howles", "Abdu" };

    Random dice = new Random();

    String temp = firstNames[dice.Next(0, 6)] + "" + lastNames[dice.Next(0, 6)];
    return temp;
}

String Multiverse()
{
    String userName = generateName();
    Console.WriteLine("Your Username is: " + userName);
    return userName;
}

bool Megaverse()
{
    bool again = true;

    String userName = Multiverse();
    Console.Write("Are you happy with your name (Y/N)?"); String userOk = Console.ReadLine();

    if (userOk.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.WriteLine("Welcome to the game " + userName);
        again = false;
    }
    else if (userOk.Equals("N", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.WriteLine("Generating new name...");
        again = true;
    }
    else
    {
        Console.WriteLine("Incorrect Input, Keeping Name!");
        Console.WriteLine("Welcome to the game " + userName);
        again = false;
    }
    return again;
}

bool again = true;

while (again = true) 
{
    Megaverse();
}