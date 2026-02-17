using System.Runtime.InteropServices;

Console.WriteLine("Hello, let's play Rock Paper Scissors.\nYes or No?");
string yesorno = Console.ReadLine();
if (yesorno == "yes")
{
    Console.WriteLine("Insert your input:");
    string userinput = Console.ReadLine();
    
    var random = new Random();
    var list = new List<string>{"rock", "paper", "scissors"};
    int index = random.Next(list.Count);
    Console.WriteLine(list[index]);

    if (userinput == "scissors" && list[index] == "paper")
    {
        Console.WriteLine("You win!");
    }
    else if (userinput == "rock" && list[index] == "scissors")
    {
        Console.WriteLine("You win!");
    }
    else if (userinput == "paper" && list[index] == "rock")
    {
        Console.WriteLine("You win!");
    }
    else if (userinput == list[index])
    {
        Console.WriteLine("Tie!");
    }
    else
    {
        Console.WriteLine("You lose!");
    }
}