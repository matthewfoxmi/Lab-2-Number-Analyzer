while (true)
{
    Console.WriteLine("Please enter your name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter a number between 1 and 100");
    int num = int.Parse(Console.ReadLine());

    if (num % 2 != 0 && num < 60)
    {
        Console.WriteLine(num + ", Your number is odd and less than 60 " + name);
    }
    else if (num % 2 == 0 && num >= 2 && num <= 24)
    {
        Console.WriteLine(num + ", Your number is even and less than 25 " + name);
    }
    else if (num % 2 == 0 && num >= 26 && num <= 60)
    {
        Console.WriteLine(num + ", Your number is even and between 26 and 60 inclusive " + name);
    }
    else if (num % 2 == 0 && num > 60)
    {
        Console.WriteLine(num + ", Your number is even and greater than 60 " + name);
    }
    else if (num % 2 != 0 && num > 60)
    {
        Console.WriteLine(num + ", Your number is odd and greater than 60 " + name);
    }

    Console.WriteLine("Would you like to stop? type yes/y to stop, or enter any other key to restart.");
    string loopChoice = Console.ReadLine();
    if (loopChoice == "yes" || loopChoice == "y")
    {
        break;
    }
}
 
