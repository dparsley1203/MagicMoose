using System;


Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // As a question
    CanadaQuestion();

}


void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}


// Re-writting code to randomize response

string MooseAsks(string question)
{
    Console.Write($"{question}");
    string answer = Console.ReadLine().ToLower();

    while (answer != "")
    {
        Console.Write($"{question}");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return "h";
    }
    else
    {
        return "n";
    }
}



void CanadaQuestion()
{
    bool isTrue = MooseAsks("Is Canada Real?");
    if (isTrue)
    {
        MooseSays("Seems unlikely");
    }
    else
    {
        MooseSays("I knew it");
    }
}

public class Program
{
    public static void main()
    {
        Random r = new Random();
        int genRand = r.Next(0, 19);
        Console.WriteLine("Random Number = " + genRand);
    }
}
