// First epic program
void TheMultiverse()
{
    Console.WriteLine("Hello, World!");

    static String Start()
    {
        Console.Write("Please enter the password to this document: ");
        String Value = Console.ReadLine();
        return Value;
    }

    String Password = Start();

    if (Password == "221348")
    {
        Console.Write("Please enter your name, doofus: ");
        String string1 = Console.ReadLine();
        Console.WriteLine("Hello " + string1 + ", you are in the mainframe.");
    }
    else
    {
        Console.WriteLine("Security mode activated! Incorrect document password entered. Please answer the following security questions:");
        Console.Write("What is David's Last Name? "); String Q1 = Console.ReadLine();
        Console.Write("What's your handy dandy 3 digits on the back of your card? "); String Q2 = Console.ReadLine();
        if (Q1.Equals("Day", StringComparison.CurrentCultureIgnoreCase) && Q2 != "")
        {
            Console.WriteLine("Well done, security question was correct!");
            TheMultiverse();
        }
        else
        {
            Console.Write("Unfortunately, you are an intruder... Goodbye!");
        }
    }
}

TheMultiverse();