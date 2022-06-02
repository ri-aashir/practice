using static Answer.Utilities;
// See https://aka.ms/new-console-template for more information
Console.WriteLine(args);

Console.WriteLine();
foreach (var s in args)
{
    Console.Write(s);
    Console.Write(' ');
}
Console.WriteLine();

//for (int i = 0; i < 20; i++)
//{
//    Console.Write("| -");-
//    await Task.Delay(50);
//    Console.Write("\b\b\b");
//    Console.Write("/ \\");
//    await Task.Delay(50);
//    Console.Write("\b\b\b");
//    Console.Write("- |");
//    await Task.Delay(50);
//    Console.Write("\b\b\b");
//    Console.Write("\\ /");
//    await Task.Delay(50);
//    Console.Write("\b\b\b");
//}
//Console.WriteLine();

await ShowConsoleAnimation();

//static async Task ShowConsoleAnimation()
//{
//    for (int i = 0; i < 20; i++)
//    {
//        Console.Write("| -");
//        await Task.Delay(50);
//        Console.Write("\b\b\b");
//        Console.Write("/ \\");
//        await Task.Delay(50);
//        Console.Write("\b\b\b");
//        Console.Write("- |");
//        await Task.Delay(50);
//        Console.Write("\b\b\b");
//        Console.Write("\\ /");
//        await Task.Delay(50);
//        Console.Write("\b\b\b");
//    }
//    Console.WriteLine();
//}

string[] answers =
        {
            "It is certain.", "Reply hazy, try again.", "Don’t count on it.", "It is decidedly so.", "Ask again later.", "My reply is no.", "Without a doubt.", 
            "Better not tell you now.", "My sources say no.", "Yes – definitely.", "Cannot predict now.", "Outlook not so good.", "You may rely on it.", 
            "Concentrate and ask again.", "Very doubtful.", "As I see it, yes.", "Most likely.", "Outlook good.", "Yes.", "Signs point to yes.",
        };

var index = new Random().Next(answers.Length - 1);
Console.WriteLine(answers[index]);